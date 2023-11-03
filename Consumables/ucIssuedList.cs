using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eMediShop;
namespace eMediShop.Inventory
{
    public partial class ucIssuedList : UserControl
    {
       
        string _Action="",_ItemId="";
        DataSet _ds = new DataSet();
        DateTime dt_from = new DateTime();
        DateTime dt_to = new DateTime();
        public ucIssuedList()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            _Action = "IssuedLiist";
            dt_from = dateTimePicker1.Value;
            dt_to = dateTimePicker2.Value;
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            else
                MessageBox.Show("Wait.. Process is Running");
        }
        private void ucIssuedList_Load(object sender, EventArgs e)
        {
            _Action = "LoadProduct";
            progressBar1.Visible = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            else
                MessageBox.Show("Wait.. Process is Running");
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_Action == "LoadProduct")
            {
                try { _ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("select item_id,item_name from item_master order by item_name", "eIM_Data"); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            if (_Action == "IssuedLiist")
            {
                try { _ds = GlobalUsage.pharmacy_proxy.GetProductHistory(GlobalUsage.Unit_id, _ItemId, dt_from.ToString("yyyy/MM/dd"), dt_to.ToString("yyyy/MM/dd")); }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

        }
        private void fillProductList()
        {
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    cbxProductList.Items.Add(new AddValue("Select", "Select"));
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        cbxProductList.Items.Add(new AddValue(dr["item_id"].ToString(), dr["item_name"].ToString()));
                    }
                    cbxProductList.SelectedIndex = 0;
                }
            }
        }
        private void fillIssuedList()
        {
            if (_ds.Tables.Count > 0)
            {
                listView1.Items.Clear();
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    int run_bal = Convert.ToInt32(_ds.Tables[1].Rows[0][0]);
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        listView1.Items.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MMM-yyyy"));
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Recieved"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["Isued_qty"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(run_bal.ToString());
                        run_bal = (run_bal + Convert.ToInt32(dr["Recieved"])) - Convert.ToInt32(dr["Isued_qty"]);
                    }
                }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_Action == "LoadProduct")
            {
                fillProductList();
            }
            if (_Action == "IssuedLiist")
            {
                fillIssuedList();
            }
            progressBar1.Visible = false;
            _ds.Clear();
            _ds.Dispose();
            btnGo.Enabled = true;
        }
        private void cbxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ItemId = ((AddValue)cbxProductList.SelectedItem).Value;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxProductList_Leave(object sender, EventArgs e)
        {
            _ItemId = ((AddValue)cbxProductList.SelectedItem).Value;
        }
   
    }
}
