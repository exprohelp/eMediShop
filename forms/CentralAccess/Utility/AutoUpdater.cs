using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace eMediShop
{
    public partial class AutoUpdater : Telerik.WinControls.UI.RadForm
    {
        
        int count = 0;
        byte[] _data;
        public AutoUpdater()
        {
            InitializeComponent();
        }
        private void cmdDownload_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = Application.StartupPath + "\\AutoUpdater\\ExProAutoUpdater.exe";
            string args = GlobalUsage.Login_id.Trim() + " " + Application.ProductName.Trim() + " " + GlobalUsage.Unit_id.Trim() + " " + Application.ProductVersion.Trim() + " " + GlobalUsage.UniqueMachineId;
            p.StartInfo.Arguments = args;
            p.Start();
            Application.Exit();
        }
     
    }
}
