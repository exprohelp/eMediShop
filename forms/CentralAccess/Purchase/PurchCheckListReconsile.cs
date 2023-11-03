using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using eMediShop.Pharmacy;
namespace eMediShop
{
    public partial class PurchCheckListReconsile : Form
    {
        string _ItemId = "";
        string _ProductName = "";
        
        DataSet _ds = new DataSet();
        public PurchCheckListReconsile(string ItemId,string ProductName)
        {
            this._ItemId = ItemId;
            this._ProductName = ProductName;
            InitializeComponent();
        }
        private void PurchCheckListReconsile_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160); 
            if (!backgroundWorker1.IsBusy)
            {
                progressBar1.Visible = true;
                lblCurStock.Text = _ProductName;
                backgroundWorker1.RunWorkerAsync();
            }
            else
                MessageBox.Show("Wait It's Processing..");
        
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
            //    _ds = GlobalUsage.pharmacyproxy.GetQueryResult("exec UnitItemanalysis '" + GlobalUsage.Unit_id + "','" + _ItemId + "','" + DateTime.Now.AddMonths(-5).ToString("yyyy-MM-dd") + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "'");
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (_ds.Tables.Count > 0)
                {
                    int balance = 0;
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        int Row = 0;
                        dgCheckList.Items.Clear();
                        foreach (DataRow dr in _ds.Tables[0].Rows)
                        {
                            if(Row==0)
                            { balance = Convert.ToInt32(dr["runbal"]); /*lblCurStock.Text = "Current Stock :" + balance.ToString();*/ }
                            dgCheckList.Items.Add(dr["cr_date"].ToString());
                            dgCheckList.Items[Row].SubItems.Add(dr["particular"].ToString());
                            dgCheckList.Items[Row].SubItems.Add(dr["st_received"].ToString());
                            dgCheckList.Items[Row].SubItems.Add(dr["st_trf_sale"].ToString());
                            balance = balance + Convert.ToInt32(dr["st_received"]) - Convert.ToInt32(dr["st_trf_sale"]);
                            dgCheckList.Items[Row].SubItems.Add(balance.ToString());
                            if ((Row % 2) == 0)
                            dgCheckList.Items[Row].SubItems[0].BackColor = SystemColors.Control;
                            Row++;
                        }
                    }
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        lblStock.Text ="Current Stock : "+_ds.Tables[1].Rows[0][0].ToString();
                        lblrunBal.Text="Run Balance : "+balance.ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            progressBar1.Visible = false;

        }
        private void PurchCheckListReconsile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
