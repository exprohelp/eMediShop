using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.RCM
{
    public partial class ucCompleteOrder : UserControl
    {
        string _result = string.Empty;
        public ucCompleteOrder()
        {
            InitializeComponent();
        }
        private void btnGo_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.healthcard_proxy.RCMCall_Report(out _result, "Order_MarkDelivered", dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), GlobalUsage.Unit_id, "N/A");
                rgv_info.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvOrder_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtOrderNo.Text = e.Item.Text;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            btnComplete.Enabled = false;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string result = GlobalUsage.pharmacy_proxy.Mark_OrderDelivered(GlobalUsage.Unit_id, txtOrderNo.Text, dtdeldate.Value.ToString("yyyy/MM/dd"), cmbdeltime.Text, GlobalUsage.Login_id);
                MessageBox.Show(result);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtOrderNo_TextChanged(object sender, EventArgs e)
        {
            if (txtOrderNo.TextLength > 6)
                btnDelay.Enabled = true;
            else
                btnDelay.Enabled = false;
        }

        private void btnDelay_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            eMediShop.forms.CentralAccess.RCM.order_remarks UseForm = new order_remarks(txtOrderNo.Text);
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            txtOrderNo.Text = e.Row.Cells[0].Value.ToString();
            btnComplete.Enabled = true;
        }

        private void ucCompleteOrder_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today;
            dtdeldate.MinDate = DateTime.Today;
        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }
    }
}
