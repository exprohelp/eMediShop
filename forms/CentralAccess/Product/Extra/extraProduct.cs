using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using eMediShop.Pharmacy;
using J4L.TextPrinter;
using J4L.TextPrinter.Ports;
using J4L.TextPrinter.Printers;

namespace eMediShop
{
    public partial class extraProduct : Form
    {
        string _TransferId = string.Empty; string _result = string.Empty;
        public extraProduct()
        {
            InitializeComponent();
        }
        private void btnRcv_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DbManager.QueryExecute("delete from TempExtraProduct where unit_id='"+GlobalUsage.gUnit_id+"'", "eMediShop");
            DataSet ds = GlobalUsage.cws.GetExtraProductsInfo(GlobalUsage.gUnit_id, "Transfer");
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataTable stockTable = (DataTable)RecFrmStocks();
            foreach (DataRow dr in dt.Rows)
            {
               
                DataRow[] localDr = stockTable.Select("master_key_id='" + dr["master_key_id"].ToString() + "'");
                if (localDr.Length  > 0)
                {
                    string matchFlag = "";string remark = "";
                    if (Convert.ToInt32(localDr[0]["packs"]) >= Convert.ToInt32(dr["packs"]))
                    {
                        matchFlag = "Y"; remark = "OK";
                    }
                    else
                    {
                        matchFlag = "N";
                        remark = "Not Matching";
                        int qty = Convert.ToInt32(localDr[0]["packs"]) * Convert.ToInt32(localDr[0]["pack_qty"]);
                    }
                    //Inserting in emedishop in tempExtraProd
                    eMediShop_ServiceLibrary.StockTransaction.extra.InsertInTemporaryTable(out _result, GlobalUsage.gUnit_id, dr["item_id"].ToString(),
                        dr["master_key_id"].ToString(), Convert.ToInt32(dr["packs"].ToString()), matchFlag, "N", remark);
                }
            }
            fillMatch();
            fillMisMatch();
            Cursor.Current = Cursors.Default;
        }
        private DataTable RecFrmStocks()
        {
            DataSet ds = eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(out _result, GlobalUsage.gUnit_id, "N/A", "stocksByMasterKeyId", "N/A", "N/A", "N/A");
            return ds.Tables[0];
        }
        //Filling Mismatch Product
        private void fillMisMatch()
        {
            DataSet ds = eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(
                out _result, GlobalUsage.gUnit_id, "N/A", "ExtraMatchMisMatch", "N", "N/A", "N/A");

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListViewItem ls = new ListViewItem(dr["master_key_id"].ToString());
                    ls.SubItems.Add(dr["item_id"].ToString());
                    ls.SubItems.Add(dr["item_name"].ToString());
                    ls.SubItems.Add(dr["Pack_type"].ToString());
                    ls.SubItems.Add(dr["pack_qty"].ToString());
                    ls.SubItems.Add(dr["qty"].ToString());
                    ls.SubItems.Add(dr["shelf_no"].ToString());
                    lv_MisMatchDetail.Items.Add(ls);
                }
            }
            if (lv_MisMatchDetail.Items.Count > 1)
                btn_Mismatch.Enabled = true;
            else btn_Mismatch.Enabled = false;
           
        }
        //Filling Match Product
        private void fillMatch()
        {
            DataSet ds = eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(
                out _result, GlobalUsage.gUnit_id, "N/A", "ExtraMatchMisMatch", "Y", "N/A", "N/A");

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    ListViewItem ls = new ListViewItem(dr["master_key_id"].ToString());
                    ls.SubItems.Add(dr["item_id"].ToString());
                    ls.SubItems.Add(dr["item_name"].ToString());
                    ls.SubItems.Add(dr["Pack_type"].ToString());
                    ls.SubItems.Add(dr["pack_qty"].ToString());
                    ls.SubItems.Add(dr["qty"].ToString());
                    ls.SubItems.Add(dr["shelf_no"].ToString());
                    lv_MatchDet.Items.Add(ls);
                }
                btnGenrateId.Enabled = true;
            }
            else
                btnGenrateId.Enabled = false;
           
        }
        private void frmExtraProd_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 120);
            btnGenrateId.Enabled = false;
            btnTrfToHO.Enabled = false;
            ddlTrfId.Enabled = false;
        }
        //Generating Transfer Id.
        private string TransferProduct(string item_id, string master_key_id, int qty, string TransferTo, string login_id)
        {
            string trf_id = string.Empty;
            trf_id=eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.TransferStocks(
              out _result, _TransferId, GlobalUsage.gUnit_id, TransferTo, item_id, master_key_id, qty, GlobalUsage.gLogin_id);
            return trf_id;
        }
        private void btnGenrateId_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnGenrateId.Enabled = false;
            ddlTrfId.Enabled = true;
            int nos = 0;
            _TransferId = GlobalUsage.cws.NewTrfId(out _result, GlobalUsage.gUnit_id);
            ddlTrfId.Items.Insert(ddlTrfId.Items.Count - 1 + 1, _TransferId);
            foreach (ListViewItem li in lv_MatchDet.Items)
            {
                nos++;
                int qty=Convert.ToInt32(li.SubItems[5].Text)*Convert.ToInt32(li.SubItems[4].Text);
                _TransferId = TransferProduct(li.SubItems[1].Text.ToString(), li.SubItems[0].Text.ToString(), qty, "MS-00001", GlobalUsage.gLogin_id);
                
                UpdateTrfFlag(li.SubItems[1].Text.ToString(), li.SubItems[0].Text.ToString());

                if (nos == 50)
                {
                    nos = 0; _TransferId = GlobalUsage.cws.NewTrfId(out _result, GlobalUsage.gUnit_id);
                    ddlTrfId.Items.Insert(ddlTrfId.Items.Count - 1 + 1, _TransferId);
                }
                
            }
            if (ddlTrfId.Items.Count > 0)
                btnTrfToHO.Enabled = true;
            else
                btnTrfToHO.Enabled = false;
            Cursor.Current = Cursors.Default;
        }
        //Updating Transfer Flag.
        private void UpdateTrfFlag(string item_id,string master_Key_Id)
        {
            DataSet ds = eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(
            out _result, GlobalUsage.gUnit_id, "N/A", "Extra:UpdateMasterKeyId", item_id, master_Key_Id, "N/A");
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Config.CheckDbConnect("eMediShop");
            string qry = "select trf_id from TRF_MASTER where convert(varchar(10),trf_date,111)='" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' and lock_flag=0 order by trf_id ";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.gCon);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ddlTrfId.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    ddlTrfId.Items.Insert(ddlTrfId.Items.Count - 1 + 1, dr["trf_id"].ToString());
                }
                ddlTrfId.Enabled = true;
                btnTrfToHO.Enabled = true;
            }
            else
                ddlTrfId.Enabled = false;
            btnTrfToHO.Enabled = false;
        }
        private void btnTrfToHO_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds=new DataSet();
            Config.CheckDbConnect("eMediShop");
            try
            {
                ds=eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(
                out _result, GlobalUsage.gUnit_id, ddlTrfId.Text, "Extra:UpdateMasterKeyId", "N/A", "N/A", "N/A");
                string result = GlobalUsage.cws.TransferStocks(ddlTrfId.Text, "Extra", GlobalUsage.gUnit_id,"-", GlobalUsage.gLogin_id, ds);
                if (result.ToUpper() == "Success".ToUpper())
                {
                    _result = GlobalUsage.cws.StockTransferClosing(out _result, ddlTrfId.Text, GlobalUsage.gUnit_id, "MS-00001","Transfer", GlobalUsage.gLogin_id, "N/A");
                    if (GlobalUsage.gUnit_id.Substring(4, 4)==_result.Substring(0, 4))
                    {
                        ds = eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(out _result, GlobalUsage.gUnit_id, ddlTrfId.Text, "CloseTransferId", _result, "N/A", "N/A");
                    }
                }
                MessageBox.Show("Transfer " + _result,"ExPro Help",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                DbManager.SaveErrorLog(GlobalUsage.gUnit_id, "eMediShop", ErrorTracker.ErrorHistory(ex));
            }
            finally { }
            Cursor.Current = Cursors.Default;

        }
        private void btn_PrintFormT03_Click(object sender, EventArgs e)
        {
            PrintFormT03();
        }
