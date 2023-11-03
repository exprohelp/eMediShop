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

namespace eMediShop.purchase.debitNote
{
    public partial class ucInterCompany_DebitNoteImport : UserControl
    {
        bool isMyKeyAvailable = true;string _debitNoteNo = string.Empty;
        public ucInterCompany_DebitNoteImport()
        {
            InitializeComponent();
        }

        private void btngetDebitNote_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "List:DebitNote"; p.Note_No = "-"; p.vendor_id = "-"; p.searchkey = "-";
                p.prm_1 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                rgv_debitNotes.DataSource = dwr.result.Tables[0];
               
               
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
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _debitNoteNo = e.Row.Cells["debitnoteno"].Value.ToString();
                rgb_info.Text = _debitNoteNo;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.logic = "List:ForCreditNote"; p.Note_No = _debitNoteNo;
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
                if (e.RowElement.RowInfo.Cells["referenceNo"].Value.ToString().Length < 8)
                { 
                    e.RowElement.ForeColor = Color.Red;
                    isMyKeyAvailable = false;
                }
                else {
                    e.RowElement.ForeColor = Color.Green;
                    if(isMyKeyAvailable)
                        btnGenerate.Enabled = true;
                }
            }
            catch (Exception ex) { }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.prm_1 = "-"; p.Note_No = _debitNoteNo;
                p.vendor_id = "-"; p.searchkey = "-";
                
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteGenerateForInterCompany", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                if (dwr.message.Contains("Success"))
                {
                    rgv_debitNotes.CurrentRow.Delete();
                    rgv_products.DataSource = new string[] { };
                    btnGenerate.Enabled = false;
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
    }
}
