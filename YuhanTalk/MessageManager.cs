using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YuhanTalk.CustomControl;
using YuhanTalk.Screen;
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

            // 메시지를 해석 후 실행
            public void ParseMessage(byte[] message)
            {
                MessageConverter converter = new MessageConverter(message);

                byte protocol = converter.Protocol;
                switch (protocol)
                {
                    // 서버로 부터 로그인 결과 수신
                    case Protocols.S_RES_LOGIN:
                        {
                            ReceiveLoginResult(converter);
                        }
                        break;
                    // 회원가입 결과 수신
                    case Protocols.S_RES_SIGN_UP:
                        {
                            ReceiveSignUpResult(converter);
                        }
                        break;
                    // 방 리스트 수신
                    case Protocols.S_RES_ROOM_LIST:
                        {
                            ReceiveRoomInfo(converter);
                        }
                        break;
                    // 클라이언트가 접속중인지 확인하기 위해 서버가 보내는 메시지
                    case Protocols.S_PING:
                        {
                            // 클라이언트는 반응이 없어도 됨
                        }
                        break;
                    // 다른 클라이언트가 보낸 메시지 수신
                    case Protocols.S_MSG:
                        {
                            ReceiveMessage(converter);
                        }
                        break;
                    // 과거 주고 받은 메시지 수신
                    case Protocols.S_RES_CHAT_LIST:
                        {
                            ReceiveChatList(converter);
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

            private void ReceiveLoginResult(MessageConverter converter)
            {
                bool result = converter.NextBool();
                
                // 로그인에 성공
                if(result)
                {
                    Console.WriteLine("로긴 성공");
                    talkManager.MainForm.ChangeScreen(new YuhanTalkScreen(talkManager.MainForm));
                }
                else
                {
                    Console.WriteLine("로긴 실패");
                }
            }

            private void ReceiveSignUpResult(MessageConverter converter)
            {
                int result = converter.NextInt();

                // 로그인에 성공
                switch(result)
                {
                    case 0:
                        talkManager.MainForm.ChangeScreen(new LoginScreen(talkManager.MainForm));
                        break;
                }
            }

            private void ReceiveRoomInfo(MessageConverter converter)
            {
                int roomId = converter.NextInt();
                string roomName = converter.NextString();

                // 컨트롤 검색
                FlowLayoutPanel? fl = talkManager.MainForm.Controls.Find("fl_ChattingList", true).FirstOrDefault() as FlowLayoutPanel;

                // 유효하다면
                if(fl != null)
                {
                    // 채팅창 만듬
                    ChattingRoom cr = new ChattingRoom(talkManager.MainForm, roomId);
                    cr.SetTitle(roomName);

                    // 추가
                    fl.Invoke(new Action(() =>
                    {
                        fl.Controls.Add(cr);
                    }));
                    
                    
                }

            }

            // 메시지 수신
            private void ReceiveMessage(MessageConverter converter)
            {
                int roomID = converter.NextInt();
                string message = converter.NextString();
                string name = converter.NextString();
                string time = converter.NextString();

                ChattingRoom_Form? form;

                // 해당 방번호에 해당하는 폼을 찾음
                talkManager.ChattingForm_Dic.TryGetValue(roomID, out form);

                if(form != null)
                {
                    form.Invoke(new Action(() =>
                    {
                        form.AddLChat(message, name, time);
                    }
                    ));
                }
            }

            // 기존 DB에 있던 메시지 수신 ( 과거 메시지 )
            private void ReceiveChatList(MessageConverter converter)
            {
                int roomID = converter.NextInt();
                string name = converter.NextString();
                string message = converter.NextString();
                string time = converter.NextString();

                bool isMyMsg = converter.NextBool();

                ChattingRoom_Form? form;

                // 해당 방번호에 해당하는 폼을 찾음
                talkManager.ChattingForm_Dic.TryGetValue(roomID, out form);

                if (form != null)
                {
                    form.Invoke(new Action(() =>
                    {
                        if (isMyMsg)
                        {
                            form.AddRChat(message, time);
                        }
                        else
                        {
                            form.AddLChat(message, name, time);
                        }
                    }
                    ));
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