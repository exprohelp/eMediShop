using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace eMediShop.Hospital
{
    public partial class ucIndentChecking : UserControl
    {
        string _indentNo = string.Empty; string _SalesInvNo = string.Empty;
        public ucIndentChecking()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.from = "1900/01/01"; p.to = "1900/01/01"; p.card_no = "-"; p.uhid = "-";
                p.IPOPNo = txtIndentNo.Text; p.logic = "Indent-Check";

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                rgv_Info.DataSource = dwr.result.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }
        }

        private void rgv_Info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _indentNo = e.Row.Cells["indent_no"].Value.ToString();
                string trnNo = e.Row.Cells["trn_no"].Value.ToString();

                if (e.Row.Cells["proctype"].Value.ToString() == "SoldToOtherCompany")
                {
                    //                    SoldToOtherCompany
                    var s = rgv_Info.Rows.AsEnumerable().Where(x => x.Cells["indent_no"].Value.ToString() == _indentNo && x.Cells["proctype"].Value.ToString() == "SoldToOtherCompany").Select(y => new { inv = y.Cells["trn_no"].Value.ToString() }).First();
                    _SalesInvNo = s.inv;
                    var t = rgv_Info.Rows.AsEnumerable().Where(x => x.Cells["indent_no"].Value.ToString() == _indentNo && x.Cells["trn_no"].Value.ToString().Length == 0).Count();

                    if (t == 2)
                        btnProcessSales.Enabled = true;
                    else
                        btnProcessSales.Enabled = false;
                }
                else
                    btnProcessSales.Enabled = false;

                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.from = "1900/01/01"; p.to = "1900/01/01"; p.card_no = "-"; p.uhid = "-";
                p.IPOPNo = _indentNo; p.logic = "IndentDisplay"; p.prm_1 = e.Row.Cells["proctype"].Value.ToString();
                datasetWithResult dwr;
                dwr= ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                rgvIndent.DataSource = dwr.result.Tables[0];
                foreach (GridViewColumn column in rgvIndent.Columns) { column.BestFit(); }

                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.from = "1900/01/01"; p.to = "1900/01/01"; p.card_no = "-"; p.uhid = "-";
                p.IPOPNo = e.Row.Cells["trn_no"].Value.ToString(); p.logic = "Bill-Verify"; p.prm_1 = e.Row.Cells["proctype"].Value.ToString();
                dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                if (dwr.result.Tables[1].Rows.Count == 0)
                    btnReleaseIndent.Visible = true;
                else
                    btnReleaseIndent.Visible = false;

                if (p.prm_1.Contains("Sold"))
                {
                    rgv_detail.DataSource = dwr.result.Tables[1];
                    foreach (GridViewColumn column in rgv_detail.Columns){column.BestFit();}
                    rgv_Header.DataSource = dwr.result.Tables[0];
                    foreach (GridViewColumn column in rgv_Header.Columns) { column.BestFit(); }
                    
                }
                else
                {
                    rgv_detail.DataSource = dwr.result.Tables[0];
                    foreach (GridViewColumn column in rgv_detail.Columns) { column.BestFit(); }
                    rgv_Header.DataSource = dwr.result.Tables[1];
                    foreach (GridViewColumn column in rgv_Header.Columns) { column.BestFit(); }
                }
                
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }
        }

        private void btnProcessSales_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnProcessSales.Enabled = false;
                pm_IPOPQueries p = new pm_IPOPQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.from = "1900/01/01"; p.to = "1900/01/01"; p.card_no = "-"; p.uhid = "-";
                p.IPOPNo = _indentNo; p.logic = "IndentSaleProcess"; p.prm_1 = _SalesInvNo;

                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", p);
                rgv_Info.DataSource = dwr.result.Tables[0];
              
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }
        }

        private void ucIndentChecking_Load(object sender, EventArgs e)
        {

        }

        private void btnReleaseIndent_Click(object sender, EventArgs e)
        {
            if (rgv_Info.CurrentRow.Cells["proctype"].Value.ToString() != "Estimate")
            {
                RadMessageBox.Show("Click on Estimate Option Row.", "ExPro Help", MessageBoxButtons.OK);
                return;
            }
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm  to Release Indent?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p1 = new cm1();
                    p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                    p1.prm_1 = "-"; p1.prm_2 = "-";
                    p1.Logic = "Indent-Release"; p1.tran_id = rgv_Info.CurrentRow.Cells["trn_no"].Value.ToString();
                    p1.prm_3 = "-"; p1.prm_4 = "-";
                    p1.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                    radButton1.PerformClick();
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
