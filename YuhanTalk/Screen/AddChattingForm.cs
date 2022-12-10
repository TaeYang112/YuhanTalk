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
using YuhanTalkModule;

namespace YuhanTalk.Screen
{
    public partial class AddChattingForm : Form
    {
        private YuhanTalkManager? talkManager;
        public AddChattingForm(YuhanTalkManager yuhanTalkManager)
        {
            InitializeComponent();
            
            this.talkManager = yuhanTalkManager;

            // 폼 그림자 생성
            (new DropShadow()).ApplyShadows(this);
        }

        public AddChattingForm()
        {
            InitializeComponent();
        }


        // 리스트뷰에 ID 추가
        public void AddID(string id)
        {
            if(this.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    lv_list.Items.Add(id);
                }
                ));
            }
            else
            {
                lv_list.Items.Add(id);
            }
            
        }

        private bool inputFlag = false;


        // 입력창에 포커스가 생기면 Type you message라는 텍스트가 사라짐
        private void tb_InputBox_Enter(object sender, EventArgs e)
        {
            if (inputFlag == false)
            {
                inputFlag = true;

                tb_InputBox.Text = "";
                tb_InputBox.ForeColor = Color.Black;
                
            }
        }

        // 입력창에서 포커스가 풀리면 Type your message라는 텍스트가 입력창에 보임
        private void tb_InputBox_Leave(object sender, EventArgs e)
        {
            if (inputFlag == true && tb_InputBox.Text == "")
            {
                inputFlag = false;

                tb_InputBox.Text = "아이디";
                tb_InputBox.ForeColor = Color.FromArgb(188, 188, 188);
            }
        }

        // 삭제 버튼
        private void btn_RemoveID_Click(object sender, EventArgs e)
        {
            int idx = lv_list.SelectedIndex;
            if (idx != -1)
            {
                lv_list.Items.RemoveAt(idx);
            }
        }

        // 엔터키 입력
        private void tb_InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RequestAddID();
            }
        }

        private void btn_AddID_Click(object sender, EventArgs e)
        {
            RequestAddID();
        }

        // 입력한 ID가 실재하는지 서버에게 검사를 요청함
        private void RequestAddID()
        {
            // 입력창이 비어있거나 "아이디" 라는 메시지가 떠있으면 요청 무시
            if (tb_InputBox.Text == "" || inputFlag == false) return;

            foreach (var item in lv_list.Items)
            {
                if (item.ToString() == tb_InputBox.Text)
                    return;
            }

            // 메시지 생성
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_CHECK_ID);
            generator.AddString(tb_InputBox.Text);

            // 전송
            talkManager?.SendMessage(generator.Generate());


            tb_InputBox.Text = "";
        }

        // 생성버튼
        private void btn_Commit_Click(object sender, EventArgs e)
        {
            // 비어있다면 리턴
            if(lv_list.Items.Count == 0) return;

            // 메시지 생성
            MessageGenerator generator = new MessageGenerator(Protocols.C_REQ_CREATE_ROOM);

            // 인원수 입력
            generator.AddInt(lv_list.Items.Count);
            foreach (var item in lv_list.Items)
            {
                // 아이디 입력
                generator.AddString(item.ToString()!);
            }

            // 전송
            talkManager?.SendMessage(generator.Generate());
        }

        private void AddChattingForm_Load(object sender, EventArgs e)
        {

        }


        #region 위에 잡고 움직일 수 있는 패널

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
