using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Products
{
    public partial class ucReplaceTempNewMed : UserControl
    {
        string _tempId = string.Empty;
        string _result = string.Empty;
        public ucReplaceTempNewMed()
        {
            InitializeComponent();
        }

        private void ucReplaceTempNewMed_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                prm_newProduct p = new prm_newProduct();
                p.logic = "ReplByTempItemId"; p.sale_inv_no = _tempId; p.item_id = ddlMedList.SelectedValue.ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/NewProduct", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                //GlobalUsage.cws.ReplaceTemporaryMedicine(out _result,_tempId, ddlMedList.SelectedValue.ToString(),"-","Replace");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }
        }

        private void GridNewMed_Click(object sender, EventArgs e)
        {
           GrpSelectedMed.Text="Selected Med : "+GridNewMed.CurrentRow.Cells[1].Value.ToString();
           txtSearch.Text = GridNewMed.CurrentRow.Cells[1].Value.ToString();
           _tempId = GridNewMed.CurrentRow.Cells[0].Value.ToString();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
              Cursor.Current = Cursors.WaitCursor;
              ddlMedList.Items.Clear();
             
                cm1 p = new cm1();
                p.Logic = "SearchProductForRepl"; p.prm_1 = txtSearch.Text; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                ddlMedList.Items.AddRange(Config.FillTelrikCombo(dwr.result.Tables[0]));
              ddlMedList.SelectedIndex = 0;
              Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }
  
          
       }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.Logic = "GetTempList"; p.prm_2 = _tempId; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                GridNewMed.DataSource = dwr.result.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
