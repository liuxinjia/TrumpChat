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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void contentPBox_Click(object sender, EventArgs e)
        {
            if (contentPanel.Visible)
            {
                contentHide.HideSync(contentPanel);
            }
            else
            {
                contentShow.ShowSync(contentPanel);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (friendsPanel.Visible)
            {
                contentHide.HideSync(friendsPanel);
            }
            else
            {
                contentShow.ShowSync(friendsPanel);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            hostControl1.BringToFront();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            //hostControl1.Hide();
            sendMailControl1.BringToFront();
        }

        private void closePBOx_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
