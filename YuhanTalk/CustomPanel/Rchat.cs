using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace YuhanTalk.CustomControl
{
    public partial class Rchat : UserControl
    {
        public Rchat() : this("테스트테스테스테스테스테스테스테스테스테스", "00-00-00")
        {
        }
        public Rchat(string context, string time)
        {
            InitializeComponent();
            lblContext.Text = context;
            lblContext.Left -= 13 - (this.Width - (lblContext.Left + lblContext.Width));
            lblTime.Text = time;
            rbtnChat.Location = new Point(lblContext.Left - 8, rbtnChat.Top);
            rbtnChat.Size = new Size(lblContext.Width + 16, lblContext.Height + 16);
            lblTime.Location = new Point(rbtnChat.Left - lblTime.Width - 9, rbtnChat.Top + rbtnChat.Height - lblTime.Height);
            this.Height = rbtnChat.Height + rbtnChat.Top + 3;
        }


        private void Lchat_Load(object sender, EventArgs e)
        {
        }
    }
}
