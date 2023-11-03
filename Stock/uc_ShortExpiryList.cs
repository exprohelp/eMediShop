using System;
using System.Data;
using System.Windows.Forms;

using Telerik.WinControls.UI.Export;
namespace eMediShop.forms.Stock
{
    public partial class uc_ShortExpiryList : UserControl
    {
       string _result = string.Empty; DataSet _ds = new DataSet();
        public uc_ShortExpiryList()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int Count = 0;
            if (txtDays.Text.Length==0)
            {
                MessageBox.Show ("Please Enter Number of Days For Expiry");
                txtDays.Focus();
                return;
            }
            lblTotal.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.tran_id = "-";
            if (chkIntercompany.Checked)
                p.Logic = "Stocks:InterCompanyExpiry";
            else
            p.Logic = "CheckNearExpiry";
            p.prm_1 = txtDays.Text;p.dtFrom = DateTime.Today.ToString("yyyy-MM-dd"); p.dtTo = DateTime.Today.ToString("yyyy-MM-dd");
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/TranStockQueries", p);
            _ds = dwr.result;

            radGridView1.DataSource=_ds.Tables[0];
            Cursor.Current = Cursors.Default;
                lblTotal.Visible = true;
            lblTotal.Text = "Total Number of Items=  " + radGridView1.RowCount.ToString();
            }
        private void btn_xl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ExportToExcelML exporter = new ExportToExcelML(this.radGridView1);
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            exporter.ExportVisualSettings = true;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                exporter.RunExport(fd.SelectedPath + "Expiry_List.xls");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
    }

