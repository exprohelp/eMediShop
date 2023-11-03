using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
    public partial class GC_UpdReport : Form
    {
        
        public GC_UpdReport()
        {
            InitializeComponent();
        }
        private void GC_UpdReport_Load(object sender, EventArgs e)
        {
            try
            {
                Rectangle rec = Screen.PrimaryScreen.WorkingArea;
                int size = (rec.Size.Width - this.Width) / 2;
                this.Location = new System.Drawing.Point(size, 130); 
                #region Process Block
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds=GlobalUsage.pharmacy_proxy.GetQueryResult2("exec pGC_Reports 'Diagnostic','"+GlobalUsage.Unit_id+"' ", "eManagement");
                fillTransferProduct(ds);  
                #endregion
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }
        private void fillTransferProduct(DataSet pds)
        {
            lv_Comp.Items.Clear();
            if (pds.Tables.Count > 0)
            {
                if (pds.Tables[0].Rows.Count > 0)
                {
                    string temp = "Temp";
                    foreach (DataRow dr in pds.Tables[0].Rows)
                    {
                        if (temp != dr["comp_name"].ToString())
                        {
                            lv_Comp.Groups.Add(dr["comp_name"].ToString(), dr["comp_name"].ToString());
                            temp = dr["comp_name"].ToString();
                        }
                        ListViewItem li = new ListViewItem(dr["UID"].ToString().Trim());
                        li.SubItems.Add(dr["reg_no"].ToString());
                        li.SubItems.Add(Convert.ToDateTime(dr["valid_upto"]).ToString("dd-MMM-yyyy"));
                        li.SubItems.Add(dr["remarks"].ToString());
                        li.SubItems.Add(dr["comp_name"].ToString());
                        li.Group = lv_Comp.Groups[dr["comp_name"].ToString()];
                        if (Convert.ToDateTime(dr["valid_upto"])>Convert.ToDateTime(GlobalUsage.CurrentDate))
                            lv_Comp.Items.Add(li);
                        else
                            lv_Comp.Items.Add(li).ForeColor = Color.Red;
                    }
                }
            }
        }
        public static UCSaveDoc AddDocUploadControl(string RegNo,string DocId, int cwidth)
        {
            UCSaveDoc rpc = new UCSaveDoc();
            rpc.DocId = DocId;
            rpc.RegNo = RegNo;
            rpc.Location = new System.Drawing.Point(8, 5);
            rpc.Width = cwidth;
            return rpc;
        }
        private void lv_Comp_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(AddDocUploadControl("(" + lv_Comp.Items[e.ItemIndex].SubItems[4].Text + ")" + lv_Comp.Items[e.ItemIndex].SubItems[1].Text, lv_Comp.Items[e.ItemIndex].Text, 650));
        }
    }
}
