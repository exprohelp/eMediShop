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
    public partial class UCView : UserControl
    {
        string _result="";
        public UCView()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
              
                pm_SaltInfo p = new pm_SaltInfo();
                p.logic = "SaltReport";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);

                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    lvStrength.Items.Clear();
                    string temp = "";
                    foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        if (temp != dr["item_name"].ToString())
                        {
                            lvStrength.Groups.Add(dr["item_name"].ToString(), dr["item_name"].ToString());
                            temp = dr["item_name"].ToString();
                        }
                        ListViewItem lvi = new ListViewItem(dr["salt_name"].ToString());
                        lvi.SubItems.Add(dr["Strength"].ToString() + " " + dr["str_type"].ToString());
                        lvi.Group = lvStrength.Groups[dr["item_name"].ToString()];
                        lvStrength.Items.Add(lvi);
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void UCView_Load(object sender, EventArgs e)
        {

        }
    }
}
