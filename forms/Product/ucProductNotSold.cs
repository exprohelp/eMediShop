using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;
using eMediShop.Pharmacy;
using Telerik.WinControls;
using Telerik.WinControls.UI.Export;

namespace eMediShop.forms.Product
{

    public partial class ucProductNotSold : UserControl
    {

        DataSet ds = new DataSet();
        string pPacks = "";
        string pMonths = "";
        public ucProductNotSold()
        {
            InitializeComponent();
        }

        #region FOR FILLING PRODUCT

        #endregion
        private void ProductNotSold_Load(object sender, EventArgs e)
        {

            txtMonth.Focus();
            txtMonth.SelectAll();
        }


        private void txtMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPurchDays.Focus();
                txtPurchDays.SelectAll();
            }
        }

        private void txtPack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbtn_submit.Select();
            }
        }


        private void rbtn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = "StockNotSold";p.prm_1 = txtMonth.Text;p.prm_2 = txtPurchDays.Text;
                p.prm_3 = "-";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/stocksqueries", p);
                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    rgv_info.DataSource = dwr.result.Tables[0];
                    btnXL.Enabled = true;
                }
                else
                    btnXL.Enabled = false;
            }
            catch (Exception ex)
            {

                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.ShowDialog();
                string fileName = f.SelectedPath + "\\StockNotSold_" + DateTime.Now.ToString("yyyy_MM_dd") + ".xls";
                Cursor.Current = Cursors.WaitCursor;
                ExportToExcelML exporter = new ExportToExcelML(this.rgv_info);
                exporter.ExportVisualSettings = true;
                Cursor.Current = Cursors.WaitCursor;
                exporter.RunExport(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help");
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
