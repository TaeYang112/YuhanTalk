namespace YuhanTalk.Screen
{
    partial class RoomsScreen
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
            this.fl_ChattingList = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddChatting = new YuhanTalk.CustomControl.RoundButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fl_ChattingList
            // 
            this.fl_ChattingList.AutoScroll = true;
            this.fl_ChattingList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fl_ChattingList.Location = new System.Drawing.Point(0, 175);
            this.fl_ChattingList.Margin = new System.Windows.Forms.Padding(0);
            this.fl_ChattingList.MaximumSize = new System.Drawing.Size(290, 0);
            this.fl_ChattingList.Name = "fl_ChattingList";
            this.fl_ChattingList.Size = new System.Drawing.Size(290, 415);
            this.fl_ChattingList.TabIndex = 2;
            this.fl_ChattingList.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personal Messages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Messages";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_AddChatting);
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 70);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Location = new System.Drawing.Point(15, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 1);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(66, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 58);
            this.label3.TabIndex = 1;
            this.label3.Text = "  버튼을 눌러 채팅방을 개설해보세요!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_AddChatting
            // 
            this.btn_AddChatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btn_AddChatting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.btn_AddChatting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_AddChatting.BorderRadius = 18;
            this.btn_AddChatting.BorderSize = 1;
            this.btn_AddChatting.FlatAppearance.BorderSize = 0;
            this.btn_AddChatting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddChatting.ForeColor = System.Drawing.Color.White;
            this.btn_AddChatting.Image = global::YuhanTalk.Properties.Resources.plus;
            this.btn_AddChatting.Location = new System.Drawing.Point(15, 12);
            this.btn_AddChatting.Name = "btn_AddChatting";
            this.btn_AddChatting.Size = new System.Drawing.Size(45, 45);
            this.btn_AddChatting.TabIndex = 0;
            this.btn_AddChatting.TextColor = System.Drawing.Color.White;
            this.btn_AddChatting.UseVisualStyleBackColor = false;
            this.btn_AddChatting.Click += new System.EventHandler(this.btn_AddChatting_Click);
            // 
            // RoomsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fl_ChattingList);
            this.Name = "RoomsScreen";
            this.Size = new System.Drawing.Size(290, 590);
            this.Load += new System.EventHandler(this.MessagesScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel fl_ChattingList;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private CustomControl.RoundButton btn_AddChatting;
        private Label label3;
        private Panel panel2;
    }
}
