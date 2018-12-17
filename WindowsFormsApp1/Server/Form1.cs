using Server.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.NetDealer;

namespace Server
{
    public partial class Form1 : Form
    {
        public List<string> IPList = new List<string>();

        private bool bConnected = false;
        private Thread tAcceptMsg = null;

        //socket
        private IPEndPoint ipEndPoint = null;
        private Socket sockets = null;
        private Socket clientSocket = null;

        private NetworkStream networkStream = null;
        public TextReader tReader = null;
        public TextWriter tWriter = null;

        //TCP Client
        ConnectTCP clientTCP = null;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        //private function
        //----------------------

        private void AcceptMessage()
        {
            clientSocket = sockets.Accept();
            if (clientSocket != null)
            {
                bConnected = true;
                label_serverStatus.Text = "Connected with " + clientSocket.RemoteEndPoint.ToString();
            }

            networkStream = new NetworkStream(clientSocket);
            tReader = new StreamReader(networkStream);
            tWriter = new StreamWriter(networkStream);
            string sTemp = null;

            while (bConnected)
            {
                try
                {
                    sTemp = tReader.ReadLine();

                    if (sTemp != null)
                    {
                        lock (this)
                        {
                            MessageReceiver.Text += "Server: " + sTemp;
                        }
                    }
                }
                catch (Exception e)
                {
                    tAcceptMsg.Abort();
                    MessageBox.Show("Can't communicate with clients" + e.Message);
                }
            }
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            sockets.Shutdown(SocketShutdown.Both);
            sockets.Close();
        }

        private void SocketReceiveMessage()
        {
            Socket receiveSocket = sockets.Accept();
            if (receiveSocket != null)
            {
                bConnected = true;
                label_serverStatus.Text = "Connected with " + receiveSocket.RemoteEndPoint.ToString();
            }

            IPEndPoint tempIPEndPoint = receiveSocket.RemoteEndPoint as IPEndPoint;
            clientTCP = new ConnectTCP(IPAddress.Parse(tempIPEndPoint.Address.ToString()));

            Byte[] byteReceive = new byte[256];

            while (bConnected)
            {
                while (receiveSocket.Receive(byteReceive) != 0)
                //while ((byteReceive = clientTCP.receiveMessage()) != byteReceive)
                {
                    string returnMessage = null;

                    string acceptData = System.Text.Encoding.Default.GetString(byteReceive);
                    string acceptDataType = acceptData.Substring(0, 9);

                    //format Username:^^;password:^^; ... End;
                    if (acceptDataType == "Username:")
                    {
                        try
                        {
                            string[] userList = acceptData.Split(new char[] { ':', ';' });
                            string userName = userList[1];
                            string password = userList[3];
                            //string ipAddress = userList[5];

                            string selectQuery = @"select* from user where User_name  = '" + userName + "';";

                            userErrorType loginErrorType = userErrorType.Notexists;
                            loginErrorType = User.RunQuery(selectQuery, QueryEnum.Reader, password);
                            if (loginErrorType == userErrorType.Notexists)
                            {
                                returnMessage = new UserErrorTypeString(userErrorType.Notexists).ErrorTypeString;
                                clientTCP.ReplyTCP(returnMessage, receiveSocket);
                            }
                            else if (loginErrorType == userErrorType.Password)
                            {
                                returnMessage = new UserErrorTypeString(userErrorType.Password).ErrorTypeString;
                                clientTCP.ReplyTCP(returnMessage, receiveSocket);
                            }

                            returnMessage = new UserErrorTypeString(userErrorType.Exists).ErrorTypeString;
                            //clientTCP.ReplyTCP(returnMessage, receiveSocket);
                            byte[] returnBuff = Encoding.Default.GetBytes(returnMessage);

                            receiveSocket.Send(returnBuff);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Server.cs; Location: SocketReceiveMessage" + e.Message);
                        }
                    }
                }
            }
        }
        //Control function
        //----------------------

        private void button1_Click(object sender, EventArgs e)
        {
            bindNewConnection();
        }

        private void bindNewConnection()
        {
            ipEndPoint = new IPEndPoint(IPAddress.Any, Client.User_port);
            sockets = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sockets.Bind(ipEndPoint);
            sockets.Listen(0);

            //Initial the acceptMessage thread
            //tAcceptMsg = new Thread(new ThreadStart(AcceptMessage));
            tAcceptMsg = new Thread(new ThreadStart(SocketReceiveMessage));
            tAcceptMsg.Start();
            button1.Enabled = false;
        }
        private void closeIPConnection()
        {
            try
            {
                sockets.Close();
                tAcceptMsg.Abort();
                button1.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Server.cs; location: closeIPConnection()" + e.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOnlineList startUpdateOnlineList = new UpdateOnlineList(this.listView_UserInfo, this.label_serverStatus);
            Thread listenUDPThread = new Thread(new ThreadStart(startUpdateOnlineList.StartUpdateOnlineList));
            listenUDPThread.IsBackground = true;
            listenUDPThread.Start();

            UpdateOnlineList updateOnlineList = new UpdateOnlineList(this.RichBox_RemoteClient);
            updateOnlineList.UpdateClientIPAddress();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sockets.Close();
                tAcceptMsg.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MessageSender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (bConnected)
                {
                    try
                    {
                        lock (this)
                        {
                            MessageReceiver.Text += "Server: " + MessageSender.Text + "\n";
                            tWriter.WriteLine(MessageSender.Text);

                            /*another use receive the message*/

                            /*another use receive the message*/

                            tWriter.Flush();
                            MessageSender.Text = "";
                            MessageSender.Focus();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Can't connect with client :" + clientSocket.RemoteEndPoint.ToString() + exception.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please connect one client first");
                }
            }
        }
    }
}
