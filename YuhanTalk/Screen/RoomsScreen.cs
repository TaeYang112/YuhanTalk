using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuhanTalkModule;

namespace YuhanTalk.Screen
{
    public partial class RoomsScreen : UserControl
    {
        YuhanTalkManager talkManager;
        public RoomsScreen(YuhanTalkManager talkManager)
        {
            InitializeComponent();
            this.talkManager = talkManager;
            Name = "Rooms";
        }

        private void MessagesScreen_Load(object sender, EventArgs e)
        {
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_ROOM_LIST);

            talkManager.SendMessage(generator.Generate());
        }

        private void btn_AddChatting_Click(object sender, EventArgs e)
        {
            Form form = new AddChattingForm(talkManager);
            form.ShowDialog();

        }
    }
}
