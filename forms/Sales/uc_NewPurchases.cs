using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls;

namespace eMediShop.forms.Sales
{
    public partial class uc_NewPurchases : UserControl
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _unitID = string.Empty;
        public uc_NewPurchases()
        {
            InitializeComponent();
        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                btnProcess.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id + "|"; p.Logic = "NewProductList";
                p.dtFrom = dtFrom.Value.ToString("yyyy/MM/dd"); p.dtTo = dtTo.Value.ToString("yyyy/MM/dd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/NewPurchases", p);
                _ds = dwr.result;
                rgv.DataSource = _ds.Tables[0];
                if (_ds.Tables[0].Rows.Count > 0)
                    btnXL.Enabled = true;
                //Fill_SummaryByUnit(_ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            btnProcess.Enabled = true;
        }
        //private void Fill_SummaryByUnit(DataSet ds)
        //{ 
        //    var unit = ds.Tables[0].AsEnumerable().Select(o => new {unit_id=o.Field<string>("unit_id"),unit_name=o.Field<string>("unit_name")});
        //    var unitItems = ds.Tables[1].AsEnumerable().Select(o => new { unit_id = o.Field<string>("unit_id"), item_id = o.Field<string>("item_id") });
        //    var Items = ds.Tables[2].AsEnumerable().Select(o => new { item_id = o.Field<string>("item_id"), item_name = o.Field<string>("item_name") });

        //    //var tmp = myCollection.GroupBy(x => x.Id);
        //    //          .Select(y => new { 
        //    //                    Id = y.Key, 
        //    //                    Quantity = y.Sum(x => x.Quantity)
        //    //                  });

        //    var data = unit.Join(unitItems, u => u.unit_id, ui => ui.unit_id, (u, ui) => new
        //    {
        //        unit_id=u.unit_id,
        //        unit_name = u.unit_name + "|" + u.unit_id,
        //        item_id = ui.item_id
        //    }).GroupBy(g => new {unitid=g.unit_id,unitName=g.unit_name }).Select(x => new
        //    {
        //        unit_id=x.Key.unitid,
        //        unit_name = x.Key.unitName,
        //        ItemNo = x.Count()
        //    }).OrderBy(o => o.unit_name);
        //    lv_UnitInfo.Items.Clear();
        //    foreach (var r in data)
        //    { 
        //        ListViewItem lvi=new ListViewItem(r.unit_id);
        //        lvi.SubItems.Add(r.unit_name);
        //        lvi.SubItems.Add(r.ItemNo.ToString());
        //        lv_UnitInfo.Items.Add(lvi);
        //    }
        //}

        //private void lv_UnitInfo_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        //{
        //    try 
        //    {
        //        Cursor.Current = Cursors.WaitCursor;
        //        _unitID = e.Item.Text;
        //        var unitItems = _ds.Tables[1].AsEnumerable().Select(o => new { unit_id = o.Field<string>("unit_id"), item_id = o.Field<string>("item_id") });
        //        var Items = _ds.Tables[2].AsEnumerable().Select(o => new { item_id = o.Field<string>("item_id"), item_name = o.Field<string>("item_name") });

        //        var unitItem = unitItems.Join(Items, u => u.item_id, itms => itms.item_id, (
        //            u, itms) => new {
        //                unit_id=u.unit_id,
        //                item_id=u.item_id,
        //                item_name=itms.item_name
        //            }).Where(w=>w.unit_id==e.Item.Text).OrderBy(ord=>ord.item_name);
        //        lv_Products.Items.Clear();
        //        foreach (var r in unitItem)
        //        {
        //            ListViewItem lvi = new ListViewItem(r.item_id);
        //            lvi.SubItems.Add(r.item_name);
        //            lv_Products.Items.Add(lvi);
        //        }
        //    }
        //    catch (Exception ex)
        //    { }
        //    Cursor.Current = Cursors.WaitCursor;
        //}

        //private void lv_Products_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        //{
        //    try
        //    {
        //        Cursor.Current = Cursors.WaitCursor;
        //        var data = GlobalUsage.pwcf.NewPurchases(out _result, _unitID, dtFrom.Value.ToString("yyyy/MM/dd"), dtTo.Value.ToString("yyyy/MM/dd"), "SingleProductInfo",e.Item.Text)
        //            .Tables[0].AsEnumerable().Select(o => new { 
        //            SalesDate=o.Field<DateTime>("sale_date"),
        //            PurchDate = o.Field<DateTime>("inv_date")
        //            }).First();

        //        lblSalesDate.Text = "    First Sale Date : " + data.SalesDate.ToString("dd-MM-yyyy");
        //        lblPurchDate.Text = "First Purchase Date : " + data.PurchDate.ToString("dd-MM-yyyy");

        //        Cursor.Current = Cursors.Default;
        //    }
        //    catch (Exception ex)
        //    { }
        //}

        private void uc_NewPurchases_Load(object sender, EventArgs e)
        {

        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            ExportToExcelML exporter = new ExportToExcelML(this.rgv);
            exporter.HiddenColumnOption = Telerik.WinControls.UI.Export.HiddenOption.DoNotExport;
            exporter.ExportVisualSettings = true;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                exporter.RunExport(fd.SelectedPath + "\\NewProducts.xls");
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
