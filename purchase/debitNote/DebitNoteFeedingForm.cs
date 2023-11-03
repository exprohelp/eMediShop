using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.purchase.debitNote
{
    public partial class DebitNoteFeedingForm : Telerik.WinControls.UI.RadForm
    {
        Int16 _StockPacks = 0; string _masterKeyId = string.Empty; string _itemID = string.Empty; string _result = string.Empty;
        Int16 _packqty = 0; 
        DataSet _ds = new DataSet();
        public DebitNoteFeedingForm()
        {
            InitializeComponent();
           
        }

        private void rtb_ProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProdName.Text.Length > 3)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_debitCreditNotes p = new pm_debitCreditNotes();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.logic = "All-Product";
                    p.prm_1 = "-";
                    p.vendor_id = "-"; p.searchkey = txtProdName.Text;

                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                    rgv_info.DataSource = dwr.result.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void rgv_info_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                _StockPacks = Convert.ToInt16(rgv_info.CurrentRow.Cells["packs"].Value.ToString());
                _itemID = rgv_info.CurrentRow.Cells["item_id"].Value.ToString();
                _masterKeyId = rgv_info.CurrentRow.Cells["master_key_id"].Value.ToString();
                _packqty = Convert.ToInt16(rgv_info.CurrentRow.Cells["pack_qty"].Value);
                txtDebitQty.Text = (Convert.ToInt16(rgv_info.CurrentRow.Cells["packs"].Value) * Convert.ToInt16(rgv_info.CurrentRow.Cells["pack_qty"].Value)).ToString();
                txtDebitQty.Focus();
            }
        }

        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                rgv_info.Focus();
                rgv_info.Rows[0].IsSelected = true;
            }
        }

        private void txtDebitQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                decimal res = Convert.ToDecimal(txtDebitQty.Text) % Convert.ToDecimal(_packqty);
                if (res != 0)
                {
                    RadMessageBox.Show("Quantity should be in multiplication of Pack Quantity.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    return;
                }
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (_StockPacks >= Convert.ToInt16(rgv_info.CurrentRow.Cells["packs"].Value.ToString()))
                    {
                        #region Saving Process
                        pm_debitCreditNotes p = new pm_debitCreditNotes();
                        p.unit_id = GlobalUsage.Unit_id; p.Note_No = txtDebitNoteNo.Text; p.vendor_id = "-";
                        p.master_key_id = _masterKeyId;
                        p.qty = Convert.ToInt16(txtDebitQty.Text); p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteTranInsert", p);
                        rgv_products.DataSource = dwr.result.Tables[0];
                        rgv_Vendors.DataSource = dwr.result.Tables[1];
                        if (dwr.result.Tables[0].Rows.Count > 0)
                        {
                            txtDebitNoteNo.Text = dwr.result.Tables[0].Rows[0]["debitnote_no"].ToString();
                            rgv_info.CurrentRow.Delete();
                            txtDebitQty.Text = "0";
                        }
                        else
                        {
                            txtDebitNoteNo.Text = "New Debit Note";
                        }
                        #endregion
                    }
                    else
                    {
                        RadMessageBox.Show("Qty is greater than Stock.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        txtDebitQty.Focus();
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }

            }
        }

        private void DebitNoteFeedingForm_Load(object sender, EventArgs e)
        {
            FillInfo("New Debit Note", "DNT:All", "-");
        }

        private void FillInfo(string debitNoteNo, string logic, string masterkeyid)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.logic = logic; p.Note_No = debitNoteNo;
                p.vendor_id = "-"; p.searchkey = "-";
                p.prm_1 = masterkeyid;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                rgv_products.DataSource = dwr.result.Tables[0];
                rgv_Vendors.DataSource = dwr.result.Tables[1];
                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    txtDebitNoteNo.Text = dwr.result.Tables[0].Rows[0]["debitnote_no"].ToString();
                }
                else
                {
                    txtDebitNoteNo.Text = "New Debit Note";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rgv_products_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You want Confirm?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    FillInfo(txtDebitNoteNo.Text, "DNT:Delete", e.Row.Cells["master_key_id"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rgv_Vendors_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm To Post Debit Note ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    pm_debitCreditNotes p = new pm_debitCreditNotes();
                    p.unit_id = GlobalUsage.Unit_id; p.vendor_id = e.Row.Cells["vendorid"].Value.ToString();
                    p.Note_No = txtDebitNoteNo.Text; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteTranPosting", p);
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    FillInfo(txtDebitNoteNo.Text, "DNT:All", "-");
                    rgv_info.DataSource = new string[] { };
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnInternalsheet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Printing.Laser.DebitNoteInternalSheet(txtDebitNoteNo.Text, "Print");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        private void rgv_products_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            try
            {
                if (btnInternalsheet.Enabled == false)
                    btnInternalsheet.Enabled = true;
            }
            catch (Exception ex) { }
        }

        
    }
}
