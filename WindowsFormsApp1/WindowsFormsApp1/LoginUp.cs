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
    public partial class LoginUp : Form
    {
        public LoginUp()
        {
            InitializeComponent();
        }
        private void register1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            FormMain fMain = new FormMain();
            fMain.Show();

            this.Dispose();
            this.Close();
        }
    }
}
