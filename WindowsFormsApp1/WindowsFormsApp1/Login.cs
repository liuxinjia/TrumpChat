using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginControl11_Load(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormMain mainForm = new FormMain();
            mainForm.Show();
            this.Visible = false;
            this.Enabled = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            LoginUp register = new LoginUp();
            register.Show();
            this.Visible = false;
            this.Enabled = false;
        }
        private void NameTBox_MouseEnter_1(object sender, EventArgs e)
        {
            nameD_label.Hide();
        }

        private void NameTBox_MouseLeave(object sender, EventArgs e)
        {
            if (NameTBox.Text == "")
                nameD_label.Show();
        }

        private void nameD_label_MouseEnter(object sender, EventArgs e)
        {
            nameD_label.Hide();
        }
    }
}
