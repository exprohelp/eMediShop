using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
namespace eMediShop.forms.Product
{
    public partial class ucNewMedicine : UserControl
    {
        string _result = string.Empty;
        public ucNewMedicine()
        {
            InitializeComponent();
        }

        private void ucNewMedicine_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fillMedicineDet();
            Cursor.Current = Cursors.Arrow;
        }
        private void fillMedicineDet()
        {
            try
            {
                DataSet ds = new DataSet();
                cm1 p = new cm1();
                p.Logic = "New Product List"; p.prm_1 = DateTime.Now.ToString("yyyy/MM/dd");p.item_id = "New";
                p.prm_2 = DateTime.Now.ToString("yyyy/MM/dd");p.prm_3 = "New";
                p.login_id = GlobalUsage.Login_id; p.unit_id = GlobalUsage.Unit_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                DataTable dt = dwr.result.Tables[0];
                
                int i = 0;
                lv_medicineDet.Items.Clear();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        i++;
                        ListViewItem ls = new ListViewItem(i.ToString());
                        ls.SubItems.Add(dr["item_name"].ToString());
                        ls.SubItems.Add(dr["qty"].ToString());
                        lv_medicineDet.Items.Add(ls);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                if (txtQty.Text.Length > 0 || txtMedcineName.Text.Length > 0)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        prm_newProduct p = new prm_newProduct();
                        p.logic = "Merge"; p.sale_inv_no = "-"; p.item_id = "New";p.qty = Convert.ToInt16(txtQty.Text);
                        p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                        p.item_name = txtMedcineName.Text;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);

                        txtMedcineName.Text = "";
                        txtQty.Text = "";
                        GlobalUsage.Temp = "-";
                        fillMedicineDet();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    finally { }
                }
                else
                {
                    MessageBox.Show("All Field Is Mandetory", "ExProhelp");
                }
                Cursor.Current = Cursors.Default;
            }
        }
        private void txtMedcineName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lv_medicineDet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Cursor.Current = Cursors.WaitCursor;
                prm_newProduct p = new prm_newProduct();
                p.logic = "Delete"; p.sale_inv_no = lv_medicineDet.FocusedItem.Text; p.item_id = "New"; p.qty = 0;
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.item_name = txtMedcineName.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);

                lv_medicineDet.FocusedItem.Remove();
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
