using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;
using System.Drawing.Imaging;

namespace eMediShop.FOC
{
    public partial class ucFOC : UserControl
    {
        string _result = string.Empty; string _empCode = string.Empty; Byte[] _imgByte = null; string szFileName = string.Empty;
        string _selectedFilePath = string.Empty; string _qry = string.Empty;
        string _Extension = string.Empty; string _unitCode = string.Empty; string _uniqeId = string.Empty;
        byte[] imageContent = null;
        OpenFileDialog dlg = new OpenFileDialog();
        SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
        DataSet _ds = new DataSet();string _estimateNo = string.Empty;
        public ucFOC()
        {
            InitializeComponent();
        }

        private void ucFOC_Load(object sender, EventArgs e)
        {
            rdp_from.Value = DateTime.Today;
            rdp_to.Value = DateTime.Today;
            try {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "EstimateNos"; p.prm_1 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/FOCQueries", p);
                _ds = dwr.result;
                rgv_info.DataSource=_ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            rgvItems.DataSource = new string[]{ };
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _estimateNo = e.Row.Cells["estimate_no"].Value.ToString();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "EstimateInfo"; p.prm_1 = _estimateNo; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/FOCQueries", p);
                _ds = dwr.result;
                rgvItems.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                FOCInfo p = new FOCInfo();
                p.unitID = GlobalUsage.Unit_id; p.Logic = "Insert"; p.estimateNo = _estimateNo;
                p.SendBy = GlobalUsage.Login_Name;p.attachmentPath = "-";
                p.Remarks = rtbReason.Text;p.approveBy = "-";p.isApproved = "N";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/Insert_Modify_FOC_InfoLog", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rdp_from_Leave(object sender, EventArgs e)
        {
            rdp_to.MinDate = rdp_from.Value;
        }

        private void btngetReport_Click(object sender, EventArgs e)
        {
            rgvReport.DataSource = new string[] { };
            try
            {
                Cursor.Current = Cursors.WaitCursor;
             
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;
                if(chkUnApproved.Checked)
                p.Logic = "UnProcess";
                else
                {
                    p.Logic = "Processed";
                    p.prm_1 = rdp_from.Value.ToString("yyyy-MM-dd");
                    p.prm_2 = rdp_to.Value.ToString("yyyy-MM-dd");
                }
                p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/FOCQueries", p);
                _ds = dwr.result;
                rgvReport.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btn_xl_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "FOCINFO"+DateTime.Now.ToString("ddMMyy")+".xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(rgvReport);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;
                    //spreadExporter.SheetName = "OrderStatus";
                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            dlg.Filter = "Image files (*.jpg, *.jpeg,*.png) | *.jpg; *.jpeg;*.png;*.pdf;*.PDF";
            if (dlg.ShowDialog() == DialogResult.OK) // Test result.
            {
                FileInfo file = new FileInfo(dlg.FileName);
                txtFilePath.Text = file.ToString();
                lblFileSize.Text = "File Size: " + ((Convert.ToDecimal(file.Length) / 1048576)).ToString("##.00") + " MB";
                btnUpload.Enabled = true;
                try
                {
                    if (!file.Extension.ToUpper().Contains("PDF"))
                    {

                        szFileName = Application.StartupPath + "\\uploadTemp" + file.Extension.ToString();
                        FileInfo check = new FileInfo(szFileName);
                        if (((Convert.ToDecimal(file.Length) / 1048576)) > 2)
                        {
                            SaveJPGWithCompressionSetting(Image.FromFile(dlg.FileName), szFileName, 50);
                        }
                        else
                            szFileName = dlg.FileName;
                        Image img = Image.FromFile(szFileName.ToString());
                        _imgByte = imgToByteArray(img);
                        //byte[] bArr = imgToByteConverter(img);
                        //Again convert byteArray to image and displayed in a picturebox
                        Image img1 = byteArrayToImage(_imgByte);

                        _Extension = "Image";
                    }
                    else
                    {
                        _imgByte = File.ReadAllBytes(dlg.FileName);
                        _Extension = "PDF";
                    }
                }
                catch (IOException)
                {
                }
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
            if (File.Exists(szFileName))
                File.Delete(szFileName);
            image.Save(szFileName, ici, eps);
        }

        //convert image to bytearray
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
        //convert bytearray to image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }
        //another easy way to convert image to bytearray
        public static byte[] imgToByteConverter(Image inImg)
        {
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                lblFileSize.Text = "Result : " + _result;
                FileInfo fi = new FileInfo(txtFilePath.Text);

                //byte[] data=eAccounts.azurestorage.Download().ToArray();
                //System.IO.File.WriteAllBytes("c:\\test.xlsx", data);
                string filepath = txtFilePath.Text;
                FileInfo f = new FileInfo(filepath);
                bool result = eMediShop.azurestorage.Upload(GlobalUsage.Unit_id,"foc", filepath);
                if (result)
                {
                    FOCInfo p = new FOCInfo();
                    p.unitID = GlobalUsage.Unit_id; p.Logic = "UpdateDocs"; p.estimateNo = _estimateNo;
                    p.SendBy = GlobalUsage.Login_Name;
                    p.attachmentPath = GlobalUsage.CloudStoragePath+ "/pharmacydocs/" + GlobalUsage.Unit_id+"/foc/"+f.Name;
                    p.Remarks = "-"; p.approveBy = "-"; p.isApproved = "N";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/Insert_Modify_FOC_InfoLog", p);
                    RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; btnUpload.Enabled = false; }
        }

        private void rgvReport_DoubleClick(object sender, EventArgs e)
        {
        }

        private void rgvReport_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _estimateNo = e.Row.Cells["estimateNo"].Value.ToString();
            radGroupBox1.Text = _estimateNo + "[" + e.Row.Cells["customerName"].Value.ToString() + "]"; 
        }

        private void chkUnApproved_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkUnApproved.Checked)
                radGroupBox1.Enabled = false;
            else
                radGroupBox1.Enabled = true;

        }
    }
}
