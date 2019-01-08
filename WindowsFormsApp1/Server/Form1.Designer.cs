namespace Server
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_serverStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.MessageReceiver = new System.Windows.Forms.RichTextBox();
            this.MessageSender = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RichBox_RemoteClient = new System.Windows.Forms.RichTextBox();
            this.listView_UserInfo = new System.Windows.Forms.ListView();
            this.User_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_serverStatus);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_serverStatus
            // 
            this.label_serverStatus.AutoSize = true;
            this.label_serverStatus.Location = new System.Drawing.Point(61, 42);
            this.label_serverStatus.Name = "label_serverStatus";
            this.label_serverStatus.Size = new System.Drawing.Size(95, 29);
            this.label_serverStatus.TabIndex = 0;
            this.label_serverStatus.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Controls.Add(this.MessageReceiver);
            this.panel1.Controls.Add(this.MessageSender);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 351);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 42);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(637, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message_Reveiver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message_Sender";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(399, 64);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 95);
            this.vScrollBar1.TabIndex = 2;
            // 
            // MessageReceiver
            // 
            this.MessageReceiver.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MessageReceiver.Location = new System.Drawing.Point(437, 48);
            this.MessageReceiver.Name = "MessageReceiver";
            this.MessageReceiver.Size = new System.Drawing.Size(363, 303);
            this.MessageReceiver.TabIndex = 1;
            this.MessageReceiver.Text = "";
            // 
            // MessageSender
            // 
            this.MessageSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MessageSender.Location = new System.Drawing.Point(0, 34);
            this.MessageSender.Name = "MessageSender";
            this.MessageSender.Size = new System.Drawing.Size(377, 317);
            this.MessageSender.TabIndex = 0;
            this.MessageSender.Text = "";
            this.MessageSender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MessageSender_KeyPress);
<<<<<<< HEAD
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.RichBox_RemoteClient);
            this.panel3.Controls.Add(this.listView_UserInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 328);
            this.panel3.TabIndex = 2;
            // 
            // RichBox_RemoteClient
            // 
            this.RichBox_RemoteClient.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RichBox_RemoteClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.RichBox_RemoteClient.Location = new System.Drawing.Point(372, 0);
            this.RichBox_RemoteClient.Name = "RichBox_RemoteClient";
            this.RichBox_RemoteClient.Size = new System.Drawing.Size(434, 328);
            this.RichBox_RemoteClient.TabIndex = 1;
            this.RichBox_RemoteClient.Text = "";
            // 
            // listView_UserInfo
            // 
            this.listView_UserInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User_name,
            this.User_ID});
            this.listView_UserInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView_UserInfo.GridLines = true;
            this.listView_UserInfo.Location = new System.Drawing.Point(0, 0);
            this.listView_UserInfo.Name = "listView_UserInfo";
            this.listView_UserInfo.Size = new System.Drawing.Size(377, 328);
            this.listView_UserInfo.TabIndex = 0;
            this.listView_UserInfo.UseCompatibleStateImageBehavior = false;
            this.listView_UserInfo.View = System.Windows.Forms.View.Details;
            // 
            // User_name
            // 
            this.User_name.Text = "User_name";
            this.User_name.Width = 127;
            // 
            // User_ID
            // 
            this.User_ID.Text = "User_ID";
            this.User_ID.Width = 132;
=======
>>>>>>> parent of c7c8852... Revert "Ready to chat"
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 778);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_serverStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.RichTextBox MessageReceiver;
        private System.Windows.Forms.RichTextBox MessageSender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView_UserInfo;
        private System.Windows.Forms.ColumnHeader User_name;
        private System.Windows.Forms.ColumnHeader User_ID;
        private System.Windows.Forms.RichTextBox RichBox_RemoteClient;
    }
}

