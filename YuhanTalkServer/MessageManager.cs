using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using YuhanTalkModule;
using YuhanTalkServer.Client;
using YuhanTalkServer;
using System.Data;
using Oracle.ManagedDataAccess.Client;

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
                        ResponseRoomList(client, converter);
                    }
                    break;
                // 채팅 목록 수신
                case Protocols.C_REQ_CHAT_LIST:
                    {
                        ResponseChatLIst(client, converter);
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

        private void ResponseRoomList(ClientUser client, MessageConverter converter)
        {
            // 자신이 참가하고 있는 방 검색
            string query = $"select * from Participant WHERE user_ID = '{client.ID}'";
            DataSet ds = program.OracleDB.ExecuteDataAdt(query);

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                int RoomId = Convert.ToInt32(dr[0]);

                // 자신이 참가한 방에 있는 사람 검색
                string query2 = $"select user_ID from Participant where room_ID ={RoomId}";

                DataSet ds2 = program.OracleDB.ExecuteDataAdt(query2);

                // 방 제목
                string RoomName = "";

                // 참가자의 이름으로 방제목 설정함
                foreach(DataRow dr2 in ds2.Tables[0].Rows)
                {
                    if (RoomName.Length != 0) RoomName += ", ";

                    RoomName += program.OracleDB.GetName(dr2[0].ToString()!);
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
                generator.AddString(DateTime.Parse(LastTime).ToString("tt h:mm"));

                // 전송
                program.SendMessage(generator.Generate(),client);
                
                ds2.Dispose();
            }
            ds.Dispose();
        }

        private void RecieveMessage(ClientUser clientUser, MessageConverter converter)
        {
            int roomID = converter.NextInt();
            string message = converter.NextString();

            // 서버 기준 현재시간 받음
            DateTime dt = DateTime.Now;

            // 데이터베이스에 채팅을 넣음
            string query = $"insert into CHATTING(room_id, id, message, time) values({roomID}, '{clientUser.ID}','{message}', to_date('{dt:yyyy/MM/dd HH:mm:ss}','yyyy/mm/dd hh24:mi:ss'))";
            program.OracleDB.InsertData(query);

            // 해당 방번호에 있는 유저 검색
            string query2 = $"select user_ID from Participant WHERE room_ID = {roomID} AND USER_ID <> '{clientUser.ID}'";
            DataSet ds = program.OracleDB.ExecuteDataAdt(query2);

            // 유저에게 보낼 메시지 생성
            MessageGenerator generator = new MessageGenerator(Protocols.S_MSG);
            generator.AddInt(roomID);
            generator.AddString(message);
            generator.AddString(clientUser.Name);
            generator.AddString(dt.ToString("tt h:mm"));

            // 각 유저 아이디가 있는 행 반복
            foreach (var item in ds.Tables[0].Rows)
            {
                DataRow dr = (item as DataRow)!;
                string userID = Convert.ToString(dr[0])!;

                // 해당 방에 있는 유저가 접속중인지 검색
                ClientUser? user;
                program.clientManager.ClientDic.TryGetValue(userID, out user);
                // 접속중이라면
                if (user != null)
                {
                    // 서버가 받은 메시지를 보냄
                    program.SendMessage(generator.Generate(), user);
                }
                
            }
            ds.Dispose();
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


    }
}
