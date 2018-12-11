namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton_host = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.addFriend = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closePBOx = new System.Windows.Forms.PictureBox();
            this.contentPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.contentHide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.hostControl1 = new WindowsFormsApp1.Controller.Host.HostControl();
            this.sendMailControl1 = new WindowsFormsApp1.Controller.Mail.sendMailControl();
            this.friendsPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contentShow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFriend)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.friendsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // contentPanel
            // 
            this.contentPanel.AllowDrop = true;
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.contentPanel.Controls.Add(this.bunifuTileButton3);
            this.contentPanel.Controls.Add(this.bunifuTileButton2);
            this.contentPanel.Controls.Add(this.bunifuTileButton_host);
            this.contentPanel.Controls.Add(this.pictureBox2);
            this.contentShow.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(213, 749);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.Visible = false;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentShow.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 40;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Mail";
            this.bunifuTileButton3.Location = new System.Drawing.Point(0, 539);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(213, 190);
            this.bunifuTileButton3.TabIndex = 5;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentShow.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 30;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Contact";
            this.bunifuTileButton2.Location = new System.Drawing.Point(0, 349);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(213, 190);
            this.bunifuTileButton2.TabIndex = 4;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton_host
            // 
            this.bunifuTileButton_host.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuTileButton_host.color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuTileButton_host.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuTileButton_host.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentShow.SetDecoration(this.bunifuTileButton_host, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.bunifuTileButton_host, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton_host.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuTileButton_host.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuTileButton_host.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton_host.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton_host.Image")));
            this.bunifuTileButton_host.ImagePosition = 35;
            this.bunifuTileButton_host.ImageZoom = 50;
            this.bunifuTileButton_host.LabelPosition = 41;
            this.bunifuTileButton_host.LabelText = "Host";
            this.bunifuTileButton_host.Location = new System.Drawing.Point(0, 159);
            this.bunifuTileButton_host.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton_host.Name = "bunifuTileButton_host";
            this.bunifuTileButton_host.Size = new System.Drawing.Size(213, 190);
            this.bunifuTileButton_host.TabIndex = 3;
            this.bunifuTileButton_host.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // pictureBox2
            // 
            this.contentHide.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panelHead.Controls.Add(this.addFriend);
            this.panelHead.Controls.Add(this.panel2);
            this.panelHead.Controls.Add(this.pictureBox3);
            this.contentShow.SetDecoration(this.panelHead, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.panelHead, BunifuAnimatorNS.DecorationType.None);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(213, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1070, 105);
            this.panelHead.TabIndex = 1;
            // 
            // addFriend
            // 
            this.addFriend.BackColor = System.Drawing.Color.Transparent;
            this.contentHide.SetDecoration(this.addFriend, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.addFriend, BunifuAnimatorNS.DecorationType.None);
            this.addFriend.Image = ((System.Drawing.Image)(resources.GetObject("addFriend.Image")));
            this.addFriend.Location = new System.Drawing.Point(167, 69);
            this.addFriend.Name = "addFriend";
            this.addFriend.Size = new System.Drawing.Size(33, 36);
            this.addFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addFriend.TabIndex = 5;
            this.addFriend.TabStop = false;
            this.addFriend.Click += new System.EventHandler(this.addFriend_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.closePBOx);
            this.panel2.Controls.Add(this.contentPBox);
            this.contentShow.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 39);
            this.panel2.TabIndex = 0;
            // 
            // closePBOx
            // 
            this.contentHide.SetDecoration(this.closePBOx, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.closePBOx, BunifuAnimatorNS.DecorationType.None);
            this.closePBOx.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePBOx.Image = ((System.Drawing.Image)(resources.GetObject("closePBOx.Image")));
            this.closePBOx.Location = new System.Drawing.Point(1037, 0);
            this.closePBOx.Name = "closePBOx";
            this.closePBOx.Size = new System.Drawing.Size(33, 39);
            this.closePBOx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePBOx.TabIndex = 0;
            this.closePBOx.TabStop = false;
            this.closePBOx.Click += new System.EventHandler(this.closePBOx_Click);
            // 
            // contentPBox
            // 
            this.contentHide.SetDecoration(this.contentPBox, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.contentPBox, BunifuAnimatorNS.DecorationType.None);
            this.contentPBox.Image = ((System.Drawing.Image)(resources.GetObject("contentPBox.Image")));
            this.contentPBox.Location = new System.Drawing.Point(16, -1);
            this.contentPBox.Name = "contentPBox";
            this.contentPBox.Size = new System.Drawing.Size(33, 36);
            this.contentPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contentPBox.TabIndex = 0;
            this.contentPBox.TabStop = false;
            this.contentPBox.Click += new System.EventHandler(this.contentPBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.contentHide.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.contentPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // contentHide
            // 
            this.contentHide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.contentHide.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.contentHide.DefaultAnimation = animation1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.hostControl1);
            this.mainPanel.Controls.Add(this.sendMailControl1);
            this.mainPanel.Controls.Add(this.friendsPanel);
            this.contentShow.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(213, 105);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1070, 644);
            this.mainPanel.TabIndex = 3;
            // 
            // hostControl1
            // 
            this.contentHide.SetDecoration(this.hostControl1, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.hostControl1, BunifuAnimatorNS.DecorationType.None);
            this.hostControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostControl1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.hostControl1.Location = new System.Drawing.Point(200, 0);
            this.hostControl1.Margin = new System.Windows.Forms.Padding(4);
            this.hostControl1.Name = "hostControl1";
            this.hostControl1.Size = new System.Drawing.Size(870, 644);
            this.hostControl1.TabIndex = 7;
            // 
            // sendMailControl1
            // 
            this.contentHide.SetDecoration(this.sendMailControl1, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.sendMailControl1, BunifuAnimatorNS.DecorationType.None);
            this.sendMailControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendMailControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.sendMailControl1.Location = new System.Drawing.Point(200, 0);
            this.sendMailControl1.Margin = new System.Windows.Forms.Padding(6);
            this.sendMailControl1.Name = "sendMailControl1";
            this.sendMailControl1.Size = new System.Drawing.Size(870, 644);
            this.sendMailControl1.TabIndex = 6;
            // 
            // friendsPanel
            // 
            this.friendsPanel.Controls.Add(this.pictureBox1);
            this.friendsPanel.Controls.Add(this.flowLayoutPanel1);
            this.contentShow.SetDecoration(this.friendsPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.friendsPanel, BunifuAnimatorNS.DecorationType.None);
            this.friendsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.friendsPanel.Location = new System.Drawing.Point(0, 0);
            this.friendsPanel.Name = "friendsPanel";
            this.friendsPanel.Size = new System.Drawing.Size(200, 644);
            this.friendsPanel.TabIndex = 5;
            this.friendsPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.contentHide.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.bunifuFlatButton1);
            this.contentShow.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 476);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.AutoSize = true;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "WayneRonny";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentShow.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.contentHide.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(9181, 66);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "WayneRonny";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // contentShow
            // 
            this.contentShow.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.contentShow.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.contentShow.DefaultAnimation = animation2;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 749);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.contentPanel);
            this.contentHide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.contentShow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelHead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addFriend)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contentPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.friendsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox contentPBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition contentHide;
        private BunifuAnimatorNS.BunifuTransition contentShow;
        private System.Windows.Forms.PictureBox closePBOx;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton_host;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controller.Host.HostControl hostControl1;
        private Controller.Mail.sendMailControl sendMailControl1;
        private System.Windows.Forms.PictureBox addFriend;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel friendsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}