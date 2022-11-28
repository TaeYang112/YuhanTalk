using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using YuhanTalkModule;
using YuhanTalkServer.Client;
using YuhanTalkServer;

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
                        string s = converter.NextString();
                        Console.WriteLine(s);
                    }
                    break;
                case Protocols.C_REQ_SIGN_UP:
                    {
                        SignUpProcess(client, converter);
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


    }
}
