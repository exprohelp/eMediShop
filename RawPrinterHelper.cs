using System;
using System.IO;
using System.Runtime.InteropServices;


namespace eMediShop
{

    public class RawPrinterHelper
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public class DOCINFOA
        {
            public string pDocName;
            public string pOutputFile;
            public string pDataType;
        }

        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool OpenPrinter(string pPrinterName, out IntPtr phPrinter, IntPtr pDefault);

        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, int Level, [In] DOCINFOA pDocInfo);

        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.drv", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);



        public static bool SendBytesToPrinter(string printerName, byte[] bytes)
        {
            IntPtr hPrinter = IntPtr.Zero;
            bool success = false;

            DOCINFOA docInfo = new DOCINFOA
            {
                pDocName = "PRN File Print Job",
                pDataType = "RAW"
            };

            try
            {
                // Open the printer
                if (!OpenPrinter(printerName, out hPrinter, IntPtr.Zero))
                {
                    throw new Exception($"Unable to open printer: {printerName}");
                }

                // Start document
                if (!StartDocPrinter(hPrinter, 1, docInfo))
                {
                    throw new Exception("StartDocPrinter failed.");
                }

                // Start page
                if (!StartPagePrinter(hPrinter))
                {
                    throw new Exception("StartPagePrinter failed.");
                }

                // Write bytes to the printer
                IntPtr unmanagedBytes = Marshal.AllocHGlobal(bytes.Length);
                Marshal.Copy(bytes, 0, unmanagedBytes, bytes.Length);

                if (!WritePrinter(hPrinter, unmanagedBytes, bytes.Length, out int bytesWritten))
                {
                    Marshal.FreeHGlobal(unmanagedBytes);
                    throw new Exception("WritePrinter failed.");
                }

                Marshal.FreeHGlobal(unmanagedBytes);

                // End page and document
                EndPagePrinter(hPrinter);
                EndDocPrinter(hPrinter);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the printer
                if (hPrinter != IntPtr.Zero)
                {
                    ClosePrinter(hPrinter);
                }
            }

            return success;
        }
    }
}