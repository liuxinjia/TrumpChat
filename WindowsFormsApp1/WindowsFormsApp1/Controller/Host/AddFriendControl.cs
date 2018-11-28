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
            //Program.i++;
        }

        private void AutoCompleteText()
        {
            string query = @"select * from tchat.user where user_id !=" + Program.localUser.LocalUser.User_id + ";";
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
            Console.WriteLine("The result of searching:" + friends.Count);
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
                    currentButton.Name = friend.User_name;
                    currentButton.Text = friend.NickName;
                    currentButton.BackColor = Color.FromArgb(i * 10, i * 30, i * 50);

                    panel_adding.Controls.Add(currentButton);
                    currentButton.Click += new System.EventHandler(currentButton_Click);

                    //FormMain tempForMain = new FormMain();
                    //currentButton.Click += new EventHandler(Program.mainForm.updateFriendList_click);
                }
            }
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            BunifuFlatButton button = sender as BunifuFlatButton;
            label_name.Text = button.Name.ToString();
        }

        private void label_name_TextChanged(object sender, EventArgs e)
        {
            Label nameLabel = sender as Label;
            string query = "select *from user where User_name = '" + nameLabel.Text.ToString() + "';";
            ArrayList list = User.SelectQueryReader(query);
            if (list.Count != 1) { MessageBox.Show("Not found, this guy is not one of us");  return; }

            User friend = (User)list[0];
            for (int i =0; i< Program.localUser.Friends.Count; i++)
            {
                User cmp = (User)Program.localUser.Friends[i];
                if (String.Compare(nameLabel.Text.ToString(), cmp.User_name.ToString()) == 0)
                {
                    return;
                }
            }
            Program.localUser.makingFriends(friend);
        }

        private void closePBOx_Click(object sender, EventArgs e)
        {
            this.panel_adding.Controls.Clear();
            this.panel_Tool.Controls.Clear();
            this.panel1.Controls.Clear();
            this.Enabled = false;
            this.Dispose();
        }

        private void timer_closeCreatiedButton_Tick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                BunifuFlatButton currentButton = sender as BunifuFlatButton;
                currentButton.Enabled = false;
                currentButton.Visible = false;
                //panel_adding.Controls.Remove(currentButton);
            }
        }
    }
}
