using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace eMediShop
{
    public partial class ucImportApprovals : UserControl
    {
        string _result = "";
        public ucImportApprovals()
        {
            InitializeComponent();
        }
        private void ucImportApprovals_Load(object sender, EventArgs e)
        {

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            FillRecord();
        }
        private void FillRecord()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.accounts_proxy.Expense_Queries(out _result, "Import", GlobalUsage.Unit_id, "N/A", null, null, GlobalUsage.Login_id);
                lvDetail.Items.Clear();
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
                            ListViewItem li = new ListViewItem(dr["app_id"].ToString().Trim()); //0
                            li.SubItems.Add(dr["remark"].ToString());//1
                            li.SubItems.Add(dr["head_name"].ToString()); //2
                            li.SubItems.Add(dr["emp_name"].ToString()); //3
                            li.SubItems.Add(Convert.ToDecimal(dr["amount"]).ToString("###"));//4
                            li.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy"));//5
                            li.SubItems.Add(dr["app_head_id"].ToString());//6
                            li.Group = lvDetail.Groups[dr["head_name"].ToString()];//7
                            li.Checked = true;
                            lvDetail.Items.Add(li);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvDetail.Items.Count; i++)
            {
                if (lvDetail.Items[i].Checked)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _result = GlobalUsage.accounts_proxy.ImportExpenses_ByUnit(GlobalUsage.Unit_id, lvDetail.Items[i].SubItems[0].Text, lvDetail.Items[i].SubItems[1].Text + " By App No." + lvDetail.Items[i].Text, GlobalUsage.Login_id);
                        if (_result != "Failed To Post")
                        {
                            lvDetail.Items[i].Remove();
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    finally
                    {
                        Cursor.Current = Cursors.WaitCursor;
                    }
                }
            }
            MessageBox.Show("Successfully Paid", "Cash Payment");
        }


    }
}