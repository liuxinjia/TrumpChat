using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    enum userErrorType { Notexists, Exists, Name, Nickname, Password, ID }

    class User
    {
        private string User_name;
        private string nickName;
        private string password;
        private int user_id;

        public string Name { get => User_name; set => User_name = value; }
        public string NickName { get => nickName; set => nickName = value; }
        public string Password { get => password; set => password = value; }
        public int User_id { get => user_id; set => user_id = value; }

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
                MessageBox.Show("Update Error: " + e.Message);
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
                    return false;
                }
            }

            return true;
        }

        public static userErrorType RunQuery(string query, QueryEnum q, string password = null)
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
                int count = 0;
                dataBaseConnection.Open();
                try
                {
                    count = Convert.ToInt32(commandDataBase.ExecuteScalar());
                    dataBaseConnection.Close();
                }
                catch (Exception e)
                {
                    dataBaseConnection.Close();
                    return userErrorType.Notexists;
                }
                if (count == 0)
                    return userErrorType.Notexists;
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
                       // return userErrorType.Exists;
                    }
                    else
                    {
                        return userErrorType.Password;
                    }
                }
                catch (Exception e)
                {
                    return userErrorType.Notexists;
                }
            }

            return userErrorType.Exists;
        }

    }
}
