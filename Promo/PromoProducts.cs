using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Promo
{
    public partial class PromoProducts : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; string _prm = string.Empty; string _itemid = string.Empty;
        decimal _oldValue = 0; string _masterKeyId = string.Empty;
        public PromoProducts()
        {
            InitializeComponent();
        }

        private void PromoProducts_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 185);
            _itemid = "N/A";
            Fill_Category();
            
        }

        private  void Fill_Category()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            pm_promoQueries p = new pm_promoQueries();
            p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
            p.Logic = "FillCategories";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailPromoQueries", p);
            ds = dwr.result;
            rdd_Category.Items.Clear();

            rdd_Category.DataSource = ds.Tables[0];
            rdd_Category.DisplayMember = "cat_name";
        
            this.rdd_Category.DataSource = null; 
            RadListDataItem[] comboItems = new RadListDataItem[ds.Tables[0].Rows.Count];
            int i = 0;
            foreach (DataRow dr in ds.Tables[0].Rows ) 
            { 
                comboItems[i] = new RadListDataItem(dr["cat_name"].ToString());
                i++;
            }
            this.rdd_Category.Items.AddRange(comboItems);
            this.rdd_Category.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending; 
            Cursor.Current = Cursors.Default;
        }

        private void rc_All_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (args.ToggleState.ToString() == "On")
            {
                rg_Group.Enabled = false;
                _prm = "All";
            }
            else
            {
                rg_Group.Enabled = true;
                _prm = "No";
            }
        }

        private void rb_Search_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
            p.Logic = "Search:InProduct";p.prm_1 = txtSearch.Text;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
            ds = dwr.result;
 
            rdd_Products.DataSource = ds.Tables[0];
            rdd_Products.ValueMember = "item_id";
            rdd_Products.DisplayMember = "item_name";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                pm_promoQueries p = new pm_promoQueries();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "ExpireToBe";p.category = rdd_Category.SelectedItem.Text;
                p.item_id = _itemid;p.prm_1 = _prm;p.prm_2 = Convert.ToInt32(txtMonths.Text).ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailPromoQueries", p);

                ds = dwr.result;
                rg_expiryList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;    
        }

        private void rdd_Products_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            _itemid = rdd_Products.SelectedValue.ToString();
        }

        private void rg_expiryList_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
                _oldValue = (decimal)e.Row.Cells["Dis%age"].Value;
        }

        private void rg_expiryList_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Row.Cells[0].Value != null)
            {
                string masterkeyid = e.Row.Cells["Master Key"].Value.ToString();

                if (Convert.ToDecimal(e.Row.Cells["Dis%age"].Value) >= 0 && Convert.ToDecimal(e.Row.Cells["Dis%age"].Value) != _oldValue)
                {
                    try
                    {
                        pm_promoQueries p = new pm_promoQueries();
                        p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                        p.Disc_per = Convert.ToDecimal(e.Row.Cells["Dis%age"].Value);
                        p.master_key_id = masterkeyid;p.input_date = DateTime.Now.ToString("yyyy/MM/dd");
                        p.Logic = "Ins_Upd";
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/InsertPromoData", p);
                        if (!dwr.message.Contains("Success"))
                            MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            e.Row.Delete();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }
    }
}
