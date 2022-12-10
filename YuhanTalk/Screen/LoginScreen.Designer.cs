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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Pw
            // 
            this.tb_Pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Pw.Font = new System.Drawing.Font("맑은 고딕", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tb_Pw.Location = new System.Drawing.Point(10, 43);
            this.tb_Pw.Name = "tb_Pw";
            this.tb_Pw.Size = new System.Drawing.Size(217, 19);
            this.tb_Pw.TabIndex = 1;
            this.tb_Pw.Text = "비밀번호";
            this.tb_Pw.Enter += new System.EventHandler(this.tb_InputBox_Enter);
            this.tb_Pw.Leave += new System.EventHandler(this.tb_InputBox_Leave);
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
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(55, 308);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(240, 41);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lklbl_GoToSignUp
            // 
            this.lklbl_GoToSignUp.ActiveLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToSignUp.AutoSize = true;
            this.lklbl_GoToSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklbl_GoToSignUp.LinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToSignUp.Location = new System.Drawing.Point(153, 526);
            this.lklbl_GoToSignUp.Name = "lklbl_GoToSignUp";
            this.lklbl_GoToSignUp.Size = new System.Drawing.Size(55, 15);
            this.lklbl_GoToSignUp.TabIndex = 2;
            this.lklbl_GoToSignUp.Text = "회원가입";
            this.lklbl_GoToSignUp.VisitedLinkColor = System.Drawing.Color.Black;
            this.lklbl_GoToSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbl_GoToSignUp_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_Id);
            this.panel1.Controls.Add(this.tb_Pw);
            this.panel1.Location = new System.Drawing.Point(55, 212);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 71);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 1);
            this.panel2.TabIndex = 4;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lklbl_GoToSignUp);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginScreen";
            this.Size = new System.Drawing.Size(360, 590);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_Pw;
        private TextBox tb_Id;
        private Button btn_login;
        private LinkLabel lklbl_GoToSignUp;
        private Panel panel1;
        private Panel panel2;
    }
}