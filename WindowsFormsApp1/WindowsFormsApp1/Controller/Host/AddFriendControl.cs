using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller.Host
{
    public partial class AddFriendControl : UserControl
    {
        public AddFriendControl()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            string queryName = searchBox.Text;
            string query = @"select *from user where User_name = '" + queryName + @"' or nickName = '" + queryName + "';";

        }
    }
}
