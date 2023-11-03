using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.CentralAccess.RCM
{
    public partial class order_remarks : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; 

        public order_remarks(string orderno)
        {
            InitializeComponent();
            txtOrderNo.Text = orderno;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (chkCancelOrder.Checked)
                {
                    string qry = @"exec pRCM_CancelOrder '" + txtOrderNo.Text + "','" + txtRemark.Text + "','eMediShop','" + GlobalUsage.Login_id + "';";
                    string msg = GlobalUsage.pharmacy_proxy.QueryExecute(qry, "customer_data");
                    GlobalUsage.pharmacy_proxy.Insert_OrderRemark(out _result, "Manager", txtOrderNo.Text, txtRemark.Text+"{"+txtOrderNo.Text+"}", GlobalUsage.Login_id);
                }
                else
                {
                    GlobalUsage.pharmacy_proxy.Insert_OrderRemark(out _result, "Manager", txtOrderNo.Text, txtRemark.Text, GlobalUsage.Login_id);
                }
                RadMessageBox.Show(_result, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void order_remarks_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderNo.Text.Length > 4)
                    btnSave.Enabled = true;
                else
                    btnSave.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.pharmacy_proxy.OnlineOrder_Queries(out _result, GlobalUsage.Unit_id, txtOrderNo.Text, "OrderRemarks", "N/A", 0, "OrderRemarks");
                dgRemarks.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void dgRemarks_Click(object sender, EventArgs e)
        {
            txtExistingRemark.Text = dgRemarks.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
