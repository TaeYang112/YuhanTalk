namespace YuhanTalk.Screen
{
    partial class MainForm
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
            this.pnl_Screen = new System.Windows.Forms.Panel();
            this.btn_ExitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_Screen
            // 
            this.pnl_Screen.Location = new System.Drawing.Point(0, 0);
            this.pnl_Screen.Name = "pnl_Screen";
            this.pnl_Screen.Size = new System.Drawing.Size(360, 590);
            this.pnl_Screen.TabIndex = 0;
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
            this.btn_ExitProgram.Location = new System.Drawing.Point(328, 12);
            this.btn_ExitProgram.Name = "btn_ExitProgram";
            this.btn_ExitProgram.Size = new System.Drawing.Size(20, 20);
            this.btn_ExitProgram.TabIndex = 0;
            this.btn_ExitProgram.TabStop = false;
            this.btn_ExitProgram.UseVisualStyleBackColor = false;
            this.btn_ExitProgram.Click += new System.EventHandler(this.btn_ExitProgram_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 590);
            this.Controls.Add(this.pnl_Screen);
            this.Controls.Add(this.btn_ExitProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "YuhanTalk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnl_Screen;
        private Button btn_ExitProgram;
    }
}