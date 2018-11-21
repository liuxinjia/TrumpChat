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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closePBOx = new System.Windows.Forms.PictureBox();
            this.panel_adding = new System.Windows.Forms.Panel();
            this.searchBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).BeginInit();
            this.panel_adding.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closePBOx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.TabIndex = 0;
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
            this.panel_adding.Controls.Add(this.searchBox);
            this.panel_adding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_adding.Location = new System.Drawing.Point(0, 50);
            this.panel_adding.Name = "panel_adding";
            this.panel_adding.Size = new System.Drawing.Size(300, 250);
            this.panel_adding.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.searchBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.searchBox.BorderThickness = 3;
            this.searchBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchBox.isPassword = false;
            this.searchBox.Location = new System.Drawing.Point(0, 0);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(300, 44);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Search...";
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchBox.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // AddFriendControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_adding);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddFriendControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePBOx)).EndInit();
            this.panel_adding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closePBOx;
        private System.Windows.Forms.Panel panel_adding;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchBox;
    }
}
