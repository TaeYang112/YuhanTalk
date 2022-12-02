namespace YuhanTalk.Screen
{
    partial class YuhanTalkScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_screen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(0)))), ((int)(((byte)(74)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 590);
            this.panel1.TabIndex = 0;
            // 
            // pnl_screen
            // 
            this.pnl_screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.pnl_screen.Location = new System.Drawing.Point(70, 0);
            this.pnl_screen.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_screen.Name = "pnl_screen";
            this.pnl_screen.Size = new System.Drawing.Size(290, 590);
            this.pnl_screen.TabIndex = 1;
            // 
            // YuhanTalkScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pnl_screen);
            this.Controls.Add(this.panel1);
            this.Name = "YuhanTalkScreen";
            this.Size = new System.Drawing.Size(360, 590);
            this.Load += new System.EventHandler(this.YuhanTalkScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnl_screen;
    }
}
