using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExPro.Client;
using ExPro.Server;
using eMediShop.Pharmacy;
namespace eMediShop
{
    public partial class SingleProductAnalysis : Form
    {
        
        DataSet _ds = new DataSet();
        string _Key = "";
        string _ItemId = "";
        string _ItemName = "";
        public SingleProductAnalysis()
        {
            InitializeComponent();
        }
        private void cbxProduct_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                #region Process Body
            
                _ItemId =((AddValue)cbxProduct.SelectedItem).Value;
                _ItemName = ((AddValue)cbxProduct.SelectedItem).NewDescription;
                lblProduct.Text ="Product Name : "+_ItemName;
                if (!backgroundWorker1.IsBusy)
                {
                    pb_working.Visible = true; 
                    backgroundWorker1.RunWorkerAsync();
                }  
                     #endregion
                btnGo.Visible = false;
            }
            catch (Exception ex)
            {
                  MessageBox.Show("You Clicked " +ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }
        private void cbxProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.Logic = "Search:InProduct"; p.prm_1 = "%" + cbxProduct.Text;
                    p.prm_2 = DateTime.Today.ToString("yyyyMMdd"); p.prm_3 = DateTime.Today.ToString("yyyyMMdd");
                    p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    _Key = cbxProduct.Text;
                    cbxProduct.Items.Clear();
                    //MoveCursor(_Key.Length);
                    cbxProduct.SelectionStart = _Key.Length;
                    cbxProduct.Items.AddRange(Config.FillCombo(dwr.result.Tables[0]));
                    btnGo.Enabled = true;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.Default;
            }
        }
        private void SingleProductAnalysis_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160); 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string qry = "exec pGetBestRateInfo '" + _ItemId + "'; exec GetMedicineStatus '" + _ItemName + "'  ";
            //_ds = GlobalUsage.pharmacyproxy.GetQueryResult2(qry,"eMediCentral");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        #region
            Cursor.Current = Cursors.WaitCursor;
             if (_ds.Tables.Count > 0)
            {
                lvBestDeal.Items.Clear();
                lvProAtUnit.Items.Clear();
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr1 in _ds.Tables[0].Rows)
                    {
                        lblMfd.Text = "Manufacturer : " + dr1["mfd_name"].ToString();
                        lvBestDeal.Items.Add(dr1["vendor_name"] + "," + dr1["city"]);
                        lvBestDeal.Items[lvBestDeal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr1["mrp"]).ToString("##.00"));
                        lvBestDeal.Items[lvBestDeal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr1["ptr"]).ToString("##.00"));
                        lvBestDeal.Items[lvBestDeal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr1["it_free"]).ToString("##.00"));
                        lvBestDeal.Items[lvBestDeal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr1["disper"]).ToString("##.00"));
                        lvBestDeal.Items[lvBestDeal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr1["npr"]).ToString("##.00"));
                        lvBestDeal.Items[lvBestDeal.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr1["quantity"]).ToString("##.##"));
                    }
                }
                if (_ds.Tables[1].Rows.Count > 0)
                {
                    foreach (DataRow dr2 in _ds.Tables[1].Rows)
                    {
                        lvProAtUnit.Items.Add((dr2["unit_name"].ToString().Replace("<B>", "")).Replace("</B>", ""));
                        lvProAtUnit.Items[lvProAtUnit.Items.Count - 1].SubItems.Add(dr2["pack_qty"].ToString());
                        lvProAtUnit.Items[lvProAtUnit.Items.Count - 1].SubItems.Add(dr2["m_cons"].ToString());
                        lvProAtUnit.Items[lvProAtUnit.Items.Count - 1].SubItems.Add(dr2["last_purch_date"].ToString());
                        lvProAtUnit.Items[lvProAtUnit.Items.Count - 1].SubItems.Add(dr2["last_trf_date"].ToString());
                        lvProAtUnit.Items[lvProAtUnit.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr2["stockqty"]).ToString("##.##"));
                        lvProAtUnit.Items[lvProAtUnit.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr2["packs"]).ToString("##.##"));
                        lvProAtUnit.Items[lvProAtUnit.Items.Count - 1].SubItems.Add(dr2["last_trf_date"].ToString());
                    }
                }
            }
        #endregion
             pb_working.Visible= false;
        }
    }
}
