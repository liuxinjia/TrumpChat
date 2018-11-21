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
            addnewControl();
        }

        private void addnewControl()
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
                panel_adding.Controls.Clear();
                for (int j = 0; j < friends.Count; j++)
                {
                    int i = j % 3;
                    //currentButton.Parent = FormMain.newFriend;
                    BunifuFlatButton currentButton = new BunifuFlatButton();
                    currentButton.Dock = DockStyle.Top;
                    currentButton.AutoSize = true;
                    currentButton.Name = friend.NickName;
                    currentButton.Text = friend.NickName;
                    currentButton.BackColor = Color.FromArgb(i * 10, i * 30, i * 50);

                    panel_adding.Controls.Add(currentButton);
                    currentButton.Click += new System.EventHandler(currentButton_Click);
                }
            }
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
