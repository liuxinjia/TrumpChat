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
        }

        //Event Handler
        //-----------------

        //reponse to create updatefriends_button
        public void Subscribe_UpdateFriends(User theUser) => theUser.UpdateFriends += new User.UpdateDataHandler(CreateFlatButton);
        public void Unscribe_UpdateFriends(User theUser) => theUser.UpdateFriends -= new User.UpdateDataHandler(CreateFlatButton);
        //click to create diaologue window
        public void Subscribe_OpenDialogue(User theUser, string friend)
        {
            theUser.OpenDialogue += new User.OpenDialogueHandler(ClickUpdateChatFriend);
            theUser.userFriend_before = friend;
        }
        private void ClickUpdateChatFriend(object theUser, string friend)
        {
            //if (friend == Login.localUser.LocalUser)
            //    return;

            //User userAdapter = theUser as User;
        }
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
            newButton.Click += new EventHandler(friends_click);
            flowLayoutPanel1.Controls.Add(newButton);
        }

        private void friends_click(object sender, EventArgs e)
        {
            BunifuFlatButton friendButton = sender as BunifuFlatButton;

            if (friendButton.Text != Login.localUser.LocalUser.NickName)
            { 
                this.Subscribe_OpenDialogue(Login.localUser.LocalUser, friendButton.Text);
                Login.localUser.LocalUser.Run_OpenDialogue();
            }
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            load_friends();
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
