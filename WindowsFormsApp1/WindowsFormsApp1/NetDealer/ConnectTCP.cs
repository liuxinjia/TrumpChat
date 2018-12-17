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

namespace WindowsFormsApp1.NetDealer
{
    public class ConnectTCP
    {
        //TCP 
        private IPEndPoint ipEndPoint = null;
        public Socket replySocket = null;
        private NetworkStream networkStram = null;
        public TextWriter tWriter = null;
        public TextReader tReader = null;

        public bool connected = false;

        private IPAddress clientIPAddress = null;

        //ref controls

        public ConnectTCP(IPAddress ipAddress)
        {
            clientIPAddress = ipAddress;
            replySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ipEndPoint = new IPEndPoint(clientIPAddress, Client.User_port);

            if (!ConnectFriend_IPAddress())
                return;

            //SendMessage("Hello", ref tWriter);
        }
        public bool ConnectFriend_IPAddress()
        {
            Ping myPing = new Ping();

            try
            {
                myPing.SendAsync(clientIPAddress, 1000, null);
                myPing.PingCompleted += new PingCompletedEventHandler(connectPing_Completed);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: can't ping your friend" + e.Message);
                return false;
            }

            if (myPing != null)
            {
                ConnectFriend_TCP();
            }

            return true;
        }
        private void connectPing_Completed(object sender, PingCompletedEventArgs e)
        {
            if (e.Reply.Status == IPStatus.Success)
            {
                ConnectFriend_TCP();
                SendMessageTCP("Got you!");
                //SendMessage("Hello", ref tWriter);

            }
        }

        private void SendMessageTCP(string ReplyMessage)
        {
            byte[] buff = Encoding.Default.GetBytes(ReplyMessage);
            SendMessage(ReplyMessage);

            try
            {
                buff = Encoding.Default.GetBytes("Fuck you");
                //replySocket.Send(buff);
            }
            catch

            {
                MessageBox.Show("Error2");
            }
        }

        public void ConnectFriend_TCP()
        {
            try
            {
                if (!replySocket.Connected)
                    replySocket.Connect(ipEndPoint);

              
                if (replySocket.Connected)
                {
                    networkStram = new NetworkStream(replySocket);
                    tWriter = new StreamWriter(networkStram);
                    tReader = new StreamReader(networkStram);

                    connected = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: ConnectTCP.cs; LocationConnectFriend_TCP(; " + e.Message);
            }
        }

        public void ReplyTCP(string ReplyMessage, Socket replySocket)
        {
            byte[] buff = Encoding.Default.GetBytes(ReplyMessage);
            try
            {
                if (replySocket.Connected)
                {
                    SendMessage(buff);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: UpdateOnlineList.cs; Line: 129; can't communicate with client" + e.Message);
            }
        }

        public void SendMessage(byte[] buff)
        {
            try
            {
                replySocket.Send(buff);
            }
            catch (Exception e)
            {
                MessageBox.Show("UpdateOnlineList.cs; Location:public void SendMessage(byte[] buff)" + e.Message);
            }
        }
        public byte[] receiveMessage()
        {
            byte[] buff = new byte[256];
            int bytes = 0;
            //do
            //{
            //    bytes = replySocket.Receive(buff, buff.Length, 0);
            //}
            //while (bytes > 0);
            bytes = replySocket.Receive(buff, buff.Length, 0);

            int i = buff.Length - 1;
            while (buff[i] == 0)
                i--;

            byte[] trimBytes = new byte[i + 1];
            Array.Copy(buff, trimBytes, i+1);

            return trimBytes;
        }
        public void SendMessage(string buff)
        {
            try
            {
                tWriter.WriteLine(buff);
                tWriter.Flush();
            }
            catch (Exception e)
            {
                MessageBox.Show("ConnectTCP.cs; Location: public void SendMessage(string buff)" + e.Message);
            }
        }
        public void receiveMessage(ref string message)
        {
            while (tReader.ReadLine() != null)
            {
                try
                {
                    message = tReader.ReadLine();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ConnectTCP.cs; Location: receiveMessage(ref string message);Can't write into netstream" + e.Message);

                }
            }
        }
    }
}
