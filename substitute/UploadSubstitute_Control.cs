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
namespace eMediShop.Substitute
{
    public partial class UploadSubstitute_Control : UserControl
    {
        public event UpdateMainPageTitleEventHandler MainPageTitle;
        OpenFileDialog dlg = new OpenFileDialog();
        string _ItemId = string.Empty;
        string _ItemName = string.Empty;
        string _result = "";
        string _extention = "";
        public UploadSubstitute_Control()
        {
            InitializeComponent();
        }
        public string ItemId
        {
            get { return _ItemId; }
            set { _ItemId = value; }
        }
        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            btnSave.Enabled = true;
            dlg.ShowDialog();
            if (dlg.FileName.Length > 3)
            {
                FileInfo fi = new FileInfo(dlg.FileName);
                txtpath.Text = dlg.FileName;
                _extention = fi.Extension;
                if (fi.Extension.ToUpper().Contains("JP") || fi.Extension.ToUpper().Contains("GIF"))
                {
                    if (((Convert.ToDecimal(fi.Length) / 1024)) > 300)
                    {
                        dlg.Dispose();
                        Image img = Image.FromFile(dlg.FileName);
                        txtpath.Text = Application.StartupPath + "\\substitute" + _extention;
                        CompressJPG(dlg.FileName, img, 9, txtpath.Text);
                        FileInfo fi1 = new FileInfo(Application.StartupPath + "\\substitute" + _extention);
                        pictureBox1.ImageLocation = fi1.FullName;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        lblMsg.Text = ((Convert.ToDecimal(fi.Length) / 1048576)).ToString("0.0") + "/" + ((Convert.ToDecimal(fi1.Length) / 1048576)).ToString("0.0") + "MB";
                    }
                    else
                    {
                        lblMsg.Text = ((Convert.ToDecimal(fi.Length) / 1048576)).ToString("0.0") + "MB";
                        pictureBox1.ImageLocation = fi.FullName;
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        txtpath.Text = fi.FullName;
                    }
                }

            }
            Cursor.Current = Cursors.Default;
        }

        private void ucUploadScanedDoc_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                btnSave.Enabled = false;
                //_result = GlobalUsage.cws.Insert_Modify_Substitute_docs(GlobalUsage.gUnit_id, _ItemId, _ItemName, System.IO.File.ReadAllBytes(txtpath.Text), "Insert");
                lblMsg.Text = _result;
                UpdateMainPageTitleEventArgs valueArgs = new UpdateMainPageTitleEventArgs(_result);
                MainPageTitle(this, valueArgs);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        public static void CompressJPG(string path, Image img, int quality, string FilePath)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");
            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
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
