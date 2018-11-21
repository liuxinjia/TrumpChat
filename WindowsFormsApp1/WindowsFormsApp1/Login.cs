using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            if (CheckUserDate())
            {
                FormMain mainForm = new FormMain();
                mainForm.Show();
                this.Visible = false;
                this.Enabled = false;
            }

        }

        private bool CheckUserDate()
        {
            int y_Top = 0;
            int x_Left = 0;
            x_Left = this.Bounds.Width / 2;
            y_Top = this.Bounds.Height / 2 - 20;

            string User_Name = nameTbox.Text;
            string password = pwTbox.Text;

            string selectAll = @"select count(*) from user";
            QueryEnum q = QueryEnum.Scalar;
            if (User.RunQuery(selectAll, q) == userErrorType.Notexists)
            {
                Alert.show("Congratulations! You are our first user", AlertType.success,x_Left, y_Top);
            }

            string selectName = @"select* from user where User_name  = '" + User_Name + "';";
            q = QueryEnum.Reader;
            //bool restart = RunQuery(selectName, q, password)? false : true;
            //if (!restart)
            //{
            //    //MessageBox.Show("Welcome back");
            //    Alert.show("Welcome back", AlertType.success, x_Left, y_Top);
            //}
            userErrorType loginErrorType = userErrorType.Notexists;
            loginErrorType = User.RunQuery(selectName, q, password);
            if (loginErrorType == userErrorType.Notexists)
            {
                LoginUp register = new LoginUp();
                register.Show();
                x_Left = register.Bounds.Width / 4;
                y_Top = register.Bounds.Height / 4 - 20;
                Alert.show("Please login up first!", AlertType.info, x_Left, y_Top);
                this.Visible = false;
                this.Enabled = false;
                return false;
            }
            else if (loginErrorType == userErrorType.Password)
            {
                Alert.show("Error: The keyword your enter does not fit", AlertType.error, x_Left, y_Top);
                return false;
            }

            Alert.show("Welcome Back!", AlertType.success, x_Left, y_Top);
            return true;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            LoginUp register = new LoginUp();
            register.Show();
            this.Visible = false;
            this.Enabled = false;
        }
    }
}
