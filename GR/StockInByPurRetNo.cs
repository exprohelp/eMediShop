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
using Telerik.WinControls.UI;

namespace eMediShop.GR
{
    public partial class StockInByPurRetNo : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        public StockInByPurRetNo()
        {
            InitializeComponent();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "StockInByPurRetNo"; p.prm_1 = txtGRNO.Text; p.prm_2 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
                DataSet ds = dwr.result;
                    rgv_info.DataSource = ds.Tables[0];
                    foreach (GridViewColumn column in rgv_info.Columns)
                    {
                        column.BestFit();
                    }
                    if (rgv_info.Rows.Count > 0)
                        btn_Import.Enabled = true;
                    else
                        btn_Import.Enabled = false;
                

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = RadMessageBox.Show("Do You Confirm (Y/N)", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    pm_PurchaseReturn p = new pm_PurchaseReturn();
                    p.unit_id = GlobalUsage.Unit_id;
                    p.gr_no = txtGRNO.Text;p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/StockInByPurRetNo", p);
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK,RadMessageIcon.Info);
                    rgv_info.DataSource = new string[] { };
                }

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void StockInByPurRetNo_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
        }
    }
}
