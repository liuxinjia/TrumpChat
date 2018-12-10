using Bunifu.Framework.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller.Host;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        private string lastFriend = "";

        public FormMain()
        {
            InitializeComponent();

            load_friends();
        }

        //Event Handler
        //-----------------

        //reponse to create updatefriends_button
        public void Subscribe_UpdateFriends(User theUser) => theUser.UpdateFriends += new User.UpdateDataHandler(CreateFlatButton);
        public void Unscribe_UpdateFriends(User theUser) => theUser.UpdateFriends -= new User.UpdateDataHandler(CreateFlatButton);

        private void CreateFlatButton(object theUser, string nickName)
        {

            if (lastFriend == nickName || nickName == "")
                return;
            lastFriend = nickName;

            BunifuFlatButton newButton = new BunifuFlatButton();
            newButton.AutoSize = true;
            newButton.Text = nickName;
            newButton.Name = nickName;
            newButton.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(newButton);
        }

        //Preload function
        //-----------------

        private void load_friends()
        {
            string query = @"SELECT 
                                   *
                              FROM
                                    tchat.friends
                            WHERE
                                 user_id IS NOT NULL;";
            ArrayList friends = User.SelectQueryReader(query);
            if (friends.Count == 0)
                return;

            foreach(User friend in friends)
            {
                CreateFlatButton(friend, friend.NickName);
            }

        }



        //autocreation function
        //-----------------

        private void contentPBox_Click(object sender, EventArgs e)
        {
            if (contentPanel.Visible)
            {
                contentHide.HideSync(contentPanel);
            }
            else
            {
                contentShow.ShowSync(contentPanel);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (friendsPanel.Visible)
            {
                contentHide.HideSync(friendsPanel);
            }
            else
            {
                contentShow.ShowSync(friendsPanel);
            }

            this.Subscribe_UpdateFriends(Login.localUser.LocalUser);           
            Login.localUser.LocalUser.Run_UpdateFriends();
           // this.Unscribe(Login.localUser.LocalUser);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            hostControl1.BringToFront();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            //hostControl1.Hide();
            sendMailControl1.BringToFront();
        }

        private void closePBOx_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addFriend_Click(object sender, EventArgs e)
        {
            AddFriendControl newFriend = new AddFriendControl();
            newFriend.Parent = this;
            newFriend.Dock = DockStyle.Left;
            newFriend.Name = "add";            
        }

        //public void updateFriendList_click(object sender, EventArgs e)
        //{
        //    BunifuFlatButton button = sender as BunifuFlatButton;
        //    CreateFlatButton(button.Text);
        //}

        //private delegate void NameCallBack(string varText);

        //public void UpdateTextBox(string input)
        //{
        //    if (InvokeRequired)
        //        bunifuTileButton_host.BeginInvoke(new NameCallBack(UpdateTextBox), new object[] { input });
        //    else
        //    {
        //        bunifuTileButton_host.LabelText = "Amazing2";
        //    }
        //}
    }
}
