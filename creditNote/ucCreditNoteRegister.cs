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

namespace eMediShop.creditNote
{
    public partial class ucCreditNoteRegister : UserControl
    {
        string _jsonString = string.Empty;string _result = string.Empty;String _creditNoteNo = string.Empty;
        Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
        public ucCreditNoteRegister()
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
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "CreditNoteRegister";
                p.prm_1 = rdp_from.Value.ToString("yyyyMMdd"); p.prm_2 = rdp_to.Value.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);
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
                _creditNoteNo = e.Row.Cells["CreditNote_No"].Value.ToString() ;
                radGroupBox1.Text = _creditNoteNo + " [" + e.Row.Cells["customer_name"].Value.ToString() + "]";
                btnestimate.Visible = true;
                pm_debitCreditNotes p = new pm_debitCreditNotes();
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "CreditNoteDetail";
                p.prm_1 = e.Row.Cells["CreditNote_No"].Value.ToString(); p.prm_2 = rdp_to.Value.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);

              
                rgv_detail.DataSource = dwr.result.Tables[0];
                radPageViewPage2.Select();
               
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
                p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "CreditNoteDetail";
                p.prm_1 = _creditNoteNo; p.prm_2 = "-";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/CreditNoteQueries", p);
                ds = dwr.result;

                eMediShop.PrintMaster.rdlcViewer obj = new PrintMaster.rdlcViewer(ds,"Credit Note Pronting", @"rdlc\CreditNote.rdlc","Credit Note");
                obj.Show();
          
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
