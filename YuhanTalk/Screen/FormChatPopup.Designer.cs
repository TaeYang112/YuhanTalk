using YuhanTalk.CustomControl;
/*
namespace YuhanTalk.Screen
{
    partial class FormChatPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatPopup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnChatList = new System.Windows.Forms.Button();
            this.panMessage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLocationToAll = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSend = new RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnChatList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 25);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(26, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(346, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "채팅";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChatList
            // 
            this.btnChatList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChatList.BackgroundImage")));
            this.btnChatList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChatList.FlatAppearance.BorderSize = 0;
            this.btnChatList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChatList.Location = new System.Drawing.Point(379, 2);
            this.btnChatList.Name = "btnChatList";
            this.btnChatList.Size = new System.Drawing.Size(20, 20);
            this.btnChatList.TabIndex = 0;
            this.btnChatList.UseVisualStyleBackColor = true;
            // 
            // panMessage
            // 
            this.panMessage.AutoScroll = true;
            this.panMessage.BackColor = System.Drawing.Color.White;
            this.panMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMessage.Location = new System.Drawing.Point(0, 25);
            this.panMessage.Name = "panMessage";
            this.panMessage.Size = new System.Drawing.Size(404, 362);
            this.panMessage.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblLocationToAll);
            this.panel2.Controls.Add(this.lblLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 20);
            this.panel2.TabIndex = 2;
            // 
            // lblLocationToAll
            // 
            this.lblLocationToAll.AutoSize = true;
            this.lblLocationToAll.Location = new System.Drawing.Point(324, 3);
            this.lblLocationToAll.Name = "lblLocationToAll";
            this.lblLocationToAll.Size = new System.Drawing.Size(80, 15);
            this.lblLocationToAll.TabIndex = 1;
            this.lblLocationToAll.Text = "-> (전체에게)";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.GhostWhite;
            this.lblLocation.Location = new System.Drawing.Point(2, 3);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 15);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "전송 대상:";
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.rtbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChat.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbChat.Location = new System.Drawing.Point(5, 5);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbChat.Size = new System.Drawing.Size(318, 120);
            this.rtbChat.TabIndex = 0;
            this.rtbChat.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Controls.Add(this.rtbChat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 407);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(404, 130);
            this.panel3.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(250)))));
            this.btnSend.BorderColor = System.Drawing.Color.Black;
            this.btnSend.BorderRadius = 5;
            this.btnSend.BorderSize = 0;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(324, 1);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 129);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "전송";
            this.btnSend.TextColor = System.Drawing.Color.Black;
            this.btnSend.UseVisualStyleBackColor = false;
            //this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FormChatPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 537);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panMessage);
            this.Controls.Add(this.panel1);
            this.Name = "FormChatPopup";
            this.Text = "채팅창";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnChatList;
        private Panel panMessage;
        private Panel panel2;
        private Label lblLocation;
        private RichTextBox rtbChat;
        private Panel panel3;
        private Label lblLocationToAll;
        private Label lblTitle;
        private RoundButton btnSend;
    }
}
*/