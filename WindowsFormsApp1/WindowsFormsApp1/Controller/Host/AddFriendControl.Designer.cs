namespace WindowsFormsApp1.Controller.Host
{
    partial class AddFriendControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriendControl));
            this.panel_Tool = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.closePBOx = new System.Windows.Forms.PictureBox();
            this.searchTBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_closeCreatiedButton = new System.Windows.Forms.Timer(this.components);
            this.panel_adding = new System.Windows.Forms.Panel();
            this.panel_blank = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowpanel_adding = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_adding.SuspendLayout();
            this.panel_blank.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Tool
            // 
            this.panel_Tool.Controls.Add(this.label_name);
            this.panel_Tool.Controls.Add(this.closePBOx);
            this.panel_Tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Tool.Location = new System.Drawing.Point(0, 0);
            this.panel_Tool.Name = "panel_Tool";
            this.panel_Tool.Size = new System.Drawing.Size(300, 50);
            this.panel_Tool.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name.Font = new System.Drawing.Font("Verdana", 32F);
            this.label_name.Location = new System.Drawing.Point(0, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(267, 55);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "label1";
            this.label_name.TextChanged += new System.EventHandler(this.label_name_TextChanged);
            // 
            // closePBOx
            // 
            this.closePBOx.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePBOx.Image = ((System.Drawing.Image)(resources.GetObject("closePBOx.Image")));
            this.closePBOx.Location = new System.Drawing.Point(267, 0);
            this.closePBOx.Name = "closePBOx";
            this.closePBOx.Size = new System.Drawing.Size(33, 50);
            this.closePBOx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePBOx.TabIndex = 1;
            this.closePBOx.TabStop = false;
            this.closePBOx.Click += new System.EventHandler(this.closePBOx_Click);
            // 
            // searchTBox
            // 
            this.searchTBox.AcceptsReturn = false;
            this.searchTBox.AcceptsTab = false;
            this.searchTBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchTBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchTBox.AutoSize = true;
            this.searchTBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTBox.BackgroundImage")));
            this.searchTBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.searchTBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.searchTBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(38)))), ((int)(((byte)(157)))));
            this.searchTBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.searchTBox.BorderRadius = 1;
            this.searchTBox.BorderThickness = 2;
            this.searchTBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchTBox.DefaultFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTBox.DefaultText = "";
            this.searchTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTBox.FillColor = System.Drawing.Color.White;
            this.searchTBox.HideSelection = true;
            this.searchTBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchTBox.IconLeft")));
            this.searchTBox.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.searchTBox.IconPadding = 10;
            this.searchTBox.IconRight = null;
            this.searchTBox.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.searchTBox.Location = new System.Drawing.Point(0, 0);
            this.searchTBox.MaxLength = 32767;
            this.searchTBox.MinimumSize = new System.Drawing.Size(100, 35);
            this.searchTBox.Modified = false;
            this.searchTBox.Name = "searchTBox";
            this.searchTBox.PasswordChar = '\0';
            this.searchTBox.ReadOnly = false;
            this.searchTBox.SelectedText = "";
            this.searchTBox.SelectionLength = 0;
            this.searchTBox.SelectionStart = 0;
            this.searchTBox.ShortcutsEnabled = true;
            this.searchTBox.Size = new System.Drawing.Size(300, 35);
            this.searchTBox.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.searchTBox.TabIndex = 2;
            this.searchTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchTBox.TextMarginLeft = 5;
            this.searchTBox.TextPlaceholder = "Search...";
            this.searchTBox.UseSystemPasswordChar = false;
            this.searchTBox.TextChange += new System.EventHandler(this.searchTBox_TextChange);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 3;
            // 
            // timer_closeCreatiedButton
            // 
            this.timer_closeCreatiedButton.Interval = 5000;
            this.timer_closeCreatiedButton.Tick += new System.EventHandler(this.timer_closeCreatiedButton_Tick);
            // 
            // panel_adding
            // 
            this.panel_adding.Controls.Add(this.panel2);
            this.panel_adding.Controls.Add(this.panel_blank);
            this.panel_adding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_adding.Location = new System.Drawing.Point(0, 85);
            this.panel_adding.Name = "panel_adding";
            this.panel_adding.Size = new System.Drawing.Size(300, 215);
            this.panel_adding.TabIndex = 4;
            // 
            // panel_blank
            // 
            this.panel_blank.Controls.Add(this.pictureBox1);
            this.panel_blank.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_blank.Location = new System.Drawing.Point(0, 0);
            this.panel_blank.Name = "panel_blank";
            this.panel_blank.Size = new System.Drawing.Size(300, 51);
            this.panel_blank.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.flowpanel_adding);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 164);
            this.panel2.TabIndex = 1;
            // 
            // flowpanel_adding
            // 
            this.flowpanel_adding.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowpanel_adding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanel_adding.Location = new System.Drawing.Point(0, 0);
            this.flowpanel_adding.Name = "flowpanel_adding";
            this.flowpanel_adding.Size = new System.Drawing.Size(300, 164);
            this.flowpanel_adding.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddFriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_adding);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Tool);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddFriendControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.panel_Tool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_adding.ResumeLayout(false);
            this.panel_blank.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Tool;
        private System.Windows.Forms.PictureBox closePBOx;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchTBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Timer timer_closeCreatiedButton;
        private System.Windows.Forms.Panel panel_adding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowpanel_adding;
        private System.Windows.Forms.Panel panel_blank;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
