using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.GC
{
    public partial class ucGC_Legallogin : UserControl
    {
        public ucGC_Legallogin()
        {
            InitializeComponent();
        }

        private void ucGC_Legallogin_Load(object sender, EventArgs e)
        {
            cbxLType.SelectedIndex = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            OpenFileDialog fld = new OpenFileDialog();
            fld.ShowDialog();
            txtPath.Text = fld.FileName;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string _FileName="";
            string _result="";
            byte[] data=null;
            if (txtSubject.Text == "")
            { MessageBox.Show("Please Input Subject");return; }
            if (txtRemark.Text == "")
            { MessageBox.Show("Please Input Remark"); return; }
            if(txtPath.Text.Length>5)
            {
                System.IO.FileInfo fi=new System.IO.FileInfo(txtPath.Text);
               _FileName=fi.Name;
                data=System.IO.File.ReadAllBytes(txtPath.Text);
            }
            try
            {
                GlobalUsage.pharmacy_proxy.GC_LoginlegalInfo(GlobalUsage.Unit_id, txtSubject.Text, cbxLType.Text, txtRemark.Text, _FileName, GlobalUsage.Login_id, data, out _result);
                MessageBox.Show(_result);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }

     
    }
}
