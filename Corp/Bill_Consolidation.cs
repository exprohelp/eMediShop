using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Corp
{
    public partial class Bill_Consolidation : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _corpid = string.Empty;
        public Bill_Consolidation()
        {
            InitializeComponent();
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void Bill_Consolidation_Load(object sender, EventArgs e)
        {
            //_ds = Config.GetQueryResult("select corp_id,inst_name,credit,discount,c_to from corp_cont_info", "eMediShop");
            rgv_info.DataSource = _ds.Tables[0];

        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btn_Submit.Enabled = true;
            _corpid = e.Row.Cells[0].Value.ToString();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            btn_Submit.Enabled = false;
            //try
            //{
            //    Cursor.Current = Cursors.WaitCursor;
            //    _ds = eMediShop_ServiceLibrary.corporate.BillConsolidateion(out _result, GlobalUsage.Unit_id, _corpid, rdp_from.Value.ToString("yyyy/MM/dd"), rdp_to.Value.ToString("yyyy/MM/dd"));
            //    rgv_detail.DataSource = _ds.Tables[1];
            //    if (_ds.Tables[1].Rows.Count > 0)
            //        rbtn_pdf.Enabled = true;
            //    else
            //        rbtn_pdf.Enabled = false;

            //}
            //catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            //finally { Cursor.Current = Cursors.Default; }
        }

        private void rbtn_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do You want to Print ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    Printing.Laser.Bill_Consolidation(_ds);

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
