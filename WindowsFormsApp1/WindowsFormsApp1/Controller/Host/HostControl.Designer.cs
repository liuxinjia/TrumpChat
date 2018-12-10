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
            this.panel_chatTask = new System.Windows.Forms.Panel();
            this.panel_mail03 = new System.Windows.Forms.Panel();
            this.panel_mail02 = new System.Windows.Forms.Panel();
            this.panel_mail01 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mailController2 = new WindowsFormsApp1.Controller.Host.MailController();
            this.mailController1 = new WindowsFormsApp1.Controller.Host.MailController();
            this.panel_chatTask.SuspendLayout();
            this.panel_mail02.SuspendLayout();
            this.panel_mail01.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_chatTask
            // 
            this.panel_chatTask.Controls.Add(this.panel_mail03);
            this.panel_chatTask.Controls.Add(this.panel_mail02);
            this.panel_chatTask.Controls.Add(this.panel_mail01);
            this.panel_chatTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_chatTask.Location = new System.Drawing.Point(0, 0);
            this.panel_chatTask.Name = "panel_chatTask";
            this.panel_chatTask.Size = new System.Drawing.Size(1070, 339);
            this.panel_chatTask.TabIndex = 0;
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
    }
}
