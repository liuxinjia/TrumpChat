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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFriendControl));
            this.panel_Tool = new System.Windows.Forms.Panel();
            this.closePBOx = new System.Windows.Forms.PictureBox();
            this.panel_adding = new System.Windows.Forms.Panel();
            this.searchTBox = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel_Tool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).BeginInit();
            this.panel_adding.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Tool
            // 
            this.panel_Tool.Controls.Add(this.closePBOx);
            this.panel_Tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Tool.Location = new System.Drawing.Point(0, 0);
            this.panel_Tool.Name = "panel_Tool";
            this.panel_Tool.Size = new System.Drawing.Size(300, 50);
            this.panel_Tool.TabIndex = 0;
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
            // 
            // panel_adding
            // 
            this.panel_adding.Controls.Add(this.searchTBox);
            this.panel_adding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_adding.Location = new System.Drawing.Point(0, 50);
            this.panel_adding.Name = "panel_adding";
            this.panel_adding.Size = new System.Drawing.Size(300, 250);
            this.panel_adding.TabIndex = 1;
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
            this.searchTBox.Dock = System.Windows.Forms.DockStyle.Top;
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
            // AddFriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_adding);
            this.Controls.Add(this.panel_Tool);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddFriendControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.panel_Tool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).EndInit();
            this.panel_adding.ResumeLayout(false);
            this.panel_adding.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Tool;
        private System.Windows.Forms.PictureBox closePBOx;
        private System.Windows.Forms.Panel panel_adding;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox searchTBox;
    }
}
