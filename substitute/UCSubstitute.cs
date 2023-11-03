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
    public partial class UCSubstitute : UserControl
    {
        string _result = string.Empty;
        public UCSubstitute()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ddlProduct.Items.Clear();
            try
            {
               if(txtItemName.Text.Length>0)
               {
                    pm_SaltInfo p = new pm_SaltInfo();
                    p.logic = "ProductSearch"; p.prm_1 = txtItemName.Text;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);

                   
                 if (dwr.result.Tables[0].Rows.Count > 0)
                 {
                    ddlProduct.SelectedIndexChanged-= new System.EventHandler(ddlProduct_SelectedIndexChanged);
                    ddlProduct.Items.AddRange(Config.FillCombo(dwr.result.Tables[0]));
                    ddlProduct.SelectedIndex=0;
                    ddlProduct.SelectedIndexChanged += new System.EventHandler(ddlProduct_SelectedIndexChanged);
                 }
               }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(((AddValue)ddlProduct.SelectedItem).Value=="Select")
            { MessageBox.Show("Please select Product"); return; }
            if(((AddValue)ddlSalt.SelectedItem).Value=="Select")
            { MessageBox.Show("Please select Salt Name");return; }
            if(((AddValue)ddlStrength.SelectedItem).Value=="Select")
            { MessageBox.Show("Please select Strength Type");return;}
            if(txtStrength.Text.Length==0)
            { MessageBox.Show("Please feed Strength Value");  return; }
            pm_SaltInfo p = new pm_SaltInfo();
            p.item_id = ((AddValue)ddlProduct.SelectedItem).Value;
            p.salt_code = ((AddValue)ddlSalt.SelectedItem).Value;p.login_id = GlobalUsage.Login_id;
            p.Strength = Convert.ToDecimal(txtStrength.Text);p.str_code = ((AddValue)ddlStrength.SelectedItem).Value;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/InsertSubstitute", p);
           
            if (dwr.message.Contains("Success"))
            {
                string itemid = ((AddValue)ddlProduct.SelectedItem).Value;
                FillSubstitute(itemid);}
            Cursor.Current = Cursors.Default;
        }
        private void UCSubstitute_Load(object sender, EventArgs e)
        {
            pm_SaltInfo p = new pm_SaltInfo();
            p.logic = "SaltAndStrType"; p.prm_1 = txtItemName.Text;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
         
            if (dwr.result.Tables[0].Rows.Count > 0)
            {
                ddlSalt.Items.AddRange(Config.FillCombo(dwr.result.Tables[0]));
                ddlSalt.SelectedIndex = 0;
            }
            if (dwr.result.Tables[1].Rows.Count > 0)
            {
                ddlStrength.Items.AddRange(Config.FillCombo(dwr.result.Tables[1]));
                ddlStrength.SelectedIndex = 0;
            }
        }
        private void FillSubstitute(string ItemId)
        {
            try
            {
                lvStrength.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                _result = DateTime.Now.Second.ToString();
                pm_SaltInfo p = new pm_SaltInfo();
                p.logic = "SaltsofAnItem"; p.prm_1 = txtItemName.Text;p.item_id = ItemId;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);

              
                if (dwr.result.Tables.Count>0 && dwr.result.Tables[0].Rows.Count > 0)
                {
                  
                    foreach (DataRow dr in dwr.result.Tables[0].Rows)
                    {
                        lvStrength.Items.Add(dr["auto_id"].ToString());
                        lvStrength.Items[lvStrength.Items.Count - 1].SubItems.Add(dr["salt_name"].ToString());
                        lvStrength.Items[lvStrength.Items.Count - 1].SubItems.Add(dr["Strength"].ToString() +" "+dr["str_type"].ToString());
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemid = ((AddValue)ddlProduct.SelectedItem).Value;
            FillSubstitute(itemid);
        }
        private void lvStrength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    pm_SaltInfo p = new pm_SaltInfo();
                    p.logic = "DeleteSubstitue"; p.prm_2 = Convert.ToInt32(lvStrength.Items[lvStrength.FocusedItem.Index].Text);
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
                    FillSubstitute(((AddValue)ddlProduct.SelectedItem).Value);
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message);}
             
            }
        }

        private void btn_SaltSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ddlSalt.Items.Clear();
            pm_SaltInfo p = new pm_SaltInfo();
            p.logic = "SaltSearch"; p.prm_1 = txtSaltSearch.Text;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
        
            if (dwr.result.Tables[0].Rows.Count > 0)
            {
                ddlSalt.Items.AddRange(Config.FillCombo(dwr.result.Tables[0]));
                ddlSalt.SelectedIndex = 0;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
