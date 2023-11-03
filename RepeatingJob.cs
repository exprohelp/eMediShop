using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace eMediShop
{
    
    public partial class RepeatingJob : UserControl
    {
        string _Detail = "";
        string _Count = "";
        public RepeatingJob()
        {
            InitializeComponent();
        }
        public string Development
        {
            get { return _Detail; }
            set { _Detail = value; }
        }
        public string UpdDate
        {
            get { return _Count; }
            set { _Count = value; }
        }
        private void RepeatingJob_Load_1(object sender, EventArgs e)
        {
            richTextBox1.Refresh();
            richTextBox1.Text = _Detail;
            lblDevelopment.Text = _Count;
            richTextBox1.Refresh();
            lblDevelopment.Refresh();
        }
    }
}
