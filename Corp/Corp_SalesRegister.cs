using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Corp
{
    public partial class Corp_SalesRegister : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        public Corp_SalesRegister()
        {
            InitializeComponent();
            rdpFrom.Value = DateTime.Today;
            rdpTo.Value = DateTime.Today;
        }

        private void Corp_SalesRegister_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
        }

        private void rdpFrom_Leave(object sender, EventArgs e)
        {
            rdpTo.MinDate = rdpFrom.Value;
        }



        private void MasterTemplate_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is Telerik.WinControls.UI.GridSummaryCellElement)
            {
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
            }
        }
    }
}
