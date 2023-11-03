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
//using J4L.TextPrinter;
//using J4L.TextPrinter.Ports;
//using J4L.TextPrinter.Printers;

namespace eMediShop
{
    public partial class BulkTransfer : Form
    {
        string _Trf_to = "";
        string _TrfUnit = "";
        string _trf_id = "";
        string UnitLedgerPosting_Name = "";

        //LPrinter MyPrinter=null;
        //PrinterPort port;//=new PrinterPort ;
        //TextPrinter printer;// =new TextPrinter;
        //JobProperties job;//=new JobProperties ;
        //J4L.TextPrinter.TextProperties txtprop = new J4L.TextPrinter.TextProperties();
        //J4L.TextPrinter.TextProperties txtprop1 = new J4L.TextPrinter.TextProperties();
        //J4L.TextPrinter.TextProperties txtPropUnd = new J4L.TextPrinter.TextProperties();
        string pTransferId = "";
        public BulkTransfer()
        {
            InitializeComponent();
            //MyPrinter = new LPrinter();
        }
        private void btnRcv_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Config.QueryExecute("delete from TempExtraProduct", "eMediShop");
            //webservice
            DataSet ds = GlobalUsage.pharmacy_proxy.BulkDispatchFromUnit(GlobalUsage.Unit_id);
            //Unit Filling
            DataSet ds_unit = GlobalUsage.pharmacy_proxy.GetUnitList(GlobalUsage.Unit_id, "StockTransfer", "new");
            cbxTrf_to.Items.Clear();
            cbxTrf_to.Items.AddRange(Config.FillCombo(ds_unit.Tables[0]));
            cbxTrf_to.SelectedIndex = 0;
            //
            //int  d = 0;
            //d = ds.Tables[0].Rows.Count;
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataTable stockTable = (DataTable)RecFrmStocks();
            Config.CheckDbConnect("eMediShop"); ;
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand("pInsTempExtraProduct", GlobalUsage.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 1500;
            string qry = "";
            foreach (DataRow dr in dt.Rows)
            {
                DataRow[] localDr = stockTable.Select("master_key_id='" + dr["master_key_id"].ToString() + "'");
                if (localDr.Length > 0)
                {
                    //DataRow LocalDr = Checkds.Tables[0].Rows[0];
                    string matchFlag = "";
                    string remark = "";
                    if (Convert.ToInt32(localDr[0]["quantity"]) >= Convert.ToInt32(dr["qty"]))
                    {
                        matchFlag = "Y"; remark = "OK";
                    }
                    else
                    {
                        matchFlag = "N";
                        remark = "Not Matching";
                        int qty = Convert.ToInt32(localDr[0]["quantity"]);
                        //GlobalUsage.pharmacy_proxy.TransferMisMatchInfo(GlobalUsage.Unit_id,dr["master_key_id"].ToString(),0,qty,"Extra Product Mismatch");
                    }
                    //Inserting in emedishop in tempExtraProd
                    cmd.Parameters.Add("@item_id", SqlDbType.NVarChar, 7).Value = dr["item_id"].ToString();
                    cmd.Parameters.Add("@master_key_id", SqlDbType.VarChar, 16).Value = dr["master_key_id"].ToString();
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = dr["qty"].ToString();
                    cmd.Parameters.Add("@match_flag", SqlDbType.Char, 1).Value = matchFlag;
                    cmd.Parameters.Add("@trf_flag", SqlDbType.Char, 1).Value = "N";
                    cmd.Parameters.Add("@remark", SqlDbType.VarChar, 100).Value = remark;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            fillMatch();
            fillMisMatch();
            Cursor.Current = Cursors.Default;
        }
        private DataTable RecFrmStocks()
        {
            Config.CheckDbConnect("eMediShop");
            string qry = "select  quantity ,master_key_id,pack_qty from stocks where quantity >0";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.Con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Filling Mismatch Product
        private void fillMisMatch()
        {
            Config.CheckDbConnect("eMediShop");
            string qry = @"SELECT     temp.master_key_id, temp.item_id, item.Item_Name, item.Shelf_No, temp.qty, dbo.Stocks.Pack_Type, dbo.Stocks.Pack_Qty
FROM         dbo.TempExtraProduct AS temp INNER JOIN
                      dbo.Item_Master AS item ON item.Item_id = temp.item_id INNER JOIN
                      dbo.Stocks ON temp.master_key_id = dbo.Stocks.master_key_id
WHERE     (temp.match_flag = 'N')";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.Con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow dr in dt1.Rows)
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
            Config.CheckDbConnect("eMediShop");
            string qry = @"SELECT     temp.master_key_id, temp.item_id, item.Item_Name, item.Shelf_No, temp.qty, dbo.Stocks.Pack_Type, dbo.Stocks.Pack_Qty
FROM         dbo.TempExtraProduct AS temp INNER JOIN
                      dbo.Item_Master AS item ON item.Item_id = temp.item_id INNER JOIN
                      dbo.Stocks ON temp.master_key_id = dbo.Stocks.master_key_id
WHERE     (temp.match_flag = 'Y') ";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.Con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow dr in dt1.Rows)
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
                cbxTrf_to.Enabled = true;
            }
            else
                cbxTrf_to.Enabled = false;

        }
        private void frmExtraProd_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            btnGenrateId.Enabled = false;
            btnTrfToHO.Enabled = false;
            ddlTrfId.Enabled = false;
        }
        //Generating Transfer Id.
        private string TransferProduct(string item_id, string master_key, int qty, string TransferTo, string login_id)
        {
            Config.CheckDbConnect("eMediShop"); ;
            SqlCommand cmd = new SqlCommand("Md_TrfStock", GlobalUsage.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.Parameters.Add("@trfno", SqlDbType.VarChar).Value = pTransferId;
            cmd.Parameters.Add("fromstore", SqlDbType.VarChar).Value = GlobalUsage.Unit_id;
            cmd.Parameters.Add("@tostore", SqlDbType.VarChar).Value = TransferTo;
            cmd.Parameters.Add("@itemid", SqlDbType.VarChar).Value = item_id;
            cmd.Parameters.Add("@master_key_id", SqlDbType.VarChar).Value = master_key;
            cmd.Parameters.Add("@qty", SqlDbType.Int).Value = qty;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = login_id;
            SqlParameter prm_result = new SqlParameter("@TrfNoAl", SqlDbType.VarChar, 20);

            prm_result.Value = "N/A";
            prm_result.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(prm_result);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Config.SaveErrorLog(GlobalUsage.Unit_id, "eMediShop", ErrorTracker.ErrorHistory(ex));
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); Config.SaveErrorLog(GlobalUsage.Unit_id, "eMediShop", ErrorTracker.ErrorHistory(ex)); return "";
            }

            return (string)prm_result.Value;
        }
        private void btnGenrateId_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnGenrateId.Enabled = false;
            ddlTrfId.Enabled = true;
            int chk = 0; string TrfId = "";
            foreach (ListViewItem li in lv_MatchDet.Items)
            {
                chk++;
                int qty = Convert.ToInt32(li.SubItems[5].Text);
                pTransferId = TransferProduct(li.SubItems[1].Text.ToString(), li.SubItems[0].Text.ToString(), qty, _Trf_to, GlobalUsage.Login_id);
                UpdateTrfFlag(li.SubItems[1].Text.ToString(), li.SubItems[0].Text.ToString());
                if (pTransferId != TrfId)
                {
                    ddlTrfId.Items.Insert(ddlTrfId.Items.Count - 1 + 1, pTransferId);
                }
                if (chk == 50)
                {
                    chk = 0; pTransferId = string.Empty;
                }
                TrfId = pTransferId;
            }
            if (ddlTrfId.Items.Count > 0)
                btnTrfToHO.Enabled = true;
            else
                btnTrfToHO.Enabled = false;
            Cursor.Current = Cursors.Default;
        }
        //Updating Transfer Flag.
        private void UpdateTrfFlag(string itemId, string masterKeyId)
        {
            Config.CheckDbConnect("eMediShop");
            string qry = "update TempExtraProduct set trf_flag='Y' where item_id='" + itemId + "' and master_key_id='" + masterKeyId + "'";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.Con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            cmd.ExecuteNonQuery();

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Config.CheckDbConnect("eMediShop");
            string qry = "select trf_id from TRF_MASTER where convert(varchar(10),trf_date,111)='" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' order by trf_id ";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.Con);
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
        private string getUnitNameForLedger(string trf_id)
        {
            string qry = "select trf_to,count(*) num from trf_items where trf_id='" + trf_id + "' and locked=0 group by trf_to";
            Config.CheckDbConnect("eMediShop"); ;
            SqlDataAdapter da = new SqlDataAdapter(qry, GlobalUsage.Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = Convert.ToInt32(dt.Rows[0]["num"]);
            if (count != 0)
                return GlobalUsage.pharmacy_proxy.GetUnitNameForLedger(dt.Rows[0]["trf_to"].ToString());
            else
                return "Not Found ";
        }
        private void btnTrfToHO_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds;
            Config.CheckDbConnect("eMediShop"); ;
            try
            {
                UnitLedgerPosting_Name = getUnitNameForLedger(_trf_id);
                string qry = @"SELECT master_key_id,convert(varchar(10),trf_date,111) trf_date, Trf_From, Trf_To, item_id, qty, Trf_id
                                FROM dbo.Trf_Items where trf_id='" + ddlTrfId.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, GlobalUsage.Con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                _Trf_to = ds.Tables[0].Rows[0]["trf_to"].ToString();
                string result = GlobalUsage.pharmacy_proxy.TransferStocks(ddlTrfId.Text, "Stock", GlobalUsage.Unit_id, _Trf_to, GlobalUsage.Login_id, ds);
                if (result.ToUpper() == "Success".ToUpper())
                {
                    string Voucher_No = Config.NewVoucherNo(GlobalUsage.Unit_id);
                    Config.CheckDbConnect("eMediShop");
                    cmd = new SqlCommand("StockTransfer_AC_Posting", GlobalUsage.Con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1500;
                    cmd.Parameters.Add("trf_id", SqlDbType.VarChar, 16).Value = ddlTrfId.Text;
                    cmd.Parameters.Add("shop_code", SqlDbType.VarChar, 10).Value = GlobalUsage.Unit_id;
                    cmd.Parameters.Add("trf_to_unit", SqlDbType.VarChar, 50).Value = UnitLedgerPosting_Name;
                    cmd.Parameters.Add("voucher_no", SqlDbType.VarChar, 16).Value = Voucher_No;
                    cmd.Parameters.Add("vch_date", SqlDbType.DateTime, 10).Value = DateTime.Now.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("operator", SqlDbType.VarChar, 10).Value = GlobalUsage.Login_id;
                    cmd.Parameters.Add("result", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    result = cmd.Parameters["result"].Value.ToString();
                }
                MessageBox.Show("Transfer " + result, "ExPro Help", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Config.SaveErrorLog(GlobalUsage.Unit_id, "eMediShop", ErrorTracker.ErrorHistory(ex));
            }
            finally { }
            Cursor.Current = Cursors.Default;

        }

        private void btn_PrintFormT03_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Is Printer Ready (Y/N) ?", "ExPro Help", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                dt = fillTrfIdDetail();
                Printing.Laser.Transfer_Form_T_03(dt, ddlTrfId.Text);
            }
        }
        private DataTable fillTrfIdDetail()
        {
            Config.CheckDbConnect("eMediShop"); ;
            string qry = @"select left(item_name,40) item_name,Batch_no,isnull(exp_date,'1900-01-01') exp_date,qty,(unit_pur_rate*qty) Amount from 
                           trf_items where trf_id='" + ddlTrfId.Text + "' order by item_name ";
            SqlCommand cmd = new System.Data.SqlClient.SqlCommand(qry, GlobalUsage.Con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            return dt;
        }
        private void ddlTrfId_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnTrfToHO.Enabled = true;
            _trf_id = ddlTrfId.SelectedItem.ToString();
            fillTransferedProduct(_trf_id);

        }
        private void fillTransferedProduct(string Trf_id)
        {
            string qry = @"SELECT dbo.Item_Master.Shelf_No, dbo.Item_Master.Item_Name, dbo.Item_Master.Item_id, dbo.Trf_Items.master_key_id, dbo.Trf_Items.pack_type, dbo.Trf_Items.pack_qty ,
                         dbo.Trf_Items.qty FROM  dbo.Trf_Items INNER JOIN dbo.Item_Master ON dbo.Trf_Items.item_id = dbo.Item_Master.Item_id where Trf_Items.trf_id='" + Trf_id + "' ";
            Config.CheckDbConnect("eMediShop"); ;
            SqlCommand cmd = new SqlCommand(qry, GlobalUsage.Con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1500;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                lv_View.Items.Clear();
                lv_View.BeginUpdate();
                foreach (DataRow dr in dt1.Rows)
                {
                    ListViewItem ls = new ListViewItem(dr["master_key_id"].ToString());
                    ls.SubItems.Add(dr["item_id"].ToString());
                    ls.SubItems.Add(dr["item_name"].ToString());
                    ls.SubItems.Add(dr["Pack_type"].ToString());
                    ls.SubItems.Add(dr["pack_qty"].ToString());
                    ls.SubItems.Add(dr["qty"].ToString());
                    ls.SubItems.Add(dr["shelf_no"].ToString());
                    lv_View.Items.Add(ls);
                }
                btnTrfToHO.Enabled = true;
                lv_View.EndUpdate();
            }
            else
                btnTrfToHO.Enabled = false;

        }
        private void btn_IntSheet_Click(object sender, EventArgs e)
        {
        }
        private void btn_Mismatch_Click(object sender, EventArgs e)
        {
            //if (lv_MisMatchDetail.Items.Count > 0) {
            //    Printing.DMP.ExtraMisMatchReport(lv_MisMatchDetail);
            //}
        }
        private void cbxTrf_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Trf_to = ((AddValue)cbxTrf_to.SelectedItem).Value;
            _TrfUnit = ((AddValue)cbxTrf_to.SelectedItem).NewDescription;
            btnGenrateId.Enabled = true;
        }
        private void lv_View_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string master_key_id = lv_View.Items[lv_View.FocusedItem.Index].SubItems[0].Text;
                string item_name = lv_View.Items[lv_View.FocusedItem.Index].SubItems[2].Text;
                DialogResult dlgresult = MessageBox.Show("Do You Confirm To Delete { " + item_name + " }", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgresult.ToString() == "Yes")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string result = string.Empty;
                        eMediShop_ServiceLibrary.StockTransaction.InterUnitStockTransfer.Del_RecordFromTransferId(
                        out result, GlobalUsage.Unit_id, _trf_id, master_key_id);
                        fillTransferedProduct(_trf_id);
                        MessageBox.Show(result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Config.SaveErrorLog(GlobalUsage.Unit_id, "eMediShop", ErrorTracker.ErrorHistory(ex));
                        MessageBox.Show(ex.Message, "Delete From Transfer");
                    }
                    finally { }
                    Cursor.Current = Cursors.Default;
                }
            }

        }

    } //Second Last Braces
}
