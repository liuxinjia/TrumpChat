using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
    public partial class LoginControl1 : UserControl
    {
        public LoginControl1()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_MouseEnter(object sender, EventArgs e)
        {
            UsernameTBox.Text = "";
        }

        private void UsernameTBox_MouseLeave(object sender, EventArgs e)
        {
            UsernameTBox.Text = "User name";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            LoginUp loginUp = new LoginUp();
            loginUp.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FormMain fMain = new FormMain();
            fMain.Show();
           
        }
    }
}
