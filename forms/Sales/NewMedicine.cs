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
using Telerik.WinControls;

namespace eMediShop
{
    public partial class NewMedicine : Telerik.WinControls.UI.RadForm
    {
        string _item_id = string.Empty; string _itemName = string.Empty; string _Sale_Inv_No = string.Empty; string _result = string.Empty;
        DataSet _ds = new DataSet();
        public NewMedicine(string item_id, string itemName, string Sale_Inv_No)
        {
            _item_id = item_id; _itemName = itemName; _Sale_Inv_No = Sale_Inv_No;
            InitializeComponent();
        }

        private void NewMedicine_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            txtMedcineName.Text = _itemName;
            fillMedicineDet();
            Cursor.Current = Cursors.Arrow;
        }

        private void fillMedicineDet()
        {

            try
            {
                eMediShop.cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                p.Logic = "New Product List of Today"; p.prm_1 = DateTime.Now.ToString("yyyyMMdd");p.prm_2 = DateTime.Now.ToString("yyyyMMdd");p.prm_3 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                if (dwr.message == "Success")
                {
                    rgv_info.DataSource = dwr.result.Tables[0];
                }
                else { rgv_info.DataSource = new string[]{}; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Cursor.Current = Cursors.WaitCursor;
                if (txtQty.Text.Length > 0 || txtMedcineName.Text.Length > 0)
                {
                    try
                    {
                        if (_item_id.Length < 5)
                            _item_id = "New";

                        prm_newProduct p = new prm_newProduct();
                        p.unit_id = GlobalUsage.Unit_id;p.item_id = _item_id;p.item_name = txtMedcineName.Text;
                        p.qty = Convert.ToInt16(txtQty.Text);p.action_flag = "N";p.sale_inv_no = _Sale_Inv_No;
                        p.order_no = "N/A";p.logic = "Merge";p.login_id = GlobalUsage.Login_id;

                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/newproduct", p);

                           if (dwr.message.Contains("Success"))
                        {
                            txtMedcineName.Text = "";
                            txtQty.Text = "";
                            GlobalUsage.Temp = "-";
                            fillMedicineDet();
                        }
                        else { MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    finally { }
                }
                else
                {
                    MessageBox.Show("All Field Is Mandetory", "ExPro Help");
                }
                Cursor.Current = Cursors.Arrow;
            }
        }
        private void txtMedcineName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }
        private void NewMedicine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void lv_medicineDet_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //{
            //    Cursor.Current = Cursors.WaitCursor;
            //    Config.QueryExecute("delete from NewMediCine where auto_id=" + lv_medicineDet.FocusedItem.Text, "eMediShop");
            //    lv_medicineDet.FocusedItem.Remove();
            //    Cursor.Current = Cursors.Default;
            //}
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm to Delete ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    prm_newProduct p = new prm_newProduct();
                    p.unit_id = GlobalUsage.Unit_id; p.item_id = _item_id; p.item_name = txtMedcineName.Text;
                    p.qty = 0; p.action_flag = "N"; p.sale_inv_no = e.Row.Cells["auto_id"].Value.ToString();
                    p.order_no = "N/A"; p.logic = "Delete"; p.login_id = GlobalUsage.Login_id;

                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/newproduct", p);

                    if (dwr.message.Contains("Success"))
                    {
                        txtMedcineName.Text = "";
                        txtQty.Text = "";
                        GlobalUsage.Temp = "-";
                        fillMedicineDet();
                    }
                    else { MessageBox.Show(_result, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }

        }
    }
}



