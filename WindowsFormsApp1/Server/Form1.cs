using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private bool bConnected = false;
        private Thread tAcceptMsg = null;

        //socket
        private IPEndPoint ipEndPoint = null;
        private Socket sockets = null;
        private Socket clientSocket = null;

        private NetworkStream networkStream = null;
        private TextReader tReader = null;
        private TextWriter tWriter = null;

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

            while(bConnected)
            {
                try
                {
                    sTemp = tReader.ReadLine();
                    if (sTemp != null)
                    {
                        lock(this)
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

        //Control function
        //----------------------

        private void button1_Click(object sender, EventArgs e)
        {
            ipEndPoint = new IPEndPoint(IPAddress.Any, 7);
            sockets = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sockets.Bind(ipEndPoint);
            sockets.Listen(0);

            //Initial the acceptMessage thread
            tAcceptMsg = new Thread(new ThreadStart(AcceptMessage));
            tAcceptMsg.Start();
            button1.Enabled = false;
        }

        private void MessageReceiver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (bConnected)
                {
                    try
                    {
                        lock(this)
                        {
                            MessageReceiver.Text += "Client: " + MessageSender.Text;
                            tWriter.WriteLine(MessageSender.Text);

                            /*another use receive the message*/

                            /*another use receive the message*/

                            tWriter.Flush();
                            MessageSender.Text = "";
                            MessageSender.Focus();
                        }
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show("Can't connect with client :"+ clientSocket.RemoteEndPoint.ToString() + exception.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please connect one client first");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                sockets.Close();
                tAcceptMsg.Abort();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
