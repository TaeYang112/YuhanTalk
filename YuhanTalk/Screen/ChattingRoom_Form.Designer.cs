namespace YuhanTalk
{
    partial class ChattingRoom_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_InputBox = new System.Windows.Forms.TextBox();
            this.roundButton1 = new YuhanTalk.CustomControl.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fpnl_Chats = new System.Windows.Forms.FlowLayoutPanel();
            this.rchat1 = new YuhanTalk.CustomControl.Rchat();
            this.lchat1 = new YuhanTalk.CustomControl.Lchat();
            this.panel1.SuspendLayout();
            this.fpnl_Chats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_InputBox
            // 
            this.tb_InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_InputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.tb_InputBox.Location = new System.Drawing.Point(46, 23);
            this.tb_InputBox.Multiline = true;
            this.tb_InputBox.Name = "tb_InputBox";
            this.tb_InputBox.Size = new System.Drawing.Size(294, 23);
            this.tb_InputBox.TabIndex = 1;
            this.tb_InputBox.Text = "Type your message..";
            this.tb_InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_InputBox_KeyPress);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(12, 10);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(356, 40);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_InputBox);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Location = new System.Drawing.Point(0, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 60);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 80);
            this.panel2.TabIndex = 4;
            // 
            // fpnl_Chats
            // 
            this.fpnl_Chats.AutoScroll = true;
            this.fpnl_Chats.Controls.Add(this.rchat1);
            this.fpnl_Chats.Controls.Add(this.lchat1);
            this.fpnl_Chats.Location = new System.Drawing.Point(0, 80);
            this.fpnl_Chats.Margin = new System.Windows.Forms.Padding(0);
            this.fpnl_Chats.Name = "fpnl_Chats";
            this.fpnl_Chats.Size = new System.Drawing.Size(380, 460);
            this.fpnl_Chats.TabIndex = 5;
            // 
            // rchat1
            // 
            this.rchat1.BackColor = System.Drawing.Color.Transparent;
            this.rchat1.Location = new System.Drawing.Point(0, 0);
            this.rchat1.Margin = new System.Windows.Forms.Padding(0);
            this.rchat1.Name = "rchat1";
            this.rchat1.Size = new System.Drawing.Size(360, 76);
            this.rchat1.TabIndex = 0;
            // 
            // lchat1
            // 
            this.lchat1.BackColor = System.Drawing.Color.Transparent;
            this.lchat1.Location = new System.Drawing.Point(0, 76);
            this.lchat1.Margin = new System.Windows.Forms.Padding(0);
            this.lchat1.MinimumSize = new System.Drawing.Size(360, 0);
            this.lchat1.Name = "lchat1";
            this.lchat1.Size = new System.Drawing.Size(360, 78);
            this.lchat1.TabIndex = 1;
            // 
            // ChattingRoom_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 600);
            this.Controls.Add(this.fpnl_Chats);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChattingRoom_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YuhanTalk_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.fpnl_Chats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox tb_InputBox;
        private CustomControl.RoundButton roundButton1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel fpnl_Chats;
        private CustomControl.Rchat rchat1;
        private CustomControl.Lchat lchat1;
    }
}