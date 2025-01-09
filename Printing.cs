using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ExPro.Client;
using System;
using System.Data;
using System.Windows.Forms;
namespace eMediShop
{
    public class Printing
    {
        static string _result = DateTime.Now.Second.ToString();
        static ExPro.Client.CurrencyTowords ct = new CurrencyTowords();
        //Laser Printing Class
        public class Laser
        {
            public static void gr_ReportForUnit(DataTable dt, string Master_Gr_No, string unitName)
            {
                try
                {
                    CrystalReportsPharmacy.Reports.gr_unit_Report rpt = new CrystalReportsPharmacy.Reports.gr_unit_Report();
                    rpt.Database.Tables["gr_unit_info"].SetDataSource(dt);
                    rpt.SetParameterValue("master_gr_no", Master_Gr_No);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + unitName.Substring(0, 5) + Master_Gr_No + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + unitName.Substring(0, 5) + Master_Gr_No + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + unitName.Substring(0, 5) + Master_Gr_No + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void NER_Bill(DataSet ds,string billNo)
            {
                try
                {
                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.Reports.Ner_Bill();

                    rpt.Database.Tables["sale_header"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["sale_items"].SetDataSource(ds.Tables[1]);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = Application.StartupPath.Substring(0, 2) + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + billNo.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + billNo.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + billNo.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void HAL_DeliverySummary(DataSet ds, string billNo, string orderdate)
            {
                try
                {
                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.Reports.HAl_Delivery_SummaryByTax();

                    rpt.Database.Tables["headerInfo"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["itemInfo"].SetDataSource(ds.Tables[1]);
                    rpt.SetParameterValue("billno", "Order No.  : " + billNo);
                    rpt.SetParameterValue("orderdate", "Order Date : " + orderdate);
                    //rpt.PrintToPrinter(1, false, 1, 0);
                    string path = Application.StartupPath.Substring(0, 2) + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + billNo.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + billNo.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + billNo.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void HAL_Billing(DataSet ds, string billNo, string orderdate)
            {
                try
                {
                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.Reports.HAl_Bill_SummaryByTax();

                    rpt.Database.Tables["headerInfo"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["itemInfo"].SetDataSource(ds.Tables[1]);
                    rpt.SetParameterValue("billno", "Order No.  : " + billNo);
                    rpt.SetParameterValue("orderdate", "Order Date : " + orderdate);
                    //rpt.PrintToPrinter(1, false, 1, 0);
                    string path = Application.StartupPath.Substring(0, 2) + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + billNo.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + billNo.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + billNo.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void Trade_Invoice(DataSet ds, string Sale_Inv_No)
            {
                try
                {
                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.Reports.TradeBill();

                    rpt.Database.Tables["Header"].SetDataSource(ds.Tables[1]);
                    rpt.Database.Tables["shopInfo"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["Bill_GST"].SetDataSource(ds.Tables[4]);
                    rpt.Database.Tables["Bill_Info"].SetDataSource(ds.Tables[3]);
                    rpt.Database.Tables["Bill_Summary"].SetDataSource(ds.Tables[2]);
                    rpt.Database.Tables["items"].SetDataSource(ds.Tables[5]);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = Application.StartupPath.Substring(0, 2) + "\\cashmemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void Trade_Invoice1(DataSet ds, string Sale_Inv_No)
            {
                try
                {
                    ds.Tables[1].TableName = "Header";
                    ds.Tables[0].TableName = "shopInfo";
                    ds.Tables[4].TableName = "Bill_GST";
                    ds.Tables[3].TableName = "Bill_Info";
                    ds.Tables[2].TableName = "Bill_Summary";

                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.Reports.WholeSale_Bill();

                    rpt.Database.Tables["Header"].SetDataSource(ds.Tables[1]);
                    rpt.Database.Tables["shopInfo"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["Bill_GST"].SetDataSource(ds.Tables[4]);
                    rpt.Database.Tables["Bill_Info"].SetDataSource(ds.Tables[3]);
                    rpt.Database.Tables["Bill_Summary"].SetDataSource(ds.Tables[2]);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = Application.StartupPath.Substring(0, 2) + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void ICTV_Invoice(DataSet ds, string Sale_Inv_No)
            {
                try
                {
                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.Reports.WS_Bill();

                    rpt.Database.Tables["WS_Client"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["WS_Master"].SetDataSource(ds.Tables[1]);
                    rpt.Database.Tables["WS_Info"].SetDataSource(ds.Tables[2]);
                    rpt.SetParameterValue("unit_name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("unit_Add1", GlobalUsage.CashMemoAddress.Replace(GlobalUsage.District, " "));
                    rpt.SetParameterValue("unit_Add2", "-");
                    rpt.SetParameterValue("unit_district", GlobalUsage.District);
                    rpt.SetParameterValue("contact_no", "-");
                    rpt.SetParameterValue("unit_gstn", GlobalUsage.GST_No);
                    rpt.SetParameterValue("unit_dl_no", GlobalUsage.DL_No);
                    rpt.SetParameterValue("State", GlobalUsage.State);
                    rpt.SetParameterValue("comp_name", GlobalUsage.Company);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = Application.StartupPath.Substring(0, 2) + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + Sale_Inv_No.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void DeliveryChallans(DataSet ds, string ChallanNo)
            {
                try
                {
                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.eMediShop.Challans();

                    rpt.Database.Tables["shopInfo"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["Header"].SetDataSource(ds.Tables[1]);
                    rpt.Database.Tables["Items"].SetDataSource(ds.Tables[2]);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = Application.StartupPath.Substring(0, 2) + "\\challan\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + ChallanNo.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + ChallanNo.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + ChallanNo.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void WholeSalesInvoice(DataSet ds, string Sale_Inv_No)
            {
                try
                {
                    ReportDocument rpt;
                    rpt = new CrystalReportsPharmacy.Reports.WS_Bill();

                    rpt.Database.Tables["ws_client"].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables["ws_master"].SetDataSource(ds.Tables[1]);
                    rpt.Database.Tables["ws_info"].SetDataSource(ds.Tables[2]);
                    rpt.SetParameterValue("unit_name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("unit_Add1", GlobalUsage.CashMemoAddress);
                    rpt.SetParameterValue("unit_Add2", "-");
                    rpt.SetParameterValue("unit_district", GlobalUsage.District);
                    rpt.SetParameterValue("contact_no", "-");
                    rpt.SetParameterValue("unit_gstn", GlobalUsage.GST_No);
                    rpt.SetParameterValue("unit_dl_no", GlobalUsage.DL_No);
                    rpt.SetParameterValue("State", GlobalUsage.State);
                    rpt.SetParameterValue("comp_name", GlobalUsage.Company);
                    rpt.PrintToPrinter(1, false, 1, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void exportTopdf(ReportDocument rpt, string FileName)
            {
                string path = GlobalUsage.BillDrive + "\\pdf\\Product";
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                if (!dir.Exists)
                { dir.Create(); }
                if (System.IO.File.Exists(path + "\\" + FileName))
                { System.IO.File.Delete(path + "\\" + FileName); }
                rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + FileName);
            }
            public static void ExtraPurchase(DataTable dt)
            {
                CrystalReportsPharmacy.eMediShop.ExtraPurchase rpt = new CrystalReportsPharmacy.eMediShop.ExtraPurchase();
                rpt.Database.Tables["extraPurchase"].SetDataSource(dt);
                rpt.SetParameterValue("unitName", GlobalUsage.UnitName);
                rpt.SetParameterValue("unitAddress", GlobalUsage.UnitAddress);
                rpt.PrintToPrinter(1, false, 1, 0);

            }
            public static void estimateFeedingByTrfid(DataTable dt, string trf_id)
            {
                CrystalReportsPharmacy.eMediShop.estimateForFeeding rpt = new CrystalReportsPharmacy.eMediShop.estimateForFeeding();
                rpt.Database.Tables["ws_info"].SetDataSource(dt);
                rpt.SetParameterValue("trf_id", trf_id);
                rpt.SetParameterValue("unit_Name", GlobalUsage.UnitName);
                rpt.SetParameterValue("unit_address", GlobalUsage.UnitAddress);
                rpt.PrintToPrinter(1, false, 1, 0);

            }
            public static void OnLineOrderSlip(string cust_name, string address, string contactno, DataTable dt_detail, DataTable dt_remark)
            {
                CrystalReportsPharmacy.Reports.OnLineOrderSlip rpt = new CrystalReportsPharmacy.Reports.OnLineOrderSlip();

                rpt.Database.Tables["Order_info"].SetDataSource(dt_detail);
                rpt.Database.Tables["Order_Remarks"].SetDataSource(dt_remark);
                rpt.SetParameterValue("cust_name", cust_name);
                rpt.SetParameterValue("address", address);
                rpt.SetParameterValue("contact_no", contactno);
                rpt.PrintToPrinter(1, false, 1, 0);
            }
            public static void Voucher(string Voucher_No, string Cr_Ledger, string Dr_Ledger, decimal Amount, string Narration)
            {
                CrystalReportsPharmacy.Reports.CrVoucher rpt = new CrystalReportsPharmacy.Reports.CrVoucher();
                rpt.SetParameterValue("unitname", GlobalUsage.UnitName);
                rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                rpt.SetParameterValue("debitledger", Dr_Ledger);
                rpt.SetParameterValue("creditledger", Cr_Ledger);
                rpt.SetParameterValue("narration", Narration);
                rpt.SetParameterValue("amt", Amount);
                rpt.SetParameterValue("date", DateTime.Now);
                rpt.SetParameterValue("loginid", GlobalUsage.Login_id);
                rpt.SetParameterValue("voucherno", Voucher_No);
                rpt.PrintToPrinter(1, false, 1, 0);
            }
            public static void CashMemoWithoutDiscount(string SalesInvNo, DataSet ds)
            {
                try
                {
                    string _result = string.Empty;
                    CrystalReportsPharmacy.eMediShop.CashMemo_withoutDiscount rptCashMemo = new CrystalReportsPharmacy.eMediShop.CashMemo_withoutDiscount();
                    string inwords = ct.changeCurrencyToWords(Convert.ToDouble(ds.Tables[0].Rows[0]["net"]));
                    rptCashMemo.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                    rptCashMemo.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                    rptCashMemo.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                    rptCashMemo.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                    rptCashMemo.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                    rptCashMemo.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                    rptCashMemo.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                    rptCashMemo.SetParameterValue("gstn", GlobalUsage.GST_No);
                    rptCashMemo.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                    rptCashMemo.SetParameterValue("InWords", "In Words :" + inwords);
                    rptCashMemo.PrintToPrinter(1, false, 1, 0);
                    if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                    {
                        string path = GlobalUsage.BillDrive + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                        rptCashMemo.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void CashMemoHospitalIndent(string SalesInvNo, string PrintFlag, string Hosp_Flag)
            {
                try
                {
                    string _result = string.Empty;
                    DataSet ds = new DataSet();
                    pm_BillInfo p = new pm_BillInfo();
                    p.unit_id = GlobalUsage.Unit_id; p.Bill_No = SalesInvNo; p.login_id = GlobalUsage.Login_id;
                    p.login_name = GlobalUsage.Login_Name;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/billInformation", p);

                    ds = dwr.result;
                    string inwords = ct.changeCurrencyToWords(Convert.ToDouble(ds.Tables[0].Rows[0]["net"]));
                    if (Hosp_Flag == "Y")
                    {
                        #region Hospital Invoice
                        if (PrintFlag == "Y" && SalesInvNo.Contains("E"))
                        {
                            GlobalUsage.HospitalInternalSheet.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                            GlobalUsage.HospitalInternalSheet.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("gstn", GlobalUsage.GST_No);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("InWords", "In Words :" + inwords);
                            GlobalUsage.HospitalInternalSheet.PrintToPrinter(1, false, 1, 0);
                        }
                        else if (PrintFlag == "Y")
                        {
                            GlobalUsage.HospitalCashMemo.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                            GlobalUsage.HospitalCashMemo.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                            GlobalUsage.HospitalCashMemo.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                            GlobalUsage.HospitalCashMemo.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                            GlobalUsage.HospitalCashMemo.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                            GlobalUsage.HospitalCashMemo.SetParameterValue("gstn", GlobalUsage.GST_No);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("InWords", "In Words :" + inwords);
                            GlobalUsage.HospitalCashMemo.PrintToPrinter(1, false, 1, 0);
                        }

                        if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes" && SalesInvNo.Contains("P"))
                        {
                            string path = GlobalUsage.BillDrive + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                            if (!dir.Exists)
                            { dir.Create(); }
                            if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                            { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                            GlobalUsage.HospitalCashMemo.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");


                        }
                        #endregion
                    }
                    else if (GlobalUsage.Unit_id.Contains("CH"))
                    {
                        #region Chandan Opthelmic 
                        GlobalUsage.opthCashMemo.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                        GlobalUsage.opthCashMemo.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                        GlobalUsage.opthCashMemo.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                        GlobalUsage.opthCashMemo.SetParameterValue("AdvMatter", "");
                        GlobalUsage.opthCashMemo.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                        GlobalUsage.opthCashMemo.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                        GlobalUsage.opthCashMemo.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandanhospital.in");
                        GlobalUsage.opthCashMemo.SetParameterValue("gstn", GlobalUsage.GST_No);
                        GlobalUsage.opthCashMemo.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                        GlobalUsage.opthCashMemo.SetParameterValue("InWords", "In Words :" + inwords);
                        if (PrintFlag == "Y")
                            GlobalUsage.opthCashMemo.PrintToPrinter(1, false, 1, 0);



                        if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                        {
                            string path = GlobalUsage.BillDrive + "\\CashMemo\\" + GlobalUsage.Unit_id + "\\" + Convert.ToDateTime(ds.Tables[0].Rows[0]["sale_date"]).ToString("yyyy-MM-dd");
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                            if (!dir.Exists)
                            { dir.Create(); }
                            if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                            { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                            GlobalUsage.opthCashMemo.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");
                        }
                        #endregion
                    }
                    else
                    {
                        #region Chandan Pharmacy 
                        GlobalUsage.PharmacyCashMemo.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                        GlobalUsage.PharmacyCashMemo.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("gstn", GlobalUsage.GST_No);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("InWords", "In Words :" + inwords);
                        if (PrintFlag == "Y")
                            GlobalUsage.PharmacyCashMemo.PrintToPrinter(1, false, 1, 0);



                        if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                        {
                            string path = GlobalUsage.BillDrive + "\\CashMemo\\" + GlobalUsage.Unit_id + "\\" + Convert.ToDateTime(ds.Tables[0].Rows[0]["sale_date"]).ToString("yyyy-MM-dd");
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                            if (!dir.Exists)
                            { dir.Create(); }
                            if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                            { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                            GlobalUsage.PharmacyCashMemo.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");
                        }
                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void PrintManualBill(string SalesInvNo, string PrintFlag)
            {
                try
                {
                    string _result = string.Empty;
                    DataSet ds = new DataSet();
                    pm_SalesAction1 p = new pm_SalesAction1();
                    p.unit_id = GlobalUsage.Unit_id; p.Sale_Trn_No = "-"; p.Sales_Inv_No = SalesInvNo; p.order_no = "-"; p.master_key_id = "-";
                    p.logic = "ManualBillInfo";

                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/GetSalesInvoice_Info", p);

                    ds = dwr.result;
                    string inwords = ct.changeCurrencyToWords(Convert.ToDouble(ds.Tables[0].Rows[0]["net"]));

                    #region Chandan Pharmacy Manual Bill
                    GlobalUsage.ManualBill.DataSourceConnections.Clear();
                    GlobalUsage.ManualBill.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                    GlobalUsage.ManualBill.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                    GlobalUsage.ManualBill.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                    GlobalUsage.ManualBill.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                    GlobalUsage.ManualBill.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                    GlobalUsage.ManualBill.SetParameterValue("gstn", GlobalUsage.GST_No);
                    GlobalUsage.ManualBill.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");




                    if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                    {
                        string path = GlobalUsage.BillDrive + "\\CashMemo\\" + GlobalUsage.Unit_id + "\\" + Convert.ToDateTime(ds.Tables[0].Rows[0]["sale_date"]).ToString("yyyy-MM-dd");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                        GlobalUsage.ManualBill.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");
                    }
                    if (PrintFlag == "Y")
                        GlobalUsage.ManualBill.PrintToPrinter(1, false, 1, 0);

                    #endregion

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void HAL_DeliveryNote(string DeliveryNoteNo, string PrintFlag)
            {
                try
                {
                    string _result = string.Empty;
                    DataSet ds = new DataSet();
                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "DeliveryNote";p.prm_1 = DeliveryNoteNo;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                    ds = dwr.result;
                    string inwords = ct.changeCurrencyToWords(Convert.ToDouble(ds.Tables[0].Rows[0]["net"]));
                    #region Chandan Pharmacy 
                    GlobalUsage.HAL_DeliveryNote.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                    GlobalUsage.HAL_DeliveryNote.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("gstn", GlobalUsage.GST_No);
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                    GlobalUsage.HAL_DeliveryNote.SetParameterValue("InWords", "In Words :" + inwords);



                    if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                    {
                        string path = GlobalUsage.BillDrive + "\\CashMemo\\" + GlobalUsage.Unit_id + "\\" + Convert.ToDateTime(ds.Tables[0].Rows[0]["sale_date"]).ToString("yyyy-MM-dd");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + DeliveryNoteNo.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + DeliveryNoteNo.Replace('/', '_') + ".pdf"); }
                        GlobalUsage.HAL_DeliveryNote.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + DeliveryNoteNo.Replace('/', '_') + ".pdf");
                    }
                    if (PrintFlag == "Y")
                        GlobalUsage.HAL_DeliveryNote.PrintToPrinter(1, false, 1, 0);

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void CashMemo(string SalesInvNo, string PrintFlag)
            {
                try
                {
                    string _result = string.Empty;
                    DataSet ds = new DataSet();
                    pm_BillInfo p = new pm_BillInfo();
                    p.unit_id = GlobalUsage.Unit_id; p.Bill_No = SalesInvNo; p.login_id = GlobalUsage.Login_id;
                    p.login_name = GlobalUsage.Login_Name;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/billInformation", p);

                    ds = dwr.result;
                    string inwords = ct.changeCurrencyToWords(Convert.ToDouble(ds.Tables[0].Rows[0]["net"]));

                    //BarcodeGenerator barcodeGenerator = new BarcodeGenerator();
                    //Bitmap barcodeImage = barcodeGenerator.GenerateBarcode(SalesInvNo, 300, 100);

                    if (GlobalUsage.Unit_id.Contains("H"))
                    {
                        #region Hospital Invoice
                        if (PrintFlag == "Y" && SalesInvNo.Contains("E"))
                        {
                            GlobalUsage.HospitalInternalSheet.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                            GlobalUsage.HospitalInternalSheet.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("gstn", GlobalUsage.GST_No);
                            GlobalUsage.HospitalInternalSheet.SetParameterValue("InWords", "In Words :" + inwords);
                            GlobalUsage.HospitalInternalSheet.PrintToPrinter(1, false, 1, 0);
                        }
                        else if (PrintFlag == "Y")
                        {
                            GlobalUsage.HospitalCashMemo.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                            GlobalUsage.HospitalCashMemo.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                            GlobalUsage.HospitalCashMemo.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                            GlobalUsage.HospitalCashMemo.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                            GlobalUsage.HospitalCashMemo.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                            GlobalUsage.HospitalCashMemo.SetParameterValue("gstn", GlobalUsage.GST_No);
                            GlobalUsage.HospitalCashMemo.SetParameterValue("InWords", "In Words :" + inwords);
                        }

                        if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes" && SalesInvNo.Contains("P"))
                        {
                            string path = GlobalUsage.BillDrive + "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                            if (!dir.Exists)
                            { dir.Create(); }
                            if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                            { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                            GlobalUsage.HospitalCashMemo.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");


                        }
                        GlobalUsage.HospitalCashMemo.PrintToPrinter(1, false, 1, 0);

                        #endregion
                    }
                    else if (GlobalUsage.Unit_id.Contains("CH"))
                    {
                        #region Chandan Opthelmic 
                        GlobalUsage.opthCashMemo.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                        GlobalUsage.opthCashMemo.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                        GlobalUsage.opthCashMemo.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                        GlobalUsage.opthCashMemo.SetParameterValue("AdvMatter", "");
                        GlobalUsage.opthCashMemo.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                        GlobalUsage.opthCashMemo.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                        GlobalUsage.opthCashMemo.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandanhospital.in");
                        GlobalUsage.opthCashMemo.SetParameterValue("gstn", GlobalUsage.GST_No);
                        GlobalUsage.opthCashMemo.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                        GlobalUsage.opthCashMemo.SetParameterValue("InWords", "In Words :" + inwords);
                        if (PrintFlag == "Y")
                            GlobalUsage.opthCashMemo.PrintToPrinter(1, false, 1, 0);



                        if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                        {
                            string path = GlobalUsage.BillDrive + "\\CashMemo\\" + GlobalUsage.Unit_id + "\\" + Convert.ToDateTime(ds.Tables[0].Rows[0]["sale_date"]).ToString("yyyy-MM-dd");
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                            if (!dir.Exists)
                            { dir.Create(); }
                            if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                            { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                            GlobalUsage.opthCashMemo.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");
                        }
                        #endregion
                    }
                    else
                    {
                        #region Chandan Pharmacy 
                        GlobalUsage.PharmacyCashMemo.Database.Tables["HeaderInfo"].SetDataSource(ds.Tables[0]);
                        GlobalUsage.PharmacyCashMemo.Database.Tables["Item_Info"].SetDataSource(ds.Tables[1]);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("Heading", ds.Tables[2].Rows[0]["Heading"].ToString());
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("AdvMatter", ds.Tables[2].Rows[0]["AdvMatter"].ToString());
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("Shop_Addr", GlobalUsage.CashMemoAddress);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("CounterId", ds.Tables[0].Rows[0]["counter_id"]);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("PhoneNo", "Contact No. " + GlobalUsage.ContactNo + ", Email:care@chandan.co.in");
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("gstn", GlobalUsage.GST_No);
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("managerSign_path", Application.StartupPath + "\\managerSign.jpg");
                        GlobalUsage.PharmacyCashMemo.SetParameterValue("InWords", "In Words :" + inwords);



                        if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                        {
                            string path = GlobalUsage.BillDrive + "\\CashMemo\\" + GlobalUsage.Unit_id + "\\" + Convert.ToDateTime(ds.Tables[0].Rows[0]["sale_date"]).ToString("yyyy-MM-dd");
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                            if (!dir.Exists)
                            { dir.Create(); }
                            if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                            { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                            GlobalUsage.PharmacyCashMemo.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");
                        }
                        if (PrintFlag == "Y")
                            GlobalUsage.PharmacyCashMemo.PrintToPrinter(1, false, 1, 0);

                        #endregion
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void Bill_Consolidation(DataSet ds)
            {
                try
                {
                    string _result = string.Empty;


                    CrystalReportsPharmacy.eMediShop.CorporateBills rptbills = new CrystalReportsPharmacy.eMediShop.CorporateBills();
                    rptbills.Database.Tables["corp_info"].SetDataSource(ds.Tables[0]);
                    rptbills.Database.Tables["corp_data_info"].SetDataSource(ds.Tables[1]);
                    rptbills.SetParameterValue("compName", GlobalUsage.Company);
                    rptbills.SetParameterValue("unitAddress", GlobalUsage.UnitAddress);
                    rptbills.SetParameterValue("TIN_No", GlobalUsage.GST_No);
                    rptbills.PrintToPrinter(1, false, 1, 0);
                    rptbills.Close();
                    //if (System.Configuration.ConfigurationManager.AppSettings["SoftBill"].ToString() == "Yes")
                    //{
                    //    string path = Application.StartupPath+ "\\CashMemo\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    //    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    //    if (!dir.Exists)
                    //    { dir.Create(); }
                    //    if (System.IO.File.Exists(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"))
                    //    { System.IO.File.Delete(path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf"); }
                    //    rptbills.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + SalesInvNo.Replace('/', '_') + ".pdf");
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            public static void InternalSheet_Sales(string sale_inv_no, string printType)
            {
                try
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Stock:CheckingSheet"; p.prm_1 = sale_inv_no;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/WholeSaleQueries", p);
                    DataSet ds = dwr.result;
                    CrystalReportsPharmacy.eMediShop.InternalSheet rpt = new CrystalReportsPharmacy.eMediShop.InternalSheet();
                    rpt.Database.Tables["InternalSheet"].SetDataSource(ds.Tables[0]);
                    rpt.SetParameterValue("Unit_Name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("trf_id", sale_inv_no);
                    if (printType == "Print")
                        rpt.PrintToPrinter(1, false, 1, 0);
                    else if (printType == "Pdf")
                    {
                        string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + sale_inv_no.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + sale_inv_no.Replace('/', '_') + ".pdf"); }
                        rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + sale_inv_no.Replace('/', '_') + ".pdf");
                    }
                    rpt.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void LocationSheet(string transfer_id, string printType)
            {
                try
                {

                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.tran_id = transfer_id; p.Logic = "Receive_ID_Info";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);


                    CrystalReportsPharmacy.eMediShop.InternalSheet rpt = new CrystalReportsPharmacy.eMediShop.InternalSheet();
                    rpt.Database.Tables["InternalSheet"].SetDataSource(dwr.result.Tables[0]);
                    rpt.SetParameterValue("Unit_Name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("trf_id", transfer_id);
                    if (printType == "Print")
                        rpt.PrintToPrinter(1, false, 1, 0);
                    else if (printType == "Pdf")
                    {
                        string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + transfer_id.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + transfer_id.Replace('/', '_') + ".pdf"); }
                        rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + transfer_id.Replace('/', '_') + ".pdf");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void InternalSheet(string transfer_id, string printType)
            {
                try
                {

                    cm2 p = new cm2();
                    p.unit_id = GlobalUsage.Unit_id; p.tran_id = transfer_id; p.Logic = "TransferId:InternalPaper";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);


                    CrystalReportsPharmacy.eMediShop.InternalSheet rpt = new CrystalReportsPharmacy.eMediShop.InternalSheet();
                    rpt.Database.Tables["InternalSheet"].SetDataSource(dwr.result.Tables[0]);
                    rpt.SetParameterValue("Unit_Name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("trf_id", transfer_id);
                    if (printType == "Print")
                        rpt.PrintToPrinter(1, false, 1, 0);
                    else if (printType == "Pdf")
                    {
                        string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + transfer_id.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + transfer_id.Replace('/', '_') + ".pdf"); }
                        rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + transfer_id.Replace('/', '_') + ".pdf");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void DebitNoteInternalSheet(string debitNote_No, string printType)
            {
                try
                {

                    pm_debitCreditNotes p = new pm_debitCreditNotes();
                    p.unit_id = GlobalUsage.Unit_id; p.vendor_id = "-"; p.logic = "InternalSheet";
                    p.Note_No = debitNote_No; p.prm_2 = "-";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/DebitNoteQueries", p);


                    CrystalReportsPharmacy.eMediShop.InternalSheet rpt = new CrystalReportsPharmacy.eMediShop.InternalSheet();
                    rpt.Database.Tables["InternalSheet"].SetDataSource(dwr.result.Tables[0]);
                    rpt.SetParameterValue("Unit_Name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("trf_id", debitNote_No);
                    if (printType == "Print")
                        rpt.PrintToPrinter(1, false, 1, 0);
                    else if (printType == "Pdf")
                    {
                        string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + debitNote_No.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + debitNote_No.Replace('/', '_') + ".pdf"); }
                        rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + debitNote_No.Replace('/', '_') + ".pdf");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public static void InternalSheet_Temp(DataSet ds, string Head)
            {
                try
                {
                    CrystalReportsPharmacy.eMediShop.InternalSheet rpt = new CrystalReportsPharmacy.eMediShop.InternalSheet();
                    rpt.Database.Tables["InternalSheet"].SetDataSource(ds.Tables[0]);
                    rpt.SetParameterValue("Unit_Name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("trf_id", Head);
                    rpt.PrintToPrinter(1, false, 1, 0);

                    string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + Head.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + Head.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + Head.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void ZeroStockOrder(DataTable dt)
            {
                CrystalReportsPharmacy.eMediShop.ZeroStockOrder rpt = new CrystalReportsPharmacy.eMediShop.ZeroStockOrder();
                rpt.Database.Tables["ZeroStockOrder"].SetDataSource(dt);
                rpt.SetParameterValue("ShopName", GlobalUsage.UnitName + "[" + GlobalUsage.Unit_id + "]");
                rpt.PrintToPrinter(1, false, 1, 0);
            }
            public static void StockTransfer_Form(DataSet ds, string transfer_id, string logic)
            {
                try
                {
                    ReportDocument rpt;
                    if (ds.Tables[1].Rows[0]["state_name"].ToString() == ds.Tables[2].Rows[0]["state_name"].ToString())
                        rpt = new CrystalReportsPharmacy.eMediShop.WithinStateTransfer_Form();
                    else
                        rpt = new CrystalReportsPharmacy.eMediShop.InterState_TransferForm();

                    rpt.Database.Tables["InternalSheet"].SetDataSource(ds.Tables[0]);
                    rpt.SetParameterValue("Transfer_id", transfer_id);
                    rpt.SetParameterValue("FormName", "Form T-01");
                    rpt.SetParameterValue("from_company", ds.Tables[2].Rows[0]["comp_name"].ToString());
                    rpt.SetParameterValue("to_company", ds.Tables[1].Rows[0]["comp_name"].ToString());
                    rpt.SetParameterValue("FromUnit", ds.Tables[2].Rows[0]["unit_name"].ToString());
                    rpt.SetParameterValue("FromAddress", ds.Tables[2].Rows[0]["address"].ToString());
                    rpt.SetParameterValue("To_UnitName", ds.Tables[1].Rows[0]["unit_name"].ToString());
                    rpt.SetParameterValue("To_Address", ds.Tables[1].Rows[0]["address"].ToString());
                    rpt.SetParameterValue("TrfDate", Convert.ToDateTime(ds.Tables[1].Rows[0]["trf_date"]));
                    rpt.SetParameterValue("From_Tin_No", ds.Tables[2].Rows[0]["gstn_no"].ToString());
                    rpt.SetParameterValue("To_Tin_No", ds.Tables[1].Rows[0]["gstn_no"].ToString());
                    rpt.SetParameterValue("From_DLNo", ds.Tables[2].Rows[0]["dl_no"].ToString());
                    rpt.SetParameterValue("To_DLNo", ds.Tables[1].Rows[0]["dl_no"].ToString());
                    if (logic.ToUpper() == "PDF")
                    {
                        string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                        if (!dir.Exists)
                        { dir.Create(); }
                        if (System.IO.File.Exists(path + "\\" + transfer_id.Replace('/', '_') + ".pdf"))
                        { System.IO.File.Delete(path + "\\" + transfer_id.Replace('/', '_') + ".pdf"); }
                        rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + transfer_id.Replace('/', '_') + ".pdf");
                    }
                    else if (logic.ToUpper() == "PRINT")
                    {
                        rpt.PrintToPrinter(1, false, 1, 0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private static void GetOtherUnitInfo(string transfer_id)
            {
                DataSet ds = new DataSet();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "ShopInfoAsOnLICForTRf"; p.prm_1 = transfer_id; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

                ds = dwr.result;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    GlobalUsage.ou_UnitName = ds.Tables[0].Rows[0]["nameAsOnLic"].ToString();
                    GlobalUsage.ou_Address = ds.Tables[0].Rows[0]["Address_AOL"].ToString();
                    GlobalUsage.ou_district = ds.Tables[0].Rows[0]["district"].ToString();
                    GlobalUsage.ou_DL_No = ds.Tables[0].Rows[0]["drug_lic_no"].ToString();
                    GlobalUsage.ou_TIN_No = ds.Tables[0].Rows[0]["gstin"].ToString();
                }
                else
                {
                    GlobalUsage.ou_UnitName = "-";
                    GlobalUsage.ou_Address = "-";
                    GlobalUsage.ou_district = "-";
                    GlobalUsage.ou_DL_No = "-";
                    GlobalUsage.ou_TIN_No = "-";
                }
            }
            #region Goods Return Slip
            public static void Gr_Slip(DataTable dt, string Master_Gr_No, string gr_date, string vendor_gstn, string vendorName, string VendAddress, string compGSTNO)
            {
                try
                {
                    CrystalReportsPharmacy.Reports.gr_slip rpt = new CrystalReportsPharmacy.Reports.gr_slip();
                    rpt.Database.Tables["gr_slip"].SetDataSource(dt);
                    rpt.SetParameterValue("comp_name", GlobalUsage.Company);
                    rpt.SetParameterValue("unit_name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("gr_number", Master_Gr_No);
                    rpt.SetParameterValue("vendor_gstn", vendor_gstn);
                    rpt.SetParameterValue("vendor_name", vendorName);
                    rpt.SetParameterValue("vend_address", VendAddress);
                    rpt.SetParameterValue("compGSTNO", compGSTNO);
                    rpt.SetParameterValue("grDate", gr_date);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + vendorName.Substring(0, 10) + Master_Gr_No.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + vendorName.Substring(0, 10) + Master_Gr_No.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + vendorName.Substring(0, 10) + Master_Gr_No.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            public static void ExpiryReturn_Slip(DataTable dt, string Master_Gr_No, string gr_date, string vendor_gstn, string vendorName, string VendAddress)
            {
                try
                {
                    CrystalReportsPharmacy.Reports.gr_slip_2 rpt = new CrystalReportsPharmacy.Reports.gr_slip_2();

                    rpt.Database.Tables["gr_slip"].SetDataSource(dt);
                    rpt.SetParameterValue("compName", GlobalUsage.Company);
                    rpt.SetParameterValue("unit_name", GlobalUsage.UnitName);
                    rpt.SetParameterValue("address", GlobalUsage.UnitAddress);
                    rpt.SetParameterValue("gr_number", Master_Gr_No);
                    rpt.SetParameterValue("tin_no", GlobalUsage.GST_No);
                    rpt.SetParameterValue("vendor_name", vendorName);
                    rpt.SetParameterValue("vend_address", VendAddress);
                    rpt.SetParameterValue("grdate", gr_date);
                    rpt.PrintToPrinter(1, false, 1, 0);
                    string path = GlobalUsage.BillDrive + "\\pdf\\" + ExPro.Client.utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + vendorName.Substring(0, 10) + Master_Gr_No.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + vendorName.Substring(0, 10) + Master_Gr_No.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + vendorName.Substring(0, 10) + Master_Gr_No.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
            public static void LocalExpirySheet(DataTable dt, string Master_Gr_No)
            {
                try
                {
                    CrystalReportsPharmacy.Reports.LocalExpirySheet rpt = new CrystalReportsPharmacy.Reports.LocalExpirySheet();
                    rpt.Database.Tables["gr_unit_info"].SetDataSource(dt);
                    rpt.SetParameterValue("master_gr_no", Master_Gr_No);
                    rpt.PrintToPrinter(1, false, 1, 0);

                    string path = GlobalUsage.BillDrive + "\\pdf\\" + utility.GetFinYear(DateTime.Now.ToString("yyyy-MM-dd")) + "\\" + DateTime.Now.ToString("MMM");
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                    if (!dir.Exists)
                    { dir.Create(); }
                    if (System.IO.File.Exists(path + "\\" + Master_Gr_No.Replace('/', '_') + ".pdf"))
                    { System.IO.File.Delete(path + "\\" + Master_Gr_No.Replace('/', '_') + ".pdf"); }
                    rpt.ExportToDisk(ExportFormatType.PortableDocFormat, path + "\\" + Master_Gr_No.Replace('/', '_') + ".pdf");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }// End of Laser Printing Class

} //Last Brace

