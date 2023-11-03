using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.RCM
{
    public partial class ucNextSchedule : UserControl
    {
        string _lastRemark = string.Empty; string _card_no = string.Empty; string _result = string.Empty;
        public ucNextSchedule(string lastremark,string card_no)
        {
            _lastRemark = lastremark; _card_no = card_no;
            InitializeComponent();
        }

        private void btnOnCallSave_Click(object sender, EventArgs e)
        {
            
            try
            {
            if(txtRemark.Text.Trim().Length>5)
            {
                Cursor.Current = Cursors.WaitCursor; 
                string msg = GlobalUsage.pharmacy_proxy.RCCreateData(_card_no, dtNextCalldate.Value.ToString("yyyy/MM/dd"), cmbNextCalltime.SelectedItem.ToString(), GlobalUsage.Unit_id, txtRemark.Text, "", GlobalUsage.Login_id, "OnCallEntry");
                if (msg.Contains("Success"))
                {
                    GlobalUsage.pharmacy_proxy.Insert_CustCall_Log(out _result, 0, _card_no, "Scheduled", GlobalUsage.Login_id, txtRemark.Text, "Insert");
                }
                MessageBox.Show(msg,"ExPro Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            { 
                MessageBox.Show("Remark is mandatory", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"ExPro Help",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
      
        }

        private void ucNextSchedule_Load(object sender, EventArgs e)
        {
            txtRemark.Text = _lastRemark;
            dtNextCalldate.MinDate = DateTime.Today;
            dtNextCalldate.Value = DateTime.Today;
        }
    }
}
