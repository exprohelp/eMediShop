using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.GC
{
    public partial class markScheduleH : Telerik.WinControls.UI.RadForm
    {
        public markScheduleH()
        {
            InitializeComponent();
        }

        private void markScheduleH_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }
    }
}
