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

            UpdateUserTabel();
        }

        private void UpdateUserTabel()
        {
            int y_Top = 0;
            int x_Left = 0;
            x_Left = this.Bounds.Width / 2;
            y_Top = this.Bounds.Height / 2 - 20;

            string User_name = nameTbox.Text;
            string Nick_name = nickTbox.Text;
            string Password = pwTbox.Text;
            
            if (cptTbox.Text != Password)
            {
                MessageBox.Show("The password is not the same ");
                //Alert.show("The password is not the same ", AlertType.error);
                return;
            }

            string Selectquery = @"SELECT count(*) FROM tchat.user; ";
            int user_ID = 0;
            string returnMessage = "";
            if (!SelectQueryAdapter(Selectquery, ref returnMessage, QueryEnum.Scalar))
                return;
            user_ID = Convert.ToInt32(returnMessage);

            Selectquery = @"select nickName from user
            where nickName  = '" + Nick_name + "';";
            SelectQueryAdapter(Selectquery, ref returnMessage, QueryEnum.Reader);
            if (returnMessage == Nick_name)
            {
                Alert.show("Alread has the nickname, choose the other one", AlertType.warning, x_Left, y_Top);
                return;
            }
            //string Updatequery = @"insert into user
            //values('van Persie', 'Flying DutchMan', 'Robin', '20'); ";

            string Updatequery = @"insert into user values('" + User_name + "',' "
                + Nick_name + "','" + Password + "','" + user_ID.ToString() + "');";
            if (UpdateQueryAdapter(Updatequery))
            {
                this.Dispose();
                this.Close();
                FormMain fMain = new FormMain();
                fMain.Show();

            }
            else
                return;
        }

        public static bool UpdateQueryAdapter(string Updatequery)
        {
            if (Updatequery == "")
            {
                Console.WriteLine("No query sentence!");
                return false;
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
               // return false;
            }

            return true;
        }

        public static bool SelectQueryAdapter(string query, ref string returnMessage, QueryEnum q)
        {
            if (query == "")
            {
                Console.WriteLine("No query sentence!");
                return false;
            }
            string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
                 "persistsecurityinfo=True;database=tchat";

            MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDataBase = new MySqlCommand(query, dataBaseConnection)
            {
                CommandTimeout = 60
            };


            if (q == QueryEnum.Scalar)
            {
                try
                {
                    int returnNum = 0;
                    dataBaseConnection.Open();
                    returnNum = Convert.ToInt32(commandDataBase.ExecuteScalar()) + 1;
                    returnMessage = Convert.ToString(returnNum);
                    dataBaseConnection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error: " + e.Message);
                    dataBaseConnection.Close();
                    return false;
                }
            }
            else if (q == QueryEnum.Reader)
            {
                try
                {
                    dataBaseConnection.Open();
                    returnMessage = commandDataBase.ExecuteScalar().ToString();
                    dataBaseConnection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error: " + e.Message);
                    dataBaseConnection.Close();
                }
            }

            return true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
