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
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_PasswordCheck = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lklbl_GoToLogin = new System.Windows.Forms.LinkLabel();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(94, 192);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(173, 23);
            this.tb_ID.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(94, 227);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(173, 23);
            this.tb_Password.TabIndex = 1;
            // 
            // tb_PasswordCheck
            // 
            this.tb_PasswordCheck.Location = new System.Drawing.Point(94, 256);
            this.tb_PasswordCheck.Name = "tb_PasswordCheck";
            this.tb_PasswordCheck.Size = new System.Drawing.Size(173, 23);
            this.tb_PasswordCheck.TabIndex = 2;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Location = new System.Drawing.Point(94, 331);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(173, 23);
            this.btn_SignUp.TabIndex = 3;
            this.btn_SignUp.Text = "회원가입";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lklbl_GoToLogin
            // 
            this.lklbl_GoToLogin.ActiveLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToLogin.AutoSize = true;
            this.lklbl_GoToLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklbl_GoToLogin.LinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToLogin.Location = new System.Drawing.Point(136, 458);
            this.lklbl_GoToLogin.Name = "lklbl_GoToLogin";
            this.lklbl_GoToLogin.Size = new System.Drawing.Size(107, 15);
            this.lklbl_GoToLogin.TabIndex = 4;
            this.lklbl_GoToLogin.TabStop = true;
            this.lklbl_GoToLogin.Text = "처음으로 돌아가기";
            this.lklbl_GoToLogin.VisitedLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_GoToLogin_LinkClicked);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(94, 285);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(173, 23);
            this.tb_Name.TabIndex = 5;
            // 
            // SignUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lklbl_GoToLogin);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.tb_PasswordCheck);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_ID);
            this.Name = "SignUpScreen";
            this.Size = new System.Drawing.Size(360, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_ID;
        private TextBox tb_Password;
        private TextBox tb_PasswordCheck;
        private Button btn_SignUp;
        private LinkLabel lklbl_GoToLogin;
        private TextBox tb_Name;
    }
}
