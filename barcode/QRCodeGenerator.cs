
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Windows;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
    public class GenerateQRCode
    {
        private QrCodeEncodingOptions options;
        public Image GenerateMyQCCode(string QCText,int width,int height)
        {
            options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = width,
                Height =height,
                Margin=1,
            };
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = options;

            var qr = new ZXing.BarcodeWriter();
            qr.Options = options;
            qr.Format = ZXing.BarcodeFormat.CODE_128;
            var result = new Bitmap(qr.Write(QCText.Trim()));
            return result; 
            //pictureBox1.Image = result;
            //textBox1.Clear();
        }
    public Image GenBarCode(string code, int width, int height)
    {
        var writer = new BarcodeWriter
        {
            Format = BarcodeFormat.CODE_128,
            Options = new EncodingOptions
            {
                Width = width,
                Height = height

            }
        };
        return writer.Write(code);

    }




}

