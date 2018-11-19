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
    public partial class LoginUp : Form
    {
        public enum QueryEnum { Scalar, NonQuery, Reader }

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

            UpdateUserTabel();
            this.Dispose();
            this.Close();
        }

        private void UpdateUserTabel()
        {
            string User_name = Uname_MBox.Text;
            string Nick_name = Nname_MBox.Text;
            string Password = Pword_MBox.Text;
            
            if (confirmPW_MBox.Text != Password)
            {
                MessageBox.Show("The password is not the same ");
                return;
            }

            string Selectquery = @"SELECT count(*) FROM tchat.user; ";
            int user_ID = 0;
            SelectQueryAdapter(Selectquery,ref user_ID);


            //string Updatequery = @"insert into user
            //values('van Persie', 'Flying DutchMan', 'Robin', '20'); ";

            string Updatequery = @"insert into user values('" + User_name + "',' "
                + Nick_name + "','" + Password + "','" + user_ID.ToString() + "');";
            UpdateQueryAdapter(Updatequery);
        }

        public static void UpdateQueryAdapter(string Updatequery)
        {
            if (Updatequery == "")
            {
                Console.WriteLine("No query sentence!");
                return;
            }
            string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
                 "persistsecurityinfo=True;database=tchat";

            MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDataBase = new MySqlCommand(Updatequery, dataBaseConnection)
            {
                CommandTimeout = 60
            };

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandDataBase);
            DataSet dataSet = new DataSet();


            try
            {
                dataBaseConnection.Open();
                dataAdapter.Fill(dataSet);

                dataAdapter.SelectCommand = new MySqlCommand(Updatequery, dataBaseConnection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataBaseConnection.Close();
                dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                dataAdapter.Update(dataSet);
                commandBuilder.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Register Error: " + e.Message);
            }
        }

        public static void SelectQueryAdapter(string query,ref int returnNum)
        {
            if (query == "")
            {
                Console.WriteLine("No query sentence!");
                return;
            }
            string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
                 "persistsecurityinfo=True;database=tchat";

            MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDataBase = new MySqlCommand(query, dataBaseConnection)
            {
                CommandTimeout = 60
            };


            try
            {
                dataBaseConnection.Open();
                returnNum = Convert.ToInt32(commandDataBase.ExecuteScalar()) + 1;
                dataBaseConnection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Query error: " + e.Message);
                dataBaseConnection.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
