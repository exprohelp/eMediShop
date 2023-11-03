using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Telerik.WinControls;
namespace eMediShop.RCM
{
    public partial class RCMarkCustomer : Telerik.WinControls.UI.RadForm
    {
        private System.Windows.Forms.TextBox txtqty = new System.Windows.Forms.TextBox();
        DataSet dsMed = new DataSet();
        DataSet _ds = new DataSet();
        string _LastRemarks = string.Empty;
        string _CardNo = ""; string _logic = string.Empty;
        string _login_id = string.Empty;
        string _result = "";
        public RCMarkCustomer()
        {
            InitializeComponent();
        }
        private void RCMarkCustomer_Load(object sender, EventArgs e)
        {
            //rdpFrom.MinDate = DateTime.Today.AddDays(-1);
            _logic = "Single";
            rdpFrom.Value = DateTime.Today;
            dtOnCallDate.Value = DateTime.Today;
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 120);
            cmbOnCallTime.SelectedIndex = 0;
            #region Initialize TextBox Order Quantity
            txtqty.Size = new System.Drawing.Size(0, 0);
            txtqty.Location = new System.Drawing.Point(0, 0);
            txtqty.TextAlign = HorizontalAlignment.Right;
            txtqty.BorderStyle = BorderStyle.FixedSingle;
            #endregion
        }
        private void OrderQtyFocusExit(object sender, System.EventArgs e)
        {
            txtqty.Hide();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            ShowCardInfo();
        }
        private void ShowCardInfo()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                regulareQueries p = new regulareQueries();
                p.card_no = txtCardNo.Text;p.date = "1900/01/01";p.time = "8:00";p.unit_id = GlobalUsage.Unit_id;p.loginID=GlobalUsage.Login_id;
                p.logic = "Cust Info";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMSmallQueries", p);

                DataSet ds = dwr.result;
                if (ds.Tables.Count > 0)
                {
                    radPanel2.Controls.Clear();
                    radPanel2.Controls.Add(new eMediShop.forms.RCM.ucNextSchedule("N/A", txtCardNo.Text));
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        lbCardNo.Text = ds.Tables[0].Rows[0]["card_no"].ToString();
                        lblCustName.Text = ds.Tables[0].Rows[0]["cust_name"].ToString();
                        lblMobile.Text = ds.Tables[0].Rows[0]["MobileNo"].ToString();
                        lblPhone.Text = ds.Tables[0].Rows[0]["phoneno"].ToString();
                        lblAddress.Text = ds.Tables[0].Rows[0]["address"].ToString();
                    }
                    else { MessageBox.Show("Card Not Exists"); }
                }
                else { MessageBox.Show("Card Not Exists"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }
        private void cmbOnCallTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Fill_Cards();
            }
        }

        private void Fill_Cards()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                regulareQueries p = new regulareQueries();
                p.card_no = txtCardNo.Text; p.date = dtOnCallDate.Value.ToString("yyyy/MM/dd");
                p.time = cmbOnCallTime.SelectedItem.ToString(); p.unit_id = GlobalUsage.Unit_id; p.loginID = GlobalUsage.Login_id;
                p.logic = "OnCallTimeCardNo";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMSmallQueries", p);
                rgv_info.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Fill_CardInfo(e.Row.Cells["card_no"].Value.ToString());
        }

        private void Fill_CardInfo(string CardNo)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _CardNo = CardNo;
                _login_id = GlobalUsage.Login_id;
                pnlCallingControl.Controls.Clear();
                pnlCallingControl.Controls.Add(new eMediShop.forms.RCM.ucCustomerCall(_CardNo,"RCMCall"));
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Fill_Cards();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                regulareQueries p = new regulareQueries();
                p.card_no = txtCardNo.Text; p.date = rdpFrom.Value.ToString("yyyy/MM/dd");
                p.time = cmbOnCallTime.SelectedItem.ToString(); p.unit_id = GlobalUsage.Unit_id; p.loginID = GlobalUsage.Login_id;
                p.logic = "CallDataSheet_" + _logic;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMSmallQueries", p);

                _ds = dwr.result;
                radGridView1.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (_ds.Tables.Count > 0)
                {
                    CrystalReportsPharmacy.Reports.RCM_CallDataSheet rpt = new CrystalReportsPharmacy.Reports.RCM_CallDataSheet();
                    rpt.Database.Tables["CallingData"].SetDataSource(_ds.Tables[0]);
                    rpt.SetParameterValue("unit_name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("unit_address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("date", rdpFrom.Value.ToString());
                    DialogResult res = MessageBox.Show("Do You want to Print (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        rpt.PrintToPrinter(1, false, 1, 0);
                    }
                    else
                    {
                        string path = GlobalUsage.BillDrive + "\\pdf\\" + ExPro.Client.utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\CallingData_" + rdpFrom.Value.ToString().Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\CallingData_" + rdpFrom.Value.ToString().Replace('/', '_') + ".pdf"); }
                        rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path + "\\CallingData_" + rdpFrom.Value.ToString().Replace('/', '_') + ".pdf");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void txtManualCardNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Fill_CardInfo(txtManualCardNumber.Text);
            }
        }

        private void rdpFrom_Leave(object sender, EventArgs e)
        {

        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked)
            {
                cbAll.Text = "Today Data"; _logic = "Single";
            }
            else
            {
                cbAll.Text = "All Data";
                printButton.Enabled = false;
                _logic = "All";
            }
        }

        private void btnExPortXL_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "RCM_DATA.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(radGridView1);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;

                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

    }
}
