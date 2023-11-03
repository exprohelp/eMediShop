using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eMediShop.Pharmacy;
using Telerik.WinControls;

namespace eMediShop
{
    public partial class ImportProductInfo : Form
    {

        public ImportProductInfo()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                try
                {
                    Cursor.Current = Cursors.Default;
                    DataSet ds = new DataSet();
                    ds = GlobalUsage.pharmacy_proxy.GetProductBySearch(GlobalUsage.Unit_id, textBox1.Text);

                    DataRow[] drary = ds.Tables[0].Select();
                    foreach (DataRow dr in drary)
                    {
                        ListViewItem ls = new ListViewItem(dr["Item_Id"].ToString());
                        ls.SubItems.Add(dr["Item_Name"].ToString());
                        ls.SubItems.Add(dr["mfd_Name"].ToString());
                        lv_Product.Items.Add(ls);
                    }

                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (lv_Product.Items.Count > 0)
                {
                    lv_Product.Focus();
                    lv_Product.Items[0].Selected = true;
                }
            }
        }

        private void ImportProductInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void lv_Product_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DataSet ds = new DataSet();
                ds = GlobalUsage.pharmacy_proxy.GetProductInfoForUpdation(GlobalUsage.Unit_id, lv_Product.FocusedItem.Text);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
