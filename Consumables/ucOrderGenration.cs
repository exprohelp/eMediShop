using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ExPro.Client;
using ExPro.Server;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using eMediShop;
  public partial class ucOrderGenration : UserControl
    {

        
        ListViewColumnSorter lvsort;
        private int sortColumn = -1;
        DataSet _ds = new DataSet();
        string _Action = "";
        DataSet _dsItem = new DataSet();
        DataSet _dsProduct = new DataSet();
        string _Item_Id = "";
        string _PackSize = "";
        string _deleteing_Id = "";
        decimal _Qty = 0;
        string _Msg = "";
        public ucOrderGenration()
        {
            InitializeComponent();
        }
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (_dsProduct.Tables.Count > 0)
            {
                if (_dsProduct.Tables[0].Rows.Count > 0)
                {

                    try
                    {
                        #region Process Block
                        itemhelpgrid.Items.Clear();
                        itemhelpgrid.Visible = true;
                        DataRow[] drarr = _dsProduct.Tables[0].Select("item_name like '" + txtProduct.Text + "%' ");
                        foreach (DataRow dr in drarr)
                        {
                            itemhelpgrid.Items.Add(dr["item_id"].ToString());
                            itemhelpgrid.Items[itemhelpgrid.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        }
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Stock Item List", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void itemhelpgrid_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                #region Process
                _Item_Id = itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].SubItems[0].Text;
                txtProduct.Text = itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].SubItems[1].Text;
                DataSet ds = new DataSet();
                ds = GlobalUsage.pharmacy_proxy.GetLatestPackSizeWithPendingOrder(GlobalUsage.Unit_id, _Item_Id, GlobalUsage.Login_id);
                itemhelpgrid.Visible = false;
                txtProduct.Select();
                txtProduct.Focus();
                cbxPack.Items.Clear();
                txtPendOrder.Text = "";
                txtPqty.Text = "";
                txtInStock.Text = "";
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow[] drarr = ds.Tables[0].Select("item_id='" + _Item_Id + "' ");
                        cbxPack.Items.Clear();
                        //cbxPack.Items.Add("Select");
                        foreach (DataRow dr in drarr)
                        {
                            cbxPack.Items.Add(dr["pack_size"].ToString());
                            txtPendOrder.Text = Convert.ToDecimal(dr["PendOrder"]).ToString("###.00");
                            txtPqty.Text = Convert.ToDecimal(dr["pack_qty"]).ToString("###");
                            txtInStock.Text = Convert.ToDecimal(dr["stkqty"]).ToString("###");
                        }

                        cbxPack.SelectedIndex = 0;
                        if (cbxPack.Items.Count == 1)
                            cbxPack.Enabled = false;
                    }
                }
                #endregion
                txtqty.Focus();
            }
        }
        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                itemhelpgrid.Focus();
                itemhelpgrid.Items[0].Selected = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                cbxPack.Focus();
            }
        }
        public void  FillOrderedProduct()
        {
            lv_Issued.Items.Clear();
            foreach (DataRow dr in _ds.Tables[0].Rows)
            {
                lv_Issued.Items.Add(dr["auto_id"].ToString());
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["stockatunit"]).ToString("####"));
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add((dr["pack_size"].ToString()) + "/" + Convert.ToDecimal(dr["pack_qty"]).ToString("###"));
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["pack_qty"]).ToString("###"));
                lv_Issued.Items[lv_Issued.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["qty"]).ToString("####.00"));
            }
            txtProduct.Select();
            txtProduct.Focus();
        }
        private void txtqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbxPack.Text.Length > 0 && txtqty.Text.Length > 0)
                {
                    #region Process Block
                    string[] t = cbxPack.SelectedItem.ToString().Split('x');
                    string[] r = t[1].Split(' ');
                    decimal tQty = Convert.ToDecimal(txtqty.Text); //* Convert.ToDecimal(t[0].ToString()) * Convert.ToDecimal(r[0].ToString());
                    decimal baseQty = Convert.ToDecimal(txtPqty.Text);//Convert.ToDecimal(r[0].ToString()) * Convert.ToDecimal(t[0].ToString());
                    if (tQty % baseQty == 0)
                    {
                        _Qty = Convert.ToDecimal(txtqty.Text);
                        _PackSize = cbxPack.SelectedItem.ToString();
                        progressBar1.Visible = true;
                        _Action = "Feeding";
                        if (!backgroundWorker1.IsBusy)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }
                    #endregion
                }
                else
                { MessageBox.Show("Please put valid quantity"); }
            }
        }
        private void cbxPack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtqty.Focus();
            }
        }
        private void lv_Issued_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _deleteing_Id = lv_Issued.Items[lv_Issued.FocusedItem.Index].Text;
                try
                {
                    progressBar1.Visible = true;
                    _Action = "DeleteProduct";
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string result = "";
            if (_Action == "Feeding")
            {
                try
                {
                    _Msg = GlobalUsage.pharmacy_proxy.CreateOrderInfo(GlobalUsage.Unit_id, _Item_Id, GlobalUsage.Login_id, _PackSize, Convert.ToDecimal(txtPqty.Text), _Qty);
                    _ds = GlobalUsage.pharmacy_proxy.GetUnProcessedOrder(out result, GlobalUsage.Unit_id);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            if (_Action == "DeleteProduct")
            {
                try
                {
                     GlobalUsage.pharmacy_proxy.QueryExecute("delete from order_info where auto_id=" + _deleteing_Id.ToString(), "eIM_Data");
                    _ds = GlobalUsage.pharmacy_proxy.GetUnProcessedOrder(out result, GlobalUsage.Unit_id);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            if (_Action == "FillOrder")
            {
                try
                {
                    _ds = GlobalUsage.pharmacy_proxy.GetUnProcessedOrder(out result,GlobalUsage.Unit_id);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "Feeding")
            {
                if (_Msg == "success") { FillOrderedProduct(); }
            }
            if (_Action == "DeleteProduct")
            {
                FillOrderedProduct();
            }
            if (_Action == "FillOrder")
            {
                FillOrderedProduct();
            }
            progressBar1.Visible = false;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            _Action = "FillOrder";
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void txtqty_Enter(object sender, EventArgs e)
        {
            txtqty.SelectAll();
        }
        private void txtProduct_Enter(object sender, EventArgs e)
        {
            txtProduct.SelectAll();
        }
        protected void RefreshItemXML(string result)
        {
            try
            {
                #region Process Block
                DataSet ds = new DataSet();
                if (File.Exists(Application.StartupPath + "\\InventoryProduct.xml"))
                    File.Delete(Application.StartupPath + "\\InventoryProduct.xml");
                ds = GlobalUsage.pharmacy_proxy.GetQueryResult("select Item_id,item_name from item_master order by item_name;");
                ds.WriteXml(Application.StartupPath + "\\InventoryProduct.xml");
                string qry = "insert into updatebyunit(unit_id,login_id,typeofupd,modify_date) values('" + GlobalUsage.Unit_id + "','Auto','Item Master',getdate())";
               GlobalUsage.pharmacy_proxy.QueryExecute(qry, "eIm_Data");
                #endregion
            }
            catch (Exception)
            { }
        }
        private void btnXML_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                #region Process Block
                if (File.Exists(Application.StartupPath + "\\InventoryProduct.xml"))
                    File.Delete(Application.StartupPath + "\\InventoryProduct.xml");
                _dsProduct = GlobalUsage.pharmacy_proxy.GetQueryResult2("select Item_id,item_name from item_master order by item_name;", "eIM_Data");
                _dsProduct.WriteXml(Application.StartupPath + "\\InventoryProduct.xml");
                #endregion
            }
            catch (Exception)
            { }
            Cursor.Current = Cursors.Default;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //DiagnosticCrystalLibrary.CrReport.OrderConsumable crReport = new DiagnosticCrystalLibrary.CrReport.OrderConsumable();
            //string result = "";
            //try
            //{
            //    DialogResult res = MessageBox.Show("Do You want to Print", "Expro Help", MessageBoxButtons.YesNo);
            //    if (res == DialogResult.Yes)
            //    {
            //        _ds = GlobalUsage.pharmacy_proxy.GetUnProcessedOrder(GlobalUsage.Unit_id, out result);
            //        crReport.Database.Tables["OrderConsumable"].SetDataSource(_ds.Tables[0]);
            //        crReport.SetParameterValue("UnitName", GlobalUsage.UnitName);
            //        crReport.SetParameterValue("Address", GlobalUsage.UnitAddress);
            //        crReport.PrintToPrinter(1, false, 1, 2);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //Cursor.Current = Cursors.Default;
        }

        private void ucOrderGenration_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\InventoryProduct.xml"))
            {
                 string qry = "select Item_id,item_name from item_master order by item_name;";
                 _dsProduct = GlobalUsage.pharmacy_proxy.GetQueryResult2(qry, "eIM_Data");
                _dsProduct.WriteXml(Application.StartupPath + "\\InventoryProduct.xml");
            }
            else
            {
                _dsProduct.ReadXml(Application.StartupPath + "\\InventoryProduct.xml");
            }
        } 
    }
