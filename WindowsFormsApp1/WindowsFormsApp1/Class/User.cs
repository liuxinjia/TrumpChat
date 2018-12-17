using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public enum userErrorType { Notexists, Exists, Name, Nickname, Password, ID, IPAddress }
    public enum QueryEnum { Scalar, NonQuery, Reader }
    public enum UpdateType { Update, Insert, Delete};

    public class User
    {
        public delegate void UpdateDataHandler(object runner, string message);
        public delegate void OpenDialogueHandler(object sender, string friend);
        //User properties
        private string user_name;
        private string nickName;
        private string password;
        private int user_id;
        private string user_address;
        private int user_port;
        private userErrorType errorType;

        //Event Handler
        public event UpdateDataHandler UpdateFriends;
        public event OpenDialogueHandler OpenDialogue;

        public string User_name { get => user_name; }
        public string NickName { get => nickName; set => nickName = value; }
        public string Password { get => password; set => password = value; }
        public int User_id { get => user_id; }
        public userErrorType ErrorType { get => errorType; }
        public int User_port { get => user_port; }
        public string User_address { get => user_address; }

        public User()
        {

        }

        public User(string name, string nName, string pword, int id, string address, int port)
        {
            this.user_name = name;
            this.nickName = nName;
            this.password = pword;
            this.user_id = id;
            this.user_address = address;
            this.user_port = port;
        }

        //Query function      
        //---------------
        public static bool UpdateQueryAdapter( string Selectquery, User newUser)
        {
            if (Selectquery == "")
            {
                MessageBox.Show("No query sentence!");
                return false;
            }
            string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
                 "persistsecurityinfo=True;database=tchat";

            MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);

            DataSet dataSet = new DataSet();
       
            try
            {
                dataBaseConnection.Open();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = new MySqlCommand(Selectquery, dataBaseConnection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(dataSet);

                DataRow newRow = dataSet.Tables[0].NewRow();
                newRow["User_name"] = newUser.user_name;
                newRow["nickName"] = newUser.nickName;
                newRow["User_password"] = newUser.password;
                newRow["User_ID"] = newUser.user_id;
                newRow["User_Address"] = newUser.user_address;
                newRow["User_Port"] = newUser.user_port;
                dataSet.Tables[0].Rows.Add(newRow); 

                dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                dataAdapter.Update(dataSet);

                commandBuilder.Dispose();
                dataBaseConnection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Update Error: " + e.Message);
                dataBaseConnection.Close();
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
                    dataBaseConnection.Open();
                    returnMessage = Convert.ToString(commandDataBase.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error: " + e.Message);
                    return false;
                }
            }
            else if (q == QueryEnum.Reader)
            {
                try
                {
                    dataBaseConnection.Open();

                    MySqlDataReader reader = commandDataBase.ExecuteReader();
                    if (reader.HasRows)
                        returnMessage = reader[0].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error: " + e.Message);
                    return false;
                }
            }
            else if (q == QueryEnum.NonQuery)
            {
                try
                {
                    dataBaseConnection.Open();
                    if (commandDataBase.ExecuteNonQuery() == 0)
                        MessageBox.Show("Are you fucking kidding me?");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Query error: " + e.Message);
                    return false;
                }

            }

            dataBaseConnection.Close();
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
            dataBaseConnection.Open();

            if (q == QueryEnum.Scalar)
            {
                int count = 0;
                try
                {
                    count = Convert.ToInt32(commandDataBase.ExecuteScalar());
                }
                catch
                {
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
                catch
                {
                    return userErrorType.Notexists;
                }
            }
            else if (q == QueryEnum.Scalar)
            {
                try
                {
                    int reflectRows =  commandDataBase.ExecuteNonQuery();
                    if (reflectRows == 0)
                    {
                        MessageBox.Show("0 row(s) affected");
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            dataBaseConnection.Close();
            return userErrorType.Exists;
        }

        public static ArrayList SelectQueryReader(string query)
        {
            if (query == "")
            {
                Console.WriteLine("No query sentence!");
            }


            string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
                 "persistsecurityinfo=True;database=tchat";

            MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDataBase = new MySqlCommand(query, dataBaseConnection)
            {
                CommandTimeout = 60
            };
            dataBaseConnection.Open();
            ArrayList user = new ArrayList();

            try
            {
                MySqlDataReader reader = commandDataBase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        user.Add(ReadSingleRow((IDataRecord)reader));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error : " + e.Message);
            }

            return user;
        }

        private static User ReadSingleRow(IDataRecord reader)
        {
            User user = new User();
            user.user_name = reader[0].ToString();
            user.nickName = reader[1].ToString();
            user.password = reader[2].ToString();
            user.user_id = Convert.ToInt32(reader[3]);
            user.user_address = reader[4].ToString();
            user.user_port = Convert.ToInt32(reader[5]);
            user.errorType = userErrorType.Exists;
            return user;
        }

        //Event function
        //---------------

        //eventHandler to create new friends button
        public string friend_Before = "";

        public void Run_UpdateFriends()
        {
            if (UpdateFriends != null)
            {
                UpdateFriends(this, friend_Before);
            }
        }

        //eventHandler to create new dialogue window
        public string userFriend_before = "";
        public void Run_OpenDialogue()
        {
            if (OpenDialogue != null)
            {
                OpenDialogue(this, userFriend_before);
            }
        }
    }
}
