using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Indents
{
    public partial class IndentToUnit : Telerik.WinControls.UI.RadForm
    {
        string _itemid = string.Empty;int _packqty = 0;
        public IndentToUnit()
        {
            InitializeComponent();
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {

            if (txtProdName.TextLength > 2)
            {
                #region Process
               if (lv_Product.Visible == false)
                {
                    //lv_Product.Location = new System.Drawing.Point(1, 49);
                    lv_Product.Size = new Size(513, 403);
                    lv_Product.Visible = true;
                }
                lv_Product.Items.Clear();


                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "ProductSearch"; p.prm_1 = txtProdName.Text; p.prm_2 = "Indent";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);

                    var table = dwr.result.Tables[0];
                    DataRow[] drary = table.Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
                        ls.SubItems.Add(dr["mfd_Name"].ToString());
                        ls.SubItems.Add(dr["hsn"].ToString());
                        ls.SubItems.Add(dr["pack_qty"].ToString());
                        lv_Product.Items.Add(ls);
                    }
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
                #endregion
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter | e.KeyCode == Keys.Escape)
            {
                _itemid = lv_Product.FocusedItem.SubItems[0].Text;
                _packqty = Convert.ToInt16(lv_Product.FocusedItem.SubItems[4].Text);
                this.txtProdName.TextChanged -= new System.EventHandler(this.txtProdName_TextChanged);
                txtProdName.Text = lv_Product.FocusedItem.SubItems[1].Text;
                this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
                lv_Product.Visible = false;
                txtQty.Focus();
            }
        }

        private void txtQty_Enter(object sender, EventArgs e)
        {
            txtQty.SelectAll();
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (_packqty != 0)
                {
                    if (((Convert.ToInt16(txtQty.Text) / _packqty) * _packqty) != Convert.ToInt16(txtQty.Text))
                    {
                        RadMessageBox.Show("Qty should be in multiplication of " + _packqty.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
                        txtQty.SelectAll();
                        txtQty.Focus();
                        return;
                    }
                }
                try
            {
                Cursor.Current = Cursors.WaitCursor;
                pmIndentToUnit p = new pmIndentToUnit();
                p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id;p.logic = "Merge";
                p.item_id = _itemid; p.qty = Convert.ToInt16(txtQty.Text);p.remarks = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
                if (dwr.message.Contains("Success")) { 
                    rgv_info.DataSource = dwr.result.Tables[0];
                    txtQty.Text = "0";
                    txtProdName.Focus();
                }
                else
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
            }
        }

        private void txtProdName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Return | e.KeyCode == Keys.Down) && (lv_Product.Items.Count > 0 && txtProdName.Text.Length > 0))
            {
                lv_Product.Focus();
                lv_Product.Items[0].Selected = true;
            }
        }

        private void txtProdName_Enter(object sender, EventArgs e)
        {
            txtProdName.SelectAll();
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pmIndentToUnit p = new pmIndentToUnit();
            p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id; p.logic = "Delete";
            p.auto_id = e.Row.Cells["auto_id"].Value.ToString();
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
            if (dwr.message.Contains("Success"))
            {
                rgv_info.DataSource = dwr.result.Tables[0];
            }
            else
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
        }

        private void IndentToUnit_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pmIndentToUnit p = new pmIndentToUnit();
            p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id; p.logic = "Select";
      
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
            if (dwr.message.Contains("Success"))
            {
                rgv_info.DataSource = dwr.result.Tables[0];
            }
            else
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
        }

        private void btnSubmitIndent_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pmIndentToUnit p = new pmIndentToUnit();
            p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id; p.logic = "FinalByUnit";

            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
            if (dwr.message.Contains("Success"))
            {
                RadMessageBox.Show("Generated Indent No.:"+dwr.result.Tables[0].Rows[0]["indent_no"].ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                rgv_processedIndent.DataSource = dwr.result.Tables[0];
            }
            else
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
        }

        private void btnIndentStatus_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pmIndentToUnit p = new pmIndentToUnit();
            p.unit_id = GlobalUsage.Unit_id; p.createdby = GlobalUsage.Login_id; p.logic = "IndentStatus";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/InsertModifyIndentToUnit", p);
            rgv_processedIndent.DataSource = dwr.result.Tables[0];
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            if(_packqty!=0)
            {
                if(((Convert.ToInt16(txtQty.Text)/_packqty)*_packqty)!= Convert.ToInt16(txtQty.Text))
                {
                    RadMessageBox.Show("Qty should be in multiplication of "+_packqty.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
                    txtQty.SelectAll();
                    txtQty.Focus();

                }
            }
        }
    }
}
