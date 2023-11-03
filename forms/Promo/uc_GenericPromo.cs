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
    public partial class uc_GenericPromo : UserControl
    {
        string _result = string.Empty;
        public uc_GenericPromo()
        {
            InitializeComponent();
            rdtp_from.Value = DateTime.Today;
            rdtp_to.Value = DateTime.Today;
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "PromoProdSales";
                p.prm_1 = rdtp_from.Value.ToString("yyyyMMdd");
                p.prm_2 = rdtp_to.Value.ToString("yyyyMMdd");
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/analysisqueries", p);
      
                radPivotGrid1.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex)
            { 
             MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            finally {
                Cursor.Current = Cursors.Default;
            }

        }
    }
}
