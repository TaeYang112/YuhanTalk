using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YuhanTalk.Class.Core;

namespace YuhanTalk.Screen
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();

            // 폼 외부 그림자
            new DropShadow().ApplyShadows(this);
        }

        public MyMessageBox(string message) : this()
        {
            lbl_message.Text = message;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }



        #region 폼을 잡고 움직이기 위한 상단바

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
