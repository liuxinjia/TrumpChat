using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.NetDealer;

namespace WindowsFormsApp1
{
    public partial class loginForm : Form
    {
        public static readonly FormMain mainForm = new FormMain();

        public loginForm()
        {
            InitializeComponent();
            autoCompleteName();
            if (!checkDataBaseExists())
            {
                generateDataBase();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginControl11_Load(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //if (CheckUserDate() == false) { return; }
            string User_Name = nameTbox.Text;
            string password = pwTbox.Text;
            if (verifyExistence(User_Name,password) == false) { return; }

            string query = @"select *from user where User_name = '" + User_Name + "';";
            ArrayList list = User.SelectQueryReader(query);
            if (list.Count != 1) { return; }

            User me = (User)list[0];
            Login.localUser = new Client(me);

            FormMain mainForm = new FormMain();
            mainForm.Show();
            this.Visible = false;
            this.Enabled = false;
        }

        private void updateRecentUser(User localUser)
        {
            string query = "SELECT * FROM tchat.recentuser WHERE nickname = '" +  localUser.NickName + "'; ";

            if (User.RunQuery(query, QueryEnum.Scalar) == userErrorType.Exists)
                return;

            string updateQuery = "SELECT * FROM tchat.recentuser;";
            User.UpdateQueryAdapter(updateQuery, localUser);
        }
        private void autoCompleteName()
        {
            string query = "SELECT * FROM tchat.recentuser;";

            ArrayList recentUser = User.SelectQueryReader(query);

            if (recentUser.Count == 0)
                return;

            User user = (User)recentUser[0];

            nameTbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            nameTbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collumn = new AutoCompleteStringCollection();

            if (user.ErrorType == userErrorType.Notexists)
            {
                new Alert("Not user exists", AlertType.warning);
            }
            else
            {
                for (int i = 0; i < recentUser.Count; i++)
                {
                    user = (User)recentUser[i];
                    collumn.Add(user.User_name);
                }
            }

            nameTbox.AutoCompleteCustomSource = collumn;
        }
        private bool checkDataBaseExists()
        {
            string MySQLConnectionString = "server=127.0.0.1;user id=root;password=Kobe1997911;" +
            "persistsecurityinfo=True;database=tchat";

            MySqlConnection dataBaseConnection = new MySqlConnection(MySQLConnectionString);

            try
            {
                dataBaseConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't connect with dataBase. " + e.Message);
                return false;
            }

            return true;
        }
        private void generateDataBase()
        {
            if (!File.Exists(Application.StartupPath + "\\CreateTables.sql"))
            {
                MessageBox.Show("Can't find the CreateTables.sql");
                return;
            }

            string line = "";
            string cmd = "";
            TextReader tReader = new StreamReader(Application.StartupPath + "\\CreateTables.sql");

            while ((line = tReader.ReadLine()) != null)
            {
                cmd += line;
            }

            if (cmd.Length > 0)
            {
                User.RunQuery(cmd, QueryEnum.NonQuery);
            }
        }
        private bool CheckUserDate()
        {
            int y_Top = 0;
            int x_Left = 0;
            x_Left = this.Bounds.Width / 2;
            y_Top = this.Bounds.Height / 2 - 20;

            string User_Name = nameTbox.Text;
            string password = pwTbox.Text;

            string selectAll = @"select count(*) from user";
            QueryEnum q = QueryEnum.Scalar;
            if (User.RunQuery(selectAll, q) == userErrorType.Notexists)
            {
                Alert.show("Congratulations! You are our first user", AlertType.success,x_Left, y_Top);
            }

            string selectName = @"select* from user where User_name  = '" + User_Name + "';";
            q = QueryEnum.Reader;

            userErrorType loginErrorType = userErrorType.Notexists;
            loginErrorType = User.RunQuery(selectName, q, password);
            if (loginErrorType == userErrorType.Notexists)
            {
                LoginUp register = new LoginUp();
                register.Show();
                x_Left = register.Bounds.Width / 4;
                y_Top = register.Bounds.Height / 4 - 20;
                Alert.show("Please login up first!", AlertType.info, x_Left, y_Top);
                this.Visible = false;
                this.Enabled = false;
                return false;
            }
            else if (loginErrorType == userErrorType.Password)
            {
                Alert.show("Error: The keyword your enter does not fit", AlertType.error, x_Left, y_Top);
                return false;
            }

            Alert.show("Welcome Back!", AlertType.success, x_Left, y_Top);
            return true;
        }

        public bool verifyExistence(string userName, string password = null)
        {
            int y_Top = 0;
            int x_Left = 0;

            ConnectTCP hostServer = new ConnectTCP(IPAddress.Parse(Client.hostIPAddress));

            string verification = "Username:" + userName + ";password:" + password + ";End;";
            Byte[] bytesSend = Encoding.Default.GetBytes(verification);
            hostServer.SendMessage(bytesSend);

            string verifyResult = Encoding.Default.GetString(hostServer.receiveMessage());
            if (verifyResult == new UserErrorTypeString(userErrorType.Notexists).ErrorTypeString)
            {
                LoginUp register = new LoginUp();
                register.Show();
                Alert.show("Please login up first!", AlertType.info, x_Left, y_Top);
                this.Visible = false;
                this.Enabled = false;
                return false;
            }
            else if (verifyResult == new UserErrorTypeString(userErrorType.Password).ErrorTypeString)
            {
                Alert.show("Error: The keyword your enter does not fit", AlertType.error, x_Left, y_Top);
                return false;
            }

            Alert.show("Welcome Back!", AlertType.success, x_Left, y_Top);
            return true;

        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            LoginUp register = new LoginUp();
            register.Show();
            this.Visible = false;
            this.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string checkMessage = "Amigo, I remember you!";
            new Alert(checkMessage, AlertType.success).Show();

            rememberPassword();
        }

        private bool rememberPassword()
        {
            string name = nameTbox.Text;
            string password = name;
            string query = @"select User_password from tchat.localuser where user_name = '" + name + "';";

            if (!User.SelectQueryAdapter(query, ref password, QueryEnum.Scalar))
            {
                return false;
            }

            if (password != "")
                pwTbox.Text = password;
            else
            {
                //new Alert("Sorry, what the fuck are you", AlertType.warning);
                //MessageBox.Show("Sorry, what the fuck are you");
                return false;
            }

            return true;
        }

        private void pwTbox_MouseEnter(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                rememberPassword();
            }
        }

        private void nameTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (checkBox1.Checked == true)
                {
                    if (!rememberPassword())
                    {
                        new Alert("Sorry, what the fuck are you", AlertType.warning).Show();
                    }
                }
            }
        }
    }
}
