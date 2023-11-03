using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI;
namespace eMediShop
{
    public partial class newProductOrderProcess : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; string[] search; string _tempid = string.Empty;

        int pIndex = 0;
        string _autoID = string.Empty; string _unitid = string.Empty; string _itemid = string.Empty; int _oldValue = 0;
        DataTable pDT = new DataTable();
        string SearchString = string.Empty; string _replaceBy = string.Empty;
        bool pLogic = false;
        public newProductOrderProcess()
        {
            InitializeComponent();
            rmcc.EditorControl.Columns.Add("ITEM NAME", "ITEM NAME", "item_name");
            rmcc.EditorControl.Columns.Add("ITEM ID", "ITEM ID", "item_id");
            rmcc.EditorControl.Columns[0].Width = 250;
            rmcc.EditorControl.Columns[1].Width = 80;

            rmcc.EditorControl.CurrentRowChanged += EditorControl_CurrentRowChanged;
        }
        private void EditorControl_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (e.CurrentRow != null)
            {
                GridViewRowInfo row = e.CurrentRow;
                _replaceBy = row.Cells[1].Value.ToString();
            }
        }
        private void tabNewMed_MouseClick(object sender, MouseEventArgs e)
        {
            if (Report.Focus() == true)
            {
                ddlSelectionType.ResetText();
                lv_reprot.Items.Clear();
            }

        }
        private void fillLocalItem()
        {
            lv_newMedicine.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "WHP:NewMedList"; p.prm_1 = "-"; p.prm_2 = "N/A"; p.prm_3 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                DataSet ds = dwr.result;

                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        lv_newMedicine.Groups.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy"), Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy"));
                    }
                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem li = new ListViewItem(dr["auto_id"].ToString().Trim());
                        li.SubItems.Add(dr["item_name"].ToString().Trim());
                        li.SubItems.Add(dr["unit_name"].ToString().Trim());
                        li.Group = lv_newMedicine.Groups[Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy")];
                        lv_newMedicine.Items.Add(li);
                    }
                    lv_newMedicine.Focus();
                    lv_newMedicine.Items[pIndex + 1].Selected = true;
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void fillReport(string type)
        {
            lv_reprot.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "WSP:NewMedReport"; p.prm_1 = type; p.prm_2 = "N/A"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                DataSet ds = dwr.result;
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string unitName = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (unitName != dr["unit_name"].ToString())
                        {
                            ListViewItem li = new ListViewItem(dr["unit_name"].ToString().ToUpper());
                            li.Font = new System.Drawing.Font("Arial Narrow", 8, System.Drawing.FontStyle.Bold);
                            li.ForeColor = Color.DarkRed;
                            lv_reprot.Items.Add(li);
                            ListViewItem li1 = new ListViewItem(dr["item_name"].ToString());
                            lv_reprot.Items.Add(li1);
                            unitName = dr["unit_name"].ToString();
                        }
                        else
                        {
                            ListViewItem li = new ListViewItem(dr["item_name"].ToString());
                            lv_reprot.Items.Add(li);
                        }
                    }
                    lv_reprot.Focus();
                    lv_reprot.Items[1].Selected = true;
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void lv_newMedicine_KeyDown(object sender, KeyEventArgs e)
        {
            string[] search;
            if (e.KeyCode == Keys.Enter)
            {
                SearchString = "";
                lv_CentralMed.Items.Clear();
                grpItemDet.Visible = false;
                if (lv_newMedicine.Items.Count > 0)
                    search = SearchProducts(lv_newMedicine.FocusedItem);
            }
        }

        private string[] SearchProducts(ListViewItem lvi)
        {
            if (lvi.Index > 1)
                pIndex = lvi.Index - 1;
            else
                pIndex = 0;
            if (lvi.SubItems[1].Text.IndexOf(' ') != -1)
            {
                txtSearch.Text = lvi.SubItems[1].Text;
                search = txtSearch.Text.Split(' ');
                txtSearch.Text = search[0];
                SearchString = search[0];
            }
            else
            {
                txtSearch.Text = lvi.SubItems[1].Text;
                SearchString = txtSearch.Text;
            }
            _autoID = lvi.SubItems[0].Text;
            pLogic = true;
            grp_Search.Visible = true;
            txtSearch.Focus();
            txtSearch.SelectAll();
            return search;
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNotFound.Visible = false;
                pLogic = true;
                SearchString = txtSearch.Text.Replace("-", "");
                lv_CentralMed.Items.Clear();
                if (txtSearch.Text.Length > 0)
                {
                    backgroundWorker1.RunWorkerAsync();
                    FillAfterSearch();
                }
                else { lv_newMedicine.Focus(); }
            }
            //Shift Focus on New Medicine
            if (e.KeyCode == Keys.Escape)
            {
                lv_newMedicine.Focus();
            }
        }

        protected void FillSearchList()
        {
            try
            {
                //DataSet ds = GlobalUsage.pws.SearchProduct2(out _result, SearchString);
                //pDT = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void lv_CentralMed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReplaceNewItems(lv_CentralMed.FocusedItem);
            }
        }

        private void ReplaceNewItems(ListViewItem lvi)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //string qry = "execute eMediCentral..pNewProdTempCode_Update '" + lvi.SubItems[0].Text.ToString() + "','" + lvi.SubItems[1].Text.ToString() + "','" + _autoID + "'";
                //ws.QueryExecute(qry, "eMediCentral");
                _autoID = string.Empty;
                lv_CentralMed.Items[pIndex + 1].Remove();
                // fillLocalItem();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void lv_CentralMed_MouseClick(object sender, MouseEventArgs e)
        {
            int g = e.Delta;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "ItemWithManufacturer"; p.prm_1 = lv_CentralMed.FocusedItem.SubItems[0].Text.ToString();
                p.prm_2 = "-"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                DataSet ds = dwr.result;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grpItemDet.Visible = true;
                    lblCode.Text = ds.Tables[0].Rows[0]["item_id"].ToString();
                    lblName.Text = ds.Tables[0].Rows[0]["item_name"].ToString();
                    lblMfd.Text = ds.Tables[0].Rows[0]["mfd_name"].ToString();
                    lblPtype.Text = ds.Tables[0].Rows[0]["pack_type"].ToString();
                    lblPsize.Text = ds.Tables[0].Rows[0]["pack_qty"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                    grpItemDet.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void frmNewMedicine_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);

            btnNotFound.Visible = false;
            grpItemDet.Visible = false;
        }
        private void btnNotFound_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ////string qry = @"update newMedicine set item_id='Not' where auto_id=" + _autoID;
                ////string result = ws.QueryExecute(qry, "Pharmacy_Data");
                ////if (result == "Success")
                ////    MessageBox.Show("Succesfully Transfred", "ExPro Help");
                ////else
                ////    MessageBox.Show("Faild to Update.", "ExPro Help");
                ////_autoID = "";
                //////fillLocalItem();
                ////lv_newMedicine.Items[pIndex + 1].Remove();
                btnNotFound.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void ddlSelectionType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fillReport(ddlSelectionType.SelectedText);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            lv_CentralMed.Items.Clear();
            grpItemDet.Visible = false;
            btnNotFound.Visible = false;
            txtSearch.Text = "";
            _autoID = "";
            fillLocalItem();
        }

        private void lv_CentralMed_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.item_id = lv_CentralMed.FocusedItem.SubItems[0].Text.ToString();
                p.Logic = "ItemWithManufacturer"; p.prm_1 = "-"; p.prm_2 = "N/A"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);

                DataSet ds = dwr.result;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    grpItemDet.Visible = true;
                    lblCode.Text = ds.Tables[0].Rows[0]["item_id"].ToString();
                    lblName.Text = ds.Tables[0].Rows[0]["item_name"].ToString();
                    lblMfd.Text = ds.Tables[0].Rows[0]["mfd_name"].ToString();
                    lblPtype.Text = ds.Tables[0].Rows[0]["pack_type"].ToString();
                    lblPsize.Text = ds.Tables[0].Rows[0]["pack_qty"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                    grpItemDet.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            SearchString = txtSearch.Text.Replace("-", "");
            backgroundWorker1.RunWorkerAsync();
        }
        protected void FillAfterSearch()
        {
            lv_CentralMed.Items.Clear();
            if (pDT.Rows.Count > 0)
            {
                foreach (DataRow dr in pDT.Rows)
                {
                    ListViewItem li = new ListViewItem(dr["item_id"].ToString());
                    li.SubItems.Add(dr["item_name"].ToString());
                    lv_CentralMed.Items.Add(li);
                }
                lv_CentralMed.Focus();
                lv_CentralMed.Items[0].Focused = true;
                lv_CentralMed.Items[0].Selected = true;
            }
            else
            {
                btnNotFound.Visible = true;
            }
            pDT.Clear();
            grp_Search.Visible = false;
        }
        private void lv_newMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_newMedicine.FocusedItem.Index > 0)
                lblUnit.Text = lv_newMedicine.Items[lv_newMedicine.FocusedItem.Index].SubItems[2].Text; ;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pLogic)
                FillSearchList();
            pLogic = false;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillAfterSearch();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //DataSet ds = GlobalUsage.pws.ProductQueries(out _result, GlobalUsage.gUnit_id,"-", "ExcelList", "-", "N/A");
            //if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            //    CreateCSVFile(ds.Tables[0]);
            //else
            //{ MessageBox.Show("Record not found"); }
            //Cursor.Current = Cursors.Default;     
        }
        public void CreateCSVFile(DataTable dt)
        {
            #region Export Grid to CSV
            // Create the CSV file to which grid data will be exported.
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
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
            byte[] buffer = ms.ToArray();
            if (buffer.Length > 0)
            {
                FolderBrowserDialog Fbd = new FolderBrowserDialog();
                Fbd.ShowDialog();
                string path = Fbd.SelectedPath + "\\" + "New_Medicine.csv";
                System.IO.File.WriteAllBytes(path, buffer);
            }
            #endregion
        }

        private void tabNewMed_Click(object sender, EventArgs e)
        {
            if (tabNewMed.SelectedTab.Tag == "Process")
            {
                try
                {
                    radPanel1.Controls.Clear();
                    NewProductProcess obj = new NewProductProcess();
                    radPanel1.Controls.Add(obj);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ExPro Help");
                }
            }
            else if (tabNewMed.SelectedTab.Tag.ToString() == "OrderInfo" || tabNewMed.SelectedTab.Tag.ToString() == "ReOrder")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //var data = GlobalUsage.cws.UrgentProd_Queries(out _result, GlobalUsage.Unit_id, "N/A", "N/A", "N/A", "N/A", "UrgentOrders", GlobalUsage.Login_id).
                    //    Tables[0].AsEnumerable().Select(o => new
                    //    {
                    //        order_no = o.Field<string>("order_no"),
                    //        orderdate = o.Field<string>("orderdate"),
                    //    }).ToList();
                    //rddl_OrderNo.DataSource = data;
                    rddl_OrderNo.DisplayMember = "orderdate";
                    rddl_OrderNo.ValueMember = "order_no";

                    //rddPendingOrd.DataSource = data;
                    rddPendingOrd.DisplayMember = "orderdate";
                    rddPendingOrd.ValueMember = "order_no";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ExPro Help");
                }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void rb_GetIt_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "ExcelList"; p.prm_1 = "N/A"; p.prm_2 = "N/A"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);

                radGridView1.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help");
            }
            Cursor.Current = Cursors.Default;
        }

        private void rb_exprot_Click(object sender, EventArgs e)
        {

            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();
                string fileName = f.SelectedPath + "\\NewProducts_" + DateTime.Now.ToString("yyyy_MM_dd") + ".xls";
                Cursor.Current = Cursors.WaitCursor;
                ExportToExcelML exporter = new ExportToExcelML(this.radGridView1);
                exporter.ExportVisualSettings = true;
                //exporter.SheetMaxRows = ExcelMaxRows._1048576;
                Cursor.Current = Cursors.WaitCursor;
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help");
            }
            Cursor.Current = Cursors.Default;
        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (_oldValue != Convert.ToInt16(e.Value.ToString()))
                {
                    if (e.Column.Name.ToString() == "QTY[P]")
                    {
                        cm1 p = new cm1();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                        p.Logic = "NewMedicine:QtyUpdate"; p.prm_1 = e.Value.ToString(); p.tran_id = _itemid.TrimEnd();
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void radGridView1_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            try
            {
                _unitid = e.Row.Cells[1].Value.ToString();
                _itemid = e.Row.Cells[2].Value.ToString();
                _oldValue = Convert.ToInt16(e.Row.Cells[6].Value.ToString());
            }
            catch (Exception ex) { }
        }

        private void lv_newMedicine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SearchString = string.Empty;
            lv_CentralMed.Items.Clear();
            grpItemDet.Visible = false;
            if (lv_newMedicine.Items.Count > 0)
                search = SearchProducts(lv_newMedicine.FocusedItem);
        }

        private void lv_CentralMed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReplaceNewItems(lv_CentralMed.FocusedItem);
        }

        private void rb_Go_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //DataSet ds = GlobalUsage.cws.UrgentProd_Queries(out _result, GlobalUsage.Unit_id, rddl_OrderNo.SelectedValue.ToString(), "N/A", "N/A", "N/A", "OrderInfo", GlobalUsage.gLogin_id);
                //rgv_OldOrderInfo.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { }
            Cursor.Current = Cursors.Default;

        }

        private void rgv_OldOrderInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rgb_tempReplace.Text = rgv_OldOrderInfo.CurrentRow.Cells[3].Value.ToString() + " [" + rgv_OldOrderInfo.CurrentRow.Cells[2].Value.ToString() + "]";
            _tempid = rgv_OldOrderInfo.CurrentRow.Cells[2].Value.ToString();
        }

        private void rmcc_TextChanged(object sender, EventArgs e)
        {
            if (rmcc.Text.Length > 3)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataSet ds = new DataSet(); //GlobalUsage.pws.SearchProduct2(out _result, rmcc.Text);
                    RadMultiColumnComboBoxElement combo = rmcc.MultiColumnComboBoxElement;
                    RadGridView grid = combo.EditorControl;
                    combo.AutoSizeDropDownHeight = true;
                    grid.Rows.Clear();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        GridViewRowInfo r = grid.Rows.NewRow();
                        //Telerik.WinControls.UI.GridViewRowInfo r = new GridViewRowInfo(grid.MasterView);
                        r.Cells[0].Value = dr["item_name"].ToString();
                        r.Cells[1].Value = dr["item_id"].ToString();
                        grid.Rows.AddRange(r);
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "ExPro Help"); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void rmcc_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    DataSet ds = GlobalUsage.pws.SearchProduct2(out _result, rmcc.Text);
            //    rmcc.EditorControl.Columns.Add("ITEM NAME", "ITEM NAME", "item_name");
            //    rmcc.EditorControl.Columns.Add("ITEM ID", "ITEM ID", "item_id");
            //    rmcc.EditorControl.Columns[0].Width = 250;
            //    rmcc.EditorControl.Columns[1].Width = 80;
            //    //rmcc.EditorControl.DataSource = ds.Tables[0];
            //    // get a reference to the combo box element
            //    RadMultiColumnComboBoxElement combo = rmcc.MultiColumnComboBoxElement;
            //    RadGridView grid = combo.EditorControl;
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //         Telerik.WinControls.UI.GridViewRowInfo r=new GridViewRowInfo(grid.MasterView);
            //         r.Cells[0].Value=dr["item_name"].ToString();
            //         r.Cells[1].Value=dr["item_id"].ToString();
            //        grid.Rows.AddRange(r);               
            //    }

            //}
        }

        private void rmcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRowInfo row = (sender as RadMultiColumnComboBox).SelectedItem as GridViewRowInfo;
            MessageBox.Show(row.Cells[0].Value.ToString());
        }

        private void rb_update_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string qry = "execute pNewProdTempCode_Update '" + _replaceBy + "','tempCodeReplace','" + _tempid + "'";
                //GlobalUsage.cws.QueryExecute(qry, "eMediCentral");
                MessageBox.Show("Updated Successfully", "ExPro Help");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "ExPro Help"); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void tabNewMed_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabNewMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabNewMed.SelectedIndex == 5)
            {
                panel_temp.Controls.Clear();
                eMediShop.warehouse.ucReplaceTempNewMed obj = new warehouse.ucReplaceTempNewMed();
                panel_temp.Controls.Add(obj);

            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //DataSet ds = GlobalUsage.cws.UrgentProd_Queries(out _result, GlobalUsage.gUnit_id, rddPendingOrd.SelectedValue.ToString(), "N/A", "N/A", "N/A", "Pending_Products", GlobalUsage.gLogin_id);
                //rgvPending.DataSource = ds.Tables[0];
                //ds.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "ExPro Help"); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvPending_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //DataSet ds = GlobalUsage.cws.UrgentProd_Queries(out _result, GlobalUsage.gUnit_id, rddPendingOrd.SelectedValue.ToString(), rgvPending.CurrentRow.Cells["ITEM ID"].Value.ToString(), "N/A", "N/A", "ProdInDistribution", GlobalUsage.gLogin_id);
                //radGridView2.DataSource = ds.Tables[0];
                //ds.Dispose();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "ExPro Help"); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string item_id = string.Empty; string unit_id = string.Empty; string med_name = string.Empty; int qty = 0;
                item_id = radGridView2.CurrentRow.Cells["item_id"].Value.ToString();
                unit_id = radGridView2.CurrentRow.Cells["unit_id"].Value.ToString();
                med_name = radGridView2.CurrentRow.Cells["item_name"].Value.ToString();
                qty = Convert.ToInt16(radGridView2.CurrentRow.Cells["Req_Packs"].Value.ToString());

                string qry = "insert into Pharmacy_Data..NewMedicine(shop_id,item_id,med_name,qty,status) values('";
                qry += unit_id + "','" + item_id + "','" + med_name + "'," + qty.ToString() + ",'N')";
                //GlobalUsage.cws.QueryExecute(qry, "pharmacy_data");
                radGridView2.CurrentRow.Delete();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "ExPro Help"); }
            finally { Cursor.Current = Cursors.Default; }
        }

    }
}
