using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging; 
using System.IO;
namespace eMediShop
{
    public partial class ucUploadScanedDoc : UserControl
    {
        public event UpdateMainPageTitleEventHandler MainPageTitle;
        OpenFileDialog dlg = new OpenFileDialog();
        string _DocId = string.Empty;
        string _DocType = string.Empty;
        string _result = "";
        string _extention = "";
        public ucUploadScanedDoc()
        {
            InitializeComponent();
        }
        public string DocId
        {
            get { return _DocId; }
            set { _DocId = value; }
        }
        public string DocType
        {
            get { return _DocType; }
            set { _DocType = value; }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnSave.Enabled = true;
            dlg.ShowDialog();
            if (dlg.FileName.Length>3)
            {
                FileInfo fi = new FileInfo(dlg.FileName);
                txtpath.Text=dlg.FileName;
                _extention=fi.Extension;
                if (fi.Extension.ToUpper().Contains("JP"))
                {
                    if (((Convert.ToDecimal(fi.Length) / 1024)) > 300)
                    {
                        dlg.Dispose();
                        Image img = Image.FromFile(dlg.FileName);
                        txtpath.Text = Application.StartupPath + "\\TempImage" + _extention;
                        CompressJPG(dlg.FileName, img, 9, txtpath.Text);
                        FileInfo fi1 = new FileInfo(Application.StartupPath + "\\TempImage" + _extention);
                        lblMsg.Text = ((Convert.ToDecimal(fi.Length) / 1048576)).ToString("0.0") + "/" + ((Convert.ToDecimal(fi1.Length) / 1048576)).ToString("0.0") + "MB";
                    }
                    else {
                        lblMsg.Text = ((Convert.ToDecimal(fi.Length) / 1048576)).ToString("0.0") +"MB";
                    }
                }
            //    if (((Convert.ToDecimal(fi.Length) / 1048576)) > 2)
            //    { btnSave.Enabled = false; MessageBox.Show("File size should not be more than 2 MB"); }
            //    else
            //    { btnSave.Enabled = true; }
            }
            Cursor.Current = Cursors.Default;
        }
        private void ucUploadScanedDoc_Load(object sender, EventArgs e)
        {
            txtDocType.Text =_DocType.ToUpper();
            txtDocId.Text =_DocId.ToUpper();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(txtpath.Text);

                Cursor.Current = Cursors.WaitCursor;
               btnSave.Enabled = false;
                pm_documents p = new pm_documents();
                p.DocId = _DocId;p.DocType = _DocType;p.login_id = GlobalUsage.Login_id;p.unit_id = GlobalUsage.Unit_id;
                p.extension = fi.Extension;
                p.filename = fi.Name;
                p.dataInBytes = System.IO.File.ReadAllBytes(txtpath.Text);
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/documents/InsertScanedDocuments", p);
                _result = dwr.message;
               UpdateMainPageTitleEventArgs valueArgs = new UpdateMainPageTitleEventArgs(_result);
               MainPageTitle(this, valueArgs);
               lblMsg.Text = _result;
               Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }
        public static void CompressJPG(string path,Image img,int quality,string FilePath)
        {
            if (quality < 0 || quality > 100)
            throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");
            // Encoder parameter for image quality 
            EncoderParameter qualityParam =new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // Jpeg image codec 
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(FilePath, jpegCodec, encoderParams);
        }
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
            if (codecs[i].MimeType == mimeType)
            return codecs[i];
            return null;
        } 

    }
}
