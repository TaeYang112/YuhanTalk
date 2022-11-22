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

        private byte[]? remainedMessage = null;

        // 받은 메시지를 해석함
        public void ParseMessage(ClientUser client, byte[] message)
        {
            // 만약 저번 해석때 메시지가 남았더라면 남은 메시지와 이어붙임
            byte[] message2;
            if(remainedMessage == null)
            {
                message2 = message;
            }
            else
            {
                remainedMessage.AddRa
                message2 = new byte[remainedMessage.Length + message.Length];
                Array.Copy(remainedMessage, message2, remainedMessage.Length);
                Array.Copy(message, 0, message2, remainedMessage.Length, message.Length);
            }
            MessageConverter converter = new MessageConverter(message2);
            while (true)
            {
                bool result = converter.NextMessage();

                // 다음 메시지가 없으면 종료
                if(result == false)
                {
                    remainedMessage = converter.RemainMessage;
                    break;
                }
                Console.WriteLine("sdf");
                byte protocol = converter.Protocol;
                switch (protocol)
                {
                    default:
                        Console.WriteLine("에러");
                        break;

                }
            }
        }
       
    }
}
