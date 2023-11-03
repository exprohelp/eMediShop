using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class UnPostedBill : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _purchID = string.Empty;
        public UnPostedBill()
        {
            InitializeComponent();
        }

        private void UnPostedBill_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);

        }
        protected void Fill_UnPostedIds()
        {
            pm_PurchaseQueries p = new pm_PurchaseQueries();
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "Pending_Bills"; p.prm_1 = "-"; p.prm_2 = GlobalUsage.Login_id; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

            rgv_info.DataSource = dwr.result.Tables[0];
        }

        private void btnRetrive_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Fill_UnPostedIds();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }

        private void lv_PurchaseIds_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void lv_PurchaseIds_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {


        }
        protected void Fill_IdInfo(string purchId)
        {
            _purchID = purchId;
            pm_PurchaseQueries p = new pm_PurchaseQueries();
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = _purchID; p.logic = "Pending_Bill_Detail"; p.prm_1 = "-"; p.prm_2 = "N/A"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);


            rgv_detail.DataSource = dwr.result.Tables[0];
        }

        private void lv_PurchaseIds_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

            }
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                groupBox1.Text = e.Row.Cells[1].Value.ToString();
                Fill_IdInfo(groupBox1.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You Confirm To Delete (Y/N) ", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_PurchaseDelete p = new pm_PurchaseDelete();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.purch_id = e.Row.Cells["purch_id"].Value.ToString();
                    p.master_key_id = e.Row.Cells["master_key_id"].Value.ToString();p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseDelAllPurchTran", p);
                    _result = dwr.message;
                    if (_result.Contains("Successfully All"))
                    { e.Row.Delete(); rgv_info.CurrentRow.Delete(); }
                    else if (_result.Contains("Successfully"))
                        e.Row.Delete();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
