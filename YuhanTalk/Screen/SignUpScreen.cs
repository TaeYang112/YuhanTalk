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
    public partial class SignUpScreen : UserControl
    {
        private MainForm mainForm;
        public SignUpScreen(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void lklbl_GoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            mainForm.ChangeScreen(new LoginScreen(mainForm));

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_SIGN_UP);
            generator.AddString(tb_ID.Text);
            generator.AddString(tb_Password.Text);
            generator.AddString(tb_Name.Text);

            mainForm.YuhanTalkManager.SendMessage(generator.Generate());
        }
    }
}
