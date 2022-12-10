using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using YuhanTalkModule;
using YuhanTalkServer.Client;
using YuhanTalkServer;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace YuhanTalkServer
{
    public class MessageManager
    {
        private Program program;

        public MessageManager(Program program)
        {
            this.program = program;
        }

        // 받은 메시지를 해석함
        public void ParseMessage(ClientUser client, byte[] message)
        {

            MessageConverter converter = new MessageConverter(message);

            byte protocol = converter.Protocol;
            switch (protocol)
            {
                // 로그인 요청 수신
                case Protocols.C_REQ_LOGIN:
                    {
                        LoginProcess(client, converter);
                    }
                    break;
                // 메시지 수신
                case Protocols.C_MSG:
                    {
                        RecieveMessage(client, converter);
                    }
                    break;
                // 회원가입 요청 수신
                case Protocols.C_REQ_SIGN_UP:
                    {
                        SignUpProcess(client, converter);
                    }
                    break;
                // 방 목록 요청 수신
                case Protocols.C_REQ_ROOM_LIST:
                    {
                        ResponseRoomList(client);
                    }
                    break;
                // 채팅 목록 수신
                case Protocols.C_REQ_CHAT_LIST:
                    {
                        ResponseChatLIst(client, converter);
                    }
                    break;
                // ID체크 요청 수신
                case Protocols.C_REQ_CHECK_ID:
                    {
                        ResponseIDCheckResult(client, converter);
                    }
                    break;
                case Protocols.C_REQ_CREATE_ROOM:// 방생 요청 수신
                    {
                        CreateRoomProcess(client, converter);
                    }
                    break;
                default:
                    Console.WriteLine("에러 프로토콜 : " + protocol);
                    break;

            }
        }

        

        private void LoginProcess(ClientUser client, MessageConverter convert)
        {
            string Id = convert.NextString();
            string Pw = convert.NextString();

            OracleDB.LoginInfo info = program.OracleDB.GetLoginInfo(Id, Pw);

            MessageGenerator generator = new MessageGenerator(Protocols.S_RES_LOGIN);

            // ID와 비번이 같은 데이터가 있다면
            if(info.Empty == false)
            {
                generator.AddBool(true);
                generator.AddString(info.Name);

                // 게스트에서 로그인으로 옮김
                client.Login(info.Id, info.Name);
                program.guestClientManager.RemoveClient(client);
                program.clientManager.AddClient(client);
            }
            else
            {
                generator.AddBool(false);
            }

            // 클라이언트에게 전송
            program.SendMessage(generator.Generate(), client);
        }

        private void SignUpProcess(ClientUser client, MessageConverter converter)
        {
            string id = converter.NextString();
            string pw = converter.NextString();
            string name = converter.NextString();

            int result = program.OracleDB.SignUpProcess(id, pw, name);
            
            MessageGenerator generator = new MessageGenerator(Protocols.S_RES_SIGN_UP);
            generator.AddInt(result);

            program.SendMessage(generator.Generate(), client);
        }

        private void ResponseRoomList(ClientUser client)
        {
            // 자신이 참가하고 있는 방 검색
            string query = $"select * from Participant WHERE user_ID = '{client.ID}'";
            DataSet ds = program.OracleDB.ExecuteDataAdt(query);

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                int RoomId = Convert.ToInt32(dr[0]);

                // 자신이 참가한 방에 있는 사람 검색
                string query2 = $"select name from Participant, userInfo where userInfo.ID = Participant.User_ID AND room_ID ={RoomId}";

                DataSet ds2 = program.OracleDB.ExecuteDataAdt(query2);

                // 방 제목
                string RoomName = "";

                // 참가자의 이름으로 방제목 설정함
                foreach(DataRow dr2 in ds2.Tables[0].Rows)
                {
                    if (RoomName.Length != 0) RoomName += ", ";

                    RoomName += dr2[0].ToString()!;
                }

                // 해당 방에 마지막으로 보낸 채팅 검색
                string query3 = $"select message, time from chatting where room_id = {RoomId} ORDER BY TIME DESC";

                DataSet ds3 = program.OracleDB.ExecuteDataAdt(query3);

                string LastMessage = "";
                string LastTime = "";
                foreach (DataRow dr3 in ds3.Tables[0].Rows)
                {
                    LastMessage = Convert.ToString(dr3[0])!;
                    LastTime = Convert.ToString(dr3[1])!;
                    break;
                }

                // 클라이언트에게 보낼 메시지 생성
                MessageGenerator generator = new MessageGenerator(Protocols.S_RES_ROOM_LIST);
                generator.AddInt(RoomId);
                generator.AddString(RoomName);
                generator.AddString(LastMessage);
                if(LastTime == "") 
                    generator.AddString("");
                else 
                    generator.AddString(DateTime.Parse(LastTime).ToString("tt h:mm"));

                // 전송
                program.SendMessage(generator.Generate(), client);
                
                ds2.Dispose();
            }
            ds.Dispose();
        }

        private void RecieveMessage(ClientUser clientUser, MessageConverter converter)
        {
            int roomID = converter.NextInt();
            string message = converter.NextString();

            string dbMessage = message.Replace("\'", "\'\'");

            // 서버 기준 현재시간 받음
            DateTime dt = DateTime.Now;

            // 데이터베이스에 채팅을 넣음
            string query = $"insert into CHATTING(room_id, id, message, time) values({roomID}, '{clientUser.ID}','{dbMessage}', to_date('{dt:yyyy/MM/dd HH:mm:ss}','yyyy/mm/dd hh24:mi:ss'))";
            program.OracleDB.ExecuteQuery(query);

            // 유저에게 보낼 메시지 생성
            MessageGenerator generator = new MessageGenerator(Protocols.S_MSG);
            generator.AddInt(roomID);
            generator.AddString(message);
            generator.AddString(clientUser.Name);
            generator.AddString(dt.ToString("tt h:mm"));

            // 방에 있는 접속중인 유저에게 메시지 전송
            program.SendMessageInRoom(generator.Generate(), roomID, clientUser);
        }

        // 특정 방에 있는 채팅 내역 송신
        private void ResponseChatLIst(ClientUser clientUser, MessageConverter converter)
        {
            int roomId = converter.NextInt();

            // 해당 방번호에 있는 채팅 검색
            string query2 = $"select userInfo.id, name, message, to_char(time,'yyyy/mm/dd hh24:mi') from userInfo, chatting where userInfo.ID = Chatting.ID AND room_ID = {roomId} ORDER BY time";
            DataSet ds = program.OracleDB.ExecuteDataAdt(query2);

            

            // 검색한 채팅 내용들을 요청 클라이언트에게 송신함 
            foreach (var item in ds.Tables[0].Rows)
            {
                DataRow dr = (item as DataRow)!;
                string userID = Convert.ToString(dr[0])!;
                string userName = Convert.ToString(dr[1])!;
                string message = Convert.ToString(dr[2])!;
                string time = Convert.ToString(dr[3])!;

                // 유저에게 보낼 메시지 생성
                MessageGenerator generator = new MessageGenerator(Protocols.S_RES_CHAT_LIST);
                generator.AddInt(roomId);
                generator.AddString(userName);
                generator.AddString(message);

                // 시간
                DateTime dt = DateTime.Parse(time);
                generator.AddString(dt.ToString("tt h:mm"));

                // 본인 여부
                if(userID == clientUser.ID)
                {
                    generator.AddBool(true);
                }
                else
                {
                    generator.AddBool(false);
                }

                // 전송
                program.SendMessage(generator.Generate(), clientUser);

            }
            ds.Dispose();
        }


        // 사용자가 채팅방 초대를 위해 입력한 ID가 실재하는지 검증해줌
        private void ResponseIDCheckResult(ClientUser clientUser, MessageConverter converter)
        {
            string id = converter.NextString();

            MessageGenerator messageGenerator = new MessageGenerator(Protocols.S_RES_CHECK_ID);
            messageGenerator.AddString(id);

            // 사용자 본인의 아이디라면 에러 전송
            if(clientUser.ID == id)
            {
                messageGenerator.AddByte(IDCheckResult.ERROR_SAME_YOUR_ID);
                program.SendMessage(messageGenerator.Generate(), clientUser);
                return;
            }

            // 아이디 검색
            string query = $"select id from userInfo where id = '{id}'";

           OracleDataReader dr =  program.OracleDB.SelectData(query);

            // 존재한다면
            if(dr.Read())
            {
                // 성공 메시지
                messageGenerator.AddByte(IDCheckResult.SUCCESS);
            }
            // 존재하지 않으면
            else
            {
                // 에러 메시지
                messageGenerator.AddByte(IDCheckResult.ERROR_NO_ID);
            }

            // 전송
            program.SendMessage(messageGenerator.Generate(), clientUser);

            dr.Dispose();
        }

        // 사용자의 방 생성 요청
        private void CreateRoomProcess(ClientUser client, MessageConverter converter)
        {
            // 초대인원 수
            int count = converter.NextInt();

            // DB에 새로운 방 추가
            OracleParameterCollection ?param = program.OracleDB.ExecuteQuery($"insert into chattingRoom(s) values(1) returning id into :v_room_id",
                new OracleParameter[1] { new OracleParameter("v_Room_ID", OracleDbType.Int64,2,0,ParameterDirection.ReturnValue) });

            if (param == null) return;

            // 추가된 방 번호
            int roomID = Convert.ToInt32((decimal)(OracleDecimal)(param["v_room_id"].Value));

            program.OracleDB.ExecuteQuery($"insert into PARTICIPANT values({roomID},'{client.ID}')");
            for (int i = 0; i < count; i++)
            {
                string id = converter.NextString();
                program.OracleDB.ExecuteQuery($"insert into PARTICIPANT values({roomID},'{id}')");
            }

            // 자신이 참가한 방에 있는 사람 검색
            string query = $"select name from Participant, userInfo where userInfo.ID = Participant.User_ID AND room_ID ={roomID}";

            DataSet ds = program.OracleDB.ExecuteDataAdt(query);

            // 방 제목
            string RoomName = "";

            // 참가자의 이름으로 방제목 설정함
            foreach (DataRow dr2 in ds.Tables[0].Rows)
            {
                if (RoomName.Length != 0) RoomName += ", ";

                RoomName += dr2[0].ToString()!;
            }

            // 방을 만든 클라이언트에게 보낼 메시지 생성
            MessageGenerator generator = new MessageGenerator(Protocols.S_CREATE_ROOM);
            generator.AddInt(roomID);               // 방 번호
            generator.AddString(RoomName);          // 방 이름
            generator.AddBool(true);                // 채팅창을 띄울지 여부

            // 전송
            program.SendMessage(generator.Generate(), client);

            // 방에있는 다른 클라이언트에게 보낼 메시지 생성
            generator.Clear();
            generator.AddInt(roomID);
            generator.AddString(RoomName);
            generator.AddBool(false);

            // 전송
            program.SendMessageInRoom(generator.Generate(), roomID, client);

            ds.Dispose();
        }


    }
}
