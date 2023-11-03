using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.ServiceProcess;
namespace eMediShop
{
    public partial class StartOnLineSale : Form
    {
        public StartOnLineSale()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartService("SalesUpdater", 10000);
            button1.Enabled = false;
            button2.Enabled = true;
            this.Text = "Auto Sales Transfer Service " + CheckServiceStatus();
        }
        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {

                TimeSpan timeout=TimeSpan.FromMilliseconds(timeoutMilliseconds);
                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                MessageBox.Show("Service is Started","About Service");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout=TimeSpan.FromMilliseconds(timeoutMilliseconds);
                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped,timeout);
                MessageBox.Show("Service is Stopped","About Service");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static void RestartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch
            {
                // ...
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StopService("SalesUpdater", 10000);
               this.Text = "Auto Sales Transfer Service "+CheckServiceStatus();
               button1.Enabled = true;
               button2.Enabled = false; 
        }
        private void StartOnLineSale_Load(object sender, EventArgs e)
        {
            this.Text = "Auto Sales Transfer Service " + CheckServiceStatus();
            if (this.Text == "Auto Sales Transfer Service Running")
            {
                button1.Enabled = false;
                button2.Enabled = true; 
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = false; 
            }
        }

        private string CheckServiceStatus() {
            ServiceController service = new ServiceController("SalesUpdater");
           return   service.Status.ToString();
        }
    }
}
