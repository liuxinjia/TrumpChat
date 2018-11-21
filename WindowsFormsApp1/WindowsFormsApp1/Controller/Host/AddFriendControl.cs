using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Collections;

namespace WindowsFormsApp1.Controller.Host
{
    public partial class AddFriendControl : UserControl
    {
        private BunifuFlatButton[] creatButtons;

        public AddFriendControl()
        {
            InitializeComponent();
            AutoCompleteText();
        }

        private void AutoCompleteText()
        {
            string query = @"SELECT * FROM tchat.user;";
            ArrayList users = User.SelectQueryReader(query);
            if (users.Count == 0)
                return;
            User user = (User)users[0];

            searchTBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchTBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collumn = new AutoCompleteStringCollection();
            if (user.ErrorType == userErrorType.Notexists)
            {
                new Alert("Not user exists", AlertType.warning);
            }
            else
            {
                for (int i = 0; i < users.Count; i++)
                {
                    user = (User)users[i];
                    collumn.Add(user.User_name);
                    collumn.Add(user.NickName);
                }
            }

            searchTBox.AutoCompleteCustomSource = collumn;
        }

        private void searchTBox_TextChange(object sender, EventArgs e)
        {
            string queryName = searchTBox.Text;
            string query = @"select *from user where User_name like '" + queryName
                + @"' or nickName like '" + queryName + "';";

            ArrayList friends = User.SelectQueryReader(query);
            if (friends.Count == 0)
                return;
            User friend = (User)friends[0];

            if (friend.ErrorType == userErrorType.Notexists)
            {
                new Alert("Not found", AlertType.warning);
            }
            else
            {
                creatButtons = new BunifuFlatButton[3];

                for (int j = 0; j < friends.Count; j++)
                {
                    int i = j % 3;
                    friend = (User)friends[j];
                    creatButtons[j].Parent = this;
                    creatButtons[j].Dock = DockStyle.Top;
                    creatButtons[j].Name = friend.NickName;
                    creatButtons[j].Text = friend.NickName;
                    creatButtons[j].BackColor = Color.FromArgb(i * 10, i * 30, i * 50);
                }
            }
        }
    }
}
