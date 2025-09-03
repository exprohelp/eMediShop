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
using Telerik.WinControls.UI;
using eMediShop.Properties;
using Telerik.WinControls.UI.Export;

namespace eMediShop.purchase.debitNote
{
    public partial class ucMapByCreditNote : UserControl
    {
        bool isMyKeyAvailable = true; string _debitNoteNo = string.Empty; string _adjustentType = string.Empty;
        string _masterkeyid = string.Empty; decimal _qty = 0; string _autoid = string.Empty;
        Dictionary<string, string> adjustmentType = new Dictionary<string, string>();
        public ucMapByCreditNote()
        {
            InitializeComponent();
        }

        private void btngetDebitNote_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "List:Un-Adjusted"; p.Note_No = "-"; p.vendor_id = "-"; p.searchkey = "-";
                p.prm_1 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                rgv_debitNotes.DataSource = dwr.result.Tables[0];
                adjustmentType.Clear();


                foreach (DataRow dr in dwr.result.Tables[1].Rows)
                {
                    adjustmentType.Add(dr["title_name"].ToString(), dr["title_name"].ToString());
                }
                cmbAdjtype.DataSource = new BindingSource(adjustmentType, null);
                cmbAdjtype.DisplayMember = "value";
                cmbAdjtype.ValueMember = "Key";
                cmbAdjtype.SelectedValue = "Select";

                rdbCNDate.MinDate = Convert.ToDateTime(dwr.result.Tables[2].Rows[0]["minDate"].ToString());
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

        private void rgv_debitNotes_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _debitNoteNo = e.Row.Cells["debitnoteno"].Value.ToString();
            RefreshDebitNoteInfo(_debitNoteNo);
        }

        private void RefreshDebitNoteInfo(string debitNoteInfo)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                rgb_info.Text = _debitNoteNo;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "List:ForCreditNote"; p.Note_No = debitNoteInfo;
                p.vendor_id = "-"; p.searchkey = "-";
                p.prm_1 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                rgv_products.DataSource = dwr.result.Tables[0];


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

        private void rgv_products_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            try
            {
                if (e.RowElement.RowInfo.Cells["adjustmenttype"].Value.ToString().Length < 8)
                {
                    e.RowElement.ForeColor = Color.Green;
                    isMyKeyAvailable = false;
                }
                else
                {
                    e.RowElement.ForeColor = Color.Red;
                    if (isMyKeyAvailable)
                        btnSubmit.Enabled = true;
                }
            }
            catch (Exception ex) { }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void cmbAdjtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            _adjustentType = ((KeyValuePair<string, string>)cmbAdjtype.SelectedItem).Value;
            lblOption.Text = _adjustentType;
            //if (_adjustentType == "Credit Note" || _adjustentType == "Adjusted In Bill")
                rgb_creditNoteInfo.Visible = true;
            //else
            //    rgb_creditNoteInfo.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            #region Validation

