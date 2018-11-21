﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public enum QueryEnum { Scalar, NonQuery, Reader }

    public partial class LoginUp : Form
    {

        public LoginUp()
        {
            InitializeComponent();
        }
        private void register1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

           if( UpdateUserTabel())
            {
                this.Dispose();
                this.Close();
                FormMain fMain = new FormMain();
                fMain.Show();
            }
        }

        private bool UpdateUserTabel()
        {
            int y_Top = 0;
            int x_Left = 0;
            x_Left = this.Bounds.Width / 2;
            y_Top = this.Bounds.Height / 2 - 20;

            string User_name = nameTbox.Text;
            string Nick_name = nickTbox.Text;
            string Password = pwTbox.Text;
            
            if (User_name == "")
            {
                Alert.show("The name is empty", AlertType.warning, x_Left, y_Top);
                return false;
            }
            if (Nick_name == "")
            {
                Alert.show("The nickname is empty", AlertType.warning, x_Left, y_Top);
                return false;
            }
            if (Password == "")
            {
                Alert.show("The password is empty", AlertType.warning, x_Left, y_Top);
                return false;
            }
            if (cptTbox.Text == "")
            {
                Alert.show("Please re_enter the password", AlertType.warning, x_Left, y_Top);
                return false;
            }

            if (cptTbox.Text != Password)
            {
                Alert.show("The password is not the same ", AlertType.error, x_Left, y_Top);
                return false;
            }

            string Selectquery = @"SELECT count(*) FROM tchat.user; ";
            int user_ID = 0;
            string returnMessage = "";
            if (!User.SelectQueryAdapter(Selectquery, ref returnMessage, QueryEnum.Scalar))
                return false;
            user_ID = Convert.ToInt32(returnMessage);

            Selectquery = @"select nickName from user
            where nickName  = '" + Nick_name + "';";
            User.SelectQueryAdapter(Selectquery, ref returnMessage, QueryEnum.Reader);
            if (returnMessage == Nick_name)
            {
                Alert.show("Alread has the nickname, choose the other one", AlertType.warning, x_Left, y_Top);
                return false;
            }
            //string Updatequery = @"insert into user
            //values('van Persie', 'Flying DutchMan', 'Robin', '20'); ";

            string Updatequery = @"insert into user values('" + User_name + "',' "
                + Nick_name + "','" + Password + "','" + user_ID.ToString() + "');";
            if (User.UpdateQueryAdapter(Updatequery))
            {
                return true;
            }
            else
                return false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
