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
using YuhanTalk.CustomControl;

namespace YuhanTalk.Screen
{
    public partial class MainForm : Form
    {
     
        public YuhanTalkManager YuhanTalkManager { get;private set; }
        
        public MainForm()
        {
            InitializeComponent();
            YuhanTalkManager = new YuhanTalkManager(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            YuhanTalkManager.Start();
            AddBorderTop();

            btn_ExitProgram.BringToFront();


            UserControl userControl = new LoginScreen(this);
            ChangeScreen(userControl);
        }

        
        // X버튼이 있고, 잡고 창을 움직일 수 있는 패널 생성
        private void AddBorderTop()
        {
            Panel panel = new TransparentPanel();
            panel.Size = new Size(360, 75);
            Controls.Add(panel);
            panel.BringToFront();
            panel.MouseDown += pnl_BorderTop_MouseDown!;
            panel.MouseUp += pnl_BorderTop_MouseUp!;
            panel.MouseMove += pnl_BorderTop_MouseMove!;
           

        }
        
        // 보여질 화면 변경
        public void ChangeScreen(UserControl newScreen)
        {
            Invoke(new Action(() =>
            {
                pnl_Screen.Controls.Clear();
                pnl_Screen.Controls.Add(newScreen);
                btn_ExitProgram.BackColor = newScreen.BackColor;

            }));
        }


        bool isMove = false;
        Point fPt = new Point(0,0);

        private void pnl_BorderTop_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void pnl_BorderTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
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
            Application.Exit();
        }
    }
}
