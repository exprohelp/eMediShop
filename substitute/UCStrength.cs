using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace eMediShop.Substitute
{
    public partial class UCStrength : UserControl
    {
        string _StrCode = "";
        string _result = string.Empty;
        public UCStrength()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            pm_SaltInfo p = new pm_SaltInfo();
            p.logic = "Insert";p.str_type = txtStrName.Text;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/InsertStrengthInfo", p);
            FillStrength();
        }
      
        private void FillStrength()
        {
            try
            {
                pm_SaltInfo p = new pm_SaltInfo();
                p.logic = "StrengthList"; 
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
               
                if (dwr.result.Tables[0].Rows.Count > 0)
                {
                    lvStrengtnName.Items.Clear();
                    foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        lvStrengtnName.Items.Add(dr["str_code"].ToString());
                        lvStrengtnName.Items[lvStrengtnName.Items.Count - 1].SubItems.Add(dr["str_type"].ToString());
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void lvStrengtnName_ItemSelectionChanged(object sender,ListViewItemSelectionChangedEventArgs e)
        {
             _StrCode = e.Item.Text;
             txtModifyStr.Text = e.Item.SubItems[1].Text;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            pm_SaltInfo p = new pm_SaltInfo();
            p.logic = "Update";p.str_code = _StrCode; p.str_type = txtModifyStr.Text;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/InsertStrengthInfo", p);
          
            FillStrength();
        }
        private void UCStrength_Load(object sender, EventArgs e)
        {
            FillStrength();
        }
    }
}
