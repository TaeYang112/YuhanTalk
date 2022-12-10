namespace YuhanTalk.Screen
{
    partial class AddChattingForm
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
            this.btn_ExitProgram = new YuhanTalk.CustomControl.CustomButton();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_InputBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lv_list = new System.Windows.Forms.ListBox();
            this.btn_Commit = new YuhanTalk.CustomControl.RoundButton();
            this.btn_RemoveID = new YuhanTalk.CustomControl.RoundButton();
            this.btn_AddID = new YuhanTalk.CustomControl.RoundButton();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ExitProgram
            // 
            this.btn_ExitProgram.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExitProgram.BackgroundImage = global::YuhanTalk.Properties.Resources.x;
            this.btn_ExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ExitProgram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ExitProgram.FlatAppearance.BorderSize = 0;
            this.btn_ExitProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ExitProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExitProgram.Location = new System.Drawing.Point(306, 12);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(20, 20);
            this.btn_ExitProgram.TabIndex = 3;
            this.btn_ExitProgram.TabStop = false;
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.White;
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Controls.Add(this.btn_ExitProgram);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(338, 62);
            this.pnl_header.TabIndex = 5;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseMove);
            this.pnl_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "채팅방 만들기";
            // 
            // tb_InputBox
            // 
            this.tb_InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_InputBox.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_InputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tb_InputBox.Location = new System.Drawing.Point(30, 92);
            this.tb_InputBox.Name = "tb_InputBox";
            this.tb_InputBox.Size = new System.Drawing.Size(220, 18);
            this.tb_InputBox.TabIndex = 6;
            this.tb_InputBox.Text = "아이디";
            this.tb_InputBox.Enter += new System.EventHandler(this.tb_InputBox_Enter);
            this.tb_InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_InputBox_KeyPress);
            this.tb_InputBox.Leave += new System.EventHandler(this.tb_InputBox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Location = new System.Drawing.Point(30, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 1);
            this.panel2.TabIndex = 7;
            // 
            // lv_list
            // 
            this.lv_list.FormattingEnabled = true;
            this.lv_list.ItemHeight = 15;
            this.lv_list.Location = new System.Drawing.Point(30, 144);
            this.lv_list.Name = "lv_list";
            this.lv_list.Size = new System.Drawing.Size(181, 94);
            this.lv_list.TabIndex = 8;
            // 
            // btn_Commit
            // 
            this.btn_Commit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Commit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Commit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(87)))), ((int)(((byte)(239)))));
            this.btn_Commit.BorderRadius = 5;
            this.btn_Commit.BorderSize = 1;
            this.btn_Commit.FlatAppearance.BorderSize = 0;
            this.btn_Commit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Commit.ForeColor = System.Drawing.Color.White;
            this.btn_Commit.Location = new System.Drawing.Point(217, 193);
            this.btn_Commit.Name = "btn_Commit";
            this.btn_Commit.Size = new System.Drawing.Size(88, 45);
            this.btn_Commit.TabIndex = 9;
            this.btn_Commit.Text = "생성";
            this.btn_Commit.TextColor = System.Drawing.Color.White;
            this.btn_Commit.UseVisualStyleBackColor = false;
            this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
            // 
            // btn_RemoveID
            // 
            this.btn_RemoveID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_RemoveID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_RemoveID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_RemoveID.BorderRadius = 5;
            this.btn_RemoveID.BorderSize = 1;
            this.btn_RemoveID.FlatAppearance.BorderSize = 0;
            this.btn_RemoveID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveID.ForeColor = System.Drawing.Color.Black;
            this.btn_RemoveID.Location = new System.Drawing.Point(217, 142);
            this.btn_RemoveID.Name = "btn_RemoveID";
            this.btn_RemoveID.Size = new System.Drawing.Size(88, 45);
            this.btn_RemoveID.TabIndex = 9;
            this.btn_RemoveID.Text = "삭제";
            this.btn_RemoveID.TextColor = System.Drawing.Color.Black;
            this.btn_RemoveID.UseVisualStyleBackColor = false;
            this.btn_RemoveID.Click += new System.EventHandler(this.btn_RemoveID_Click);
            // 
            // btn_AddID
            // 
            this.btn_AddID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_AddID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_AddID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_AddID.BorderRadius = 5;
            this.btn_AddID.BorderSize = 1;
            this.btn_AddID.FlatAppearance.BorderSize = 0;
            this.btn_AddID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddID.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddID.ForeColor = System.Drawing.Color.Black;
            this.btn_AddID.Location = new System.Drawing.Point(260, 92);
            this.btn_AddID.Name = "btn_AddID";
            this.btn_AddID.Size = new System.Drawing.Size(45, 29);
            this.btn_AddID.TabIndex = 9;
            this.btn_AddID.Text = "등록";
            this.btn_AddID.TextColor = System.Drawing.Color.Black;
            this.btn_AddID.UseVisualStyleBackColor = false;
            this.btn_AddID.Click += new System.EventHandler(this.btn_AddID_Click);
            // 
            // AddChattingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 267);
            this.Controls.Add(this.btn_AddID);
            this.Controls.Add(this.btn_RemoveID);
            this.Controls.Add(this.btn_Commit);
            this.Controls.Add(this.lv_list);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tb_InputBox);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddChattingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddChattingForm";
            this.Load += new System.EventHandler(this.AddChattingForm_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.CustomButton btn_ExitProgram;
        private Panel pnl_header;
        private Label label1;
        private TextBox tb_InputBox;
        private Panel panel2;
        private ListBox lv_list;
        private CustomControl.RoundButton btn_Commit;
        private CustomControl.RoundButton btn_RemoveID;
        private CustomControl.RoundButton btn_AddID;
    }
}