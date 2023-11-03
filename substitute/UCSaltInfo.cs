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
    public partial class UCSaltInfo : UserControl
    {
        string _SaltCode = "N/A", _result = string.Empty; string _replByCode = string.Empty; string _replToCode = string.Empty; int _lvindex = 0;
        string _replByName = string.Empty; string _replToName = string.Empty;string _oldSaltName = string.Empty;
     
        public UCSaltInfo()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pm_SaltInfo p = new pm_SaltInfo();
            p.salt_code = "New"; p.Salt_Name = txtSaltName.Text;p.logic = "InsertUpdate";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/InsertSaltInfo", p);
           if(dwr.message.Contains("Success"))
           FillSalt();
           else
                MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FillSalt()
        {
            try
            {
                pm_SaltInfo p = new pm_SaltInfo();
                p.logic = "SaltList";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SaltQueries", p);
                rgvSaltInfo.DataSource = dwr.result.Tables[0];
               
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message);}
        }
        private void UCSaltInfo_Load(object sender,EventArgs e)
        {
            
         }
      
        private void btnFillSalt_Click(object sender, EventArgs e)
        {
            FillSalt();
        }

        private void rgvSaltInfo_KeyDown(object sender, KeyEventArgs e)
        {
        
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.R)
            {
                _replToCode = rgvSaltInfo.CurrentRow.Cells["salt_code"].Value.ToString();
                _replToName = rgvSaltInfo.CurrentRow.Cells["salt_name"].Value.ToString() + " [" + rgvSaltInfo.CurrentRow.Cells["salt_code"].Value.ToString() + "]";
               
            }
            else if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.D)
            {
                _replToCode = rgvSaltInfo.CurrentRow.Cells["salt_code"].Value.ToString();
                _replToName = rgvSaltInfo.CurrentRow.Cells["salt_name"].Value.ToString() + " [" + rgvSaltInfo.CurrentRow.Cells["salt_code"].Value.ToString() + "]";
                DialogResult res = MessageBox.Show("Do You Confirm To Delete :\n" + _replToName, "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    pm_SaltInfo p = new pm_SaltInfo();
                    p.salt_code = _replToCode; p.Salt_Name = "N/A"; p.logic = "Delete";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/InsertSaltInfo", p);
                    
                    MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rgvSaltInfo_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells["salt_name"].Value != null)
                _oldSaltName = e.Row.Cells["salt_name"].Value.ToString();
        }

        private void rgvSaltInfo_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            if (e.Row.Cells["salt_name"].Value != null && _oldSaltName!= e.Row.Cells["salt_name"].Value.ToString())
            {
                DialogResult res = MessageBox.Show("Do You Confirm To Delete :\n" + e.Row.Cells["salt_name"].Value.ToString(), "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    pm_SaltInfo p = new pm_SaltInfo();
                    p.salt_code = e.Row.Cells["salt_code"].Value.ToString(); p.Salt_Name = e.Row.Cells["salt_name"].Value.ToString(); p.logic = "InsertUpdate";
                    if (p.Salt_Name.Length < 5)
                    {
                        MessageBox.Show("Salt Name Should be More Than 5 Char.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/InsertSaltInfo", p);
                    MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void replace()
        {
           
            try
            {
                string msg = "Do You Confirm To Replace: \n" + _replToName + "\n By \n" + _replByName; 
                DialogResult res = MessageBox.Show(msg, "Expro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    pm_SaltInfo p = new pm_SaltInfo();
                    p.salt_code = _replToCode; p.Salt_Name = _replByCode; p.logic = "Merge";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/InsertSaltInfo", p);
                    MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
