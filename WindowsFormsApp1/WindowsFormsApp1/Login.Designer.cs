namespace WindowsFormsApp1
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pwTbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nameTbox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.AllowDrop = true;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panelHeader.Controls.Add(this.bunifuImageButton1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(842, 100);
            this.panelHeader.TabIndex = 15;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(751, 25);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(68, 55);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.label2.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "chat";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.pwTbox);
            this.panelLogin.Controls.Add(this.bunifuThinButton22);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.checkBox1);
            this.panelLogin.Controls.Add(this.nameTbox);
            this.panelLogin.Controls.Add(this.bunifuThinButton21);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 100);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(842, 498);
            this.panelLogin.TabIndex = 16;
            // 
            // pwTbox
            // 
            this.pwTbox.AcceptsReturn = false;
            this.pwTbox.AcceptsTab = false;
            this.pwTbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pwTbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pwTbox.BackColor = System.Drawing.Color.Transparent;
            this.pwTbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pwTbox.BackgroundImage")));
            this.pwTbox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.pwTbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.pwTbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.pwTbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.pwTbox.BorderRadius = 33;
            this.pwTbox.BorderThickness = 4;
            this.pwTbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pwTbox.DefaultFont = new System.Drawing.Font("Verdana", 7.8F);
            this.pwTbox.DefaultText = "";
            this.pwTbox.FillColor = System.Drawing.Color.White;
            this.pwTbox.HideSelection = true;
            this.pwTbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("pwTbox.IconLeft")));
            this.pwTbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.pwTbox.IconPadding = 10;
            this.pwTbox.IconRight = null;
            this.pwTbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.pwTbox.Location = new System.Drawing.Point(242, 193);
            this.pwTbox.MaxLength = 32767;
            this.pwTbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.pwTbox.Modified = false;
            this.pwTbox.Name = "pwTbox";
            this.pwTbox.PasswordChar = '.';
            this.pwTbox.ReadOnly = false;
            this.pwTbox.SelectedText = "";
            this.pwTbox.SelectionLength = 0;
            this.pwTbox.SelectionStart = 0;
            this.pwTbox.ShortcutsEnabled = true;
            this.pwTbox.Size = new System.Drawing.Size(376, 47);
            this.pwTbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.pwTbox.TabIndex = 8;
            this.pwTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pwTbox.TextMarginLeft = 5;
            this.pwTbox.TextPlaceholder = "Enter Password";
            this.pwTbox.UseSystemPasswordChar = false;
            this.pwTbox.MouseEnter += new System.EventHandler(this.pwTbox_MouseEnter);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Register";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaShell;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(214, 393);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(435, 44);
            this.bunifuThinButton22.TabIndex = 33;
            this.bunifuThinButton22.TabStop = false;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(272, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 48);
            this.label1.TabIndex = 28;
            this.label1.Text = "Please Login first";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(347, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(169, 29);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Remerber Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nameTbox
            // 
            this.nameTbox.AcceptsReturn = false;
            this.nameTbox.AcceptsTab = false;
            this.nameTbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTbox.BackColor = System.Drawing.Color.Transparent;
            this.nameTbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nameTbox.BackgroundImage")));
            this.nameTbox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.nameTbox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.nameTbox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.nameTbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.nameTbox.BorderRadius = 33;
            this.nameTbox.BorderThickness = 4;
            this.nameTbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTbox.DefaultFont = new System.Drawing.Font("Verdana", 7.8F);
            this.nameTbox.DefaultText = "";
            this.nameTbox.FillColor = System.Drawing.Color.White;
            this.nameTbox.HideSelection = true;
            this.nameTbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("nameTbox.IconLeft")));
            this.nameTbox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.nameTbox.IconPadding = 10;
            this.nameTbox.IconRight = null;
            this.nameTbox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.nameTbox.Location = new System.Drawing.Point(242, 118);
            this.nameTbox.MaxLength = 32767;
            this.nameTbox.MinimumSize = new System.Drawing.Size(100, 35);
            this.nameTbox.Modified = false;
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.PasswordChar = '\0';
            this.nameTbox.ReadOnly = false;
            this.nameTbox.SelectedText = "";
            this.nameTbox.SelectionLength = 0;
            this.nameTbox.SelectionStart = 0;
            this.nameTbox.ShortcutsEnabled = true;
            this.nameTbox.Size = new System.Drawing.Size(376, 47);
            this.nameTbox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.nameTbox.TabIndex = 8;
            this.nameTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTbox.TextMarginLeft = 5;
            this.nameTbox.TextPlaceholder = "Enter Full Name";
            this.nameTbox.UseSystemPasswordChar = false;
            this.nameTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTbox_KeyPress);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login in";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaShell;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(214, 339);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(435, 44);
            this.bunifuThinButton21.TabIndex = 30;
            this.bunifuThinButton21.TabStop = false;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // loginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 598);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "loginForm";
            this.Text = "Login";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox nameTbox;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox pwTbox;
        private System.Windows.Forms.Label label2;
    }
}