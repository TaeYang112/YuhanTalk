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
        private YuhanTalkManager talkManager;
        public SignUpScreen(YuhanTalkManager talkManager)
        {
            InitializeComponent();
            this.talkManager = talkManager;
        }

        private void lklbl_GoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            talkManager.MainForm.ChangeScreen(new LoginScreen(talkManager));

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if(tb_Id.Text =="")
            {
                new MyMessageBox("아이디를 입력해주세요!").ShowDialog();
                return;
            }
            else if(tb_Pw.Text == "")
            {
                new MyMessageBox("비밀번호를 입력해주세요!").ShowDialog();
                return;
            }
            else if(tb_PwCheck.Text != tb_Pw.Text)
            {
                new MyMessageBox("비밀번호가 일치하지 않습니다!").ShowDialog();
                return;
            }
            else if(tb_Name.Text == "")
            {
                new MyMessageBox("이름을 입력해주세요!").ShowDialog();
                return;
            }

            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_SIGN_UP);
            generator.AddString(tb_Id.Text);
            generator.AddString(tb_Pw.Text);
            generator.AddString(tb_Name.Text);

            talkManager.SendMessage(generator.Generate());
        }

        private bool idInputFlag = false;
        private bool pwInputFlag = false;
        private bool pwCheckInputFlag = false;
        private bool nameInputFlag = false;

        // 입력창에 포커스가 생기면 힌트가 사라짐
        private void tb_InputBox_Enter(object sender, EventArgs e)
        {
            if (sender == tb_Id)
            {
                if (idInputFlag == false)
                {
                    idInputFlag = true;

                    tb_Id.Text = "";
                    tb_Id.ForeColor = Color.Black;
                }
            }
            else if(sender == tb_Pw)
            {
                if (pwInputFlag == false)
                {
                    pwInputFlag = true;

                    tb_Pw.Text = "";
                    tb_Pw.ForeColor = Color.Black;
                }
            }
            else if(sender == tb_PwCheck)
            {
                if (pwCheckInputFlag == false)
                {
                    pwCheckInputFlag = true;

                    tb_PwCheck.Text = "";
                    tb_PwCheck.ForeColor = Color.Black;
                }
            }
            else if(sender == tb_Name)
            {
                if (nameInputFlag == false)
                {
                    nameInputFlag = true;

                    tb_Name.Text = "";
                    tb_Name.ForeColor = Color.Black;
                }
            }
        }

        // 입력창에서 포커스가 풀리면 힌트가 입력창에 보임
        private void tb_InputBox_Leave(object sender, EventArgs e)
        {
            if (sender == tb_Id)
            {
                if (idInputFlag == true && tb_Id.Text == "")
                {
                    idInputFlag = false;

                    tb_Id.Text = "아이디";
                    tb_Id.ForeColor = Color.FromArgb(188, 188, 188);
                }
            }
            else if (sender == tb_Pw)
            {
                if (pwInputFlag == true && tb_Pw.Text == "")
                {
                    pwInputFlag = false;

                    tb_Pw.Text = "비밀번호";
                    tb_Pw.ForeColor = Color.FromArgb(188, 188, 188);
                }
            }
            else if (sender == tb_PwCheck&& tb_PwCheck.Text == "")
            {
                if (pwCheckInputFlag == true)
                {
                    pwCheckInputFlag = false;

                    tb_PwCheck.Text = "비밀번호 확인";
                    tb_PwCheck.ForeColor = Color.FromArgb(188, 188, 188);
                }
            }
            else if (sender == tb_Name && tb_Name.Text == "")
            {
                if (nameInputFlag == true)
                {
                    nameInputFlag = false;

                    tb_Name.Text = "이름";
                    tb_Name.ForeColor = Color.FromArgb(188, 188, 188);
                }
            }
        }

        private void SignUpScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
