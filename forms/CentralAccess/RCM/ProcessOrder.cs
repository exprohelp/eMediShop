using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.CentralAccess.RCM
{
    public partial class ProcessOrder : Telerik.WinControls.UI.RadForm
    {
        public ProcessOrder()
        {
            InitializeComponent();
        }

        private void ProcessOrder_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                eMediShop.forms.CentralAccess.RCM.ucProcessOrder obj = new eMediShop.forms.CentralAccess.RCM.ucProcessOrder();
                panel1.Controls.Add(obj);
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
