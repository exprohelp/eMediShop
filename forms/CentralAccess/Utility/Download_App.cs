using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class Download_App : Form
    {
        
        int count = 0;
        byte[] _data;
        public 
        Download_App()
        {
            InitializeComponent();
        }
        private void cmdDownload_Click(object sender, EventArgs e)
        {
            label1.Text ="Downloading...";
            pbDownload.Visible = true;
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _data = GlobalUsage.pharmacy_proxy.DownLoadFile("Application\\eMediShop.zip");
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Stop();
            if (_data.Length > 0)
            {
                FolderBrowserDialog Fbd = new FolderBrowserDialog();
                Fbd.ShowDialog();
                string path = Fbd.SelectedPath + "\\" + "eMedishop.zip";
                File.WriteAllBytes(path, _data);
            }
            pbDownload.Visible = false;
            label1.Text = "Download  Successfully";
            cmdDownload.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count >= 1)
            {
                label1.Text = "UPDATED :  " + count.ToString();
            }
        }

        private void FrmDownload_Load(object sender, EventArgs e)
        {

        }
     
    }
}
