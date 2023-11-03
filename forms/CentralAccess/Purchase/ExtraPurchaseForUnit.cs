using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
    public partial class ExtraPurchaseForUnit : Form
    {
        DataSet _ds = new DataSet();
        
        DateTime dtfrom =new DateTime();
        DateTime dtTo = new DateTime();
        public ExtraPurchaseForUnit()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                dtfrom = dateTimePicker1.Value;
                dtTo = dateTimePicker2.Value;
                progressBar1.Visible = true;
                btnPrint.Visible =false;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string qry = "pExtraPurchaseForUnit  '" + GlobalUsage.Unit_id + "','" + dtfrom.ToString("yyyy/MM/dd") + "','" + dtTo.ToString("yyyy/MM/dd") + "' ";
            //try { _ds = GlobalUsage.pharmacyproxy.GetQueryResult(qry); }
            //catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void fillExtraPurchase()
        {
            if(_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    lv_ExtraPurchase.Items.Clear();
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        lv_ExtraPurchase.Items.Add(dr["Item_id"].ToString());
                        lv_ExtraPurchase.Items[lv_ExtraPurchase.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        lv_ExtraPurchase.Items[lv_ExtraPurchase.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["Cur_Sales_Avg"]).ToString("##.##"));
                        lv_ExtraPurchase.Items[lv_ExtraPurchase.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["cur_stock"]).ToString("##.##"));
                        lv_ExtraPurchase.Items[lv_ExtraPurchase.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["Adq_qty"]).ToString("##.##"));
                        lv_ExtraPurchase.Items[lv_ExtraPurchase.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["extra_qty"]).ToString("##.##"));
                    }
                }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fillExtraPurchase();
            progressBar1.Visible = false;
            btnPrint.Visible = true;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
           // eMediShop.Printing.DMP.Print_ExtraPurchaseForUnit(_ds);
        }

        private void ExtraPurchaseForUnit_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160); 
        }
    }
}
