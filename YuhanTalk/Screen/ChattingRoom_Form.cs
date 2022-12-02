using System.Runtime.InteropServices;
using YuhanTalk.CustomControl;
using YuhanTalk.Screen;
using YuhanTalkModule;

namespace YuhanTalk
{
    public partial class ChattingRoom_Form : System.Windows.Forms.Form
    {
        private YuhanTalkManager? yuhanTalkManager;
        private int roomID = -1;

        public ChattingRoom_Form(YuhanTalkManager yuhanTalkManager, int roomID) : this()
        {
            this.yuhanTalkManager = yuhanTalkManager;
            this.roomID = roomID;
        }
        
        public ChattingRoom_Form()
        {
            InitializeComponent();

            // 가로 스크롤바 지우는 코드
            fpnl_Chats.HorizontalScroll.Maximum = 10;
            fpnl_Chats.AutoScroll = false;
            fpnl_Chats.VerticalScroll.Visible = true;
            fpnl_Chats.AutoScroll = true;
        }

        private void YuhanTalk_Load(object sender, EventArgs e)
        {
        }

        public void AddLChat(string context, string name, string time)
        {
            Lchat newChat = new Lchat(tb_InputBox.Text, name, time);
            fpnl_Chats.Controls.Add(newChat);

            // 스크롤을 맨 밑으로 내림
            fpnl_Chats.PerformLayout();
            fpnl_Chats.ScrollControlIntoView(newChat);
        }

        public void AddRChat(string context, string time)
        {
            Rchat newChat = new Rchat(tb_InputBox.Text, time);
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
                    // 비어둠
                }
                else
                {
                    // 컨트롤 추가
                    AddRChat(tb_InputBox.Text, DateTime.Now.ToString("tt h:mm"));

                    // 서버로 전송
                    MessageGenerator generator = new MessageGenerator(Protocols.C_MSG);
                    generator.AddInt(roomID);
                    generator.AddString(tb_InputBox.Text);

                    yuhanTalkManager?.SendMessage(generator.Generate());

                    tb_InputBox.Text = "";
                    e.Handled = true;
                }
            }
        }


    }
}