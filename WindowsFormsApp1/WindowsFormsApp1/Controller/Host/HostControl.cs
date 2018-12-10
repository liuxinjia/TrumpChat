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

            foreach (Panel mPanel in mailPanel)
            {
                if (mPanel.Controls.Count == 0)
                {
                    foreach(User f in Login.localUser.Friends)
                    {
                        if (string.Equals(f.NickName, friendsname))
                            mPanel.Controls.Add(CreateMailControl(f));
                    }
                }
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
            newControl.Contacfriend = friendInfo;
            return newControl;
        }

        private void HostControl_Load(object sender, EventArgs e)
        {
            this.Subscribe_OpenDialogue(Login.localUser.LocalUser);
            Login.localUser.LocalUser.Run_OpenDialogue();
        }
    }
}
