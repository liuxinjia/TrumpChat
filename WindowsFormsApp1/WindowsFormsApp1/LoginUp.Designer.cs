namespace WindowsFormsApp1
{
    partial class LoginUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmPW_MBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pword_MBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nname_MBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.Uname_MBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 480);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "The ear is the avenue to the heart.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "——Voltaire";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirmPW_MBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Pword_MBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Nname_MBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Uname_MBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 480);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // confirmPW_MBox
            // 
            this.confirmPW_MBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.confirmPW_MBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.confirmPW_MBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.confirmPW_MBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPW_MBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.confirmPW_MBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmPW_MBox.HintForeColor = System.Drawing.Color.Empty;
            this.confirmPW_MBox.HintText = "Full Name";
            this.confirmPW_MBox.isPassword = true;
            this.confirmPW_MBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.confirmPW_MBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.confirmPW_MBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.confirmPW_MBox.LineThickness = 3;
            this.confirmPW_MBox.Location = new System.Drawing.Point(7, 372);
            this.confirmPW_MBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPW_MBox.MaxLength = 32767;
            this.confirmPW_MBox.Name = "confirmPW_MBox";
            this.confirmPW_MBox.Size = new System.Drawing.Size(379, 30);
            this.confirmPW_MBox.TabIndex = 7;
            this.confirmPW_MBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login Up";
            // 
            // Pword_MBox
            // 
            this.Pword_MBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Pword_MBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Pword_MBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Pword_MBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pword_MBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Pword_MBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pword_MBox.HintForeColor = System.Drawing.Color.Empty;
            this.Pword_MBox.HintText = "Full Name";
            this.Pword_MBox.isPassword = true;
            this.Pword_MBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Pword_MBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Pword_MBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Pword_MBox.LineThickness = 3;
            this.Pword_MBox.Location = new System.Drawing.Point(7, 294);
            this.Pword_MBox.Margin = new System.Windows.Forms.Padding(4);
            this.Pword_MBox.MaxLength = 32767;
            this.Pword_MBox.Name = "Pword_MBox";
            this.Pword_MBox.Size = new System.Drawing.Size(379, 30);
            this.Pword_MBox.TabIndex = 7;
            this.Pword_MBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "User Name:";
            // 
            // Nname_MBox
            // 
            this.Nname_MBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Nname_MBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Nname_MBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Nname_MBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nname_MBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Nname_MBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nname_MBox.HintForeColor = System.Drawing.Color.Empty;
            this.Nname_MBox.HintText = "Full Name";
            this.Nname_MBox.isPassword = false;
            this.Nname_MBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Nname_MBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Nname_MBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Nname_MBox.LineThickness = 3;
            this.Nname_MBox.Location = new System.Drawing.Point(7, 216);
            this.Nname_MBox.Margin = new System.Windows.Forms.Padding(4);
            this.Nname_MBox.MaxLength = 32767;
            this.Nname_MBox.Name = "Nname_MBox";
            this.Nname_MBox.Size = new System.Drawing.Size(379, 30);
            this.Nname_MBox.TabIndex = 7;
            this.Nname_MBox.Text = "anything you want to call";
            this.Nname_MBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.label5.Location = new System.Drawing.Point(7, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nick Name:";
            // 
            // Uname_MBox
            // 
            this.Uname_MBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Uname_MBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Uname_MBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Uname_MBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Uname_MBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Uname_MBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Uname_MBox.HintForeColor = System.Drawing.Color.Empty;
            this.Uname_MBox.HintText = "Full Name";
            this.Uname_MBox.isPassword = false;
            this.Uname_MBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Uname_MBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Uname_MBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.Uname_MBox.LineThickness = 3;
            this.Uname_MBox.Location = new System.Drawing.Point(7, 138);
            this.Uname_MBox.Margin = new System.Windows.Forms.Padding(4);
            this.Uname_MBox.MaxLength = 32767;
            this.Uname_MBox.Name = "Uname_MBox";
            this.Uname_MBox.Size = new System.Drawing.Size(379, 30);
            this.Uname_MBox.TabIndex = 7;
            this.Uname_MBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.label6.Location = new System.Drawing.Point(7, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(170, 429);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(53, 48);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.label7.Location = new System.Drawing.Point(7, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Re-Enter Password:";
            // 
            // LoginUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUp";
            this.Text = "LoginUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox confirmPW_MBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Pword_MBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Nname_MBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Uname_MBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label7;
    }
}