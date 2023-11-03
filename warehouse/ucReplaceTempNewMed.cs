using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.warehouse
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
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //DataSet ds = GlobalUsage.cws.ReplaceTemporaryMedicine(out _result, _tempId, "", "-", "GetTempList");
                //GridNewMed.DataSource = ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //GlobalUsage.cws.ReplaceTemporaryMedicine(out _result,_tempId, ddlMedList.SelectedValue.ToString(),"-","Replace");
                Cursor.Current = Cursors.Default;
                MessageBox.Show(_result);
            }
            catch (Exception ex) { }
        }

        private void GridNewMed_Click(object sender, EventArgs e)
        {
            GrpSelectedMed.Text = "Selected Med : " + GridNewMed.CurrentRow.Cells[1].Value.ToString();
            txtSearch.Text = GridNewMed.CurrentRow.Cells[1].Value.ToString();
            _tempId = GridNewMed.CurrentRow.Cells[0].Value.ToString();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ddlMedList.Items.Clear();
                //DataSet ds = GlobalUsage.cws.ReplaceTemporaryMedicine(out _result, _tempId, "",txtSearch.Text, "Search");
                //ddlMedList.Items.AddRange(Config.FillTelrikCombo(ds.Tables[0]));
                ddlMedList.SelectedIndex = 0;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { }


        }
    }
}