//        private DataTable fillTrfIdDetail()
//        {
//            Config.CheckDbConnect("eMediShop");
//            string qry = @"select left(item_name,40) item_name,Batch_no,isnull(exp_date,'1900-01-01') exp_date,qty,(unit_pur_rate*qty) Amount from 
//                           trf_items where trf_id='"+ddlTrfId.Text+"' order by item_name ";
//            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.gCon);
//            cmd.CommandType = CommandType.Text;
//            cmd.CommandTimeout = 1500;
//            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
//            DataTable dt = new DataTable();
//            da1.Fill(dt);
           
//            return dt;
//        }

        private void ddlTrfId_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTrfToHO.Enabled = true;
        }

        private void btn_IntSheet_Click(object sender, EventArgs e)
        {
            PrintInternalSheet();
        }
        private void PrintInternalSheet()
        {
            if (GlobalUsage.gPrinterType == "LASER")
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DataSet ds = eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(out _result, GlobalUsage.gUnit_id, ddlTrfId.Text, "TransferId_InfoByShelfNo", "N/A", "N/A", "N/A");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        CrystalReportsPharmacy.eMediShop.InternalSheet rpt = new CrystalReportsPharmacy.eMediShop.InternalSheet();
                        rpt.Database.Tables["InternalSheet"].SetDataSource(ds.Tables[0]);
                        rpt.SetParameterValue("Unit_name", GlobalUsage.gUnitName);
                        rpt.SetParameterValue("Address", GlobalUsage.gAddress);
                        rpt.SetParameterValue("trf_id", ddlTrfId.Text);
                        rpt.PrintToPrinter(1, false, 1, 0);
                    }
                    else { MessageBox.Show("Record Not Found"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                Cursor.Current = Cursors.Default;
            }
           
        }
        private void PrintFormT03()
        {

            if (GlobalUsage.gPrinterType == "LASER")
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    DataSet ds = eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.StocksTransSelectQueries(out _result, GlobalUsage.gUnit_id, ddlTrfId.Text, "TransferId_InfoByShelfNo", "N/A", "N/A", "N/A");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        CrystalReportsPharmacy.eMediShop.Transfer_Form_T_01 rpt = new CrystalReportsPharmacy.eMediShop.Transfer_Form_T_01();
                        rpt.Database.Tables["InternalSheet"].SetDataSource(ds.Tables[0]);//in Reports.Dataset
                        rpt.SetParameterValue("FromUnit", GlobalUsage.gUnitName);
                        rpt.SetParameterValue("FromAddress", GlobalUsage.gAddress);
                        rpt.SetParameterValue("from_tin_no", GlobalUsage.gVAT_No); 
                        rpt.SetParameterValue("To_UnitName", "Chandan Health Care Ltd.[MS-00001] ");
                        rpt.SetParameterValue("To_Address", "Indradeep Complex,Sanjay Gandhi Puram,Faizabad Road,Lucknow ");
                        rpt.SetParameterValue("to_tin_no", GlobalUsage.gVAT_No);
                        rpt.SetParameterValue("Transfer_Id", ddlTrfId.Text);
                        rpt.SetParameterValue("FormName", "Transfer Form[T-03]");
                        rpt.SetParameterValue("TrfDate", Convert.ToDateTime(ds.Tables[0].Rows[0]["trf_date"]).ToString("dd-MM-yyyy"));
                        rpt.PrintToPrinter(1, false, 1, 0);
                    }
                    else { MessageBox.Show("Record Not Found"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                Cursor.Current = Cursors.Default;
            }
        }
        
        private void btn_Mismatch_Click(object sender, EventArgs e)
        {
            //if (lv_MisMatchDetail.Items.Count > 0) {
            //    Printing.DMP.ExtraMisMatchReport(lv_MisMatchDetail);
            //}
        }
    }
}
