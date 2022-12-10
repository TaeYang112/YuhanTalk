using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuhanTalk.Screen
{
    public partial class YuhanTalkScreen : UserControl
    {
        private YuhanTalkManager yuhanTalkManager;
        public YuhanTalkScreen(YuhanTalkManager talkManager)
        {
            InitializeComponent();
            Name = "YuhanTalk";
            this.yuhanTalkManager = talkManager;
        }

        private void YuhanTalkScreen_Load(object sender, EventArgs e)
        {
            ChangeScreen(new RoomsScreen(yuhanTalkManager));
        }

        public void ChangeScreen(UserControl control)
        {
            pnl_screen.Controls.Clear();
            pnl_screen.Controls.Add(control);
        }
    }
}
