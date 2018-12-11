namespace WindowsFormsApp1.Controller.Host
{
    partial class HostControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostControl));
            this.panel_chatTask = new System.Windows.Forms.Panel();
            this.panel_loadmail = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton_StartChat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_mail03 = new System.Windows.Forms.Panel();
            this.panel_mail02 = new System.Windows.Forms.Panel();
            this.panel_mail01 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mailController2 = new WindowsFormsApp1.Controller.Host.MailController();
            this.mailController1 = new WindowsFormsApp1.Controller.Host.MailController();
            this.panel_chatTask.SuspendLayout();
            this.panel_loadmail.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel_mail02.SuspendLayout();
            this.panel_mail01.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chatTask
            // 
            this.panel_chatTask.Controls.Add(this.panel_loadmail);
            this.panel_chatTask.Controls.Add(this.panel_mail03);
            this.panel_chatTask.Controls.Add(this.panel_mail02);
            this.panel_chatTask.Controls.Add(this.panel_mail01);
            this.panel_chatTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_chatTask.Location = new System.Drawing.Point(0, 0);
            this.panel_chatTask.Name = "panel_chatTask";
            this.panel_chatTask.Size = new System.Drawing.Size(1070, 339);
            this.panel_chatTask.TabIndex = 0;
            // 
            // panel_loadmail
            // 
            this.panel_loadmail.BackColor = System.Drawing.Color.White;
            this.panel_loadmail.Controls.Add(this.panel3);
            this.panel_loadmail.Controls.Add(this.bunifuImageButton1);
            this.panel_loadmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_loadmail.Location = new System.Drawing.Point(0, 0);
            this.panel_loadmail.Name = "panel_loadmail";
            this.panel_loadmail.Size = new System.Drawing.Size(1070, 339);
            this.panel_loadmail.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.bunifuFlatButton_StartChat);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 56);
            this.panel3.TabIndex = 3;
            // 
            // bunifuFlatButton_StartChat
            // 
            this.bunifuFlatButton_StartChat.Active = false;
            this.bunifuFlatButton_StartChat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_StartChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_StartChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton_StartChat.BorderRadius = 0;
            this.bunifuFlatButton_StartChat.ButtonText = "Find friends to chat";
            this.bunifuFlatButton_StartChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton_StartChat.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton_StartChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuFlatButton_StartChat.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton_StartChat.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton_StartChat.Iconimage")));
            this.bunifuFlatButton_StartChat.Iconimage_right = null;
            this.bunifuFlatButton_StartChat.Iconimage_right_Selected = null;
            this.bunifuFlatButton_StartChat.Iconimage_Selected = null;
            this.bunifuFlatButton_StartChat.IconMarginLeft = 0;
            this.bunifuFlatButton_StartChat.IconMarginRight = 0;
            this.bunifuFlatButton_StartChat.IconRightVisible = true;
            this.bunifuFlatButton_StartChat.IconRightZoom = 0D;
            this.bunifuFlatButton_StartChat.IconVisible = true;
            this.bunifuFlatButton_StartChat.IconZoom = 90D;
            this.bunifuFlatButton_StartChat.IsTab = false;
            this.bunifuFlatButton_StartChat.Location = new System.Drawing.Point(400, 0);
            this.bunifuFlatButton_StartChat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuFlatButton_StartChat.Name = "bunifuFlatButton_StartChat";
            this.bunifuFlatButton_StartChat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton_StartChat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton_StartChat.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton_StartChat.selected = false;
            this.bunifuFlatButton_StartChat.Size = new System.Drawing.Size(270, 56);
            this.bunifuFlatButton_StartChat.TabIndex = 4;
            this.bunifuFlatButton_StartChat.Text = "Find friends to chat";
            this.bunifuFlatButton_StartChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton_StartChat.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton_StartChat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton_StartChat.Click += new System.EventHandler(this.bunifuFlatButton_StartChat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(670, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 56);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 56);
            this.panel4.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(1070, 339);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // panel_mail03
            // 
            this.panel_mail03.Location = new System.Drawing.Point(759, 21);
            this.panel_mail03.Name = "panel_mail03";
            this.panel_mail03.Size = new System.Drawing.Size(300, 300);
            this.panel_mail03.TabIndex = 2;
            // 
            // panel_mail02
            // 
            this.panel_mail02.Controls.Add(this.mailController2);
            this.panel_mail02.Location = new System.Drawing.Point(387, 21);
            this.panel_mail02.Name = "panel_mail02";
            this.panel_mail02.Size = new System.Drawing.Size(300, 300);
            this.panel_mail02.TabIndex = 1;
            // 
            // panel_mail01
            // 
            this.panel_mail01.Controls.Add(this.mailController1);
            this.panel_mail01.Location = new System.Drawing.Point(15, 21);
            this.panel_mail01.Name = "panel_mail01";
            this.panel_mail01.Size = new System.Drawing.Size(300, 300);
            this.panel_mail01.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 305);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(371, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 305);
            this.panel2.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this.bunifuFlatButton_StartChat;
            // 
            // mailController2
            // 
            this.mailController2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailController2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.mailController2.Location = new System.Drawing.Point(0, 0);
            this.mailController2.Margin = new System.Windows.Forms.Padding(4);
            this.mailController2.Name = "mailController2";
            this.mailController2.Size = new System.Drawing.Size(300, 300);
            this.mailController2.TabIndex = 0;
            // 
            // mailController1
            // 
            this.mailController1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailController1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.mailController1.Location = new System.Drawing.Point(0, 0);
            this.mailController1.Margin = new System.Windows.Forms.Padding(4);
            this.mailController1.Name = "mailController1";
            this.mailController1.Size = new System.Drawing.Size(300, 300);
            this.mailController1.TabIndex = 0;
            // 
            // HostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_chatTask);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HostControl";
            this.Size = new System.Drawing.Size(1070, 644);
            this.Load += new System.EventHandler(this.HostControl_Load);
            this.panel_chatTask.ResumeLayout(false);
            this.panel_loadmail.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel_mail02.ResumeLayout(false);
            this.panel_mail01.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_chatTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_mail03;
        private System.Windows.Forms.Panel panel_mail02;
        private MailController mailController2;
        private System.Windows.Forms.Panel panel_mail01;
        private MailController mailController1;
        private System.Windows.Forms.Panel panel_loadmail;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton_StartChat;
    }
}
