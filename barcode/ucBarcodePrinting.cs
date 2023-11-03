using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Telerik.WinControls;
using System.Drawing.Printing;
using Telerik.WinControls.UI;

namespace eMediShop.barcode
{
    public partial class ucBarcodePrinting : UserControl
    {
        System.Drawing.Image bitmap = (System.Drawing.Image)Bitmap.FromFile(GlobalUsage.BillDrive + "\\barcode.jpeg"); // set image   
        public ucBarcodePrinting()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            LabelPrint();
        }

        private void LabelPrint()
        {
            try
            {
                string name = "RAMESH KUMAR AGARWAL";
                string dietType = "LUNCH-THU-NORMAL";
                string ipdNo = "IPD No. 68123";
                string roomDetail = "1stFloor/134";


                string sku = "2001";
                while (sku.Length < 12)
                {
                    sku = "0" + sku;
                }
                var sb = new StringBuilder();
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();

                sb.AppendLine(); sb.AppendLine();
               
                sb.AppendLine("N");//Clear Image Buffer
                                   //sb.AppendLine("q425");//Set Form Width
                                   //sb.AppendLine("Q360,26"); //Set Form Length
                                   //sb.AppendLine("q425");//Set Form Width
                                   //sb.AppendLine("Q360"); //Set Form Length
                                   //AStartPoint, VerticalSter:Point, Rotation, Font Selection, Horizontel

                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A40,25,0,4,1,1,N,\"{0}\"", ipdNo));
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A40,59,0,4,1,1,N,\"{0}\"", name));
                if (dietType.Length > 20)
                {
                    sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A40,93,0,4,1,1,N,\"{0}\"", dietType.Substring(0, 20)));
                    sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A40,125,0,2,1,1,N,\"{0}\"", dietType.Substring(20, dietType.Length - 20)));
                    sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A40,155,0,4,1,1,N,\"{0}\"", roomDetail));
                }
                else
                {
                    sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A40,93,0,3,1,1,N,\"{0}\"", dietType));
                    sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A40,125,0,4,1,1,N,\"{0}\"", roomDetail));
                }

                //BstartPoint, VerticalstartPosition,Rotation, BarSelection/Code 128 Mo
                //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A100,164,0,4,1,1,N,\"{0}\"", sku));
                //sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "850,13,0,1A,2,3,B,\"{0}\"", sku));
                sb.AppendLine("P1,3");//Print Command, Qty
                if (DialogResult.OK == pd.ShowDialog(this))
                {
                    int[] vals = { 1, 2}; //, 3,4,5,6,7,8,9,10 

                    foreach (var val in vals)
                    {
                        eMediShop.RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, sb.ToString());
                    }



                }
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
           
            PrintDocument printDoc = new PrintDocument();
           // printDoc.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("LisBarCode", 200, 100);
            //printDoc.DefaultPageSettings.Margins = new Margins(2, 2, 2, 2);
            printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDoc.Print();
        }
        string mkeyText = "*N0123478980098*";
        string ItemNameText = "Disprine tab 500 mg";
        string BatchText = "B:12568795,E:20-02-2022";
        string Logic = "BarCode";
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bitmap, 0, 0);
            if (Logic == "QR")
            {
                GenerateQRCode obj = new GenerateQRCode();
                Image img = obj.GenerateMyQCCode(mkeyText, 50, 50);

                PointF mkey_Location = new PointF(60f, 2f);
                PointF itemName_Location = new PointF(60f, 20f);
                PointF Batch_Lcation = new PointF(60f, 42f);
                PointF ImageQrCodeLocation = new PointF(3f, 5f);

                using (Font arialFont = new Font("Arial", 10))
                {
                    e.Graphics.DrawString(mkeyText, arialFont, Brushes.Black, mkey_Location);
                    e.Graphics.DrawString(ItemNameText, arialFont, Brushes.Black, itemName_Location);
                    e.Graphics.DrawString(BatchText, arialFont, Brushes.Black, Batch_Lcation);
                    e.Graphics.DrawImage(img, ImageQrCodeLocation);
                }
            }
            else
            {

                GenerateQRCode obj = new GenerateQRCode();
                Image img = obj.GenBarCode(mkeyText, 50, 40);

                //PointF mkey_Location = new PointF(3f, 2f);
                PointF itemName_Location = new PointF(10f, 2f);
                PointF Batch_Lcation = new PointF(10f, 15f);
                PointF mkey_Lcation = new PointF(10f, 40f);
                Point ImageBarCode_Location = new Point(7, 35);
                Font barcodeFont = new Font("IDAutomationHC39M", 10);
                using (Font forntName = new Font("TSC Font 2", 10))
                {
                    e.Graphics.DrawString(ItemNameText, forntName, Brushes.Black, itemName_Location);
                    e.Graphics.DrawString(BatchText, forntName, Brushes.Black, Batch_Lcation);
                   //e.Graphics.DrawString(mkeyText, barcodeFont, Brushes.Black, mkey_Lcation);

                    

                    //e.Graphics.DrawImage(img, ImageBarCode_Location);
                    e.Graphics.DrawImageUnscaled(img, ImageBarCode_Location);
                    //e.Graphics.DrawRectangle(new Pen(Color.Black), 3, 1, 180, 85);

                }


            }

        }

        private void rgvInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ProductLabel(e.Row.Cells["itemname"].Value.ToString(), e.Row.Cells["batchno"].Value.ToString(),
                  e.Row.Cells["expiry"].Value.ToString(), e.Row.Cells["barcodeno"].Value.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                pm_PurchaseQueries p = new pm_PurchaseQueries();
                p.unit_id = GlobalUsage.Unit_id; p.Purchase_id = txtpurchaseID.Text; p.logic = "BarCodeInfo"; p.prm_1 ="-"; p.prm_2 = "-";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/purchase/PurchaseQueries", p);
                rgvInfo.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void ProductLabel(string prdName,string batchNo,string expiry,string barcodeNo)
        {
            GenerateQRCode obj = new GenerateQRCode();
            mkeyText = barcodeNo;
            ItemNameText = prdName;
            BatchText = "Batch:"+ batchNo+", Exp:"+ expiry;
           
            PrintDocument printDoc = new PrintDocument();
   
            printDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDoc.Print();

        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            foreach(GridViewRowInfo row in rgvInfo.Rows)
            {
                ProductLabel(row.Cells["itemname"].Value.ToString(), row.Cells["batchno"].Value.ToString(),
                    row.Cells["expiry"].Value.ToString(), row.Cells["barcodeno"].Value.ToString());
            }
        }
    }//
}
