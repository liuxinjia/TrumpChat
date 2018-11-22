using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Client
    {
        private ArrayList friends;
        private User localUser;

        internal ArrayList Friends { get => friends; }
        internal User LocalUser { get => localUser;}

        public Client(User me)
        {
            localUser = me;
            friends = new ArrayList();

            //creatLocalUserTable();
        }

        private void creatLocalUserTable()
        {
            string query = "SELECT count(*) FROM tchat.localuser;";
            QueryEnum q = QueryEnum.Scalar;
            string count = "";
            if (User.SelectQueryAdapter(query, ref count, q))
            {

            }
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
        }
    }
}