using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Telerik.WinControls;

namespace eMediShop.Hospital
{
    public partial class CartIssueProduct : UserControl
    {
        string _result = string.Empty;string _itemid = string.Empty;int _inStock;
        public CartIssueProduct()
        {
            InitializeComponent();
        }

        private void CartIssueProduct_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string Jsonstring = GlobalUsage.pwcf.Hospitalcart_Queries_JSON(out _result,GlobalUsage.Unit_id,"","","CartList","","",GlobalUsage.Login_id);
                var table = JsonConvert.DeserializeObject<DataTable>(Jsonstring);
                rddl_cartName.DataSource = table;
                rddl_cartName.ValueMember = "cart_name";
                rddl_cartName.DisplayMember= "cart_name";
                GetIssue_CurrentDay();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                radGroupBox3.Text = rddl_cartName.SelectedValue.ToString();
                string Jsonstring = GlobalUsage.pwcf.Hospitalcart_Queries_JSON(out _result, GlobalUsage.Unit_id, "", rddl_cartName.SelectedValue.ToString(), "CartInfo", "", "", GlobalUsage.Login_id);
                var table = JsonConvert.DeserializeObject<DataTable>(Jsonstring);
                rgv_cartItems.DataSource = table;

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_cartItems_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _itemid = e.Row.Cells["item_id"].Value.ToString();
                rtb_issueqty.Text= e.Row.Cells["stock"].Value.ToString();
                _inStock = Convert.ToInt32(e.Row.Cells["stock"].Value.ToString());
                radGroupBox2.Text= e.Row.Cells["item_name"].Value.ToString();
                cmbIssueType.Focus();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtb_issueqty.TextLength==0)
                    RadMessageBox.Show("Enter Issue Qty?", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                if (txtRemarks.TextLength < 5)
                    RadMessageBox.Show("Remarks Should Be more than 5 Char.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

                Cursor.Current = Cursors.WaitCursor;
                string qry = "insert into Hosp_IssueFromCart(unit_id,department,issue_type,item_id,qty,issue_by,issue_remarks)";
                qry += "values('MS-H0049','" + rddl_cartName.SelectedValue.ToString() + "','" + cmbIssueType.Text + "','" + _itemid + "'," + rtb_issueqty.Text + ",'" + GlobalUsage.Login_id + "','" + txtRemarks.Text + "')";
                GlobalUsage.pharmacy_proxy.QueryExecute(qry, "ChandanPharmacy_Live");
                txtRemarks.Text = "";rtb_issueqty.Text = "0";
                GetIssue_CurrentDay();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void GetIssue_CurrentDay()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string Jsonstring = GlobalUsage.pwcf.Hospitalcart_Queries_JSON(out _result, GlobalUsage.Unit_id, "", rddl_cartName.SelectedValue.ToString(), "IssueOfTheDay", "", "", GlobalUsage.Login_id);
                var table = JsonConvert.DeserializeObject<DataTable>(Jsonstring);
                rgv_IssueInfo.DataSource = table;
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rtb_issueqty_Enter(object sender, EventArgs e)
        {
            rtb_issueqty.SelectAll();
        }
    }
}
