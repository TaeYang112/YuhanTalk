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
    public partial class LoginScreen : UserControl
    {
        private MainForm mainForm;
        public LoginScreen(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        // 로그인 버튼 클릭
        private void btn_login_Click(object sender, EventArgs e)
        {
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_LOGIN);
            generator.AddString(tb_Id.Text);
            generator.AddString(tb_Pw.Text);

            mainForm.YuhanTalkManager.SendMessage(generator.Generate());
        }

        private void lklbl_GoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainForm.ChangeScreen(new SignUpScreen(mainForm));
        }

    }
}
