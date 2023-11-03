using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using Telerik.WinControls.UI;
namespace eMediShop.Corp
{
    public partial class upp_uploadDocuments : Telerik.WinControls.UI.RadForm
    {

        string _result = string.Empty; int _appid; string _saleInvNo = string.Empty;
        string _FileName = "N/A"; string szFileName = string.Empty;
        string _FilePath = "N/A"; byte[] imgExistinCard;
        OpenFileDialog dlg = new OpenFileDialog();

        public upp_uploadDocuments()
        {
            InitializeComponent();
            radDateTimePicker1.Value = DateTime.Today;
        }

        private void upp_uploadDocuments_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            dlg.Filter = "Image files (*.jpg, *.jpeg,*.png) | *.jpg; *.jpeg;*.png";
            //dlg.Filter = "JPG Files (*.jpg)|*.jpeg|PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpg|GIF Files (*.gif)|*.gif";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                if (pbBox.Image != null)
                {
                    pbBox.Image.Dispose();
                    pbBox.Image = null;
                }
                FileInfo fi = new FileInfo(dlg.FileName);
                string mime_type = fi.Extension.ToString();
            
                szFileName = Application.StartupPath + "\\uppDoc" + mime_type;
                FileInfo check = new FileInfo(szFileName);
                if(((Convert.ToDecimal(fi.Length) / 1048576)) > 2)
                {
                    SaveJPGWithCompressionSetting(Image.FromFile(dlg.FileName), szFileName, 50);
                }
                else
                szFileName = dlg.FileName;
                FileInfo fi1 = new FileInfo(szFileName);
                pbBox.Image = Image.FromFile(szFileName);//.GetThumbnailImage(pbBox.Width, pbBox.Height, null, IntPtr.Zero);
                lblFileSize.Text = "File Size: " + ((Convert.ToDecimal(fi1.Length) / 1048576)).ToString("##.00") + " MB";
            }
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
        private void SaveJPGWithCompressionSetting(Image image, string szFileName, long lCompression)
        {
            EncoderParameters eps = new EncoderParameters(1);
            eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, lCompression);
            ImageCodecInfo ici = GetEncoderInfo("image/jpeg");
            if(File.Exists(szFileName))
            File.Delete(szFileName);
            image.Save(szFileName, ici, eps);
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (txtMobileNo.Text.Trim().Length==0 || txtMobileNo.Text.Trim().Length==10)
                {
                    byte[] img;
                    string AckInfo = string.Empty;
                    img = System.IO.File.ReadAllBytes(szFileName);
                    AckInfo = GlobalUsage.pharmacy_proxy.UpLoadPharmacy_UpPoliceDocument(comboType.Text, GlobalUsage.Unit_id, _saleInvNo, img, GlobalUsage.Login_id, txtMobileNo.Text, "N/A", out _result);
                    RadMessageBox.Show(AckInfo, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
                else
                { RadMessageBox.Show("Write proper mobile number", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvInfo_CommandCellClick(object sender, EventArgs e)
        {
            _saleInvNo = rgvInfo.CurrentRow.Cells[0].Value.ToString();
            rgbInfo.Enabled = true;
            try
            {
                if (pbBox.Image != null)
                {
                    pbBox.Image.Dispose();
                    pbBox.Image = null;
                }
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                ds = GlobalUsage.pharmacy_proxy.Corporate_AnalysisQueries(out _result, GlobalUsage.Unit_id, "VendorCode", "UPP:DocInfo", _saleInvNo, "N/A", "N/A", radDateTimePicker1.Value.ToString("yyyy/MM/dd"), "2011-10-31");
                var data = ds.Tables[0].AsEnumerable().Where(x => x.Field<string>("Doc_Type").Length >1 ).Select(x => new
                {
                    Doc_Type = x.Field<string>("Doc_Type"),
                    Doc_Path = x.Field<string>("Doc_Path")
                }
                 );
                if (data.Count()>0)
                    rgvDocInfo.DataSource = data.ToList();
                else
                    rgvDocInfo.DataSource = new DataTable();
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        rgbInfo.Text = ds.Tables[0].Rows[0]["pt_name"].ToString();
                    }
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rbtnGetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                ds=GlobalUsage.pharmacy_proxy.Corporate_AnalysisQueries(out _result,GlobalUsage.Unit_id,"VendorCode","UPP:Document","N/A","N/A","N/A",radDateTimePicker1.Value.ToString("yyyy/MM/dd"),"2011-10-31");
                rgvInfo.DataSource = ds.Tables[0]; 
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnMobileCheck_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                if (pbBox.Image != null)
                {
                    pbBox.Image.Dispose();
                    pbBox.Image = null;
                }
                ds = GlobalUsage.pharmacy_proxy.Corporate_AnalysisQueries(out _result, GlobalUsage.Unit_id, "VendorCode", "UPP:HealthCard",txtMobileNo.Text, "N/A", "N/A", radDateTimePicker1.Value.ToString("yyyy/MM/dd"), "2011-10-31");
                if (ds.Tables[0].Rows.Count> 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    imgExistinCard = GlobalUsage.accounts_proxy.DownloadFile(ds.Tables[0].Rows[0]["Doc_Path"].ToString(), out _result);
                    if (imgExistinCard != null)
                    {
                        FileInfo fi = new FileInfo(ds.Tables[0].Rows[0]["Doc_Path"].ToString());
                        string mime_type = fi.Extension.ToString();
                        szFileName = Application.StartupPath + "\\uppDoc" + mime_type;
                        File.WriteAllBytes(szFileName, imgExistinCard);
                        MemoryStream stream = new MemoryStream(imgExistinCard);
                        pbBox.Image = Image.FromFile(szFileName);
                    }
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvDocInfo_CommandCellClick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GridCommandCellElement _cmd =(GridCommandCellElement)(sender);
                Byte[] imgBytes;
                if(pbBox.Image != null)
                {
                    pbBox.Image.Dispose();
                    pbBox.Image = null;
                }
                imgBytes = GlobalUsage.accounts_proxy.DownloadFile(_cmd.RowInfo.Cells["Path"].Value.ToString(), out _result);
                if (imgBytes != null)
                {
                    MemoryStream stream = new MemoryStream(imgBytes);
                    pbBox.Image = Image.FromStream(stream).GetThumbnailImage(pbBox.Width, pbBox.Height, null, IntPtr.Zero);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void chkCardConfirm_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
