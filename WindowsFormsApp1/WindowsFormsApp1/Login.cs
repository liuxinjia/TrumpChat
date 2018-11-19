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
        private int count = 0;

        public enum QueryEnum { Scalar, NonQuery, Reader }

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
            if (!CheckUserDate())
            {
                FormMain mainForm = new FormMain();
                mainForm.Show();
                this.Visible = false;
                this.Enabled = false;
            }

        }

        private bool CheckUserDate()
        {
            string User_Name = NameTBox.Text;
            string password = PWTBox.Text;

            string selectAll = @"select count(*) from user";
            QueryEnum q = QueryEnum.Scalar;
            if (RunQuery(selectAll, q))
                MessageBox.Show("Congratulations! You are our first user");

            string selectName = @"select* from user where User_name  = '" + User_Name + "';";
            q = QueryEnum.Reader;
            bool restart = RunQuery(selectName, q, password)? false : true;
            if (!restart)
            {
                MessageBox.Show("Welcome back");
            }

            return restart;
        }

        private bool RunQuery(string query, QueryEnum q, string password = null)
        {
            string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
            "persistsecurityinfo=True;database=tchat";

            MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDataBase = new MySqlCommand(query, dataBaseConnection)
            {
                CommandTimeout = 60
            };
            

            if (q == QueryEnum.Scalar)
            {
                dataBaseConnection.Open();
                count = Convert.ToInt32(commandDataBase.ExecuteScalar());
                dataBaseConnection.Close();
                if (count == 0)
                    return false;
            }
            else if (q == QueryEnum.Reader)
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandDataBase);
                DataSet dataSet = new DataSet();
                try
                {
                    dataAdapter.Fill(dataSet);

                 //   MessageBox.Show(dataSet.Tables[0].Rows[0][0].ToString());
                    if (Convert.ToString(dataSet.Tables[0].Rows[0][2]) == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Please login up first!"+ e.Message);

                    LoginUp register = new LoginUp();
                    register.Show();
                    this.Visible = false;
                    this.Enabled = false;
                }
            }

            return false;
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
