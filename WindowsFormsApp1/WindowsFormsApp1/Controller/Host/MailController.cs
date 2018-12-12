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

namespace WindowsFormsApp1.Controller.Host
{
    public partial class MailController : UserControl
    {
        private bool connected = false;
        private Thread tAcceptMsg = null;
        private IPEndPoint ipEndPoint = null;
        private Socket sockets = null;
        private NetworkStream netWorkStream = null;
        private TextReader tReader = null;
        private TextWriter tWriter = null;

        public User Contactfriend = new User();

        public MailController()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
        }

        public bool Connected { get => connected; }

        //private function
        //----------------------
        private void AcceptMessage()
        {
            string sTemp;

            while(Connected)
            {
                try
                {
                    sTemp = tReader.ReadLine();
                    if (sTemp.Length != 0)
                    {
                        //CreateChatLabel(sTemp);
                        InvokeCreateButton(sTemp);
                    }
                }
                catch
                {
                    MessageBox.Show("Can't connect with Server");
                }
            }
            sockets.Shutdown(SocketShutdown.Both);
            sockets.Close();
        }

        //Controls funtion
        //----------------------

        private void bunifuMetroTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            BunifuMetroTextbox chatMetroTBox = sender as BunifuMetroTextbox;

            if (e.KeyChar == (char)13)
            {
                flowPanel_Send.Controls.Add(CreateChatButton(chatMetroTBox.Text));

                if (connected)
                {
                    try
                    {
                        tWriter.WriteLine(chatTBox.Text);
                        tWriter.Flush();
                        chatTBox.Text = "";
                        chatTBox.Focus();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("disconnected with the server " + ex.Message);
                    }
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

                sockets.Close();
                tAcceptMsg.Abort();
            }
            catch(Exception ex)
            {
                new Alert(ex.Message, AlertType.error);
            }
        }

        private void MailController_Enter(object sender, EventArgs e)
        {
            //try
            //{
            //    ipEndPoint = new IPEndPoint(IPAddress.Parse(Program.localUser.LocalUser.User_address), 
            //        Program.localUser.LocalUser.User_port);
            //    sockets = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //    sockets.Connect(ipEndPoint);
            //    if (sockets.Connected)
            //    {
            //        netWorkStream = new NetworkStream(sockets);
            //        tWriter = new StreamWriter(netWorkStream);
            //        tReader = new StreamReader(netWorkStream);
            //        tAcceptMsg = new Thread(new ThreadStart(this.AcceptMessage));
            //        tAcceptMsg.Start();
            //        new Alert("Connected with server, next communicating", AlertType.success);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("can't communciate with server" + ex.Message);
            //}
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                ipEndPoint = new IPEndPoint(IPAddress.Parse(Login.localUser.LocalUser.User_address),
                    Login.localUser.LocalUser.User_port);
                sockets = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sockets.Connect(ipEndPoint);
                if (sockets.Connected)
                {
                    netWorkStream = new NetworkStream(sockets);
                    tWriter = new StreamWriter(netWorkStream);
                    tReader = new StreamReader(netWorkStream);
                    tAcceptMsg = new Thread(new ThreadStart(this.AcceptMessage));
                    tAcceptMsg.Start();
                    connected = true;
                    new Alert("Connected with server, next communicating", AlertType.success);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't communciate with server" + ex.Message);
            }
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
    }
}
