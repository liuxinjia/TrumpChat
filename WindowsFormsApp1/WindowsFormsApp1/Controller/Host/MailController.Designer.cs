namespace WindowsFormsApp1.Controller.Host
{
    partial class MailController
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailController));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label_name = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel_editChat = new System.Windows.Forms.Panel();
            this.chatTBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel_chatlog = new System.Windows.Forms.Panel();
            this.panel_accept = new System.Windows.Forms.Panel();
            this.panel_send = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panel_editChat.SuspendLayout();
            this.panel_chatlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(268, 11);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(29, 26);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 6;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(233, 11);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(29, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.BorderRadius = 25;
            this.bunifuPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // label_name
            // 
            this.label_name.AutoEllipsis = false;
            this.label_name.CursorType = null;
            this.label_name.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label_name.Location = new System.Drawing.Point(56, 32);
            this.label_name.Name = "label_name";
            this.label_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_name.Size = new System.Drawing.Size(100, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "FriendName";
            this.label_name.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // panel_editChat
            // 
            this.panel_editChat.Controls.Add(this.chatTBox);
            this.panel_editChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_editChat.Location = new System.Drawing.Point(0, 260);
            this.panel_editChat.Name = "panel_editChat";
            this.panel_editChat.Size = new System.Drawing.Size(300, 40);
            this.panel_editChat.TabIndex = 1;
            // 
            // chatTBox
            // 
            this.chatTBox.BorderColorFocused = System.Drawing.Color.Brown;
            this.chatTBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chatTBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.chatTBox.BorderThickness = 3;
            this.chatTBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.chatTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatTBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chatTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chatTBox.isPassword = false;
            this.chatTBox.Location = new System.Drawing.Point(0, 7);
            this.chatTBox.Margin = new System.Windows.Forms.Padding(4);
            this.chatTBox.MaxLength = 32767;
            this.chatTBox.Name = "chatTBox";
            this.chatTBox.Size = new System.Drawing.Size(300, 33);
            this.chatTBox.TabIndex = 0;
            this.chatTBox.Text = "bunifuMetroTextbox1";
            this.chatTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.chatTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuMetroTextbox1_KeyPress);
            // 
            // panel_chatlog
            // 
            this.panel_chatlog.Controls.Add(this.panel_accept);
            this.panel_chatlog.Controls.Add(this.panel_send);
            this.panel_chatlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_chatlog.Location = new System.Drawing.Point(0, 50);
            this.panel_chatlog.Name = "panel_chatlog";
            this.panel_chatlog.Size = new System.Drawing.Size(300, 210);
            this.panel_chatlog.TabIndex = 2;
            // 
            // panel_accept
            // 
            this.panel_accept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_accept.Location = new System.Drawing.Point(152, 0);
            this.panel_accept.Name = "panel_accept";
            this.panel_accept.Size = new System.Drawing.Size(148, 210);
            this.panel_accept.TabIndex = 1;
            // 
            // panel_send
            // 
            this.panel_send.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_send.Location = new System.Drawing.Point(0, 0);
            this.panel_send.Name = "panel_send";
            this.panel_send.Size = new System.Drawing.Size(152, 210);
            this.panel_send.TabIndex = 0;
            // 
            // MailController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_chatlog);
            this.Controls.Add(this.panel_editChat);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailController";
            this.Size = new System.Drawing.Size(300, 300);
            this.Enter += new System.EventHandler(this.MailController_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panel_editChat.ResumeLayout(false);
            this.panel_chatlog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel label_name;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Panel panel_editChat;
        private Bunifu.Framework.UI.BunifuMetroTextbox chatTBox;
        private System.Windows.Forms.Panel panel_chatlog;
        private System.Windows.Forms.Panel panel_accept;
        private System.Windows.Forms.Panel panel_send;
    }
}
