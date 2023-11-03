using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;

namespace eMediShop
{
    public partial class ucAssetList : UserControl
    {
        string _MainUnitId = string.Empty;
        DataSet _ds = new DataSet();
        DataSet dsP = new DataSet();
        DataTable _dtloc = new DataTable();
        public ucAssetList()
        {
            InitializeComponent();

        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("exec pAssetsList '" + _MainUnitId + "','N/A','N/A'", "assets_data");
                dgAssetList.DataSource = ds.Tables[0];
                _dtloc.Columns.Add("eq_location", typeof(string));
                GridViewTemplate childTemplate = dgAssetList.Templates[0];
                childTemplate.HierarchyDataProvider = new GridViewEventDataProvider(childTemplate);

                _dtloc.Rows.Clear();
                foreach (DataRow dr in ds.Tables[2].Rows)
                {
                    DataRow dr1 = _dtloc.NewRow();
                    dr1["eq_location"] = dr["eq_location"].ToString();
                    _dtloc.Rows.Add(dr1);
                }
                Telerik.WinControls.UI.GridViewComboBoxColumn reportsColumn = ((Telerik.WinControls.UI.GridViewComboBoxColumn)this.dgAssetList.Columns[7]);
                reportsColumn.ValueMember = "eq_location";
                reportsColumn.DisplayMember = "eq_location";
                reportsColumn.DataSource = _dtloc;
                reportsColumn.Width = 300;
                reportsColumn.AllowFiltering = false;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void dgAssetList_RowSourceNeeded(object sender, Telerik.WinControls.UI.GridViewRowSourceNeededEventArgs e)
        {
            try
            {
                string qry = "exec pAssetsList '" + _MainUnitId + "','GET_CHILDEQ','N/A','" + e.ParentRow.Cells[1].Value.ToString() + "'";
                Cursor.Current = Cursors.WaitCursor;
                _ds = GlobalUsage.pharmacy_proxy.GetQueryResult2(qry, "assets_data");
                if (_ds.Tables.Count > 0 && _ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        GridViewRowInfo row = e.Template.Rows.NewRow();
                        row.Cells["eq_No1"].Value = dr["eq_No"].ToString();
                        row.Cells["eq_name1"].Value = dr["eq_name"].ToString();
                        row.Cells["eq_serial_no1"].Value = dr["eq_serial_no"].ToString();
                        row.Cells["eq_description1"].Value = dr["eq_description"].ToString();
                        row.Cells["eq_category1"].Value = dr["eq_category"].ToString();
                        row.Cells["eq_location1"].Value = dr["eq_location"].ToString();
                        e.SourceCollection.Add(row);
                    }

                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void ucAssetList_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "";
                    qry = "select master_unit_id from shop_info where unit_id='" + GlobalUsage.Unit_id + "' ";
              
                DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult2(qry, "chandanpharmacy_live");

                _MainUnitId = ds.Tables[0].Rows[0]["master_unit_id"].ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void dgAssetList_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GridCommandCellElement el = (GridCommandCellElement)sender;
                string _result = string.Empty;
                if (el.ColumnInfo.HeaderText == "L")
                {
                    string qry = "update equip_info set eq_location='" + dgAssetList.CurrentRow.Cells[6].Value.ToString() + "' where eq_no='" + dgAssetList.CurrentRow.Cells[1].Value.ToString() + "'  ";
                    MessageBox.Show(GlobalUsage.pharmacy_proxy.QueryExecute(qry, "Assets_Data"));
                }
                else if (el.ColumnInfo.HeaderText == "R")
                {
                    string qry = "update equip_info set unit_rec_flag='Y' where eq_no='" + dgAssetList.CurrentRow.Cells[1].Value.ToString() + "'  ";
                    _result = GlobalUsage.pharmacy_proxy.QueryExecute(qry, "Assets_Data");
                    if (_result.Contains("Success"))
                    {
                        dgAssetList.CurrentRow.Cells["unit_rec_flag"].Value = "Y";
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            ExportToExcelML exporter = new ExportToExcelML(this.dgAssetList);
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            exporter.ExportVisualSettings = true;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                exporter.RunExport(fd.SelectedPath + "\\AssetsList.xls");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }

        private void dgAssetList_Click(object sender, EventArgs e)
        {

        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.GridViewComboBoxColumn reportsColumn = ((Telerik.WinControls.UI.GridViewComboBoxColumn)this.dgAssetList.Columns[7]);
            if (_dtloc.AsEnumerable().Where(x => x.Field<string>("eq_location") == txtLoc.Text.ToUpper()).Count() == 0)
            {
                DataRow dr1 = _dtloc.NewRow();
                dr1["eq_location"] = txtLoc.Text.ToUpper();
                _dtloc.Rows.Add(dr1);
                reportsColumn.ValueMember = "eq_location";
                reportsColumn.DisplayMember = "eq_location";
                reportsColumn.DataSource = _dtloc;
                reportsColumn.Width = 300;
                reportsColumn.AllowFiltering = false;
            }
        }

        private void dgAssetList_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["unit_rec_flag"].Value.ToString() == "Y")
            { e.RowElement.ForeColor = Color.Black; }
            else
            { e.RowElement.ForeColor = Color.Red; }
        }
    }
}
