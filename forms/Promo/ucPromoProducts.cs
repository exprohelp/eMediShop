using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.Promo
{
    public partial class ucPromoProducts : UserControl
    {
        DataSet ds = new DataSet();
        string _result = string.Empty;
        public ucPromoProducts()
        {
            InitializeComponent();
        }
        private void Fill(string Logic)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int count = 1;
                pm_promoQueries p = new pm_promoQueries();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = Logic;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/RetailPromoQueries", p);

                ds = dwr.result;
                var data = ds.Tables[0].
                    AsEnumerable().Select(o => new
                    {
                        sno = count++,
                        item_name = o.Field<string>("item_name"),
                        qty = o.Field<decimal>("qty"),
                        disc_per = o.Field<decimal>("disc_per")
                    }).ToList();
                rgv_info.DataSource = data;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CrystalReportsPharmacy.Reports.CrPromotionalProduct rpt = new CrystalReportsPharmacy.Reports.CrPromotionalProduct();
            rpt.Database.Tables["PromoTable"].SetDataSource(ds.Tables[0]);
            rpt.PrintToPrinter(1, false, 1, 0);
            Cursor.Current = Cursors.Default;
        }


        private void btninternal_Click(object sender, EventArgs e)
        {
            Fill("Promo_data_In");
        }

        private void btnExternal_Click(object sender, EventArgs e)
        {
            Fill("Promo_data_Ex");
        }

        private void rgv_info_Click(object sender, EventArgs e)
        {

        }

        private void ucPromoProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
