using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.Inventory
{
    public partial class ucTransferfIdInfo : UserControl
    {
        string _Process = "InTransit";
        DataSet _ds = new DataSet();
        string _result = ""; string _action = "";
        string _Trfid = "";
        public ucTransferfIdInfo()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _ds = GlobalUsage.pharmacy_proxy.Transfer_idCheckingInfo(out _result,GlobalUsage.Unit_id, _Trfid, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), "ALL");
                fillTransferProduct();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _ds = GlobalUsage.pharmacy_proxy.Transfer_idCheckingInfo(out _result,GlobalUsage.Unit_id, _Trfid, "1900/01/10", "1900/01/10", _action);
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void fillTransferProduct()
        {
            lv_Transfer.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    string temp = "Temp";
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        if (temp != dr["from_unit"].ToString())
                        {
                            lv_Transfer.Groups.Add(dr["from_unit"].ToString(), dr["from_unit"].ToString());
                            temp = dr["from_unit"].ToString();
                        }
                        ListViewItem li = new ListViewItem(dr["auto_id"].ToString().Trim());
                        li.SubItems.Add(dr["trf_id"].ToString());
                        li.SubItems.Add(dr["from_unit"].ToString());
                        li.SubItems.Add(Convert.ToDateTime(dr["trf_date"]).ToString("dd-MMM-yyyy"));
                        li.SubItems.Add(dr["no_of_item"].ToString());
                        li.Group = lv_Transfer.Groups[dr["from_unit"].ToString()];
                        if (Convert.ToDateTime(dr["trf_date"]).ToString("dd-MM-yyyy") == System.DateTime.Now.ToString("dd-MM-yyyy"))
                            lv_Transfer.Items.Add(li).ForeColor = Color.Red;
                        else
                            lv_Transfer.Items.Add(li);
                    }
                }
            }
        }
        private void fillTransferProductDetail()
        {
            listView1.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        listView1.Items.Add(dr["item_name"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["batch_no"].ToString());
                        if (dr["exp_date"].ToString() == "")
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add("");
                        else if (Convert.ToDateTime(dr["exp_date"]).ToString("dd-MM-yyyy") == "01-01-1900")
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add("N/A");
                        else
                            listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDateTime(dr["exp_date"]).ToString("MM-yy"));
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["pack_type"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["pack_qty"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["upr"]).ToString("##.00"));
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["qty"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["rcpt_qty"].ToString());
                        listView1.Items[listView1.Items.Count - 1].SubItems.Add(dr["rcpt_login"].ToString());
                    }
                }
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_action == "InTransit")
                fillTransferProduct();
            else if (_action == "NotPosted")
                fillTransferProduct();
            else
                fillTransferProductDetail();
            _ds.Clear();
            progressBar1.Visible = false;
        }
        private void transfer_IdInfo_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            //WinAPI.AnimateWindow(this.Handle, 1000, WinAPI.AW_ACTIVATE | WinAPI.AW_BLEND);
        }
        private void lv_Transfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (radioButton1.Checked)
                _action = "InTransitItemsInfo";
            else
                _action = "TrfansferItemInfo";
            if (e.KeyCode == Keys.Enter)
            {
                if ((object)lv_Transfer.FocusedItem != null)
                {
                    _Trfid = lv_Transfer.Items[lv_Transfer.FocusedItem.Index].SubItems[1].Text;
                    progressBar1.Visible = true;
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lv_Transfer.Items.Clear();
                listView1.Items.Clear();
                progressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy) { _action = "InTransit"; backgroundWorker1.RunWorkerAsync(); }
                gbxDate.Visible = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lv_Transfer.Items.Clear();
                listView1.Items.Clear();
                _Process = "NotPosted";
                progressBar1.Visible = true;
                if (!backgroundWorker1.IsBusy) _action = "NotPosted"; backgroundWorker1.RunWorkerAsync();
                gbxDate.Visible = false;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                _Process = "ALL";
                lv_Transfer.Items.Clear();
                listView1.Items.Clear();
                gbxDate.Visible = true;
            }
        }

        private void ucTransferfIdInfo_Load(object sender, EventArgs e)
        {

        }
      
    }
}
