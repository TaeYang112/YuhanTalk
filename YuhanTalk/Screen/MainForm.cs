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
    public partial class MainForm : Form
    {
        public YuhanTalkManager YuhanTalkManager { get; }
        
        public MainForm()
        {
            InitializeComponent();
            YuhanTalkManager = new YuhanTalkManager(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            YuhanTalkManager.Start();

            UserControl userControl = new LoginScreen(this);
            ChangeScreen(userControl);
        }

        // 보여질 화면 변경
        public void ChangeScreen(UserControl newScreen)
        {
            this.Controls.Clear();
            this.Controls.Add(newScreen);
        }

        
    }
}