            if (cmbAdjtype.Text.ToUpper()=="SELECT")
            {
                RadMessageBox.Show(cmbAdjtype.Text + " Not In Adjustment Type.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }

            if (!adjustmentType.ContainsKey(cmbAdjtype.Text))
                {
                    RadMessageBox.Show(cmbAdjtype.Text + " Not In Adjustment Type.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    return;
                }
                if (_qty < 0)
                {
                    RadMessageBox.Show("Select Positive Value", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    return;
                }
                if (rgb_creditNoteInfo.Visible)
                {
                    if (txtCNNo.Text.Length < 4)
                    {
                        RadMessageBox.Show("Type Credit Note/Bill/Estimate No.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        return;
                    }

                }
            
            #endregion
            pm_debitCreditNotes p = new pm_debitCreditNotes();
            datasetWithResult dwr;
            foreach (GridViewRowInfo gvi in rgv_products.Rows)
            {
                if (gvi.Cells["chk"].Value.ToString() == "1" && gvi.Cells["adjType"].Value.ToString() == "-")
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _qty= Convert.ToDecimal(gvi.Cells["qty"].Value);
                        _masterkeyid = gvi.Cells["master_key_id"].Value.ToString();
                        p.unit_id = GlobalUsage.Unit_id; p.prm_1 = "-"; p.Note_No = _debitNoteNo;
                        p.master_key_id = _masterkeyid;
                        p.qty = _qty;
                        p.logic = _adjustentType;
                        p.creditNote_Date = rdbCNDate.Value.ToString("yyyy/MM/dd"); p.creditNote_No = txtCNNo.Text;
                        p.autoId = gvi.Cells["auto_id"].Value.ToString();
                        p.vendor_id = "-"; p.searchkey = "-"; p.login_id = GlobalUsage.Login_id;

                        dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteMapping", p);
                        //RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        if (dwr.message.Contains("Success"))
                        {
                            rgv_products.CurrentRow.Cells["adjType"].Value = "Success";
                            _masterkeyid = ""; _qty = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ExPro Help");
                    }
                    finally
                    {
                        btnSubmit.Enabled = false;
                        Cursor.Current = Cursors.Default;
                    }
                }

            }
            RefreshDebitNoteInfo(_debitNoteNo);


        }

        private void rgv_products_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            gb.Text = e.Row.Cells["item_name"].Value.ToString() + "::" + e.Row.Cells["master_key_id"].Value.ToString() + "::" + e.Row.Cells["qty"].Value.ToString();
            btnSubmit.Enabled = true;
            _masterkeyid = e.Row.Cells["master_key_id"].Value.ToString();
            _qty = Convert.ToDecimal(e.Row.Cells["qty"].Value.ToString());
            txtPackType.Text = e.Row.Cells["pack_type"].Value.ToString();
            txtPackQty.Text = e.Row.Cells["pack_qty"].Value.ToString();
            radTextBox1.Text = e.Row.Cells["auto_id"].Value.ToString();
            rgbSplit.Visible = true;
            rgbSplit.Text = "Split : " + e.Row.Cells["item_name"].Value.ToString() + ", Qty:" +Convert.ToInt16(e.Row.Cells["qty"].Value).ToString();
            txtSplitQty.Focus();
        }

        private void ucMapByCreditNote_Load(object sender, EventArgs e)
        {
            rdbCNDate.Value = DateTime.Today;
        }

        private void MasterTemplate_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "cmd")
                {
                    ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    if (e.CellElement.RowInfo.Cells["adjType"].Value.ToString() == "-")
                    {
                        ((GridCommandCellElement)e.CellElement).CommandButton.Image = Resources.split16;
                        ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    }
                }
            }
            if (e.CellElement.ColumnIndex == 1)
            {
                if (this.rgv_products.CurrentRow.Cells["chk"].Value.ToString() == "1")
                {
                    e.CellElement.ColumnInfo.ReadOnly = true;
                }
                else
                {
                    e.CellElement.ColumnInfo.ReadOnly = false;
                }
            }
        }

        private void MasterTemplate_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtSplitQty.Text) == _qty)
            {
                RadMessageBox.Show("Split Quantity Can Not Be Same.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            if ((Convert.ToDecimal(txtSplitQty.Text) % Convert.ToDecimal(txtPackQty.Text) != 0))
            {
                RadMessageBox.Show("Split Qty should be in multiple of packs.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }
            if (Convert.ToDecimal(txtSplitQty.Text) == 0)
            {
                RadMessageBox.Show("Split Qty should not be 0.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.Note_No = _debitNoteNo;
                p.autoId = radTextBox1.Text; p.qty = Convert.ToDecimal(txtSplitQty.Text);
                p.vendor_id = "-"; p.searchkey = "-"; p.login_id = GlobalUsage.Login_id;

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteSplitRecord", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                if (dwr.message.Contains("Success"))
                {
                    rgbSplit.Visible = false;
                    RefreshDebitNoteInfo(_debitNoteNo);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.rgbSplit.Visible = false;
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            ExportToExcelML exporter = new ExportToExcelML(this.rgv_debitNotes);
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            exporter.ExportVisualSettings = true;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                exporter.RunExport(fd.SelectedPath + "\\PendingDN_Mapping.xls");
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
