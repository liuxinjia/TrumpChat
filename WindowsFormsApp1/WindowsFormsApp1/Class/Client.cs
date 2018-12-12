﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Client
    {
        private ArrayList friends;
        private User localUser;
        public readonly static int User_port = 7;

        internal ArrayList Friends { get => friends; }
        internal User LocalUser { get => localUser; }

        public Client(User me)
        {
            localUser = me;
            friends = new ArrayList();

            creatLocalUserTable();
            loadFriendsTable();
        }

        private void creatLocalUserTable()
        {
            string query = "SELECT count(*) FROM tchat.localuser;";
            QueryEnum q = QueryEnum.Scalar;
            string count = "";
            if (!User.SelectQueryAdapter(query, ref count, q))
            {
                MessageBox.Show("Something wrong in querying localUser Table");
                return;
            }

            if (Convert.ToInt32(count) != 0)
            {
                query = @"SELECT user_id FROM tchat.localuser;";
                string existsID = "";
                if (!User.SelectQueryAdapter(query, ref existsID, q))
                {
                    MessageBox.Show("SOmething wrong in querying first user in localUser table");
                    return;
                }

                query = @"SELECT user_port FROM tchat.localuser;";
                string existsPort = "";
                if (!User.SelectQueryAdapter(query, ref existsPort, q))
                {
                    MessageBox.Show("Something wrong in querying first user in localUser table");
                    return;
                }

                if (Convert.ToInt32(existsID) != localUser.User_id || Convert.ToInt32(existsPort) != localUser.User_port)
                {
                    query = @"delete from localuser;";
                    q = QueryEnum.NonQuery;

                    if (!User.SelectQueryAdapter(query, ref existsID, q))
                    {
                        MessageBox.Show("Can't delete local Users");
                        return;
                    }

                }
                else
                    return;
            }

            string selectQuery = "SELECT * FROM tchat.localuser where 0 =1;";
            if (!User.UpdateQueryAdapter(selectQuery, this.localUser))
            {
                return;
            }
        }
        private void loadFriendsTable()
        {
            string query = @"SELECT * FROM tchat.friends;";

            friends = User.SelectQueryReader(query);
        }
        public Client()
        {
            MessageBox.Show("Error initialize Client");
        }

        public void changeLocalUser_nickName(string newNick)
        {
            //checkDupl(newNick);
            localUser.NickName = newNick;
        }
        public void changeLocalUser_password(string newPassword)
        {
            localUser.Password = newPassword;
        }

        public void makingFriends(User friend)
        {
            this.friends.Add(friend);

            string selectQuery = "SELECT * FROM tchat.friends where 0 =1;";
            User.UpdateQueryAdapter(selectQuery, friend);
        }
    }
}