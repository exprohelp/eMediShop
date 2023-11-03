using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ExPro.Server;
using ExPro.Client;
namespace eMediShop
{
    public partial class ConnectRemoteServer : UserControl
    {
        public ConnectRemoteServer()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Checking Internet Connection ..";
            string InetOk = CheckInternet.CheckNet();
            if (InetOk != "TRUE")
            {
                lblMessage.Text = "Internet Connection Not Available. Check and Try Again.";
            }
            else {
                lblMessage.Text = "Internet Connection Found. Ready to Work.";
            }
        }
    }
}
