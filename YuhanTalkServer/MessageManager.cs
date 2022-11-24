using System;
using System.Collections.Generic;
using System.Drawing;
using YuhanTalkModule;
using YuhanTalkServer.Client;

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
                case Protocols.C_MSG:
                    {
                        string s = converter.NextString();
                        Console.WriteLine(s);
                    }
                    break;
                default:
                    Console.WriteLine("에러");
                    break;

            }
            
        }
       
    }
}
