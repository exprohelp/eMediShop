using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace eMediShop.warehouse
{
    public partial class uc_SettingofVendorAgainstKeys : UserControl
    {
        string _result = string.Empty; DataSet _ds = new DataSet(); DataSet _dsVendor = new DataSet();
        string _master_key_id = string.Empty; string _OldVendroCode = string.Empty; string _NewVedndor_id = string.Empty; string _newVendorName = string.Empty;
        RadDropDownListEditorElement element;
        public uc_SettingofVendorAgainstKeys()
        {
            InitializeComponent();
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "EGR:VendorToReturnGoods"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
            _dsVendor = dwr.result;
        }

        int ticks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            radProgressBar1.Value1 = ticks;
            if (ticks == 100)
            {
                timer1.Enabled = false;
                ticks = 0;
            }
        }

        private void rbtn_Retrive_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "EGR:ForVendorChangeInfo"; p.prm_1 = "N/A"; p.prm_2 = "N/A";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/grQueries", p);
            _ds = dwr.result;
            if (_ds.Tables.Count == 3)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    
                    var data = _ds.Tables[0].AsEnumerable().Select(o => new { 
                    item_id=o.Field<string>("item_id"),
                    item_name=o.Field<string>("item_name"),	
                    master_key_id=o.Field<string>("master_key_id"),
                    batch_no=o.Field<string>("batch_no"),
                    exp_date=o.Field<DateTime>("exp_date"),
                    npr=o.Field<decimal>("npr"),
                    mrp=o.Field<decimal>("mrp"),
                    vendor_code = o.Field<string>("vendor_code"),
                    mfd_id = o.Field<string>("mfd_id"),
                    packs= o.Field<decimal>("gr_packs")
                    });
                    var vendor = _ds.Tables[1].AsEnumerable().Select(o => new
                    {
                        vendor_id = o.Field<string>("vendor_code"),
                        vendor_name = o.Field<string>("VendorName")
                    });
                    var company = _ds.Tables[2].AsEnumerable().Select(o => new
                    {
                        mfd_id = o.Field<string>("mfd_id"),
                        mfd_name = o.Field<string>("mfd_name")
                    });
                    //Joining in Linq
                    var final = from d in data
                                join v in vendor on d.vendor_code equals v.vendor_id
                                join c in company on d.mfd_id equals c.mfd_id
                                select new {
                                    d.item_id,
                                    d.item_name,
                                    d.master_key_id,
                                    d.batch_no,
                                    d.exp_date,
                                    d.npr,
                                    d.mrp,
                                    d.vendor_code,
                                    d.mfd_id,
                                    c.mfd_name,
                                    v.vendor_name,
                                    d.packs,
                                    amount=d.packs*d.npr
                                };
                    DataTable boundTable = Config.LINQToDataTable(final);
                    rgv_info.DataSource = boundTable;

                    timer1.Enabled = false;
                }
            }
        }

        private void MasterTemplate_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[2].Value != null)
            {
                _master_key_id = e.Row.Cells[2].Value.ToString();
                _OldVendroCode = e.Row.Cells["vendor_code"].Value.ToString();
            }
        }

        private void MasterTemplate_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (_OldVendroCode != _NewVedndor_id && _NewVedndor_id.Length > 4 && _NewVedndor_id != "Select")
                {
                    string[] x = _NewVedndor_id.Split('|');
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "gr_stock:allotVendor"; p.prm_1 = x[1].ToString();p.prm_2 = x[1].ToString();
                    p.tran_id = _master_key_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    
                    if (dwr.message.Contains("Success"))
                    {
                        rgv_info.Rows[e.Row.Index].Cells[11].Value = x[0].ToString();
                        rgv_info.Rows[e.Row.Index].Cells[12].Value = _newVendorName;
                    }
                    //rgv_info.CurrentCell.Value = _newVendorName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;
        }

        private void MasterTemplate_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            RadDropDownListEditor editor = e.ActiveEditor as RadDropDownListEditor;
            if (editor != null)
            {
                //var data=_dsVendor.Tables[0].AsEnumerable()
                //   .Select(o=>new {
                //   vendor_id=o.Field<string>("vendor_code"),
                //   vendor_name=o.Field<string>("vendor_name")
                //   }).ToList().OrderBy(o=>o.vendor_name);
                element = (RadDropDownListEditorElement)editor.EditorElement;
                //element.DataSource = data;
                //element.ValueMember = "vendor_id";
                //element.DisplayMember = "vendor_name";
                element.Items.AddRange(Config.FillTelrikCombo(_dsVendor.Tables[0]));
                element.SelectedIndex=0;
                element.SelectedValueChanged += element_SelectedValueChanged;
            }
        }

        void element_SelectedValueChanged(object sender, Telerik.WinControls.UI.Data.ValueChangedEventArgs e)
        {
            if (e.Position != -1)
            {
                _NewVedndor_id= element.SelectedValue.ToString();
                _newVendorName = element.SelectedItem.ToString();
                //_NewVedndor_id = (this.element.Items[e.Position].DataBoundItem as DataRowView)[this.element.ValueMember].ToString();
            }
        }

 
    }
}
