using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Hospital
{
    public partial class ucIPD_ExtraIn : UserControl
    {
        string _oldBatch = string.Empty; string _newBatch = string.Empty;
        string _oldExpiry = string.Empty; string _newExpiry = string.Empty;
        string _expDate = string.Empty;
        public ucIPD_ExtraIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_IPOPQueries pm = new pm_IPOPQueries();
                pm.unit_id = GlobalUsage.Unit_id; pm.card_no = "-"; pm.uhid = "-"; pm.IPOPNo = txtIpdNo.Text; pm.from = "1900/01/01"; pm.to = "1900/01/01";
                pm.prm_1 = "-"; pm.logic = "TPA-Extra"; pm.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hospital/ipopqueries", pm);
                DataSet dsVerify = dwr.result;
                rgv_processedIndent.DataSource = dsVerify.Tables[0];
                if (dsVerify.Tables[0].Rows.Count > 0)
                    btnGenExtra.Enabled = true;
                else
                    btnGenExtra.Enabled = false;

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
        }

        private void rgv_processedIndent_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            string masterkeyid = string.Empty; int OldQty = 0; int InQty = 0;
            try
            {
                OldQty = Convert.ToInt16(rgv_processedIndent.CurrentRow.Cells["sale_qty"].Value);
                InQty = Convert.ToInt16(rgv_processedIndent.CurrentRow.Cells["ExtraIn"].Value);
                masterkeyid = rgv_processedIndent.CurrentRow.Cells["master_key_id"].Value.ToString();
            }
            catch (Exception e1) { return; }
            if (e.Column.Name == "ExtraIn")
            {
                if (InQty < 0 || InQty > OldQty)
                {
                    RadMessageBox.Show("Quantity Should be between  1 and " + OldQty.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                    rgv_processedIndent.CurrentRow.Cells["ExtraIn"].Value = 0;
                }
                else
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        cm1 p1 = new cm1();
                        p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                        p1.prm_1 = masterkeyid; p1.prm_2 = InQty.ToString();
                        p1.Logic = "TPA-Extra"; p1.tran_id = txtIpdNo.Text;
                        p1.prm_3 = rgv_processedIndent.CurrentRow.Cells["batch_no"].Value.ToString();

                        if (_expDate.Length == 10)
                            p1.prm_4 = _expDate;
                        else
                            p1.prm_4 = "NoChange";

                        p1.login_id = GlobalUsage.Login_id;

                        datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }
                }
            }
            else if (e.Column.Name == "batch_no")
            {
                if (rgv_processedIndent.CurrentRow.Cells["batch_no"].Value.ToString().Length < 5)
                {
                    MessageBox.Show("Batch No. Should be Minimum 5 Char.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rgv_processedIndent.CurrentRow.Cells["batch_no"].Value = _oldBatch;
                }
                else
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        cm1 p1 = new cm1();
                        p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                        p1.prm_1 = masterkeyid; p1.prm_2 = InQty.ToString();
                        p1.Logic = "TPA-Extra"; p1.tran_id = txtIpdNo.Text;
                        p1.prm_3 = rgv_processedIndent.CurrentRow.Cells["batch_no"].Value.ToString();

                        if (_expDate.Length == 10)
                            p1.prm_4 = _expDate;
                        else
                            p1.prm_4 = "NoChange";

                        p1.login_id = GlobalUsage.Login_id;

                        datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }
                }

            }
            else if (e.Column.Name == "exp_date")
            {
                try
                {
                    int mth = 1; int fixMth = 0;
                    _newExpiry = rgv_processedIndent.CurrentRow.Cells["exp_date"].Value.ToString();
                    string date = getExpDate(_newExpiry);
                    if (date == "Fail")
                    {

                        MessageBox.Show("Invalid Date", "ExPro Help");
                        rgv_processedIndent.CurrentRow.Cells["exp_date"].Value = _oldExpiry;
                        return;
                    }
                    else if (date != "1900-01-01" && mth <= fixMth)
                    {
                        MessageBox.Show("Bellow " + fixMth.ToString() + " Month Expiry Not Allowed", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rgv_processedIndent.CurrentRow.Cells["exp_date"].Value = _oldExpiry;
                        return;
                    }
                    else if (date != "Fail")
                    {
                        DateTime xpDate_Permit = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-01"));
                        DateTime xpDate_input = Convert.ToDateTime(date);
                        TimeSpan ts = xpDate_input - xpDate_Permit;
                        mth = ts.Days / 30; fixMth = 3;
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            cm1 p1 = new cm1();
                            p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                            p1.prm_1 = masterkeyid; p1.prm_2 = InQty.ToString();
                            p1.Logic = "TPA-Extra"; p1.tran_id = txtIpdNo.Text;
                            p1.prm_3 = rgv_processedIndent.CurrentRow.Cells["batch_no"].Value.ToString();

                            if (_expDate.Length == 10)
                                p1.prm_4 = _expDate;
                            else
                                p1.prm_4 = "NoChange";

                            p1.login_id = GlobalUsage.Login_id;

                            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                        }
                        catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                        finally { Cursor.Current = Cursors.Default; }


                    }



                }

                catch (Exception ex) { rgv_processedIndent.CurrentRow.Cells["exp_date"].Value = _oldExpiry; }
                _expDate = "";

            }

        }
        protected string getExpDate(string txtDate)
        {
            if (txtDate.Length == 0)
            { MessageBox.Show("Enter date", "ExPro Help"); return "Fail"; }
            if (txtDate.Length > 0)
            {
                if (txtDate == "-" || txtDate == "-")
                { return "1900-01-01"; }

                int dasCaount = 0;
                char[] Char1 = txtDate.ToCharArray(0, txtDate.Length);
                foreach (char s in Char1)
                {
                    if (s == '-') { dasCaount = dasCaount + 1; }
                }
                if (dasCaount == 0 || dasCaount > 1)
                { return "Fail"; }

                if (txtDate.Length > 5 || txtDate.Length < 5)
                { return "Fail"; }
                string[] t = txtDate.Split('-');
                if (t[0].Length > 2 || t[0].Length < 2)
                { return "Fail"; }
                if (t[1].Length > 2 || t[1].Length < 2)
                { return "Fail"; }
                try { if (Convert.ToInt32(t[0]) > 12) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                try { if (Convert.ToInt32(t[1]) > 1000) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                string century = DateTime.Now.ToString("yyyy").Substring(0, 2);
                _expDate = century + t[1] + '-' + t[0] + '-' + "01";
            }
            return _expDate;
        }
        private void btnGenExtra_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnGenExtra.Enabled = false;
                cm1 p1 = new cm1();
                p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                p1.prm_1 = "-"; p1.prm_2 = "-";
                p1.Logic = "-"; p1.tran_id = txtIpdNo.Text;
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/purchase/ExtraInTPA_Process", p1);
                if (dwr1.message.Contains("Success"))
                {
                    string[] t = dwr1.message.Split('|');
                    DialogResult res = RadMessageBox.Show("Do You want to Print (Y/N) ", "ExPro Help", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                        Printing.Laser.InternalSheet(t[1], "Print");
                }

                RadMessageBox.Show(dwr1.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_processedIndent_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["trf_flag"].Value.ToString() != "N")
            {
                e.RowElement.RowInfo.Cells["ExtraIn"].ReadOnly = true;

            }
        }

        private void MasterTemplate_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Column.Name == "batch_no")
                _oldBatch = rgv_processedIndent.CurrentRow.Cells["batch_no"].Value.ToString();
            if (e.Column.Name == "exp_date")
                _oldExpiry = rgv_processedIndent.CurrentRow.Cells["exp_date"].Value.ToString();

        }
    }
}
