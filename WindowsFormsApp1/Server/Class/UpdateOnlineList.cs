using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Server.Class
{
    public class UpdateOnlineList
    {
        private ListView onlineUser;
        private Label label_serverStatus;
        private int IP_port = Client.User_port;

        public UpdateOnlineList(ListView onlineListView, Label label_info)
        {
            this.onlineUser = onlineListView;
            this.label_serverStatus = label_info;
        }

        public void StartUpdateOnlineList()
        {
            UdpClient server = new UdpClient(IP_port);
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 0);

            string acceptData = string.Empty;
            string userName = "SomeOne";
            string returnMessage = null;
            while (true)
            {
                acceptData = System.Text.Encoding.UTF8.GetString(server.Receive(ref ipEndPoint));
                
                string acceptDataType = acceptData.Substring(0, 9);

                if (acceptDataType == "Username:")
                {
                    try
                    {
                        string[] userList = acceptData.Split(new char[] { ':', ';'});
                        userName = userList[1];
                        string password = userList[3];
                        string ipAddress = userList[5];

                        string selectQuery = @"select* from user where User_name  = '" + userName + "';";

                        userErrorType loginErrorType = userErrorType.Notexists;
                        loginErrorType = User.RunQuery(selectQuery, QueryEnum.Reader, password);
                        if (loginErrorType == userErrorType.Notexists)
                        {
                            returnMessage = new UserErrorTypeString(userErrorType.Notexists).ErrorTypeString;
                            ReplyTCP(returnMessage, ipAddress);
                        }
                        else if (loginErrorType == userErrorType.Password)
                        {
                            returnMessage = new UserErrorTypeString(userErrorType.Password).ErrorTypeString;
                            ReplyTCP(returnMessage, ipAddress);
                        }

                        returnMessage = new UserErrorTypeString(userErrorType.Exists).ErrorTypeString;
                        ReplyTCP(returnMessage, ipAddress);
                        
                        ListViewItem newViewItem = new ListViewItem();
                        ListViewItem.ListViewSubItem listItems = new ListViewItem.ListViewSubItem(newViewItem, userName);
                        newViewItem.SubItems.Add(listItems);

                        string User_IP = string.Empty;
                        selectQuery = @"select user_address
                                        from tchat.user
                                        where user_name = '" + userName + "';";
                        if (!User.SelectQueryAdapter(selectQuery,ref User_IP, QueryEnum.Scalar))
                        {
                            MessageBox.Show("QueryError :" + " UpdateOnlineList.cs； line: 67");
                        }

                        listItems.Text = User_IP;
                        newViewItem.SubItems.Add(listItems);

                        bool existed = false;
                        foreach(ListViewItem subitem in onlineUser.Items)
                        {
                            if (subitem.SubItems[1].Text == newViewItem.SubItems[1].Text)
                            {
                                existed = true;
                            }
                        }

                        if (!existed)
                            this.onlineUser.Items.Add(newViewItem);

                        label_serverStatus.Text += "    —— —— The number of online: " + onlineUser.Items.Count.ToString();
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(userName + " is off-line");
                        MessageBox.Show("The Error info :" + e.Message);
                    }
                }
            }
        }

        public void ReplyTCP(string ReplyMessage, string ipAddress)
        {
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), IP_port);
            Socket replySocket = null;
            NetworkStream networkStram = null;
            TextWriter tWriter = null;

            byte[] buff = Encoding.Default.GetBytes(ReplyMessage);
            try
            {
                replySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                replySocket.Connect(ipEndPoint);

                if (replySocket.Connected)
                {
                    networkStram = new NetworkStream(replySocket);
                    tWriter = new StreamWriter(networkStram);
                    SendMessage(buff, ref tWriter);
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
            catch(Exception e)
            {
                MessageBox.Show("UpdateOnlineList.cs; Line: 137;Can't write into netstream" + e.Message);
            }
        }
    }
}
