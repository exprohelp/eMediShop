using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.Product
{
    public partial class UploadSubstitute_Doc : Telerik.WinControls.UI.RadForm
    {
        int YlOC = 0; byte[][] imageList = null;
        int counter = 1;
        string _Itemid = string.Empty;
        string _ItemName = string.Empty; string _result = string.Empty;

        public UploadSubstitute_Doc()
        {
            InitializeComponent();
        }
        private void btnAddMore_Click(object sender, EventArgs e)
        {
         
        }
        private void RefreshList(object sender, UpdateMainPageTitleEventArgs e)
        {
            if(e.Result.Contains("Success"))
            {
                int ctrlcount = MasterPanel.Controls.Count;
                YlOC = ctrlcount * uploadSubstitute_Control1.Height;
                UploadSubstitute_Control ctrl = new UploadSubstitute_Control();
                ctrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ctrl.Location = new System.Drawing.Point(4, YlOC + 8);
                ctrl.ItemId = _Itemid;
                ctrl.ItemName = _ItemName;
                ctrl.Name = "uploadSubstitute_Control1" + counter;
                ctrl.MainPageTitle += new UpdateMainPageTitleEventHandler(RefreshList);
                ctrl.Size = new System.Drawing.Size(498, 188);
                MasterPanel.Controls.Add(ctrl);
                counter++;
            }
        }
        private void UploadSubstitute_Doc_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }
        private void dgItemName_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _Itemid = dgItemName.CurrentRow.Cells["item_id"].Value.ToString();
                _ItemName = dgItemName.CurrentRow.Cells["item_name"].Value.ToString();
                MasterPanel.Controls.Clear();
                uploadSubstitute_Control1.ItemId = _Itemid;
                uploadSubstitute_Control1.ItemName = _ItemName;
                lblItemNAME.Text = _ItemName + " [" + _Itemid + "]";
                int ctrlcount = MasterPanel.Controls.Count;
                YlOC = ctrlcount * uploadSubstitute_Control1.Height;
                UploadSubstitute_Control ctrl = new UploadSubstitute_Control();
                ctrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                ctrl.Location = new System.Drawing.Point(4, YlOC + 8);
                ctrl.ItemId = _Itemid;
                ctrl.ItemName = _ItemName;
                ctrl.Name = "uploadSubstitute_Control1" + counter;
                ctrl.MainPageTitle += new UpdateMainPageTitleEventHandler(RefreshList);
                ctrl.Size = new System.Drawing.Size(498, 188);
                MasterPanel.Controls.Add(ctrl);

                //uploadSubstitute_Control1.MainPageTitle += new UpdateMainPageTitleEventHandler(RefreshList);
                MasterPanel.Enabled = true;
                pnlMaster.Controls.Clear();
                if (chkImages.Checked)
                {
                   
         
                    imageList = GlobalUsage.pharmacy_proxy.Substitute_GetMultipleImages(out _result, _Itemid);
                    DisplayImageTile();
                }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }

        }
        private void DisplayImageTile()
        {
            if (imageList != null && imageList.Length > 0)
            {
                int y = 10;
                int img = 0;
                foreach (byte[] bd in imageList)
                {
                    if (bd != null && bd.Length > 1)
                    {
                        PictureBox pb = new PictureBox();
                        pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        pb.Location = new System.Drawing.Point(10, y);
                        pb.Name = "pic" + img;
                        y = y + 330;
                        pb.Size = new System.Drawing.Size(400, 320);
                        pb.TabIndex = 0;
                        pb.Tag = img.ToString();
                        //pb.Click += new EventHandler(pic_Click);
                        pb.TabStop = false;
                        using (MemoryStream ms = new MemoryStream(bd))
                        {
                            pb.Image = System.Drawing.Image.FromStream(ms);
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        pnlMaster.Controls.Add(pb);
                        img++;
                    }

                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalUsage.pharmacy_proxy = new Pharmacy.Pharmacy_WebServicesSoapClient();
                Cursor.Current = Cursors.WaitCursor;
                if (txtSearch.Text.Length > 0)
                {
                    string qry = "select item_id,item_name from item_master where discontinue='N' and item_name like '"+txtSearch.Text+"%' ORDER BY ITEM_NAME ";
                    DataSet ds = GlobalUsage.pharmacy_proxy.GetQueryResult(qry);
                    dgItemName.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

    }
}
