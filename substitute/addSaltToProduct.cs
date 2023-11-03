using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Substitute
{
    public partial class addSaltToProduct : Telerik.WinControls.UI.RadForm
    {
        byte[][] imageList = null;
        string _result = string.Empty;
        public addSaltToProduct()
        {
            InitializeComponent();
        }

        private void addSaltToProduct_Load(object sender, EventArgs e)
        {
            dispPanel.Controls.Add(new Substitute.UCSubstitute());
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.login_id = GlobalUsage.Login_id;
                if (chkImage.Checked)
                    p.Logic = "ImageDataList";
                else
                    p.Logic = "SubstituteListByDate";

                p.prm_1 = rdp_from.Value.ToString("yyyyMMdd"); p.prm_2 = rdp_to.Value.ToString("yyyyMMdd");
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/SubtituteQueries", p);
                dgItemList.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
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
                        Telerik.WinControls.UI.RadPanel radPanel1 = new Telerik.WinControls.UI.RadPanel();

                        radPanel1.Location = new System.Drawing.Point(10, y);
                        radPanel1.Size = new System.Drawing.Size(400, 320);

                        System.Windows.Forms.TrackBar trackBar1 = new TrackBar();
                        trackBar1.Location = new System.Drawing.Point(360, 33);
                        trackBar1.Maximum = 200;
                        trackBar1.Minimum = 1;
                        trackBar1.Name = "trackBar1";
                        trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
                        trackBar1.Size = new System.Drawing.Size(45, 85);
                        trackBar1.TickFrequency = 10;
                        trackBar1.Value = 100;
                        trackBar1.Scroll += new EventHandler(trackBar1_Scroll);

                        ImagePanel pb = new ImagePanel();
                        pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        pb.Location = new System.Drawing.Point(5, 5);
                        pb.Name = "pic" + img;
                        y = y + 330;
                        pb.Size = new System.Drawing.Size(350, 310);
                        pb.TabIndex = 0;
                        pb.Tag = img.ToString();
                        pb.TabStop = false;
                        using (MemoryStream ms = new MemoryStream(bd))
                        {
                            Bitmap bmp = new Bitmap(System.Drawing.Image.FromStream(ms), new System.Drawing.Size(537, 472));
                            pb.Zoom = 1;
                            pb.Image = bmp;
                        }
                        radPanel1.Controls.Add(pb);
                        radPanel1.Controls.Add(trackBar1);
                        MasterPnl.Controls.Add(radPanel1);
                        img++;
                    }

                }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            foreach (Control ct in tb.Parent.Controls)
            {
                if (ct.GetType() == typeof(ImagePanel))
                {
                    ImagePanel imp = (ImagePanel)ct;
                    imp.Zoom = tb.Value * 0.02f;
                }

            }

        }
        private void dgItemList_Click(object sender, EventArgs e)
        {
            try
            {
                MasterPnl.Controls.Clear();
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.login_id = GlobalUsage.Login_id; p.item_id = dgItemList.CurrentRow.Cells["item_id"].Value.ToString();
                string obj = ConfigWebAPI.CallAPIObject("api/products/SubstituteGetMultipleImages", p);
                imageList = JsonConvert.DeserializeObject<byte[][]>(obj);

                if (!_result.Contains("Success"))
                { MessageBox.Show(_result); }
                else
                {
                    DisplayImageTile();
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void MasterTemplate_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "column1")
                {
                    ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    if (e.CellElement.RowInfo.Cells["img_flag"].Value.ToString() == "Y")
                    {
                        //((GridCommandCellElement)e.CellElement).CommandButton.Image = Resources.attachment;
                        ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                    }

                }
            }
        }
    }
}
