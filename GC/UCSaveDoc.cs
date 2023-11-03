using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace eMediShop
{
    public partial class UCSaveDoc : UserControl
    {
         
        OpenFileDialog dlg = new OpenFileDialog();
        string _RegNo = "";
        string _remark = "";
        string _Msg = "";
        string _DocId = "";
        public  UCSaveDoc()
        {
            InitializeComponent();
        }
        public string DocId
        {
            get { return _DocId; }
            set { _DocId = value; }
        }
        public string RegNo
        {
            get { return _RegNo; }
            set { _RegNo = value; }
        }
        private void UCSaveDoc_Load(object sender, EventArgs e)
        {
            txtDocId.Text=_DocId;
            groupBox1.Text = _RegNo;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
            txtpath.Text=dlg.FileName;
            lblSize.Text=getFileSize(File.ReadAllBytes(dlg.FileName).Length);
        }
        private string getFileSize(long totalbyteCount)
        {
            string size = "0 Bytes";
            if (totalbyteCount >= 1073741824)
            {
               size=String.Format("{0:##.##} ", totalbyteCount / 1073741824) + " GB";
               MessageBox.Show("Maximum 5 MB file is allowed");  
            }
            else if (totalbyteCount >= 1048576)
            {
               size=String.Format("{0:##.##}", totalbyteCount / 1048576) + " MB";
               if(totalbyteCount/1048576>5)
               MessageBox.Show("Maximum 5 MB file is allowed");
            }
            else if(totalbyteCount>=1024)
               size=String.Format("{0:##.##}", totalbyteCount / 1024) + " KB";
            return size;
        }
   
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _remark = txtRemark.Text;
                if(dlg.FileName.Length > 0)
                {
                      pictureBox1.Visible = true;
                      if(!backgroundWorker1.IsBusy)
                      backgroundWorker1.RunWorkerAsync();
                }
                else
                { MessageBox.Show("Please browse file name"); }

            }
            catch(Exception ex){MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                  string[] t = dlg.FileName.Split('\\');
                 _Msg =GlobalUsage.pharmacy_proxy.GC_InsDocInfo(txtDocId.Text,"Diagnostic",t[t.Length - 1],_remark,"01",File.ReadAllBytes(dlg.FileName),out _Msg);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible =false;
        }

   
       
    }
}
