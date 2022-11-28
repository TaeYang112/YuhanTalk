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
            this.label1 = new System.Windows.Forms.Label();
            this.fl_ChattingList = new System.Windows.Forms.FlowLayoutPanel();
            this.chattingRoom1 = new YuhanTalk.CustomControl.ChattingRoom();
            this.chattingRoom2 = new YuhanTalk.CustomControl.ChattingRoom();
            this.chattingRoom3 = new YuhanTalk.CustomControl.ChattingRoom();
            this.chattingRoom4 = new YuhanTalk.CustomControl.ChattingRoom();
            this.chattingRoom5 = new YuhanTalk.CustomControl.ChattingRoom();
            this.chattingRoom6 = new YuhanTalk.CustomControl.ChattingRoom();
            this.chattingRoom7 = new YuhanTalk.CustomControl.ChattingRoom();
            this.label2 = new System.Windows.Forms.Label();
            this.fl_ChattingList.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Messages";
            // 
            // fl_ChattingList
            // 
            this.fl_ChattingList.Controls.Add(this.chattingRoom1);
            this.fl_ChattingList.Controls.Add(this.chattingRoom2);
            this.fl_ChattingList.Controls.Add(this.chattingRoom3);
            this.fl_ChattingList.Controls.Add(this.chattingRoom4);
            this.fl_ChattingList.Controls.Add(this.chattingRoom5);
            this.fl_ChattingList.Controls.Add(this.chattingRoom6);
            this.fl_ChattingList.Controls.Add(this.chattingRoom7);
            this.fl_ChattingList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fl_ChattingList.Location = new System.Drawing.Point(70, 94);
            this.fl_ChattingList.Margin = new System.Windows.Forms.Padding(0);
            this.fl_ChattingList.Name = "fl_ChattingList";
            this.fl_ChattingList.Size = new System.Drawing.Size(290, 496);
            this.fl_ChattingList.TabIndex = 0;
            // 
            // chattingRoom1
            // 
            this.chattingRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.chattingRoom1.Location = new System.Drawing.Point(0, 0);
            this.chattingRoom1.Margin = new System.Windows.Forms.Padding(0);
            this.chattingRoom1.Name = "chattingRoom1";
            this.chattingRoom1.Size = new System.Drawing.Size(290, 70);
            this.chattingRoom1.TabIndex = 0;
            // 
            // chattingRoom2
            // 
            this.chattingRoom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.chattingRoom2.Location = new System.Drawing.Point(0, 70);
            this.chattingRoom2.Margin = new System.Windows.Forms.Padding(0);
            this.chattingRoom2.Name = "chattingRoom2";
            this.chattingRoom2.Size = new System.Drawing.Size(290, 70);
            this.chattingRoom2.TabIndex = 1;
            // 
            // chattingRoom3
            // 
            this.chattingRoom3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.chattingRoom3.Location = new System.Drawing.Point(0, 140);
            this.chattingRoom3.Margin = new System.Windows.Forms.Padding(0);
            this.chattingRoom3.Name = "chattingRoom3";
            this.chattingRoom3.Size = new System.Drawing.Size(290, 70);
            this.chattingRoom3.TabIndex = 2;
            // 
            // chattingRoom4
            // 
            this.chattingRoom4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.chattingRoom4.Location = new System.Drawing.Point(0, 210);
            this.chattingRoom4.Margin = new System.Windows.Forms.Padding(0);
            this.chattingRoom4.Name = "chattingRoom4";
            this.chattingRoom4.Size = new System.Drawing.Size(290, 70);
            this.chattingRoom4.TabIndex = 3;
            // 
            // chattingRoom5
            // 
            this.chattingRoom5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.chattingRoom5.Location = new System.Drawing.Point(0, 280);
            this.chattingRoom5.Margin = new System.Windows.Forms.Padding(0);
            this.chattingRoom5.Name = "chattingRoom5";
            this.chattingRoom5.Size = new System.Drawing.Size(290, 70);
            this.chattingRoom5.TabIndex = 4;
            // 
            // chattingRoom6
            // 
            this.chattingRoom6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.chattingRoom6.Location = new System.Drawing.Point(0, 350);
            this.chattingRoom6.Margin = new System.Windows.Forms.Padding(0);
            this.chattingRoom6.Name = "chattingRoom6";
            this.chattingRoom6.Size = new System.Drawing.Size(290, 70);
            this.chattingRoom6.TabIndex = 5;
            // 
            // chattingRoom7
            // 
            this.chattingRoom7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.chattingRoom7.Location = new System.Drawing.Point(0, 420);
            this.chattingRoom7.Margin = new System.Windows.Forms.Padding(0);
            this.chattingRoom7.Name = "chattingRoom7";
            this.chattingRoom7.Size = new System.Drawing.Size(290, 70);
            this.chattingRoom7.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(91, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Messages";
            // 
            // YuhanTalkScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fl_ChattingList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "YuhanTalkScreen";
            this.Size = new System.Drawing.Size(360, 590);
            this.Load += new System.EventHandler(this.YuhanTalkScreen_Load);
            this.fl_ChattingList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel fl_ChattingList;
        private Label label2;
        private CustomControl.ChattingRoom chattingRoom1;
        private CustomControl.ChattingRoom chattingRoom2;
        private CustomControl.ChattingRoom chattingRoom3;
        private CustomControl.ChattingRoom chattingRoom4;
        private CustomControl.ChattingRoom chattingRoom5;
        private CustomControl.ChattingRoom chattingRoom6;
        private CustomControl.ChattingRoom chattingRoom7;
    }
}
