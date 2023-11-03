using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using System.Runtime;
using System.Runtime.InteropServices;
namespace eMediShop
{
    public partial class NetStatus : UserControl
    {
        bool connected = true;
        int i = 1;
        public NetStatus()
        {
            InitializeComponent();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
                timer1.Start();
                timer1.Enabled = true;
            }
            else
                MessageBox.Show("You can not Switch another task when Running task is not completed");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(connected)
            {
                label1.Text = "Internet Connection Active";
                //pictureBox1.Image = eMediShop.Properties.Resources.green;
                //pictureBox1.Refresh();
                GlobalUsage.NetConnected = true;
            }
            else
            {
                GlobalUsage.NetConnected = false; 
                //pictureBox1.Image = eMediShop.Properties.Resources.red;
                //pictureBox1.Refresh();
                label1.Text = "Internet Connection Disconnected";
                label1.Refresh();
            }
          }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                //System.Uri Url = new System.Uri("http://www.microsoft.com");
                //System.Net.WebRequest WebReq = System.Net.WebRequest.Create(Url);
                //AsyncCallback asyncCall = new AsyncCallback(CallbackSampleMethod);
                //WebReq.BeginGetResponse(asyncCall,WebReq);
                System.Threading.Thread.Sleep(500);
                if (CheckInternet.CheckNet() == "TRUE")
                    connected = true;
                else
                    connected = false;
            }
            while (i != -1);
        }
        private void CallbackSampleMethod(IAsyncResult asyncResult)
        {
            System.Net.WebRequest  WebReq =(System.Net.WebRequest)asyncResult.AsyncState;
            System.Net.WebResponse Resp;
            try
            {
                Resp = WebReq.EndGetResponse(asyncResult);
                Resp.Close();
                WebReq = null;
                connected=true;
            }
            catch
            {
                WebReq = null;
                connected=false;
            }
         }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
