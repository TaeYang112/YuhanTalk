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
        private YuhanTalkManager talkManager;

        private bool idInputFlag = false;
        private bool pwInputFlag = false;
        public LoginScreen(YuhanTalkManager talkManager)
        {
            InitializeComponent();
            this.talkManager = talkManager;
        }

        // 로그인 버튼 클릭
        private void btn_login_Click(object sender, EventArgs e)
        {
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_LOGIN);
            generator.AddString(tb_Id.Text);
            generator.AddString(tb_Pw.Text);

            talkManager.SendMessage(generator.Generate());
        }

        private void lklbl_GoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            talkManager.MainForm.ChangeScreen(new SignUpScreen(talkManager));
        }

        // 입력창에 포커스가 생기면 힌트가 사라짐
        private void tb_InputBox_Enter(object sender, EventArgs e)
        {
            if(sender == tb_Id)
            {
                if (idInputFlag == false)
                {
                    idInputFlag = true;

                    tb_Id.Text = "";
                    tb_Id.ForeColor = Color.Black;
                }
            }
            else
            {
                if (pwInputFlag == false)
                {
                    pwInputFlag = true;

                    tb_Pw.Text = "";
                    tb_Pw.ForeColor = Color.Black;
                }
            }
        }

        // 입력창에서 포커스가 풀리면 힌트가 입력창에 보임
        private void tb_InputBox_Leave(object sender, EventArgs e)
        {
            if (sender == tb_Id)
            {
                if (idInputFlag == false && tb_Id.Text == "")
                {
                    idInputFlag = true;

                    tb_Id.Text = "아이디";
                    tb_Id.ForeColor = Color.FromArgb(188, 188, 188);
                }
            }
            else
            {
                if (pwInputFlag == false && tb_Id.Text == "")
                {
                    pwInputFlag = true;

                    tb_Pw.Text = "비밀번호";
                    tb_Pw.ForeColor = Color.FromArgb(188, 188, 188);
                }
            }
        }
    }
}
