namespace YuhanTalk.Screen
{
    partial class MyMessageBox
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
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
            this.btn_ExitProgram.Location = new System.Drawing.Point(216, 8);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(15, 15);
            this.btn_ExitProgram.TabIndex = 3;
            this.btn_ExitProgram.TabStop = false;
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.White;
            this.pnl_header.Controls.Add(this.btn_ExitProgram);
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(240, 30);
            this.pnl_header.TabIndex = 5;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseMove);
            this.pnl_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_BorderTop_MouseUp);
            // 
            // btn_OK
            // 
            this.btn_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(-10, 91);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(258, 41);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Location = new System.Drawing.Point(0, 30);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(240, 60);
            this.lbl_message.TabIndex = 7;
            this.lbl_message.Text = "메시지";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 129);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyMessageBox";
            this.Text = "ErrorForm";
            this.pnl_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.CustomButton btn_ExitProgram;
        private Panel pnl_header;
        private Button btn_OK;
        private Label lbl_message;
    }
}