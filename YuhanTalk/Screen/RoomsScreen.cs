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
        MainForm mainForm;
        public RoomsScreen(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Name = "Rooms";
        }

        private void MessagesScreen_Load(object sender, EventArgs e)
        {
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_ROOM_LIST);

            mainForm.YuhanTalkManager.SendMessage(generator.Generate());
        }
    }
}
