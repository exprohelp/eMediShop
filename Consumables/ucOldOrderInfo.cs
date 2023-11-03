using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ExPro.Client;
using ExPro.Server;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;

namespace eMediShop.Inventory
{
    public partial class ucOldOrderInfo : UserControl
    {
        ListViewColumnSorter lvsort;
        DataSet _ds = new DataSet();
        private int sortColumn = -1;
        public ucOldOrderInfo()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            string result = "";
            _ds = GlobalUsage.pharmacy_proxy.GetOrderRawData(out result,GlobalUsage.Unit_id, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"));
            lvOldOrder.Items.Clear();
            foreach (DataRow dr in _ds.Tables[0].Rows)
            {

                lvOldOrder.Items.Add(dr["auto_id"].ToString());
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((dr["item_name"].ToString()));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((dr["pack_size"].ToString()));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add(Convert.ToDecimal(dr["pack_qty"]).ToString("##"));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((Convert.ToDecimal(dr["qty"]).ToString("##")));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((Convert.ToDecimal(dr["verify_qty"]).ToString("##")));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((dr["verify_flag"].ToString()));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((dr["trf_flag"].ToString()));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((dr["cr_date"].ToString()));
                lvOldOrder.Items[lvOldOrder.Items.Count - 1].SubItems.Add((dr["verify_by"].ToString()));
            }
            btnGo.Enabled = true;
            Cursor.Current = Cursors.Default;
        }
        private void lvOldOrder_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine whether the column is the same as the last column clicked.
            if (e.Column != sortColumn)
            {
                // Set the sort column to the new column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                lvOldOrder.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Determine what the last sort order was and change it.
                if (lvOldOrder.Sorting == System.Windows.Forms.SortOrder.Ascending)
                    lvOldOrder.Sorting = System.Windows.Forms.SortOrder.Descending;
                else
                    lvOldOrder.Sorting = System.Windows.Forms.SortOrder.Ascending;
            }
            // Call the sort method to manually sort.
            lvOldOrder.Sort();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.lvOldOrder.ListViewItemSorter = new ListViewItemComparer(e.Column, lvOldOrder.Sorting);

        }
    }
}
