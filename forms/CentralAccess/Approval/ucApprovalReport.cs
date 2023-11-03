using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop
{

    public partial class ucApprovalReport : UserControl
    {
          string _result = "";
        public ucApprovalReport()
        {
            InitializeComponent();
        }
        private void ucApprovalReport_Load(object sender, EventArgs e)
        {

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            string Logic = "";
            if (rdbtnAll.Checked)
                Logic = "Unit_ALL";
            else if (rdbtnApp.Checked)
                Logic = "Unit_Approved";
            else if (rdbtnCancelled.Checked)
                Logic = "Unit_Cancelled";
            lvDetail.Items.Clear();
            lvRemark.Items.Clear();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.accounts_proxy.Expense_Queries(out _result, Logic, GlobalUsage.Unit_id, "N/A", dtfrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), GlobalUsage.Login_id);
                if (ds.Tables.Count > 0)
                {
                    string temp = "";
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            if (temp != dr["head_name"].ToString())
                            {
                                lvDetail.Groups.Add(dr["head_name"].ToString(), dr["head_name"].ToString());
                                temp = dr["head_name"].ToString();
                            }
                            ListViewItem li = new ListViewItem(dr["App_id"].ToString().Trim());
                            li.SubItems.Add(dr["emp_name"].ToString());
                            li.SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("###.##"));
                            li.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy"));
                            if (dr["doc_path"].ToString() != "N/A")
                            {
                                li.SubItems.Add("Download");
                                li.SubItems.Add(dr["doc_path"].ToString());
                            }
                            else
                            {
                                li.SubItems.Add(dr["doc_path"].ToString());
                                li.SubItems.Add(dr["doc_path"].ToString());
                            }
                            li.Group = lvDetail.Groups[dr["head_name"].ToString()];
                            lvDetail.Items.Add(li);
                        }
                    }
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void lvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                viewRemark();
            }
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.D)
            {
                if (lvDetail.Items[lvDetail.FocusedItem.Index].SubItems[5].Text != "N/A")
                    DownloadDocument(lvDetail.Items[lvDetail.FocusedItem.Index].SubItems[5].Text);
            }
        }
        private void lvDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            viewRemark();
        }
        protected void viewRemark()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.accounts_proxy.Expense_Queries(out _result, "AllRemark", GlobalUsage.Unit_id, lvDetail.FocusedItem.SubItems[0].Text, dtfrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), GlobalUsage.Login_id);
                lvRemark.Items.Clear();
                if (ds.Tables.Count > 0)
                {
                    string temp = "";
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            if (temp != dr["emp_name"].ToString())
                            {
                                lvRemark.Groups.Add(dr["emp_name"].ToString(), dr["emp_name"].ToString());
                                temp = dr["emp_name"].ToString();
                            }
                            ListViewItem li = new ListViewItem(dr["remark"].ToString().Trim());
                            li.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy hh:mm tt"));
                            li.Group = lvRemark.Groups[dr["emp_name"].ToString()];
                            if (dr["final_flag"].ToString() == "Y")
                                lvRemark.Items.Add(li).ForeColor = Color.Green;
                            else
                                lvRemark.Items.Add(li);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void lvRemark_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtRemark.Text = e.Item.SubItems[0].Text;
        }
        public void DownloadDocument(string path)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string[] arr = path.Split('\\');
                byte[] data = GlobalUsage.pharmacy_proxy.DownLoadFile(path);
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                if (fd.SelectedPath != "")
                {
                    string stored_at = fd.SelectedPath + "\\" + arr[arr.Length - 1].ToString();
                    System.IO.File.WriteAllBytes(stored_at, data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }

}