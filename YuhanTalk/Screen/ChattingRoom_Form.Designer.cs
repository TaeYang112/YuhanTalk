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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_ExitProgram = new YuhanTalk.CustomControl.CustomButton();
            this.fpnl_Chats = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnl_header.SuspendLayout();
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
            this.tb_InputBox.Enter += new System.EventHandler(this.tb_InputBox_Enter);
            this.tb_InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_InputBox_KeyPress);
            this.tb_InputBox.Leave += new System.EventHandler(this.tb_InputBox_Leave);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.White;
            this.roundButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 2;
            this.roundButton1.Enabled = false;
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
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.pnl_header.Controls.Add(this.btn_ExitProgram);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(380, 80);
            this.pnl_header.TabIndex = 4;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseMove);
            this.pnl_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseUp);
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
            this.btn_ExitProgram.Location = new System.Drawing.Point(348, 12);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(20, 20);
            this.btn_ExitProgram.TabIndex = 3;
            this.btn_ExitProgram.TabStop = false;
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // fpnl_Chats
            // 
            this.fpnl_Chats.AutoScroll = true;
            this.fpnl_Chats.Location = new System.Drawing.Point(0, 80);
            this.fpnl_Chats.Margin = new System.Windows.Forms.Padding(0);
            this.fpnl_Chats.Name = "fpnl_Chats";
            this.fpnl_Chats.Size = new System.Drawing.Size(380, 460);
            this.fpnl_Chats.TabIndex = 5;
            // 
            // ChattingRoom_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 600);
            this.Controls.Add(this.fpnl_Chats);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChattingRoom_Form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChattingRoom_Form_FormClosing);
            this.Load += new System.EventHandler(this.YuhanTalk_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox tb_InputBox;
        private CustomControl.RoundButton roundButton1;
        private Panel panel1;
        private Panel pnl_header;
        private FlowLayoutPanel fpnl_Chats;
        private CustomControl.CustomButton btn_ExitProgram;
    }
}