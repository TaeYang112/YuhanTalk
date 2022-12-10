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

        // �ؽ�Ʈ �ڽ��� Type your message ������ �ִ����� �����ϴ� ����
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

            // �� �׸��� ����
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

        // ���� ä�� �߰�
        public void AddLChat(string context, string name, string time)
        {
            Lchat newChat = new Lchat(context, name, time);
            fpnl_Chats.Controls.Add(newChat);

            // ��ũ���� �� ������ ����
            fpnl_Chats.PerformLayout();
            fpnl_Chats.ScrollControlIntoView(newChat);
        }

        // ���� ä�� �߰�
        public void AddRChat(string context, string time)
        {
            Rchat newChat = new Rchat(context, time);
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
                    // ���� ����Ű ����� �ֱ⶧���� �����
                }
                else
                {
                    // �ƹ��͵� ġ�� �ʾҴٸ� ����
                    if (tb_InputBox.Text == "")
                    {
                        e.Handled = true;
                        return;
                    }

                    string time = DateTime.Now.ToString("tt h:mm");

                    // ��Ʈ�� �߰�
                    AddRChat(tb_InputBox.Text, time);

                    // ������ ����
                    MessageGenerator generator = new MessageGenerator(Protocols.C_MSG);
                    generator.AddInt(roomID);
                    generator.AddString(tb_InputBox.Text);

                    yuhanTalkManager?.SendMessage(generator.Generate());

                    // ä�� ��� ����
                    ChattingRoom? room = null;
                    yuhanTalkManager?.ChattingRoom_Dic.TryGetValue(roomID,out room);

                    if(room != null)
                    {
                        room.SetContext(tb_InputBox.Text);
                        room.SetTime(time);
                    }

                    // �Է�â ���
                    tb_InputBox.Text = "";
                    e.Handled = true;
                }
            }
        }

        // ���� ���� �� �迭���� ������
        private void ChattingRoom_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            yuhanTalkManager?.ChattingForm_Dic.Remove(roomID);
        }

        // �Է�â�� ��Ŀ���� ����� Type you message��� �ؽ�Ʈ�� �����
        private void tb_InputBox_Enter(object sender, EventArgs e)
        {
            if (ChatFlag == true)
            {
                ChatFlag = false;

                tb_InputBox.Text = "";
                tb_InputBox.ForeColor = Color.Black;
            }
        }

        // �Է�â���� ��Ŀ���� Ǯ���� Type your message��� �ؽ�Ʈ�� �Է�â�� ����
        private void tb_InputBox_Leave(object sender, EventArgs e)
        {
            if (ChatFlag == false && tb_InputBox.Text == "")
            {
                ChatFlag = true;

                tb_InputBox.Text = "Type your message..";
                tb_InputBox.ForeColor = Color.FromArgb(188, 188, 188);
            }
        }

        #region ���� ��� ������ �� �ִ� �г�

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