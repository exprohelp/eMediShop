using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.Substitute
{
    public partial class UCSubstituteReport : UserControl
    {
        string _result = "";
        public UCSubstituteReport()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                lvProduct.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                pm_SaltInfo p = new pm_SaltInfo();
                p.logic = "DateWiseItem"; p.item_id = dtFrom.Value.ToString("yyyy/MM/dd");p.salt_code = dtTo.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    string temp = "";
                    string empName = "";
                    int callCount = 0;
                    foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        empName= dr["emp_name"].ToString();
                        if (temp != empName)
                        {
                            callCount = dwr.result.Tables[0].AsEnumerable().Where(r => r.Field<string>("emp_name") == empName).Count();
                            lvProduct.Groups.Add(empName + " :" + callCount,empName+" :"+callCount);
                            temp = empName;
                        }
                        ListViewItem lvi = new ListViewItem(dr["item_id"].ToString());
                        lvi.SubItems.Add(dr["item_name"].ToString());
                        lvi.Group = lvProduct.Groups[empName + " :" + callCount];
                        lvProduct.Items.Add(lvi);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void lvProduct_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillSubstitute();
        }
        private void FillSubstitute()
        {
            try
            {
                lvSubstitute.Items.Clear();
                string item_id = lvProduct.Items[lvProduct.FocusedItem.Index].Text;
                Cursor.Current = Cursors.WaitCursor;
               
                pm_SaltInfo p = new pm_SaltInfo();p.prm_1 = item_id;
                p.logic = "SaltInProduct";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);

                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["salt_code"].ToString());
                        lvi.SubItems.Add(dr["salt_name"].ToString());
                        lvi.SubItems.Add(dr["Strength"].ToString() + " " + dr["str_type"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(dr["cr_date"]).ToString("dd-MM-yyyy"));
                        lvSubstitute.Items.Add(lvi);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void lvProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                FillSubstitute();
            }
        }
             
    }
}
