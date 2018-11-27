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

        public MailController()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
                        panel_accept.Controls.Add(CreateChatLabel(sTemp));
                    }
                }
                catch
                {

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
                panel_send.Controls.Add(CreateChatLabel(chatMetroTBox.Text));

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

        private Label CreateChatLabel(string message)
        {
            Label newLabel = new Label();
            newLabel.Parent = panel_send;
            newLabel.AutoEllipsis = true;
            newLabel.AutoSize = true;
            newLabel.Text = message;
            return newLabel;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //Recommend to remove the control from parents rather than dispose it to kill it purely;
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
                ipEndPoint = new IPEndPoint(IPAddress.Parse(Program.localUser.LocalUser.User_address),
                    Program.localUser.LocalUser.User_port);
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
    }
}
