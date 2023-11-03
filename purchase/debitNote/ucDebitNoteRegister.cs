using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Telerik.WinControls;
using Microsoft.Reporting.WinForms;

namespace eMediShop.purchase.debitNote
{
    public partial class ucDebitNoteRegister : UserControl
    {
        string _jsonString = string.Empty; string _result = string.Empty; String _debitNoteNo = string.Empty;
        Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
        public ucDebitNoteRegister()
        {
            InitializeComponent();
        }

        private void ucCreditNoteRegister_Load(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today; rdp_to.Value = DateTime.Today;
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "DebitNoteRegister";
                p.prm_1 = rdp_from.Value.ToString("yyyyMMdd"); p.prm_2 = rdp_to.Value.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                rgv_summary.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }


        }

        private void rgv_summary_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _debitNoteNo = e.Row.Cells["DebitNote_No"].Value.ToString();
                radGroupBox1.Text = _debitNoteNo + " [" + e.Row.Cells["vendor_name"].Value.ToString() + "]";
                btnestimate.Visible = true;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "DebitNoteDetail";
                p.Note_No = _debitNoteNo; p.prm_2 = rdp_to.Value.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                rgv_detail.DataSource = dwr.result.Tables[0];
                rpv_CreditNoteMaster.Pages[1].Select();

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnestimate_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "DebitNote:Slip";
                p.Note_No = _debitNoteNo; p.prm_2 = "-";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);
                ds = dwr.result;

                if (MessageBox.Show("Is Your Printer Ready? ", "Debit Note Slip", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Printing.Laser.Gr_Slip(ds.Tables[1], _debitNoteNo, ds.Tables[0].Rows[0]["gr_date"].ToString(), ds.Tables[0].Rows[0]["gst_no"].ToString(),
                        ds.Tables[0].Rows[0]["vendor_name"].ToString(), ds.Tables[0].Rows[0]["vend_Address"].ToString(), ds.Tables[0].Rows[0]["compGSTNO"].ToString());
                }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnInternalSheet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Printing.Laser.DebitNoteInternalSheet(_debitNoteNo, "Print");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }
    }
}
