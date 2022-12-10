using System.Runtime.InteropServices;
using YuhanTalk.Class.Core;
using YuhanTalk.CustomControl;
using YuhanTalk.Screen;
using YuhanTalkModule;

namespace YuhanTalk
{
    public partial class ChattingRoom_Form : System.Windows.Forms.Form
    {
        private YuhanTalkManager? yuhanTalkManager;
        private int roomID = -1;

        // 텍스트 박스에 Type your message 문구가 있는지를 구별하는 변수
        private bool ChatFlag = true;

        public ChattingRoom_Form(YuhanTalkManager yuhanTalkManager, int roomID, string title) : this()
        {
            this.yuhanTalkManager = yuhanTalkManager;
            this.roomID = roomID;
            this.lbl_title.Text = title;
        }

        public ChattingRoom_Form()
        {
            InitializeComponent();

            // 폼 그림자 설정
            (new DropShadow()).ApplyShadows(this);
        }

        private void YuhanTalk_Load(object sender, EventArgs e)
        {
        }

        public void LoadChatHistory()
        {
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_CHAT_LIST);
            generator.AddInt(roomID);
            yuhanTalkManager?.SendMessage(generator.Generate());
        }

        // 상대방 채팅 추가
        public void AddLChat(string context, string name, string time)
        {
            Lchat newChat = new Lchat(context, name, time);
            fpnl_Chats.Controls.Add(newChat);

            // 스크롤을 맨 밑으로 내림
            fpnl_Chats.PerformLayout();
            fpnl_Chats.ScrollControlIntoView(newChat);
        }

        // 나의 채팅 추가
        public void AddRChat(string context, string time)
        {
            Rchat newChat = new Rchat(context, time);
            fpnl_Chats.Controls.Add(newChat);

            // 스크롤을 맨 밑으로 내림
            fpnl_Chats.PerformLayout();
            fpnl_Chats.ScrollControlIntoView(newChat);
        }

        private void tb_InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 엔터키
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Shift + 엔터키면 줄 바꿈
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    // 기존 엔터키 기능이 있기때문에 비워둠
                }
                else
                {
                    // 아무것도 치지 않았다면 나감
                    if (tb_InputBox.Text == "")
                    {
                        e.Handled = true;
                        return;
                    }

                    string time = DateTime.Now.ToString("tt h:mm");

                    // 컨트롤 추가
                    AddRChat(tb_InputBox.Text, time);

                    // 서버로 전송
                    MessageGenerator generator = new MessageGenerator(Protocols.C_MSG);
                    generator.AddInt(roomID);
                    generator.AddString(tb_InputBox.Text);

                    yuhanTalkManager?.SendMessage(generator.Generate());

                    // 채팅 목록 수정
                    ChattingRoom? room = null;
                    yuhanTalkManager?.ChattingRoom_Dic.TryGetValue(roomID,out room);

                    if(room != null)
                    {
                        room.SetContext(tb_InputBox.Text);
                        room.SetTime(time);
                    }

                    // 입력창 비움
                    tb_InputBox.Text = "";
                    e.Handled = true;
                }
            }
        }

        // 폼이 닫힐 때 배열에서 제거함
        private void ChattingRoom_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            yuhanTalkManager?.ChattingForm_Dic.Remove(roomID);
        }

        // 입력창에 포커스가 생기면 Type you message라는 텍스트가 사라짐
        private void tb_InputBox_Enter(object sender, EventArgs e)
        {
            if (ChatFlag == true)
            {
                ChatFlag = false;

                tb_InputBox.Text = "";
                tb_InputBox.ForeColor = Color.Black;
            }
        }

        // 입력창에서 포커스가 풀리면 Type your message라는 텍스트가 입력창에 보임
        private void tb_InputBox_Leave(object sender, EventArgs e)
        {
            if (ChatFlag == false && tb_InputBox.Text == "")
            {
                ChatFlag = true;

                tb_InputBox.Text = "Type your message..";
                tb_InputBox.ForeColor = Color.FromArgb(188, 188, 188);
            }
        }

        #region 위에 잡고 움직일 수 있는 패널

        bool isMove = false;
        Point fPt = new Point(0, 0);

        private void pnl_BorderTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void pnl_BorderTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
            }
        }

        private void pnl_BorderTop_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;

            fPt = new Point(e.X, e.Y);
        }

        private void btn_ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}