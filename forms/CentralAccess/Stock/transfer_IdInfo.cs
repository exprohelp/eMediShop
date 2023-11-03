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

namespace eMediShop
{
    public partial class transfer_IdInfo : Form
    {
        DataSet pds = new DataSet();
        string pAction = "";
        string pTrf_Id = "";
          
        public transfer_IdInfo()
        {
            InitializeComponent();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (tabControl1.SelectedIndex == 0)
            { if (!backgroundWorker1.IsBusy) pAction = "Transfer";  backgroundWorker1.RunWorkerAsync(); }
            else if (tabControl1.SelectedIndex == 1)
            { if (!backgroundWorker1.IsBusy) pAction = "Receiving"; backgroundWorker1.RunWorkerAsync(); }
            else if (tabControl1.SelectedIndex == 2)
            { if (!backgroundWorker1.IsBusy) pAction = "Local Purchase Info"; backgroundWorker1.RunWorkerAsync(); }
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pAction == "Transfer")
            {
                #region Transfer
               try
                {
                    string qry = @"select trf_type,trf_id,dbo.fnGetShopName(trf_from) from_unit ,dbo.fnGetShopName(trf_to) to_unit,trf_date,isnull(no_of_item,0) no_of_item from trf_master 
                             WHERE trf_from='" + GlobalUsage.Unit_id + "' and trf_to!='" + GlobalUsage.Unit_id + "' and ImportFlag!='Y' and lock=1";
                    pds = GlobalUsage.pharmacy_proxy.GetQueryResult(qry);
                }
                catch (Exception ex)
                {
                    
                }
                #endregion
            }
            if(pAction =="Receiving")
            {
                #region Receiving
                try
                {
                    string qry = @"select trf_type,trf_id,dbo.fnGetShopName(trf_from) from_unit ,dbo.fnGetShopName(trf_to) to_unit,trf_date,isnull(no_of_item,0) no_of_item from trf_master 
                             WHERE trf_from!='" + GlobalUsage.Unit_id + "' and trf_to='" + GlobalUsage.Unit_id + "' and ImportFlag!='Y' and lock=1";
                    pds = GlobalUsage.pharmacy_proxy.GetQueryResult(qry);
                }
                catch (Exception ex)
                {
                    
                }
            	#endregion            
            }
            if (pAction == "Local Purchase Info")
            {
                #region Local Purchase Info
                try
                {
                    string qry = "execute pLocalPurchaseTrfId  '" + GlobalUsage.Unit_id + "','N/A','Transfer Id'";
                    pds = GlobalUsage.pharmacy_proxy.GetQueryResult(qry);
                }
                catch (Exception ex)
                {
                    
                }
                #endregion
            }
            if (pAction == "Local Purchase Detail")
            {
                #region Local Purchase Info
                try
                {
                    string qry = "execute pLocalPurchaseTrfId  '" + GlobalUsage.Unit_id + "','"+pTrf_Id +"','Detail'";
                    pds = GlobalUsage.pharmacy_proxy.GetQueryResult(qry);
                }
                catch (Exception ex)
                {
                    
                }
                #endregion
            }

