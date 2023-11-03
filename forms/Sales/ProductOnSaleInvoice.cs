using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;

namespace eMediShop
{
    public partial class ProductOnSaleInvoice : Telerik.WinControls.UI.RadForm
    {
        string _item_id = string.Empty; string _result = string.Empty;
        public ProductOnSaleInvoice()
        {
            InitializeComponent();
        }
        private void ProductOnSaleInvoice_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = "Search:Sold Product";p.prm_1 = "%" + txtSearch.Text;
                p.prm_2 = dtpFrom.Value.ToString("yyyyMMdd");p.prm_3 = dtpTo.Value.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);

                var data = dwr.result.Tables[0].AsEnumerable().Select(o => new
                    {
                        item_id = o.Field<string>("item_id"),
                        item_name = o.Field<string>("item_name"),
                    }).OrderBy(o => o.item_name).ToList();

                rgv_product.DataSource = data;
            }
            catch (Exception ex)
            {
            }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void rgv_product_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _item_id = rgv_product.CurrentRow.Cells["Item Id"].Value.ToString();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "Search:Sold Product With Invoice"; p.prm_3 = _item_id;
                p.prm_1 = dtpFrom.Value.ToString("yyyyMMdd"); p.prm_2 = dtpTo.Value.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);

                this.rgv_InvInfo.SelectionChanged -= new System.EventHandler(this.rgv_InvInfo_SelectionChanged);
                rgv_InvInfo.DataSource = dwr.result.Tables[0];
                rgb_InvInfo.Text = rgv_product.CurrentRow.Cells["Name of Product"].Value.ToString();
                this.rgv_InvInfo.SelectionChanged += new System.EventHandler(this.rgv_InvInfo_SelectionChanged);
            }
            catch (Exception ex)
            {
                _item_id = ex.Message;
            }
            finally { Cursor.Current = Cursors.Default; }
        }


        public void fillInvoiceDetail(string sale_inv_no)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "Search:Fill Invoice Info"; p.prm_1 = sale_inv_no;
                p.prm_2 = "N/A"; p.prm_3 = "N/A";
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);

                rgv_InvDetail.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            {
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void rgv_InvInfo_SelectionChanged(object sender, EventArgs e)
        {
            fillInvoiceDetail(rgv_InvInfo.CurrentRow.Cells["Sale Inv No."].Value.ToString());
        }

        private void rgv_InvInfo_Click(object sender, EventArgs e)
        {
            fillInvoiceDetail(rgv_InvInfo.CurrentRow.Cells["Sale Inv No."].Value.ToString());
        }



    }
}
