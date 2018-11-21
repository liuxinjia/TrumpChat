﻿using System;
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
    public enum userErrorType { Notexists, Exists, Name, Nickname, Password, ID }
    public enum QueryEnum { Scalar, NonQuery, Reader }

    class User
    {

        private string user_name;
        private string nickName;
        private string password;
        private int user_id;
        private userErrorType errorType;

        public string User_name { get => user_name; }
        public string NickName { get => nickName; set => nickName = value; }
        public string Password { get => password; set => password = value; }
        public int User_id { get => user_id; }
        public userErrorType ErrorType { get => errorType; }

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
            dataBaseConnection.Open();

            if (q == QueryEnum.Scalar)
            {
                try
                {
                    int returnNum = 0;
                    returnNum = Convert.ToInt32(commandDataBase.ExecuteScalar()) + 1;
                    returnMessage = Convert.ToString(returnNum);
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
                    returnMessage = commandDataBase.ExecuteScalar().ToString();
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

        //public static User[] SelectQueryAdapter(string query)
        //{
        //    if (query == "")
        //    {
        //        Console.WriteLine("No query sentence!");
        //    }
        //    string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
        //         "persistsecurityinfo=True;database=tchat";

        //    MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);
        //    MySqlCommand commandDataBase = new MySqlCommand(query, dataBaseConnection)
        //    {
        //        CommandTimeout = 60
        //    };
        //    dataBaseConnection.Open();

        //    //MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandDataBase);
        //    MySqlDataReader dataReader = new MySqlDataReader(commandDataBase);
        //    DataSet dataSet = new DataSet();

        //    User[] returnUser = new User[1];
        //    returnUser[0] = new User();

        //    try
        //    {
        //        dataAdapter.Fill(dataSet);
        //        DataTable dataTable = dataSet.Tables[0];
        //        returnUser = new User[dataTable.Rows.Count];

        //        try
        //        {
        //            //for (int i = 0; i<dataTable.Rows.Count; i++)
        //            //{
        //            //    MessageBox.Show("Something wrong here !" );

        //            //    returnUser[i].user_name = dataTable.Rows[i][0].ToString();
        //            //    returnUser[i].nickName = dataTable.Rows[i][1].ToString();
        //            //    returnUser[i].password = dataTable.Rows[i][2].ToString();
        //            //    returnUser[i].user_id = Convert.ToInt32( dataTable.Rows[i][3]);
        //            //    returnUser[i].errorType = userErrorType.Exists;
        //            //}
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("Something wrong here !" + e.Message);
        //            returnUser[0].errorType = userErrorType.Notexists;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        returnUser[0].errorType = userErrorType.Notexists;
        //        MessageBox.Show(e.Message);
        //    }

        //    dataBaseConnection.Close();
        //    return returnUser;
        //}

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
                catch (Exception e)
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
                catch (Exception e)
                {
                    return userErrorType.Notexists;
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
                MessageBox.Show("Query error: " + e.Message);
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
            user.errorType = userErrorType.Exists;
            return user;
        }
    }
}
