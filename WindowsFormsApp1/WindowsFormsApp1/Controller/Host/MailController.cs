using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using Bunifu.Framework.UI;
using WindowsFormsApp1.NetDealer;

namespace WindowsFormsApp1.Controller.Host
{
    public partial class MailController : UserControl
    {
        private bool connected = false;
        private Thread tAcceptMsg = null;
        private ConnectTCP tcpClient;

        public User Contactfriend = new User();

        private bool justConnectedBefore = false;
        public bool Connected { get => connected; }


        public User Contacfriend = new User();

        public MailController()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
        }

        //private function
        //----------------------
        private void AcceptMessage()
        {
            string sTemp;

            while(tcpClient.connected)
            {
                try
                {
                    sTemp = tcpClient.tReader.ReadLine();
                    if (sTemp.Length != 0)
                    {
<<<<<<< HEAD
=======
                        //CreateChatLabel(sTemp);
>>>>>>> parent of c7c8852... Revert "Ready to chat"
                        InvokeCreateButton(sTemp);
                    }
                    justConnectedBefore = true;
                }
                catch
                {
                    MessageBox.Show("Can't connect with Server");
                }
            }
            if (justConnectedBefore)
            {
                tcpClient.replySocket.Shutdown(SocketShutdown.Both);
                tcpClient.replySocket.Close();
            }
        }

        //Controls funtion
        //----------------------

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            BunifuMetroTextbox chatMetroTBox = sender as BunifuMetroTextbox;

            if (e.KeyChar == (char)13)
            {
                flowPanel_Send.Controls.Add(CreateChatButton(chatMetroTBox.Text));

                if (tcpClient == null)
                    return;

                if (tcpClient.connected)
                {
                    tcpClient.SendMessage(chatTBox.Text);
                    chatTBox.Text = "";
                    chatTBox.Focus();
                }
                else
                {
                    MessageBox.Show("Can't connect with server");
                }
            }
        }

        private void CreateChatLabel(string message)
        {
            Label newLabel = new Label();

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { CreateChatLabel(message); }));
                return;
            }

            newLabel.AutoEllipsis = true;
            newLabel.AutoSize = true;
            newLabel.Top = 40;
            newLabel.Left = 15;
            newLabel.Text = message;

            flowPanel_Receive.Controls.Add(newLabel);

        }
        
        private void InvokeCreateButton(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { InvokeCreateButton(message); }));
                return;
            }

            flowPanel_Receive.Controls.Add(CreateChatButton(message));
        }

        private Button CreateChatButton(string message)
        {
            Button newButton = new Button();
            newButton.AutoSize = true;
            newButton.Top = 20;
            newButton.Left = 8;
            newButton.Text = message;
            newButton.Name = "NewButton_" + message;

            System.DateTime dt = System.DateTime.Now;
            int r = Math.Min(255, dt.Second * 10);
            int g = Math.Min(255, dt.Second * 15);
            int b = Math.Min(255, dt.Second * 25);
            newButton.BackColor =  Color.FromArgb(r,g,b);
            return newButton;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //Recommend to remove the control from its parents rather than dispose it to kill it purely;
                this.Dispose();

                //maybe just stop , but still to receive the message, however it costs a lot
                tcpClient.replySocket.Close();
                tAcceptMsg.Abort();
            }
            catch(Exception ex)
            {
                new Alert(ex.Message, AlertType.error);
            }
        }

        private void MailController_Enter(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            tcpClient = new ConnectTCP(IPAddress.Parse(Login.localUser.LocalUser.User_address));

            tAcceptMsg = new Thread(new ThreadStart(AcceptMessage));
            tAcceptMsg.Start();
            tAcceptMsg.IsBackground = true;
        }

        private void MailController_Load(object sender, EventArgs e)
        {
            try
            {
                friendLabel_name.Text = Contactfriend.NickName;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void MailController_Load(object sender, EventArgs e)
        {
            try
            {
                friendLabel_name.Text = Contacfriend.NickName;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
