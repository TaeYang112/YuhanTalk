using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YuhanTalkModule;

namespace YuhanTalk
{
    public partial class YuhanTalkManager
    {
        private class MessageManager
        {
            private YuhanTalkManager talkManager;

            public MessageManager(YuhanTalkManager talkManager)
            {
                this.talkManager = talkManager;
            }

            private byte[]? remainedMessage = null;

            // 메시지를 해석 후 실행
            public void ParseMessage(byte[] message)
            {
                // 만약 저번 해석때 메시지가 남았더라면 남은 메시지와 이어붙임
                byte[] message2;
                if (remainedMessage == null)
                {
                    message2 = message;
                }
                else
                {
                    message2 = new byte[remainedMessage.Length + message.Length];
                    Array.Copy(remainedMessage, message2, remainedMessage.Length);
                    Array.Copy(message, 0, message2, remainedMessage.Length, message.Length);
                }
                
                MessageConverter converter = new MessageConverter(message2);

                while (true)
                {
                    bool result = converter.NextMessage();

                    // 다음 메시지가 없으면 종료
                    if (result == false)
                    {
                        remainedMessage = converter.RemainMessage;
                        break;
                    }

                    byte protocol = converter.Protocol;
                    switch (protocol)
                    {
                        // 클라이언트가 접속중인지 확인하기 위해 서버가 보내는 메시지
                        case Protocols.S_PING:
                            {
                                // 클라이언트는 반응이 없어도 됨
                            }
                            break;
                        case Protocols.S_ERROR:
                            {
                                Error(converter);
                            }
                            break;
                        default:
                            Console.WriteLine("에러 : " + protocol);
                            break;
                    }
                }
            }

            public void Error(MessageConverter converter)
            {
                int errorCode = converter.NextInt();

                switch (errorCode)
                {
                    case 0:
                        {
                            MessageBox.Show("해당 방은 꽉찼습니다.", $"에러코드 : {errorCode}", MessageBoxButtons.OK);
                        }
                        break;
                    case 1:
                        {
                            MessageBox.Show("존재하지 않은 방입니다.", $"에러코드 : {errorCode}", MessageBoxButtons.OK);
                        }
                        break;
                    default:
                        Console.WriteLine("알수 없는 에러코드 {0}", errorCode);
                        break;
                }
            }
        }
    }
}