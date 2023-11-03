using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
    public partial class masterContainer : Telerik.WinControls.UI.RadForm
    {
        UserControl _ucView; string _FormHeading = string.Empty;
        public masterContainer(UserControl uc,string FormHeading)
        {
            _ucView = uc; _FormHeading = FormHeading;
            InitializeComponent();
        }

        private void masterContainer_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;

            this.Size = new System.Drawing.Size(_ucView.Width + 15, _ucView.Height + 30);
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            
            this.Text = _FormHeading;
            dispPanel.Controls.Clear();
            Cursor.Current = Cursors.WaitCursor;
            dispPanel.Controls.Add(_ucView);
            Cursor.Current = Cursors.Default;

        }
    }
}
