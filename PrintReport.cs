using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Reflection;
using System.Drawing.Printing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;

namespace eMediShop
{
    public static class PrintReport
    {

        private static int m_currentPageIndex;
        private static IList<Stream> m_streams;

        public static Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void Export(LocalReport report, float widthInch, float heightInch, float marginTopInch, float marginLeftInch, float marginRightInch, float marginBottomInch, bool print = true)
        {
            StringBuilder s = new StringBuilder();
            s.Append("<DeviceInfo>");
            s.Append("<OutputFormat>EMF</OutputFormat>");
            s.Append("<PageWidth>" + widthInch + "in</PageWidth>");
            s.Append("<PageHeight> " + heightInch + "in</PageHeight>");
            s.Append("<MarginTop>" + marginTopInch + "in</MarginTop>");
            s.Append("<MarginLeft>" + marginLeftInch + "in</MarginLeft>");
            s.Append("<MarginRight>" + marginRightInch + "in</MarginRight>");
            s.Append("<MarginBottom>" + marginBottomInch + "in</MarginBottom>");
            s.Append("</DeviceInfo>");

            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", s.ToString(), CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print();
            }
        }


        // Handler for PrintPageEvents
        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }
        public static void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = true;
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
        public static void PrintToPrinter(this LocalReport report, float widthInch, float heightInch, float marginTopInch, float marginLeftInch, float marginRightInch, float marginBottomInch)
        {
            Export(report, widthInch, heightInch, marginTopInch, marginLeftInch, marginRightInch, marginBottomInch);
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
    }
}
