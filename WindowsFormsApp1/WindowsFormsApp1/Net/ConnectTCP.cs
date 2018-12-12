using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Net
{
    public class ConnectTCP
    {
        //TCP 
        private IPEndPoint ipEndPoint = null;
        private Socket replySocket = null;
        private NetworkStream networkStram = null;
        private TextWriter tWriter = null;
        private TextReader tReader = null;

        public Thread tAcceptMsg = null;
        public bool connected = false;

        private IPAddress clientIPAddress = null;

        //ref controls

        public ConnectTCP(IPAddress ipAddress)
        {
            clientIPAddress = ipAddress;
            ipEndPoint = new IPEndPoint(clientIPAddress, Client.User_port);

            if (!ConnectFriend_IPAddress())
                return;

        }
        public bool ConnectFriend_IPAddress()
        {
            Ping myPing = new Ping();
            
            try
            {
                myPing.SendAsync(clientIPAddress, 1000, null);
                myPing.PingCompleted += new PingCompletedEventHandler(connectPing_Completed);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: can't ping your friend" + e.Message);
                return false;
            }

            return true;
        }
        private void connectPing_Completed(object sender, PingCompletedEventArgs e)
        {
            if (e.Reply.Status == IPStatus.Success)
            {
                ConnectFriend_TCP();
                SendMessageTCP("Got you!");
            }
        }

        private void SendMessageTCP(string ReplyMessage)
        {
            byte[] buff = Encoding.Default.GetBytes(ReplyMessage);
            SendMessage(buff, ref tWriter);
        }

        private void ConnectFriend_TCP()
        {
            try
            {
                replySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                replySocket.Connect(ipEndPoint);

                if (replySocket.Connected)
                {
                    networkStram = new NetworkStream(replySocket);
                    tWriter = new StreamWriter(networkStram);
                    tReader = new StreamReader(networkStram);

                    tAcceptMsg = new Thread(new ThreadStart(this.AcceptMessage));
                    tAcceptMsg.Start();
                    connected = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: UpdateOnlineList.cs; Line: 129; can't communicate with client" + e.Message);
            }
        }


        private void SendMessage(byte[] buff, ref TextWriter tWriter)
        {
            try
            {
                tWriter.WriteLine(buff);
                tWriter.Flush();
            }
            catch (Exception e)
            {
                MessageBox.Show("UpdateOnlineList.cs; Line: 137;Can't write into netstream" + e.Message);
            }
        }
        private void AcceptMessage()
        {
            string sTemp;

            while (connected)
            {
                try
                {
                    sTemp = tReader.ReadLine();
                    if (sTemp.Length != 0)
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("Can't connect with Server");
                }
            }
            replySocket.Shutdown(SocketShutdown.Both);
            replySocket.Close();
        }
    }
}
