namespace YuhanTalk.Screen
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Pw = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lklbl_GoToSignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tb_Pw
            // 
            this.tb_Pw.Location = new System.Drawing.Point(82, 241);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(181, 23);
            this.tb_Pw.TabIndex = 0;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(82, 217);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(181, 23);
            this.tb_Id.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(82, 285);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(181, 29);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lklbl_GoToSignUp
            // 
            this.lklbl_GoToSignUp.ActiveLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToSignUp.AutoSize = true;
            this.lklbl_GoToSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklbl_GoToSignUp.LinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToSignUp.Location = new System.Drawing.Point(99, 526);
            this.lklbl_GoToSignUp.Name = "lklbl_GoToSignUp";
            this.lklbl_GoToSignUp.Size = new System.Drawing.Size(55, 15);
            this.lklbl_GoToSignUp.TabIndex = 2;
            this.lklbl_GoToSignUp.TabStop = true;
            this.lklbl_GoToSignUp.Text = "회원가입";
            this.lklbl_GoToSignUp.VisitedLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_GoToSignUp_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(169, 526);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(83, 15);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "비밀번호 찾기";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lklbl_GoToSignUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.tb_Pw);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(360, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Pw;
        private TextBox tb_Id;
        private Button btn_login;
        private LinkLabel lklbl_GoToSignUp;
        private LinkLabel linkLabel2;
    }
}