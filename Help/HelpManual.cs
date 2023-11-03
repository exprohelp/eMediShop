using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

public partial class HelpManual : Telerik.WinControls.UI.RadForm
    {
        DataSet ds = new DataSet(); string _result = string.Empty;
        public HelpManual()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                this.radPdfViewer2.UnloadDocument();
                eMediShop.rmAccounts.Accounts_WebServiceSoapClient obj = new eMediShop.rmAccounts.Accounts_WebServiceSoapClient();
                string path ="c:\\softmanuals\\"+Application.ProductName+".pdf";
                byte[] data = obj.DownloadFile(path, out _result);
                using (Stream stream = new MemoryStream(data))
                {
                    this.radPdfViewer2.LoadDocument(new MemoryStream(data));
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
   }

