using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eMediShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //BillPosting b = new BillPosting();
            //b.sale_inv_no = "estimate no";
            //b.card_no = "CardNo";b.customer_name = "Vijay Singh";b.ipopNo = "ipopno";b.panelName = "Cash";
            //b.panelType = "Cash";b.prescribedBy = "Dr. Manmeet";b.uhidNo = "UHID";
            //Application.Run(new sales.SaleBill_Posting(b));
           Application.Run(new mainMenu());
           
        }
    }
}