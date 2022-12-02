using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using YuhanTalkModule;
using YuhanTalkServer.Client;
using YuhanTalkServer;
using System.Data;

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
                case Protocols.C_REQ_LOGIN:
                    {
                        LoginProcess(client, converter);
                    }
                    break;
                case Protocols.C_MSG:
                    {
                        RecieveMessage(client, converter);
                    }
                    break;
                case Protocols.C_REQ_SIGN_UP:
                    {
                        SignUpProcess(client, converter);
                    }
                    break;
                case Protocols.C_REQ_ROOM_LIST:
                    {
                        ResponseRoomList(client, converter);
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

            foreach(var item in ds.Tables[0].Rows)
            {
                DataRow dr = (item as DataRow)!;
                int RoomId = Convert.ToInt32(dr[0]);

                // 자신이 참가한 방에 있는 사람 검색
                string query2 = $"select user_ID from Participant where room_ID ={RoomId}";

                DataSet ds2 = program.OracleDB.ExecuteDataAdt(query2);

                // 방 제목
                string RoomName = "";

                // 참가자의 이름으로 방제목 설정함
                foreach(var item2 in ds2.Tables[0].Rows)
                {
                    DataRow dr2 = (item2 as DataRow)!;
                    if (RoomName.Length != 0) RoomName += ", ";

                    RoomName += program.OracleDB.GetName(dr2[0].ToString()!);
                }

                // 클라이언트에게 보낼 메시지 생성
                MessageGenerator generator = new MessageGenerator(Protocols.S_RES_ROOM_LIST);
                generator.AddInt(RoomId);
                generator.AddString(RoomName);

                // 전송
                program.SendMessage(generator.Generate(),client);
            }
        }

        private void RecieveMessage(ClientUser clientUser, MessageConverter converter)
        {
            int roomID = converter.NextInt();
            string message = converter.NextString();

            // 해당 방번호에 있는 유저 검색
            string query = $"select user_ID from Participant WHERE room_ID = {roomID} AND USER_ID <> '{clientUser.ID}'";
            DataSet ds = program.OracleDB.ExecuteDataAdt(query);

            // 유저에게 보낼 메시지 생성
            MessageGenerator generator = new MessageGenerator(Protocols.S_MSG);
            generator.AddInt(roomID);
            generator.AddString(message);
            generator.AddString(clientUser.Name);
            generator.AddString(DateTime.Now.ToString("tt h:mm"));

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
                    program.SendMessage(generator.Generate(), user);
                }
                
            }
        }


    }
}
