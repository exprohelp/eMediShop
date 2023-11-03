using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.forms.Audit
{
    public partial class ucBulkChecking : UserControl
    {
        public ucBulkChecking()
        {
            InitializeComponent();
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

            }
            catch (Exception ex) { };
            Cursor.Current = Cursors.WaitCursor;
        }
    }
}
