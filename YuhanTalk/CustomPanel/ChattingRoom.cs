using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuhanTalk.Screen;

namespace YuhanTalk.CustomControl
{
    public partial class ChattingRoom : UserControl
    {

        public int RoomID { get; }
        private MainForm? mainForm;
        public ChattingRoom()
        {
            InitializeComponent();

        }

        public ChattingRoom(MainForm mainForm, int RoomID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.RoomID = RoomID;
        }
        
        public void SetTitle(string title)
        {
            lbl_title.Text = title;
        }

        public void SetContext(string context)
        {
            lbl_context.Text = context;
        }

        public void SetTime(string time)
        {
            lbl_time.Text = time;
        }

        private void ChattingRoom_Load(object sender, EventArgs e)
        {
            
        }

        private void ChattingRoom_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = null;
        }

        private void ChattingRoom_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Chatting_Room_ON;
        }

        // 방을 선택
        private void ChattingRoom_Click(object sender, EventArgs e)
        {
            if(mainForm != null)
            {
                // 선택한 방번호에 해당하는 폼이 이미 열려있는지 확인
                bool result = mainForm.YuhanTalkManager.ChattingForm_Dic.ContainsKey(RoomID);

                // 열려있지 않다면
                if(result == false)
                {
                    // 채팅창 폼 생성
                    ChattingRoom_Form form = new ChattingRoom_Form(mainForm.YuhanTalkManager, RoomID,lbl_title.Text);
                    form.Location = new Point(mainForm.Left + mainForm.Width, mainForm.Top);

                    // 딕셔너리에 넣고 결과를 받아옴
                    bool result2 = mainForm.YuhanTalkManager.ChattingForm_Dic.TryAdd(RoomID, form);
                    if (result2 == false) return;

                    // 폼을 열고 채팅 기록을 요청함
                    form.Show();
                    form.LoadChatHistory();
                }
                // 해당 방이 이미 열려있다면
                else
                {
                    ChattingRoom_Form? oldForm;
                    mainForm.YuhanTalkManager.ChattingForm_Dic.TryGetValue(RoomID, out oldForm);

                    if(oldForm != null)
                    {
                        oldForm.Activate();
                        oldForm.BringToFront();
                    }
                }
            }
        }
    }
}
