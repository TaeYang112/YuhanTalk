namespace YuhanTalk.CustomControl
{
    partial class ChattingRoom
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_context = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::YuhanTalk.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ChattingRoom_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.ChattingRoom_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ChattingRoom_MouseLeave);
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("맑은 고딕", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(66, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(130, 22);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "방제목";
            this.lbl_title.Click += new System.EventHandler(this.ChattingRoom_Click);
            this.lbl_title.MouseEnter += new System.EventHandler(this.ChattingRoom_MouseEnter);
            this.lbl_title.MouseLeave += new System.EventHandler(this.ChattingRoom_MouseLeave);
            // 
            // lbl_context
            // 
            this.lbl_context.BackColor = System.Drawing.Color.Transparent;
            this.lbl_context.Location = new System.Drawing.Point(66, 32);
            this.lbl_context.MaximumSize = new System.Drawing.Size(130, 0);
            this.lbl_context.Name = "lbl_context";
            this.lbl_context.Size = new System.Drawing.Size(130, 15);
            this.lbl_context.TabIndex = 2;
            this.lbl_context.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_context.Click += new System.EventHandler(this.ChattingRoom_Click);
            this.lbl_context.MouseEnter += new System.EventHandler(this.ChattingRoom_MouseEnter);
            this.lbl_context.MouseLeave += new System.EventHandler(this.ChattingRoom_MouseLeave);
            // 
            // lbl_time
            // 
            this.lbl_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_time.ForeColor = System.Drawing.Color.Gray;
            this.lbl_time.Location = new System.Drawing.Point(196, 17);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(74, 38);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Click += new System.EventHandler(this.ChattingRoom_Click);
            this.lbl_time.MouseEnter += new System.EventHandler(this.ChattingRoom_MouseEnter);
            this.lbl_time.MouseLeave += new System.EventHandler(this.ChattingRoom_MouseLeave);
            // 
            // ChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_context);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChattingRoom";
            this.Size = new System.Drawing.Size(270, 70);
            this.Load += new System.EventHandler(this.ChattingRoom_Load);
            this.Click += new System.EventHandler(this.ChattingRoom_Click);
            this.MouseEnter += new System.EventHandler(this.ChattingRoom_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ChattingRoom_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_title;
        private Label lbl_context;
        private Label lbl_time;
    }
}
