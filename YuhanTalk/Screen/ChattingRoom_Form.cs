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

            // ���� ��ũ�ѹ� ����� �ڵ�
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

            // ��ũ���� �� ������ ����
            fpnl_Chats.PerformLayout();
            fpnl_Chats.ScrollControlIntoView(newChat);
        }

        public void AddRChat(string context, string time)
        {
            Rchat newChat = new Rchat(tb_InputBox.Text, time);
            fpnl_Chats.Controls.Add(newChat);

            // ��ũ���� �� ������ ����
            fpnl_Chats.PerformLayout();
            fpnl_Chats.ScrollControlIntoView(newChat);
        }

        private void tb_InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ����Ű
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Shift + ����Ű�� �� �ٲ�
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    // ����
                }
                else
                {
                    // ��Ʈ�� �߰�
                    AddRChat(tb_InputBox.Text, DateTime.Now.ToString("tt h:mm"));

                    // ������ ����
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