            if (pAction=="TransferItemsInfo")
            {
                #region TransferItemsInfo
                try
                {
                    string qry = @" SELECT   distinct  dbo.Item_Master.Item_Name, dbo.Trf_Items.qty, dbo.Stocks.Pack_Type, dbo.Stocks.Pack_Qty, dbo.Stocks.Batch_No,
                                 dbo.Stocks.Exp_Date,dbo.Stocks.unit_pur_rate  FROM dbo.Trf_Items INNER JOIN dbo.Item_Master ON dbo.Trf_Items.item_id = dbo.Item_Master.Item_id INNER JOIN
                                 dbo.Stocks ON dbo.Trf_Items.master_key_id = dbo.Stocks.Master_Key_id where  dbo.Trf_Items.trf_id='" + pTrf_Id + "' and trf_from='" + GlobalUsage.Unit_id + "' and trf_to!='" + GlobalUsage.Unit_id + "'";
                    pds = GlobalUsage.pharmacy_proxy.GetQueryResult(qry);
                }
                catch (Exception ex)
                {
                   
                }
                #endregion
            }
            if (pAction == "ReceivedItemsInfo")
            {
                #region ReceivedItemsInfo
                try
                {
                    string qry = @" SELECT   distinct  dbo.Item_Master.Item_Name, dbo.Trf_Items.qty, dbo.Stocks.Pack_Type, dbo.Stocks.Pack_Qty, dbo.Stocks.Batch_No,
                                 dbo.Stocks.Exp_Date,dbo.Stocks.unit_pur_rate  FROM dbo.Trf_Items INNER JOIN dbo.Item_Master ON dbo.Trf_Items.item_id = dbo.Item_Master.Item_id INNER JOIN
                                 dbo.Stocks ON dbo.Trf_Items.master_key_id = dbo.Stocks.Master_Key_id where  dbo.Trf_Items.trf_id='" + pTrf_Id + "' and trf_from!='" + GlobalUsage.Unit_id + "' and trf_to='" + GlobalUsage.Unit_id + "'";
                    pds = GlobalUsage.pharmacy_proxy.GetQueryResult(qry);
                }
                catch (Exception ex)
                {
                    
                }
                #endregion
            }
        }
        private void fillTransferProduct()
        {
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    lv_Transfer.Items.Clear();
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                        lv_Transfer.Items.Add(dr["from_unit"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["to_unit"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["trf_id"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["trf_type"].ToString());
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MMM-yyyy"));
                        lv_Transfer.Items[lv_Transfer.Items.Count - 1].SubItems.Add(dr["no_of_item"].ToString());
                    }
                }
            }
        }
        private void fillReceivedItem()
        {
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    lv_Recieving.Items.Clear();
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                        lv_Recieving.Items.Add(dr["from_unit"].ToString());
                        lv_Recieving.Items[lv_Recieving.Items.Count - 1].SubItems.Add(dr["to_unit"].ToString());
                        lv_Recieving.Items[lv_Recieving.Items.Count - 1].SubItems.Add(dr["trf_id"].ToString());
                        lv_Recieving.Items[lv_Recieving.Items.Count - 1].SubItems.Add(dr["trf_type"].ToString());
                        lv_Recieving.Items[lv_Recieving.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MMM-yyyy"));
                        lv_Recieving.Items[lv_Recieving.Items.Count - 1].SubItems.Add(dr["no_of_item"].ToString());
                    }
                }
            }
        }
        private void fillTransferProductDetail()
        {
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    listView1.Items.Clear();
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                        listView1.Items.Add(dr["item_name"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if(dr["exp_date"].ToString()=="")
                         listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                        else if(Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") == "01-01-1900")
                         listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                        else
                         listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["unit_pur_rate"]).ToString("##.00"));
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                     }
                }
            }
        }
        private void FillLocalPurchaseIdInfo() {
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    lp_id.Items.Clear();
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                        lp_id.Items.Add(dr["purch_id"].ToString());
                        if (dr["inv_date"].ToString() == "")
                            lp_id.Items[lp_id.Items.Count - 1].SubItems.Add("");
                        else if (Convert.ToDateTime(dr["inv_date"]).ToString("dd-MM-yyyy") == "01-01-1900")
                            lp_id.Items[lp_id.Items.Count - 1].SubItems.Add("");
                        else
                            lp_id.Items[lp_id.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["inv_date"]).ToString("dd-MM-yyyy"));
                        lp_id.Items[lp_id.Items.Count - 1].SubItems.Add(dr["trf_id"].ToString());
                        lp_id.Items[lp_id.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MM-yyyy"));
                        lp_id.Items[lp_id.Items.Count - 1].SubItems.Add(dr["voucher_no"].ToString());
                        lp_id.Items[lp_id.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["no_of_item"]).ToString("##"));
                    }
                }
            }
        }
        private void FillLocalPurchaseIdDetail() {
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    lp_id_detail.Items.Clear();
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                        lp_id_detail.Items.Add(dr["item_name"].ToString());
                        lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (dr["exp_date"].ToString() == "")
                            lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add("");
                        else if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") == "01-01-1900")
                            lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add("");
                        else
                            lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                        lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                        lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["unit_pur_rate"]).ToString("##.00"));
                        lp_id_detail.Items[lp_id_detail.Items.Count - 1].SubItems.Add(dr["qty"].ToString());

                        if (dr["import_flag"].ToString() == "Y")
                            lp_id_detail.Items[lp_id_detail.Items.Count - 1].ForeColor = Color.DarkGreen;
                        else
                            lp_id_detail.Items[lp_id_detail.Items.Count - 1].ForeColor = Color.Blue;

                    }
                }
            }
        }
        private void fillReceivedProductDetail()
        {
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    listView2.Items.Clear();
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                        listView2.Items.Add(dr["item_name"].ToString());
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (dr["exp_date"].ToString() == "")
                            listView2.Items[listView2.Items.Count - 1].SubItems.Add("");
                        else if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") == "01-01-1900")
                            listView2.Items[listView2.Items.Count - 1].SubItems.Add("");
                        else
                            listView2.Items[listView2.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["unit_pur_rate"]).ToString("##.00"));
                        listView2.Items[listView2.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                    }
                }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(pAction == "Transfer")
               fillTransferProduct();
            if(pAction =="Receiving")
               fillReceivedItem();
            if(pAction == "TransferItemsInfo")
               fillTransferProductDetail();
            if (pAction== "ReceivedItemsInfo")
                fillReceivedProductDetail();
            if (pAction == "Local Purchase Info")
                FillLocalPurchaseIdInfo();
            if (pAction == "Local Purchase Detail")
                FillLocalPurchaseIdDetail();
            pds.Clear();
            progressBar1.Visible =false;
        }
        private void transfer_IdInfo_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);  
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy) { pAction = "Transfer"; backgroundWorker1.RunWorkerAsync(); }
           
        }
        private void lv_Transfer_KeyDown(object sender, KeyEventArgs e)
        {
            pAction ="TransferItemsInfo";
            pTrf_Id = lv_Transfer.Items[lv_Transfer.FocusedItem.Index].SubItems[2].Text;
            progressBar1.Visible = true;
            if(!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void lv_Recieving_KeyDown(object sender, KeyEventArgs e)
        {
            pAction = "ReceivedItemsInfo";
            pTrf_Id = lv_Recieving.Items[lv_Recieving.FocusedItem.Index].SubItems[2].Text;
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void lp_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) {
                pAction = "Local Purchase Detail";
                pTrf_Id = lp_id.Items[lp_id.FocusedItem.Index].SubItems[2].Text;
                progressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
 
            }
        }
    }
}
