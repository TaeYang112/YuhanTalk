namespace YuhanTalk.CustomControl
{
    partial class Lchat
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.rbtnChat = new YuhanTalk.CustomControl.RoundButton();
            this.lblContext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(91, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(69, 15);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "0000.00.00";
            // 
            // rbtnChat
            // 
            this.rbtnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(47)))), ((int)(((byte)(255)))));
            this.rbtnChat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(47)))), ((int)(((byte)(255)))));
            this.rbtnChat.BorderColor = System.Drawing.Color.Black;
            this.rbtnChat.BorderRadius = 5;
            this.rbtnChat.BorderSize = 0;
            this.rbtnChat.Enabled = false;
            this.rbtnChat.FlatAppearance.BorderSize = 0;
            this.rbtnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnChat.ForeColor = System.Drawing.Color.White;
            this.rbtnChat.Location = new System.Drawing.Point(51, 29);
            this.rbtnChat.Name = "rbtnChat";
            this.rbtnChat.Size = new System.Drawing.Size(31, 31);
            this.rbtnChat.TabIndex = 4;
            this.rbtnChat.TextColor = System.Drawing.Color.White;
            this.rbtnChat.UseVisualStyleBackColor = false;
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(47)))), ((int)(((byte)(255)))));
            this.lblContext.ForeColor = System.Drawing.Color.White;
            this.lblContext.Location = new System.Drawing.Point(59, 37);
            this.lblContext.MaximumSize = new System.Drawing.Size(230, 0);
            this.lblContext.MinimumSize = new System.Drawing.Size(15, 15);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(15, 15);
            this.lblContext.TabIndex = 5;
            this.lblContext.Text = "C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::YuhanTalk.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Lchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.rbtnChat);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(360, 0);
            this.Name = "Lchat";
            this.Size = new System.Drawing.Size(360, 65);
            this.Load += new System.EventHandler(this.Lchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblName;
        private Label lblTime;
        private RoundButton rbtnChat;
        private Label lblContext;
        private PictureBox pictureBox1;
    }
}
