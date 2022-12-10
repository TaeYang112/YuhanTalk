namespace YuhanTalk.Screen
{
    partial class SignUpScreen
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lklbl_GoToLogin = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_PwCheck = new System.Windows.Forms.TextBox();
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lklbl_GoToLogin
            // 
            this.lklbl_GoToLogin.ActiveLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToLogin.AutoSize = true;
            this.lklbl_GoToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklbl_GoToLogin.LinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToLogin.Location = new System.Drawing.Point(120, 526);
            this.lklbl_GoToLogin.Name = "lklbl_GoToLogin";
            this.lklbl_GoToLogin.Size = new System.Drawing.Size(107, 15);
            this.lklbl_GoToLogin.TabIndex = 4;
            this.lklbl_GoToLogin.TabStop = true;
            this.lklbl_GoToLogin.Text = "처음으로 돌아가기";
            this.lklbl_GoToLogin.VisitedLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_GoToLogin_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.tb_Id);
            this.panel1.Controls.Add(this.tb_PwCheck);
            this.panel1.Controls.Add(this.tb_Pw);
            this.panel1.Location = new System.Drawing.Point(55, 176);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 147);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(0, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 1);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 1);
            this.panel2.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Font = new System.Drawing.Font("맑은 고딕", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tb_Name.Location = new System.Drawing.Point(10, 117);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(217, 19);
            this.tb_Name.TabIndex = 0;
            this.tb_Name.Text = "이름";
            this.tb_Name.Enter += new System.EventHandler(this.tb_InputBox_Enter);
            this.tb_Name.Leave += new System.EventHandler(this.tb_InputBox_Leave);
            // 
            // tb_Id
            // 
            this.tb_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Id.Font = new System.Drawing.Font("맑은 고딕", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tb_Id.Location = new System.Drawing.Point(10, 8);
            this.tb_Id.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(217, 19);
            this.tb_Id.TabIndex = 0;
            this.tb_Id.Text = "아이디";
            this.tb_Id.Enter += new System.EventHandler(this.tb_InputBox_Enter);
            this.tb_Id.Leave += new System.EventHandler(this.tb_InputBox_Leave);
            // 
            // tb_PwCheck
            // 
            this.tb_PwCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PwCheck.Font = new System.Drawing.Font("맑은 고딕", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_PwCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tb_PwCheck.Location = new System.Drawing.Point(10, 80);
            this.tb_PwCheck.Name = "tb_PwCheck";
            this.tb_PwCheck.Size = new System.Drawing.Size(217, 19);
            this.tb_PwCheck.TabIndex = 1;
            this.tb_PwCheck.Text = "비밀번호";
            this.tb_PwCheck.Enter += new System.EventHandler(this.tb_InputBox_Enter);
            this.tb_PwCheck.Leave += new System.EventHandler(this.tb_InputBox_Leave);
            // 
            // tb_Pw
            // 
            this.tb_Pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Pw.Font = new System.Drawing.Font("맑은 고딕", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tb_Pw.Location = new System.Drawing.Point(10, 46);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(217, 19);
            this.tb_Pw.TabIndex = 1;
            this.tb_Pw.Text = "비밀번호";
            this.tb_Pw.Enter += new System.EventHandler(this.tb_InputBox_Enter);
            this.tb_Pw.Leave += new System.EventHandler(this.tb_InputBox_Leave);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.White;
            this.btn_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Location = new System.Drawing.Point(55, 333);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(240, 41);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.Text = "회원가입";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lklbl_GoToLogin);
            this.Name = "SignUpScreen";
            this.Size = new System.Drawing.Size(360, 590);
            this.Load += new System.EventHandler(this.SignUpScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LinkLabel lklbl_GoToLogin;
        private Panel panel1;
        private Panel panel2;
        private TextBox tb_Id;
        private TextBox tb_Pw;
        private Button btn_SignUp;
        private Panel panel4;
        private Panel panel3;
        private TextBox tb_Name;
        private TextBox tb_PwCheck;
    }
}
