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
        private MainForm mainForm;
        public YuhanTalkScreen(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void YuhanTalkScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
