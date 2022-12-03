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

        private void ChattingRoom_Click(object sender, EventArgs e)
        {
            if(mainForm != null)
            { 
                ChattingRoom_Form form = new ChattingRoom_Form(mainForm.YuhanTalkManager, RoomID);
                bool result =  mainForm.YuhanTalkManager.ChattingForm_Dic.TryAdd(RoomID, form);

                if(result == true)
                {
                    form.Show();
                    form.LoadChatHistory();
                }
                else
                {
                    form.Dispose();

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
