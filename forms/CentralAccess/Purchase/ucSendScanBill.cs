using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.CentralAccess.Purchase
{
    public partial class ucSendScanBill : UserControl
    {
        string _purchId = string.Empty; DataSet _ds = new DataSet(); string _result = string.Empty;
        string _FilePath = string.Empty; byte[] data = null;
        System.IO.MemoryStream ms = null; Bitmap bmpPrint;
        public ucSendScanBill()
        {
            InitializeComponent();
        }
        private void btnRetreive_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = "N/A"; p.logic = "ScanBillInfo"; p.prm_1 = rdp_From.Value.ToString("yyyy/MM/dd");
                p.prm_2 = rdp_To.Value.ToString("yyyy/MM/dd"); p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                _ds = dwr.result;
                rgv_Info.DataSource = _ds.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int _index = 0;
        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void RefreshList(object sender, UpdateMainPageTitleEventArgs e)
        {
            if (e.Result == "Success")
            {
                rgv_Info.CurrentRow.Cells["Status"].Value = "Y";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //_ds=GlobalUsage.pharmacy_proxy.Purchase_Queries(out _result, GlobalUsage.Unit_id, _purchId, "CloseScanBillUploading", "N/A", "N/A");
        }



        private void rgv_Info_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (((sender as Telerik.WinControls.UI.GridCommandCellElement)).ColumnInfo.HeaderText == "Load")
                {
                    _purchId = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).Value.ToString();

                    Panel1.Controls.Clear();
                    ucUploadScanedDoc obj = new ucUploadScanedDoc();
                    obj.DocId = _purchId;
                    obj.DocType = "PurchaseBill";
                    obj.MainPageTitle += new UpdateMainPageTitleEventHandler(RefreshList);
                    Panel1.Controls.Add(obj);
                }
                else if (((sender as Telerik.WinControls.UI.GridCommandCellElement)).ColumnInfo.HeaderText == "View")
                {
                    radRotator1.Items.Clear();
                    string[] filepath = ((sender as Telerik.WinControls.UI.GridCommandCellElement)).Value.ToString().Split('|');
                    _purchId = rgv_Info.CurrentRow.Cells["Purch Id"].Value.ToString();
                    foreach (string path in filepath)
                    {
                        if (path.Length > 10)
                            radRotator1.Items.Add(GetThumbNail(path));
                    }
                    rgb_ViewDocument.Visible = true;
                    radRotator1.Start(true);
                    radRotator1.ShouldStopOnMouseOver = true;
                    rgb_ViewDocument.Location = new Point(8, 3);
                    rgb_ViewDocument.Size = new Size(951, 510);
                }
            }
            catch (Exception ex) { }
            finally { Cursor.Current = Cursors.WaitCursor; }
        }
        private Telerik.WinControls.UI.RadImageItem GetThumbNail(string path)
        {
            Telerik.WinControls.UI.RadImageItem imageItem = new Telerik.WinControls.UI.RadImageItem();
            #region Image Grab
            data = GlobalUsage.accounts_proxy.DownloadFile(path, out _result);
            ms = new System.IO.MemoryStream(data);
            Bitmap bmp = new Bitmap(System.Drawing.Image.FromStream(ms), new System.Drawing.Size(390, 455));
            #endregion
            Image image = bmp;//Image.FromFile(path);
            // workaround to prevent using internal image thumbnail
            image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            // calculate aspect ratio so image is not distorted
            double ratio = 0;
            if (image.Width > image.Height)
            {
                ratio = ClientRectangle.Width / image.Width;
            }
            else
            {
                ratio = ClientRectangle.Height / image.Height;
            }
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);
            imageItem.Image = image.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
            return imageItem;
        }
        private void rgv_Info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Status"].Value.ToString() == "Y")
                e.RowElement.ForeColor = Color.Green;
            else
                e.RowElement.ForeColor = Color.Red;
        }

        private void rgb_ViewDocument_Click(object sender, EventArgs e)
        {
            rgb_ViewDocument.Visible = false;
        }

        private void ucSendScanBill_Load(object sender, EventArgs e)
        {
            rdp_From.Value = DateTime.Today;
            rdp_To.Value = DateTime.Today;
        }

        private void rdp_From_Leave(object sender, EventArgs e)
        {
            rdp_To.MinDate = rdp_From.Value;
        }
    }
}
