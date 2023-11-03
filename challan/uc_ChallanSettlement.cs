using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.challan
{
    public partial class uc_ChallanSettlement : UserControl
    {
        DataTable _dtChallan = new DataTable();
        DataTable _dtPurchase = new DataTable();
        string _challanID = string.Empty;
        public uc_ChallanSettlement()
        {
                 
            InitializeComponent();
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _challanID = rgvPending.CurrentRow.Cells["challan_no"].Value.ToString();
            rgb_ChallanInfo.Text = rgvPending.CurrentRow.Cells["challan_no"].Value.ToString()+"-"+rgvPending.CurrentRow.Cells["vendor_name"].Value.ToString();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = rgvPending.CurrentRow.Cells["challan_no"].Value.ToString(); p.logic = "ChallanInfo";
                p.prm_1 = rgvPending.CurrentRow.Cells["challan_no"].Value.ToString(); p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ChallanQueries", p);
                rgvChallanInfo.DataSource = dwr.result.Tables[1];
                _dtChallan=dwr.result.Tables[1].Copy();
                for (int i = 1; i < this.rgvChallanInfo.Columns.Count; i++)
                {
                    this.rgvChallanInfo.Columns[i].BestFit();
                }
            }
            catch (Exception ex) { RadMessageBox.Show("Check Internet Connection.", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "Pending";
                p.prm_1 = "-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ChallanQueries", p);
                rgvPending.DataSource = dwr.result.Tables[0];
               
            }
            catch (Exception ex) { RadMessageBox.Show("Check Internet Connection.", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnPurchVerify_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = txtPurchaseId.Text; p.logic = "PurchBillInfo";
                p.prm_1 = "-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                rgvPurchaseInfo.DataSource = dwr.result.Tables[0];
                _dtPurchase = dwr.result.Tables[0].Copy();
                for (int i = 1; i < this.rgvPurchaseInfo.Columns.Count; i++)
                {
                    this.rgvPurchaseInfo.Columns[i].BestFit();
                }
                if (rgvChallanInfo.RowCount > 0 && rgvPurchaseInfo.RowCount > 0)
                {
                    btn_match.Enabled = true;
                }
                else { btn_match.Enabled = false; }
                    
            }
            catch (Exception ex) { RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_match_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (rgvChallanInfo.RowCount == rgvPurchaseInfo.RowCount)
                {
                    var updRec = from c in _dtChallan.AsEnumerable()
                                 join p in _dtPurchase.AsEnumerable()
                                 on new { x1 = c.Field<string>("item_id"), x2 = c.Field<string>("batch_no") } equals new { x1 = p.Field<string>("item_id"), x2 = p.Field<string>("batch_no") } 
                                 //on  c.Field<string>("item_id")+ c.Field<string>("batch_no") equals p.Field<string>("item_id")+ p.Field<string>("batch_no")
                                 where (c.Field<string>("item_id") !=p.Field<string>("item_id")) ||(c.Field<decimal>("quantity") !=p.Field<decimal>("qty") || c.Field<string>("batch_no") != p.Field<string>("batch_no"))
                                 select new
                                 {
                                     prim_key = c.Field<string>("item_id"),
                                     ChallanQty = c.Field<decimal>("quantity"),
                                     PurchaseQty = p.Field<decimal>("qty"),
                                 };
                    if (updRec.Count() > 0)
                        MessageBox.Show("Mismatch");
                    else
                        btnSettlement.Enabled = true;
                }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnSettlement_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_ChallanSettlement p = new pm_ChallanSettlement();
                p.unit_id = GlobalUsage.Unit_id; p.purchase_id = txtPurchaseId.Text;
                p.challan_id = _challanID; p.login_id =GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/ChallanSettlement", p);
                if (!dwr.message.Contains("Success"))
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                else
                {
                    rgvChallanInfo.DataSource = new { };
                    rgvPurchaseInfo.DataSource = new { };

                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info);}
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
