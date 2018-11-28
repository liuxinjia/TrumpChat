using Bunifu.Framework.UI;
using System;
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
        public FormMain()
        {
            InitializeComponent();
        }

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
            Client testClient = Login.localUser;
            if (friendsPanel.Visible)
            {
                contentHide.HideSync(friendsPanel);
            }
            else
            {
                contentShow.ShowSync(friendsPanel);
            }
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

        }

        private void CreateFlatButton(string nickName)
        {
            bunifuTileButton_host.LabelText = "Changed";
            friendsPanel.Controls.Clear();
            BunifuFlatButton newButton = new BunifuFlatButton();
            newButton.AutoSize = true;
            newButton.Text = nickName;
            newButton.Name = nickName;
            newButton.Dock = DockStyle.Top;
            friendsPanel.Controls.Add(newButton);
        }

        public void updateFriendList_click(object sender, EventArgs e)
        {
            BunifuFlatButton button = sender as BunifuFlatButton;
            CreateFlatButton(button.Text);
        }

        private delegate void NameCallBack(string varText);

        public void UpdateTextBox(string input)
        {
            if (InvokeRequired)
                bunifuTileButton_host.BeginInvoke(new NameCallBack(UpdateTextBox), new object[] { input });
            else
            {
                bunifuTileButton_host.LabelText = "Amazing2";
            }
        }
    }
}
