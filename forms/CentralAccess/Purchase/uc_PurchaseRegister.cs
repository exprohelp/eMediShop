using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Configuration;

namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class uc_PurchaseRegister : UserControl
    {
        //string _prnFilePath = ConfigurationManager.AppSettings["LabelPrinterFile"].ToString();
        ////@"C:\Users\expro\OneDrive\Desktop\PharmacyQrCode.prn"; // Path to your PRN file
        //string _printerName = ConfigurationManager.AppSettings["LabelPrinterName"].ToString();

        string _fileContent = string.Empty;

        DataSet _ds = new DataSet();
        string _result = string.Empty; string _VendorName = string.Empty; string _invDate = string.Empty; string _invNumber = string.Empty; string _purch_id = string.Empty;
        public uc_PurchaseRegister()
        {
            InitializeComponent();
        }

        private void rbtn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _result = DateTime.Now.Second.ToString();
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "PurchaseBillSummary";
                p.prm_1 =dtpFrom.Value.ToString("yyyyMMdd") ; p.prm_2 = dtpTo.Value.ToString("yyyyMMdd"); p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                #region Filling Parent Grid
                var data = _ds.Tables[0].AsEnumerable().Select(o => new
                {
                    purch_id = o.Field<string>("purch_id"),
                    vendor_name = o.Field<string>("Vendor_Name") + " [" + o.Field<string>("Vendor_id") + "]",
                    inv_no = o.Field<string>("Inv_No"),
                    Inv_date = o.Field<string>("inv_date"),
                    inv_total = o.Field<decimal>("inv_total"),
                    inv_discount = o.Field<decimal>("inv_discount"),
                    inv_tax = o.Field<decimal>("inv_tax"),
                    netamount = o.Field<decimal>("netAmount"),
                    payable = o.Field<decimal>("payable"),
                    address = o.Field<string>("addr").TrimEnd(),
                    status = (o.Field<string>("pStatus") == "P") ? "Posted" : "Non-Posted"
                }).ToList();
                rgv_Info.DataSource = data;
                #endregion
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }

            GridViewTemplate childTemplate = rgv_Info.Templates[0];
            childTemplate.HierarchyDataProvider = new GridViewEventDataProvider(childTemplate);
            rgv_Info.Templates[0].AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
        }

        private void uc_PurchaseRegister_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today; dtpTo.Value = DateTime.Today;
        }

        private void dtpFrom_Leave(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void rgv_Info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Status"] != null && e.RowElement.RowInfo.Cells["Status"].Value != null)
            {
                if (e.RowElement.RowInfo.Cells["Status"].Value.ToString() == "Posted")
                    e.RowElement.ForeColor = Color.Green;
                else
                    e.RowElement.ForeColor = Color.Red;
            }
        }

        private void MasterTemplate_RowSourceNeeded(object sender, Telerik.WinControls.UI.GridViewRowSourceNeededEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _result = DateTime.Now.Second.ToString();
                _purch_id = e.ParentRow.Cells["Purch Id"].Value.ToString();
                _VendorName = e.ParentRow.Cells["Name of Vendor"].Value.ToString();
                _invDate = Convert.ToDateTime(e.ParentRow.Cells["Inv Date"].Value).ToString("dd-MM-yyyy");
                _invNumber = e.ParentRow.Cells["Inv No."].Value.ToString();
                rbtn_PrintBil.Enabled = true;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = _purch_id; p.logic = "PurchaseBillDetail"; p.prm_1 = _purch_id; p.prm_2 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        GridViewRowInfo row = e.Template.Rows.NewRow();
                        row.Cells["Master Key Id"].Value = dr["master_key_id"].ToString();
                        row.Cells["Name of Product"].Value = dr["Name of Medicine"].ToString();
                        row.Cells["Batch No"].Value = dr["Batch No"].ToString();
                        row.Cells["Exp Date"].Value = Convert.ToDateTime(dr["Exp Date"]);
                        row.Cells["MRP"].Value = Convert.ToDecimal(dr["mrp"]);
                        row.Cells["Trade"].Value = Convert.ToDecimal(dr["Pur Rate"]);
                        row.Cells["Qty"].Value = Convert.ToDecimal(dr["Qty"]);
                        row.Cells["Free"].Value = Convert.ToDecimal(dr["Free"]);
                        row.Cells["Trade"].Value = Convert.ToDecimal(dr["Pur Rate"]);
                        row.Cells["Tax Id"].Value = dr["Tax_id"].ToString();
                        row.Cells["Tax%"].Value = Convert.ToDecimal(dr["Tax_Rate"]);
                        row.Cells["Disc%"].Value = Convert.ToDecimal(dr["disper"]);
                        row.Cells["Amount"].Value = Convert.ToDecimal(dr["Amount"]);
                        row.Cells["Shelf No"].Value = dr["shelfno"].ToString();

                        e.SourceCollection.Add(row);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void rbtn_PrintBil_Click(object sender, EventArgs e)
        {

            CrystalReportsPharmacy.Reports.PurchasedBill_Info crReport = new CrystalReportsPharmacy.Reports.PurchasedBill_Info();
            try
            {
                DialogResult res = MessageBox.Show("Do You Confirm to Print ? ", "ExPro Help", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    crReport.Database.Tables["BillDetail"].SetDataSource(_ds.Tables[0]);
                    crReport.Database.Tables["BillSummary"].SetDataSource(_ds.Tables[1]);
                    crReport.SetParameterValue("UnitName", GlobalUsage.UnitName);
                    crReport.SetParameterValue("Address", GlobalUsage.UnitAddress);
                    crReport.SetParameterValue("VendorName", _VendorName);
                    crReport.SetParameterValue("invDate", _invDate);
                    crReport.SetParameterValue("invNumber", _invNumber);
                    crReport.SetParameterValue("purch_id", _purch_id);

                    crReport.PrintToPrinter(0, false, 1, 2);
                    rbtn_PrintBil.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;

        }

        private void btnLocationSheet_Click(object sender, EventArgs e)
        {
            CrystalReportsPharmacy.Reports.PurchasedBill_Info crReport = new CrystalReportsPharmacy.Reports.PurchasedBill_Info();
            try
            {
                DialogResult res = MessageBox.Show("Do You Confirm to Print ? ", "ExPro Help", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    crReport.Database.Tables["BillDetail"].SetDataSource(_ds.Tables[0]);
                    crReport.Database.Tables["BillSummary"].SetDataSource(_ds.Tables[1]);
                    crReport.SetParameterValue("UnitName", GlobalUsage.UnitName);
                    crReport.SetParameterValue("Address", GlobalUsage.UnitAddress);
                    crReport.SetParameterValue("VendorName", _VendorName);
                    crReport.SetParameterValue("invDate", _invDate);
                    crReport.SetParameterValue("invNumber", _invNumber);
                    crReport.SetParameterValue("purch_id", _purch_id);

                    crReport.PrintToPrinter(0, false, 1, 2);
                    rbtn_PrintBil.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        //private void btnBarCodePrint_Click(object sender, EventArgs e)
        //{
        //    _fileContent = System.IO.File.ReadAllText(_prnFilePath);
        //    foreach (DataRow row in _ds.Tables[0].Rows)
        //    {
        //        printLabel(row["item_name"].ToString(),
        //            row["batch_no"].ToString(),
        //            row["exp date"].ToString(),
        //            row["mrp"].ToString(),
        //            row["master_key_id"].ToString(),
        //            Convert.ToInt16(row["purchPackQty"])
        //            );
        //    }
        //    btnBarCodePrint.Enabled = false;
        //}

        //private void printLabel(string product,string batch,string expiry,string mrp,string mkey,int nos)
        //{

        //    string ReplfileContent = _fileContent.Replace("{product}", product);
        //    ReplfileContent = ReplfileContent.Replace("{batch}", batch);
        //    ReplfileContent = ReplfileContent.Replace("{expiry}", expiry);
        //    ReplfileContent = ReplfileContent.Replace("{mrp}", mrp);
        //    ReplfileContent = ReplfileContent.Replace("{masterkey}", mkey);

        //    for(int i=0; i<=nos; i++)
        //    {
        //        // Read the PRN file
        //        byte[] fileBytes = Encoding.UTF8.GetBytes(ReplfileContent);
        //        eMediShop.RawPrinterHelper.SendBytesToPrinter(_printerName, fileBytes);
        //    }
        //}


    }
}
