using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public enum AlertType
    {
        success, info, warning, error
    }

    public partial class Alert : Form
    {
        public Alert(string _message, AlertType type)
        {
            InitializeComponent();

            message.Text = _message;
            switch (type)
            {
                case AlertType.success:
                    this.BackColor = Color.LimeGreen;
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    this.BackColor = Color.SkyBlue;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.warning:
                    this.BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[2];
                    break;
                case AlertType.error:
                    this.BackColor = Color.PaleVioletRed;
                    icon.Image = imageList1.Images[3];
                    break;
            }
        }
        public static void show(string message, AlertType type, int x, int y)
        {
            Alert alert = new WindowsFormsApp1.Alert(message, type);
            alert.SetAlertPosition(x, y);
            alert.Show();
        }

        private void SetAlertPosition(int x, int y)
        {
            this.Top = y;
            this.Left = x;
        }
        private void Alert_Load(object sender, EventArgs e)
        {
            timerAttenuate.Start();
        }

        private void timerOut_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerAttenuate_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.02;
            }
            else
            {
                this.Close();
            }
        }
    }
}
