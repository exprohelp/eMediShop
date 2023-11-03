using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using eMediShop;
public partial class ucStockAtUnit : UserControl
    {
        DataSet pds = new DataSet();
        string pAction = "";
        public ucStockAtUnit()
        {
            InitializeComponent();
        }
        private void ucStockAtUnit_Load(object sender, EventArgs e)
        {
            pAction = "StockAtUnit";
            pbZeroStockUpdate.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }
        #region FOR FILLING STOCK
        public void fillStock()
        {
            decimal tqty = 0;
            decimal total = 0;
            string temp = "";
            Int32 i = new int();
            Int32 j = new int();
            string[] GrpItem;
                lv_Detail.Items.Clear();
                if (pds.Tables.Count > 0)
                {

                    DataRow[] drary = pds.Tables[0].Select();
                    if (pds.Tables[0].Rows.Count > 0)
                    {
                        GrpItem = new string[pds.Tables[0].Rows.Count];
                        foreach (DataRow dr in pds.Tables[0].Rows)
                        {
                            lv_Detail.ForeColor = System.Drawing.Color.Purple;
                            lv_Detail.Groups.Add(dr["item_name"].ToString(), dr["item_name"].ToString());
                            GrpItem[i] = lv_Detail.Groups[i].ToString();
                            i = i + 1;
                        }
                        i = 0;

                        foreach (DataRow dr in pds.Tables[0].Rows)
                        {
                            ListViewItem ls = new ListViewItem(dr["Batch_no"].ToString());
                            ls.SubItems.Add(dr["Pack_type"].ToString());
                            ls.SubItems.Add(Convert.ToDecimal(dr["Pack_qty"]).ToString());
                            ls.SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy"));
                            ls.SubItems.Add(Convert.ToDecimal(dr["npr"]).ToString("###.00"));
                            ls.SubItems.Add(Convert.ToDecimal(dr["upr"]).ToString("###.00"));
                            ls.SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("###.00"));
                            ls.SubItems.Add(Convert.ToDecimal(Convert.ToDecimal(dr["qty"]) * Convert.ToDecimal(dr["upr"])).ToString("###.00"));
                            ls.SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("###.00"));
                            ls.Group = lv_Detail.Groups[dr["Item_name"].ToString()];
                            lv_Detail.Items.Add(ls);
                            tqty += Convert.ToDecimal(Convert.ToDecimal(dr["qty"]));
                            total += Convert.ToDecimal(Convert.ToDecimal(dr["qty"]) * Convert.ToDecimal(dr["upr"]));
                            ListViewItem ls1 = new ListViewItem(dr["Batch_no"].ToString());
                            if (j < lv_Detail.Groups.Count - 1)
                                j = j + 1;
                            if (GrpItem[i] != lv_Detail.Groups[j].ToString())
                            {
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("Total Qty");
                                ls1.SubItems.Add(tqty.ToString());
                                ls1.SubItems.Add(total.ToString("###.00"));
                                ls1.SubItems.Add("");
                                ls1.Group = lv_Detail.Groups[dr["Item_name"].ToString()];
                                lv_Detail.Items.Add(ls1);
                                tqty = 0;
                                total = 0;
                                temp = dr["item_name"].ToString();

                            }
                            if (lv_Detail.Items.Count > 0)
                                btn_trfToxl.Enabled = true;
                            else
                                btn_trfToxl.Enabled = false;
                            if (i == pds.Tables[0].Rows.Count - 1)
                            {
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("");
                                ls1.SubItems.Add("Total Qty");
                                ls1.SubItems.Add(tqty.ToString());
                                ls1.SubItems.Add(total.ToString("###.00"));
                                ls1.SubItems.Add("");
                                ls1.Group = lv_Detail.Groups[dr["Item_name"].ToString()];
                                lv_Detail.Items.Add(ls1);
                                tqty = 0;
                                total = 0;
                                temp = dr["item_name"].ToString();

                            }
                            if (i <= pds.Tables[0].Rows.Count - 1)
                                i = i + 1;

                        }


                    }

            }
        }
        #endregion
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pAction == "StockAtUnit")
            {
                try
                {
                    pds = GlobalUsage.pharmacy_proxy.stockAtUnit(GlobalUsage.Unit_id, "CHCL");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pAction == "StockAtUnit")
            {
                fillStock();
                pbZeroStockUpdate.Visible = false;
            }
        }
        protected void GenerateCVSFormatForOverDues(string FileName, DataTable dt1)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item Name", typeof(string));
            dt.Columns.Add("Batch No", typeof(string));
            dt.Columns.Add("Pack Type", typeof(string));
            dt.Columns.Add("Pack Qtyt", typeof(string));
            dt.Columns.Add("Exp Date", typeof(string));
            dt.Columns.Add("Unit Stock", typeof(string));
            dt.Columns.Add("Physical Stock", typeof(string));
            foreach (DataRow dr1 in dt1.Rows)
            {

                DataRow dr = dt.NewRow();
                dr["Item Name"] = dr1["Item_name"].ToString();
                dr["Batch No"] = dr1["Batch_no"].ToString();
                dr["Pack Type"] = dr1["Pack_type"].ToString();
                dr["Pack Qtyt"] = dr1["Pack_qty"].ToString();
                dr["Exp Date"] = dr1["exp_date"].ToString();
                dr["Unit Stock"] = dr1["qty"].ToString();
                dr["Physical Stock"] = " ";

                dt.Rows.Add(dr);
            }

            CreateCSVFile(dt, FileName);
        }
        public void CreateCSVFile(DataTable dt, string strFilePath)
        {
            #region Export Grid to CSV
            // Create the CSV file to which grid data will be exported.
            StreamWriter sw = new StreamWriter(strFilePath, false);
            // First we will write the headers.
            //DataTable dt = m_dsProducts.Tables[0];
            int iColCount = dt.Columns.Count;
            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dt.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }

            sw.Write(sw.NewLine);
            // Now write all the rows.
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        sw.Write(dr[i].ToString());
                    }
                    if (i < iColCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
            #endregion
        }
        private void btn_trfToxl_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            Fbd.ShowDialog();
            string path = Fbd.SelectedPath + "\\" + GlobalUsage.Unit_id + "_InventoryStock.csv";
            Cursor.Current = Cursors.WaitCursor;
            GenerateCVSFormatForOverDues(path, pds.Tables[0]);
            Cursor.Current = Cursors.Default;

        }

    }

