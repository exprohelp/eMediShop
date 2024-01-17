using System;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.contract
{
    public partial class HAL_Orders : Telerik.WinControls.UI.RadForm
    {
        string _logic = "Insert"; string _orderNo = "New"; string _result = string.Empty;
        string _SelectedItem_Id = string.Empty; string _selectedorderNo = string.Empty;
        DataSet _ds = new DataSet();
        public HAL_Orders()
        {
            InitializeComponent();
        }

        private void HAL_Orders_Load(object sender, EventArgs e)
        {
            dtpOrderDate.MinDate = DateTime.Today.AddDays(-1);
            dtpOrderDate.MaxDate =DateTime.Now;
            dtpOrderDate.Value = DateTime.Today;
            LoadOrders();
        }
        private void LoadOrders()
        {
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "Load:Orderheader";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
            rgvOrderHeaders.DataSource = dwr.result.Tables[0];
        }

        private void txtpbno_Enter(object sender, EventArgs e)
        {
            txtpbno.SelectAll();
        }

        private void txtSrNo_Enter(object sender, EventArgs e)
        {
            txtSrNo.SelectAll();
        }

        private void txtptname_Enter(object sender, EventArgs e)
        {
            txtptname.SelectAll();
        }

        private void txtMedName_Enter(object sender, EventArgs e)
        {
            txtMedName.SelectAll();
        }

        private void txtQty_Enter(object sender, EventArgs e)
        {
            txtQty.SelectAll();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                HALContractHeader p = new HALContractHeader();
                p.unitID = GlobalUsage.Unit_id; p.createdBy = GlobalUsage.Login_Name;
                p.SrNo = Convert.ToInt16(txtSrNo.Text); p.PBNO = txtpbno.Text; p.orderDate = dtpOrderDate.Value.ToString("yyyy-MM-dd");
                p.Logic = _logic; p.orderNo = _orderNo; p.ptname = txtptname.Text; p.prescribedBy = txtPrescribedBy.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/InsertModifyHALOrderHeader", p);
                if (dwr.message.Contains("Success"))
                {
                    LoadOrders();
                    txtSrNo.Text = "";
                    txtpbno.Text = "";
                    txtptname.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSrNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtpbno.Focus();
        }

        private void txtpbno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtptname.Focus();
        }

        private void txtptname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtPrescribedBy.Focus();
        }

        private void txtPrescribedBy_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnCreate.Focus();
        }

        private void txtPrescribedBy_Enter(object sender, EventArgs e)
        {
            txtPrescribedBy.SelectAll();
        }

        private void txtPrescribedBy_TextChanged(object sender, EventArgs e)
        {
            lv_referralList.Items.Clear();
            try
            {
                if (txtPrescribedBy.Text.Length > 1)
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "SearchReferral"; p.prm_1 = txtPrescribedBy.Text; p.prm_2 = "-"; p.prm_3 = "-";
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);

                    lv_referralList.Visible = true;
                    if (dwr.result.Tables[0].Rows.Count > 0)
                    {
                        lv_referralList.Visible = true;
                        foreach (DataRow dr in dwr.result.Tables[0].Rows)
                        {
                            ListViewItem li = new ListViewItem(dr["ref_name"].ToString());
                            lv_referralList.Items.Add(li);
                        }
                        _ds.Tables.Clear();
                    }
                    else
                    {
                        lv_referralList.Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtptname.Text = "";
            }
        }

        private void txtPrescribedBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtPrescribedBy.Text.Length > 0)
            {
                try
                {
                    lv_referralList.Focus();
                    lv_referralList.Items[lv_referralList.FocusedItem.Index].Selected = true;
                }
                catch (Exception ex) { }
            }

            if (e.KeyCode == Keys.Return)
            {
                txtMedName.Focus();
            }
        }

        private void lv_referralList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lv_referralList.Items.Count > 0)
                {
                    this.txtPrescribedBy.TextChanged -= new System.EventHandler(this.txtPrescribedBy_TextChanged);
                    txtPrescribedBy.Text = lv_referralList.FocusedItem.Text;
                    this.txtPrescribedBy.TextChanged += new System.EventHandler(this.txtPrescribedBy_TextChanged);
                    lv_referralList.Visible = false;
                    txtMedName.SelectAll(); txtMedName.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtPrescribedBy.SelectAll(); txtPrescribedBy.Focus(); lv_referralList.Visible = false;
            }
        }

        private void txtMedName_TextChanged(object sender, EventArgs e)
        {
            if (txtMedName.Text.Length > 2)
            {
                GetProductHelp(txtMedName.Text, "Search");
            }
            else if (txtMedName.Text.Length == 0)
            {
                itemhelpgrid.Visible = false;
            }
        }
        private void GetProductHelp(string ProductSearch, string CallFrom)
        {
            string jsonString = string.Empty;
            itemhelpgrid.Items.Clear();
            itemhelpgrid.BeginUpdate();
            itemhelpgrid.Columns[1].Text = "Name of Medicine/Item";
            ListViewItem lvi;
            Search p = new Search();
            p.unit_id = GlobalUsage.Unit_id; p.SearchKey = ProductSearch;
            p.Logic = "All-ForOrder";
            p.LoginId = GlobalUsage.Login_id; p.Prm_1 = "-";

            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/ProductHelp", p);
            if (dwr.result.Tables[0].Rows.Count > 0)
            {
                itemhelpgrid.Visible = true;
                #region Filling Item Help Grid
                string temp = string.Empty;
                foreach (DataRow dr in dwr.result.Tables[0].Rows)
                {

                    lvi = new ListViewItem(dr["item_id"].ToString());
                    lvi.SubItems.Add(dr["item_name"].ToString());
                    itemhelpgrid.Items.Add(lvi);
                }
                #endregion
            }
            itemhelpgrid.EndUpdate();

        }

        private void txtMedName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && txtMedName.Text.Length > 0)
            {
                if (itemhelpgrid.Visible == true)
                {
                    itemhelpgrid.Focus();
                    if ((object)itemhelpgrid.FocusedItem != null)
                        itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].Selected = true;
                }
                else
                {
                    itemhelpgrid.Visible = true;
                    itemhelpgrid.Focus();
                    if ((object)itemhelpgrid.FocusedItem != null)
                        itemhelpgrid.Items[itemhelpgrid.FocusedItem.Index].Selected = true;
                }

            }
            else if (e.KeyCode == Keys.Enter && txtMedName.Text.Length == 0)
            {
                itemhelpgrid.Visible = false;
            }
            else if (e.KeyCode == Keys.Enter && txtMedName.Text.Length > 0)
            {
                txtQty.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (itemhelpgrid.Visible)
                    itemhelpgrid.Visible = false;
                txtMedName.Text = "";
            }
        }

        private void itemhelpgrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _SelectedItem_Id = itemhelpgrid.FocusedItem.Text;

                if (itemhelpgrid.FocusedItem.SubItems[1].Text.Contains("~"))
                {
                    string[] sp = itemhelpgrid.FocusedItem.SubItems[1].Text.Split('~');
                    txtMedName.Text = sp[0];
                }
                else
                    txtMedName.Text = itemhelpgrid.FocusedItem.SubItems[1].Text;
                itemhelpgrid.Visible = false;
                txtQty.Text = "0";
                txtQty.Focus();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                itemhelpgrid.Visible = false;
                txtMedName.Focus();
            }

        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && txtQty.Text!="0")
            {
                try
                {
                    DataSet ds = new DataSet();
                    HALContractLineItem p = new HALContractLineItem();
                    p.unitID = GlobalUsage.Unit_id; p.createdBy = GlobalUsage.Login_Name; p.orderNo = _selectedorderNo;
                    p.itemid = _SelectedItem_Id; p.qty = Convert.ToInt16(txtQty.Text); p.loginID = GlobalUsage.Login_id;
                    p.Logic = "Merge";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/InsertModifyHALOrderInfo", p);
                    if (dwr.message.Contains("Success"))
                    {
                        rgvItemGrid.DataSource = dwr.result.Tables[0];
                        this.txtMedName.TextChanged -= new System.EventHandler(this.txtMedName_TextChanged);
                        txtMedName.Text = ""; txtQty.Text = "0";
                        txtMedName.Focus();
                        this.txtMedName.TextChanged += new System.EventHandler(this.txtMedName_TextChanged);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _selectedorderNo = e.Row.Cells["orderNo"].Value.ToString();
            rgbItems.Text = "Sr NO.:"+e.Row.Cells["srno"].Value.ToString()+", PBNO.: "+e.Row.Cells["pbno"].Value.ToString() + ", Name: " + e.Row.Cells["ptname"].Value.ToString();
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;p.prm_1 = _selectedorderNo;
            p.Logic = "Load:ItemsOfOrder";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
            rgvItemGrid.DataSource = dwr.result.Tables[0];
        }

        private void rgvItemGrid_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Are You Confirm to Delete ?", "ExPro Help", MessageBoxButtons.YesNo);
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id; p.prm_1 = _selectedorderNo;
                p.prm_2 = e.Row.Cells[0].Value.ToString();
                p.Logic = "Delete:ItemsOfOrder";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
                rgvItemGrid.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
