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
                //SendMessage("Hello", ref tWriter);

            }
        }

        private void SendMessageTCP(string ReplyMessage)
        {
            byte[] buff = Encoding.Default.GetBytes(ReplyMessage);
            SendMessage(ReplyMessage, ref tWriter);

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
                MessageBox.Show("Error: ConnectTCP.cs; Line: 102; can't communicate with client" + e.Message);
            }
        }


        public void SendMessage(byte[] buff, ref TextWriter tWriter)
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
        public void SendMessage(string buff, ref TextWriter tWriter)
        {
            try
            {
                tWriter.WriteLine(buff);
                tWriter.Flush();
            }
            catch (Exception e)
            {
                MessageBox.Show("ConnectTCP.cs; Line: 128;Can't write into netstream" + e.Message);
            }
        }
    }
}
