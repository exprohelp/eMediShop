using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
    public partial class PurchaseHelp : Telerik.WinControls.UI.RadForm
    {
        string _Action = string.Empty; string _result = string.Empty;
        string _Key = string.Empty;
        string _Item_Id = string.Empty;

        DataSet _ds = new DataSet();
        public PurchaseHelp()
        {
            InitializeComponent();
        }
        private void PurhaseHelp_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_Action == "Search")
            {
                try {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "Search:InProduct"; p.prm_1 = txtKey.Text;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    _ds = dwr.result;
                        }
                catch (Exception ex) { }
            }
            if (_Action == "PurchaseHelp")
            {
                try {
                    pm_PurchaseQueries p = new pm_PurchaseQueries();
                    p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "PurchaseHelp"; p.prm_1 = _Item_Id; p.prm_2 = "-"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                    _ds = dwr.result;
                }
                catch (Exception ex) { }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "Search")
            {
                cbxItemName.Items.Clear();
                cbxItemName.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
                cbxItemName.SelectedIndex = 0;
            }
            if (_Action == "PurchaseHelp")
            {
                purchaseHelp();
            }
            progressBar1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                _Action = "Search";
                _Key = txtKey.Text;
                progressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void cbxItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Action = "PurchaseHelp";
                _Item_Id = ((AddValue)(cbxItemName.SelectedItem)).Value;
                progressBar1.Visible = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        public void purchaseHelp()
        {
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    //Purchase Help Of UNIT
                    gbMainLko.Visible = true;
                    gbLuck.Visible = false;
                    txLkPurchFrom.Text = _ds.Tables[0].Rows[0]["Vendor_name"].ToString() + " \n " + _ds.Tables[0].Rows[0]["VendorInfo"].ToString();
                    txLkMrp.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["mrp"]).ToString("##.##");
                    txLk_Trade.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["ptr"]).ToString("###.##");
                    txLk_free.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["free"]).ToString("##.##");
                    txLk_Dis.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["disper"]).ToString("##.##");
                    txLk_bestNpr.Text = Convert.ToDecimal(_ds.Tables[0].Rows[0]["bestrate"]).ToString("##.##");
                }
                else
                {
                    gbMainLko.Visible = false;
                    groupBox1.Controls.Add(gbLuck);
                    this.gbLuck.Location = new System.Drawing.Point(77, 54);
                    this.gbLuck.Size = new System.Drawing.Size(270, 219);
                    gbLuck.Visible = true;

                }
                if (_ds.Tables[1].Rows.Count > 0)
                {
                    //Purchase Help Of UNIT
                    gbMainUnit.Visible = true;
                    gbxUnit.Visible = false;
                    txun_PurchFrom.Text = _ds.Tables[1].Rows[0]["Vendor_name"].ToString() + "\n" + _ds.Tables[1].Rows[0]["VendorInfo"].ToString();
                    txur_Mrp.Text = Convert.ToDecimal(_ds.Tables[1].Rows[0]["mrp"]).ToString("##.##");
                    txun_Trade.Text = Convert.ToDecimal(_ds.Tables[1].Rows[0]["ptr"]).ToString("##.##");
                    txun_free.Text = Convert.ToDecimal(_ds.Tables[1].Rows[0]["free"]).ToString("##.##");
                    txun_disc.Text = Convert.ToDecimal(_ds.Tables[1].Rows[0]["disper"]).ToString("##.##");
                    txun_npr.Text = Convert.ToDecimal(_ds.Tables[1].Rows[0]["npr"]).ToString("##.##");
                }
                else
                {
                    gbMainUnit.Visible = false;
                    groupBox2.Controls.Add(gbxUnit);
                    this.gbxUnit.Location = new System.Drawing.Point(81, 55);
                    this.gbxUnit.Size = new System.Drawing.Size(270, 219);
                    gbxUnit.Visible = true;

                }
            }
        }

        private void cbxItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
