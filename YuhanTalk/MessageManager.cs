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
                    // 방 생성창에서 입력한 아이디가 실제 존재하는지 결과 수신
                    case Protocols.S_RES_CHECK_ID:
                        {
                            ReceiveIDCheckResult(converter);
                        }
                        break;
                    // 방 생성 결과 수신
                    case Protocols.S_CREATE_ROOM:
                        {
                            AddRoomComplete(converter);
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
                    talkManager.MainForm.ChangeScreen(new YuhanTalkScreen(talkManager));
                }
                else
                {
                    // 로그인 실패
                    // 메인 스레드에서 창을 띄우기 위해 Invoke 사용
                    talkManager.MainForm.BeginInvoke(new Action(() =>
                    {
                        MyMessageBox msgBox = new MyMessageBox("아이디와 비밀번호가 일치하지 않습니다.");
                        msgBox.ShowDialog();
                    }));
                }
            }

            private void ReceiveSignUpResult(MessageConverter converter)
            {
                int result = converter.NextInt();

                // 로그인에 성공
                switch(result)
                {
                    case 0:
                        talkManager.MainForm.ChangeScreen(new LoginScreen(talkManager));
                        break;
                    case 1:
                        {
                            talkManager.MainForm.BeginInvoke(new Action(() =>
                            {
                                MyMessageBox msgBox = new MyMessageBox("아이디가 이미 존재합니다.");
                                msgBox.ShowDialog();
                            }));
                        }
                        break;

                }
            }

            private void ReceiveRoomInfo(MessageConverter converter)
            {
                int roomId = converter.NextInt();
                string roomName = converter.NextString();
                string lastMessage = converter.NextString();
                string time = converter.NextString();

                // 컨트롤 검색
                FlowLayoutPanel? fl = talkManager.MainForm.Controls.Find("fl_ChattingList", true).FirstOrDefault() as FlowLayoutPanel;

                // 유효하다면
                if(fl != null)
                {
                    ChattingRoom? cr = null;

                    // 채팅방 목록이 존재하면 가져옴
                    bool result = talkManager.ChattingRoom_Dic.TryGetValue(roomId, out cr);

                    // 만약 없다면 새로 만들어서 넣어줌
                    if(cr == null)
                    {
                        cr = new ChattingRoom(talkManager.MainForm, roomId);
                    }

                    // 패널에 넣음
                    fl.Invoke(new Action(() =>
                    {
                        // 정보 수정
                        cr.SetTitle(roomName);
                        cr.SetTime(time);
                        cr.SetContext(lastMessage);

                        // 만약 새로 만들어진
                        if (result == false)
                        {
                            talkManager.ChattingRoom_Dic.Add(roomId, cr);
                            fl.Controls.Add(cr);
                        }
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

                // 폼이 존재하면
                if(form != null)
                {
                    form.Invoke(new Action(() =>
                    {
                        // 채팅 추가
                        form.AddLChat(message, name, time);
                    }
                    ));
                }


                ChattingRoom? room;

                // 해당 방번호에 해당하는 채팅방 목록을 찾음
                talkManager.ChattingRoom_Dic.TryGetValue(roomID, out room);

                // 목록이 존재하면
                if(room != null)
                {
                    room.Invoke(new Action(() =>
                    {
                        room.SetContext(message);
                        room.SetTime(time);

                    }));
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

            // 채팅방 생성중 입력한 ID가 실제 존재하는지에 대한 결과를 받음
            private void ReceiveIDCheckResult(MessageConverter converter)
            {
                string id = converter.NextString();
                byte result = converter.NextByte();

                // 현재 채팅방 생성폼이 열려있는지 확인
                AddChattingForm? form = Application.OpenForms["AddChattingForm"] as AddChattingForm;
                if (form != null)
                {
                    // 메인 스레드에서 창을 띄우기 위해 Invoke 사용
                    talkManager.MainForm.BeginInvoke(new Action(() =>
                    {
                        switch (result)
                        {
                            case IDCheckResult.SUCCESS:
                                {
                                    form.AddID(id);
                                }
                                break;
                            case IDCheckResult.ERROR_NO_ID:
                                {
                                    MyMessageBox msgBox = new MyMessageBox("아이디가 존재하지 않습니다!");
                                    msgBox.Location = new Point(form.Left + form.Width / 2 - msgBox.Width / 2, form.Top + form.Height / 2 - msgBox.Height / 2);
                                    msgBox.ShowDialog();
                                }
                                break;
                            case IDCheckResult.ERROR_SAME_YOUR_ID:
                                {
                                    MyMessageBox msgBox = new MyMessageBox("자신의 아이디는 추가할 수 없습니다!");
                                    msgBox.Location = new Point(form.Left + form.Width / 2 - msgBox.Width / 2, form.Top + form.Height / 2 - msgBox.Height / 2);
                                    msgBox.ShowDialog();
                                }
                                break;
                        }
                    }));
                }
            }

            // 방 생성이 완료됨
            private void AddRoomComplete(MessageConverter converter)
            {
                int roomID = converter.NextInt();
                string roomTitle = converter.NextString();
                bool doOpen = converter.NextBool();

                // 현재 채팅방 생성폼이 열려있는지 확인
                AddChattingForm? addChattingForm = Application.OpenForms["AddChattingForm"] as AddChattingForm;
                if(addChattingForm != null)
                {
                    // 닫음
                    addChattingForm.Close();
                }


                // 방 목록 추가
                // 컨트롤 검색 ( 방 목록 레이아웃 )
                FlowLayoutPanel? fl = talkManager.MainForm.Controls.Find("fl_ChattingList", true).FirstOrDefault() as FlowLayoutPanel;
                if (fl != null)
                {
                    // 컨트롤 생성
                    ChattingRoom cr = new ChattingRoom(talkManager.MainForm, roomID);
                    cr.SetTitle(roomTitle);
                    cr.SetTime("");
                    cr.SetContext("");

                    // 배열에 넣음
                    talkManager.ChattingRoom_Dic.Add(roomID, cr);

                    fl.Invoke(new Action(() =>
                    {
                        // 패널에 넣음
                        fl.Controls.Add(cr);
                    }));
                }

                if (doOpen)
                {
                    talkManager.MainForm.BeginInvoke(new Action(() =>
                    {
                    // 방 생성과 동시에 채팅방 폼을 띄움
                    ChattingRoom_Form form = new ChattingRoom_Form(talkManager, roomID, roomTitle);
                        bool result = talkManager.ChattingForm_Dic.TryAdd(roomID, form);

                    // 위치를 메인 폼 오른쪽으로 함
                    form.Location = new Point(talkManager.MainForm.Left + talkManager.MainForm.Width, talkManager.MainForm.Top);
                        form.Show();
                    }));
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