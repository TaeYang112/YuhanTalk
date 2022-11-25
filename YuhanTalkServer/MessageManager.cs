using System;
using System.Collections.Generic;
using System.Drawing;
using YuhanTalkModule;
using YuhanTalkServer.Client;
using static YuhanTalkServer.OracleDB;

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
                case Protocols.REQ_LOGIN:
                    {
                        LoginProcess(client, converter);
                    }
                    break;
                case Protocols.C_MSG:
                    {
                        string s = converter.NextString();
                        Console.WriteLine(s);
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

            LoginInfo info = program.OracleDB.GetLoginInfo(Id, Pw);

            MessageGenerator generator = new MessageGenerator(Protocols.RES_LOGIN);

            // ID와 비번이 같은 데이터가 있다면
            if(info.Empty == false)
            {
                generator.AddByte(LoginResult.SUCCESS);
                generator.AddString(info.Name);
            }
            else
            {
                generator.AddByte(LoginResult.FAIL);
            }

            // 클라이언트에게 전송
            program.SendMessage(generator.Generate(), client);
        }
       
    }
}
