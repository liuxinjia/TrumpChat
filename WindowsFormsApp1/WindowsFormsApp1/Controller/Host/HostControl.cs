using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller.Host
{
    public partial class HostControl : UserControl
    {
        //Event Handler
        //-----------------

        //FileWebResponse to create diaologue window
        public void Subscribe_OpenDialogue(User theUser)
        {
            theUser.OpenDialogue += new User.OpenDialogueHandler(CreateDialogueWindow);
        }
        private string lastFriend = "";
        public void CreateDialogueWindow(object theUser, string friendsname)
        {
            if (friendsname == lastFriend)
                return;
            Panel[] mailPanel = { panel_mail01, panel_mail02, panel_mail03 };

<<<<<<< HEAD
            bool isAdded = false;

=======
>>>>>>> parent of c7c8852... Revert "Ready to chat"
            foreach (Panel mPanel in mailPanel)
            {
                if (mPanel.Controls.Count == 0)
                {
                    foreach(User f in Login.localUser.Friends)
                    {
                        if (string.Equals(f.NickName, friendsname))
<<<<<<< HEAD
                        {
                            mPanel.Controls.Add(CreateMailControl(f));
                            lastFriend = friendsname;
                            isAdded = true;
                            break;
                        }
                    }
                }
                if (isAdded == true)
                    break;
=======
                            mPanel.Controls.Add(CreateMailControl(f));
                    }
                }
>>>>>>> parent of c7c8852... Revert "Ready to chat"
            }
        }

        public HostControl()
        {
            InitializeComponent();
        }

        private MailController CreateMailControl(User friendInfo)
        {
            MailController newControl = new MailController();
            newControl.Dock = DockStyle.Fill;
<<<<<<< HEAD
            newControl.Contactfriend = friendInfo;
=======
            newControl.Contacfriend = friendInfo;
>>>>>>> parent of c7c8852... Revert "Ready to chat"
            return newControl;
        }

        private void HostControl_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //this.Subscribe_OpenDialogue(Login.localUser.LocalUser);
            //Login.localUser.LocalUser.Run_OpenDialogue();
        }

        private void bunifuFlatButton_StartChat_Click(object sender, EventArgs e)
        {
            this.Subscribe_OpenDialogue(Login.localUser.LocalUser);
            Login.localUser.LocalUser.Run_OpenDialogue();

            // panel_loadmail.Controls.Clear();
            panel_loadmail.Visible = false;

=======
            this.Subscribe_OpenDialogue(Login.localUser.LocalUser);
            Login.localUser.LocalUser.Run_OpenDialogue();
>>>>>>> parent of c7c8852... Revert "Ready to chat"
        }
    }
}
