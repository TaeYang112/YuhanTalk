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

namespace YuhanTalk.CustomControl
{
    public partial class ChattingRoom : UserControl
    {

        public ChattingRoom()
        {
            InitializeComponent();
            
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
    }
}
