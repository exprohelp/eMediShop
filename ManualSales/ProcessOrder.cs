using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.ManualSales
{
    public partial class ProcessManualBills : Telerik.WinControls.UI.RadForm
    {
        public ProcessManualBills()
        {
            InitializeComponent();
        }

        private void ProcessOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                eMediShop.ManualSales.ucManualSalesProcess obj = new ucManualSalesProcess();
                panel1.Controls.Add(obj);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
