
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop
{
    public partial class packTypeSelection : Telerik.WinControls.UI.RadForm
    {

        DataSet _ds = new DataSet(); string _result = string.Empty; string _itemID = string.Empty;
        public event SelectPackTypeEventHandler SelectPackType;
        public packTypeSelection(string item_id)
        {
            _itemID = item_id;
            InitializeComponent();
        }

        private void packTypeSelection_Load(object sender, EventArgs e)
        {
            pm_PurchaseQueries p = new pm_PurchaseQueries();
            p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "-"; p.logic = "PackTypes"; p.prm_1 = _itemID; p.prm_2 = "-"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
            _ds = dwr.result;
            var data = _ds.Tables[0].AsEnumerable().Select(o => new
            {
                pack_type = o.Field<string>("pack_type"),
                pack_qty = o.Field<Int64>("pack_qty"),
            }).OrderBy(ord => ord.pack_type);
            lvPackType.Items.Clear();
            foreach (var a in data)
            {
                ListViewItem lvi = new ListViewItem(a.pack_type);
                lvi.SubItems.Add(a.pack_qty.ToString());
                lvPackType.Items.Add(lvi);
            }
            //  lvPackType.DataSource = data.ToList();
        }

        private void lvPackType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SelectPackTypeEventArgs valueArgs = new SelectPackTypeEventArgs(lvPackType.FocusedItem.SubItems[0].Text, Convert.ToInt32(lvPackType.FocusedItem.SubItems[1].Text));
                SelectPackType(this, valueArgs);
                this.Close();

            }
        }
    }
}
