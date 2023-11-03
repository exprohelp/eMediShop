using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace eMediShop.Products
{
    public partial class frmNewMedicine : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; string[] search; string _tempid = string.Empty;

        int pIndex = 0;
        string _autoID = string.Empty; string _unitid = string.Empty; string _itemid = string.Empty; int _oldValue = 0;
        DataTable pDT = new DataTable();
        string SearchString = string.Empty; string _replaceBy = string.Empty;
        bool pLogic = false;
        public frmNewMedicine()
        {
            InitializeComponent();

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
                cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "WHP:NewMedList"; p.prm_1 = "-"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                DataTable dt = dwr.result.Tables[0];
                if (dt.Rows.Count > 0)
                {

                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem li = new ListViewItem(dr["auto_id"].ToString().Trim());
                        li.SubItems.Add(dr["item_name"].ToString().Trim());
                        li.SubItems.Add(dr["unit_name"].ToString().Trim());
                        lv_newMedicine.Items.Add(li);
                    }
                    lv_newMedicine.Focus();
                    if (dt.Rows.Count > 0)
                        lv_newMedicine.Items[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                    RadMessageBox.Show("No Record Found.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void fillReport(string type)
        {
            lv_reprot.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1();
                p.Logic = "NewMedReport"; p.prm_1 = "-"; p.login_id = GlobalUsage.Login_id; p.unit_id = GlobalUsage.Unit_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                DataTable dt = dwr.result.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    string unitName = "";
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (unitName != dr["sh_name"].ToString())
                        {
                            ListViewItem li = new ListViewItem(dr["sh_name"].ToString().ToUpper());
                            li.Font = new System.Drawing.Font("Arial Narrow", 8, System.Drawing.FontStyle.Bold);
                            li.ForeColor = Color.DarkRed;
                            lv_reprot.Items.Add(li);
                            ListViewItem li1 = new ListViewItem(dr["Med_name"].ToString());
                            lv_reprot.Items.Add(li1);
                            unitName = dr["sh_name"].ToString();
                        }
                        else
                        {
                            ListViewItem li = new ListViewItem(dr["Med_name"].ToString());
                            lv_reprot.Items.Add(li);
                        }
                    }
                    lv_reprot.Focus();
                    lv_reprot.Items[1].Selected = true;
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                    RadMessageBox.Show("No Record Found.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
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
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                        FillAfterSearch();
                    }
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
                cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "Search:InProduct"; p.prm_1 = SearchString; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                pDT = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
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
                prm_newProduct p = new prm_newProduct();
                p.logic = "tempCodeReplace"; p.sale_inv_no = _autoID; p.item_id = lvi.SubItems[0].Text.ToString();
                p.item_name = lvi.SubItems[1].Text.ToString();p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);

                _autoID = string.Empty;
                if (dwr.message.Contains("Success"))
                    lv_newMedicine.Items[lv_newMedicine.FocusedItem.Index].Remove();
                else
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                // fillLocalItem();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void lv_CentralMed_MouseClick(object sender, MouseEventArgs e)
        {
            int g = e.Delta;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "ItemWithManufacturer"; p.prm_1 = lv_CentralMed.FocusedItem.SubItems[0].Text.ToString(); p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    grpItemDet.Visible = true;
                    lblCode.Text = dwr.result.Tables[0].Rows[0]["item_id"].ToString();
                    lblName.Text = dwr.result.Tables[0].Rows[0]["item_name"].ToString();
                    lblMfd.Text = dwr.result.Tables[0].Rows[0]["mfd_name"].ToString();
                    lblPtype.Text = dwr.result.Tables[0].Rows[0]["pack_type"].ToString();
                    lblPsize.Text = dwr.result.Tables[0].Rows[0]["pack_qty"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                    grpItemDet.Visible = false;
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void frmNewMedicine_Load(object sender, EventArgs e)
        {
            //Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            //int size = (rec.Size.Width - this.Width) / 2;
            //this.Location = new System.Drawing.Point(size, 165);

            btnNotFound.Visible = false;
            grpItemDet.Visible = false;
        }
        private void btnNotFound_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                prm_newProduct p = new prm_newProduct();
                p.logic = "ItemWithManufacturer"; p.sale_inv_no = _autoID;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                _autoID = "";
                //fillLocalItem();
                lv_newMedicine.Items[pIndex + 1].Remove();
                btnNotFound.Visible = false;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
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
                cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "ItemWithManufacturer"; p.prm_1 = lv_CentralMed.FocusedItem.SubItems[0].Text.ToString(); p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);

                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    grpItemDet.Visible = true;
                    lblCode.Text = dwr.result.Tables[0].Rows[0]["item_id"].ToString();
                    lblName.Text = dwr.result.Tables[0].Rows[0]["item_name"].ToString();
                    lblMfd.Text = dwr.result.Tables[0].Rows[0]["mfd_name"].ToString();
                    lblPtype.Text = dwr.result.Tables[0].Rows[0]["pack_type"].ToString();
                    lblPsize.Text = dwr.result.Tables[0].Rows[0]["pack_qty"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found.", "ExPro Help");
                    grpItemDet.Visible = false;
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
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
           
        }

        private void rb_GetIt_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "ExcelList"; p.prm_1 = "-"; p.login_id = GlobalUsage.Login_id;
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
                        prm_newProduct p = new prm_newProduct();
                        p.unit_id = _unitid;
                        p.logic = "UpdateQty"; p.item_id = _itemid.TrimEnd(); p.qty = Convert.ToInt32(e.Value.ToString());
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);
                        MessageBox.Show(dwr.message, "ExPro Help");
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
                pmOpenOrder p = new pmOpenOrder();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.order_no = rddl_OrderNo.Text; p.logic = "VIEW_ORDER";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderNewMedicine", p);

                rgv_OldOrderInfo.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { }
            Cursor.Current = Cursors.Default;

        }

        private void rgv_OldOrderInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rgb_tempReplace.Text = rgv_OldOrderInfo.CurrentRow.Cells[3].Value.ToString() + " [" + rgv_OldOrderInfo.CurrentRow.Cells[2].Value.ToString() + "]";
            _tempid = rgv_OldOrderInfo.CurrentRow.Cells[2].Value.ToString();
        }



        private void rb_update_Click(object sender, EventArgs e)
        {

        }

        private void tabNewMed_TabIndexChanged(object sender, EventArgs e)
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
            else if (tabNewMed.SelectedTab.Tag == "OrderInfo" || tabNewMed.SelectedTab.Tag == "ReOrder")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pmOpenOrder p = new pmOpenOrder();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.order_no = "-"; p.logic = "UrgentOrders";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderNewMedicine", p);
                    if (dwr.result.Tables[0].Rows.Count > 0)
                    {
                        var data = dwr.result.Tables[0].AsEnumerable().Select(o => new
                        {
                            order_no = o.Field<string>("order_no"),
                            orderdate = o.Field<string>("order_date"),
                        }).ToList();
                        rddl_OrderNo.DataSource = data;
                        rddl_OrderNo.DisplayMember = "order_date";
                        rddl_OrderNo.ValueMember = "order_no";

                        rddPendingOrd.DataSource = data;
                        rddPendingOrd.DisplayMember = "order_date";
                        rddPendingOrd.ValueMember = "order_no";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ExPro Help");
                }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void tabNewMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabNewMed.SelectedTab.Tag == "Process")
            {
                try
                {
                    splitPanel2.Controls.Clear();
                    NewProductProcess obj = new NewProductProcess();
                    splitPanel2.Controls.Add(obj);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ExPro Help");
                }
            }
            else if (tabNewMed.SelectedTab.Tag == "OrderInfo" || tabNewMed.SelectedTab.Tag == "ReOrder")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pmOpenOrder p = new pmOpenOrder();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.order_no = "-"; p.logic = "UrgentOrders";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderNewMedicine", p);
                    if (dwr.result.Tables[0].Rows.Count > 0)
                    {
                        var data = dwr.result.Tables[0].AsEnumerable().Select(o => new
                        {
                            order_no = o.Field<string>("order_no"),
                            orderdate = o.Field<string>("order_date"),
                        }).ToList();
                        rddl_OrderNo.DataSource = data;
                        rddl_OrderNo.DisplayMember = "order_date";
                        rddl_OrderNo.ValueMember = "order_no";

                        rddPendingOrd.DataSource = data;
                        rddPendingOrd.DisplayMember = "order_date";
                        rddPendingOrd.ValueMember = "order_no";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "ExPro Help");
                }
                finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Search p = new Search(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "Pending_Products"; p.po_number = rddPendingOrd.SelectedValue.ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderQueries", p);

                rgvPending.DataSource = dwr.result.Tables[0];

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
                Search p = new Search(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "ProdInDistribution"; p.Prm_1 = rgvPending.CurrentRow.Cells["ITEM ID"].Value.ToString();
                p.po_number = rddPendingOrd.SelectedValue.ToString(); p.LoginId = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseOrderQueries", p);

                radGridView2.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "ExPro Help"); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {

        }

        private void txtSearchString_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchString.Text.Length > 3)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                    p.Logic = "Search:InProduct"; p.prm_1 = txtSearchString.Text; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    rgvSearchProductList.DataSource = dwr.result.Tables[0];
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString(), "ExPro Help"); }
                finally { Cursor.Current = Cursors.Default; }
            }

        }

        private void rgvSearchProductList_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                prm_newProduct p = new prm_newProduct();
                p.logic = "tempCodeReplace"; p.sale_inv_no = _tempid; p.item_id = _replaceBy;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex)
            { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {

        }

        private void radGridView2_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string item_id = string.Empty; string unit_id = string.Empty; string med_name = string.Empty; int qty = 0;
                item_id = radGridView2.CurrentRow.Cells["item_id"].Value.ToString();
                unit_id = radGridView2.CurrentRow.Cells["unit_id"].Value.ToString();
                med_name = radGridView2.CurrentRow.Cells["item_name"].Value.ToString();
                qty = Convert.ToInt16(radGridView2.CurrentRow.Cells["Req_Packs"].Value.ToString());
                prm_newProduct p = new prm_newProduct();
                p.unit_id = unit_id;
                p.logic = "Merge"; p.item_id = item_id; p.item_name = med_name; p.qty = qty; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);

                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

                radGridView2.CurrentRow.Delete();
            }
            catch (Exception ex)
            { RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvPending_CommandCellClick(object sender, GridViewCellEventArgs e)
        {

        }

        private void btnChkUnitOrder_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "UnitUrgentCheck"; p.prm_1 = "-"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                radGridView1.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help");
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLockOrder_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm1 p = new cm1(); p.unit_id = GlobalUsage.Unit_id;
                p.Logic = "LockForOrder"; p.prm_1 = "-"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                radGridView1.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help");
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
