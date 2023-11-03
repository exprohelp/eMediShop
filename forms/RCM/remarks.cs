using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace eMediShop.forms.RCM
{
    public partial class remarks : RadForm
    {
        string _CardNo = "";
        string _result = "";
        public remarks(string cardno)
        {
            _CardNo = cardno;
            InitializeComponent();
        }

        private void remarks_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = GlobalUsage.pharmacy_proxy.CallingCard_queries(out _result, GlobalUsage.Unit_id, GlobalUsage.Login_id,"CallLogByLogin",_CardNo,"N/A","N/A");
                dgCALL.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

    }
}
