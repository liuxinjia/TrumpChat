using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Client
    {
        private ArrayList friends;
        private User localUser;

        public Client(User me)
        {
            localUser = me;
            friends = new ArrayList();
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
