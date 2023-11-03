using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace eMediShop
{
    public partial class SearchStaff : Form
    {
        DataSet ds = new DataSet();
        DataSet temp_ds = new DataSet();
        
        public SearchStaff()
        {
            InitializeComponent();
        }

        private void SearchStaff_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Employee.xml"))
            {
                ds.ReadXml(Application.StartupPath + "\\Employee.xml");
                cbxEmpForMessage.ValueMember = "emp_code";
                cbxEmpForMessage.DisplayMember = "emp_name";
                cbxEmpForMessage.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Search Employee");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            temp_ds = new DataSet();
            temp_ds =GlobalUsage.pharmacy_proxy.SearchStaff(txtkey.Text,"CHCL");
            cbxSearched.ValueMember = "emp_code";
            cbxSearched.DisplayMember = "emp_name";
            cbxSearched.DataSource = temp_ds.Tables[0];
            temp_ds.Dispose();
            
        }
        private void btnReffresh_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\Employee.xml";
            foreach (DataRow dr1 in temp_ds.Tables[0].Rows)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["emp_code"] = dr1["emp_code"].ToString();
                dr["emp_name"] = dr1["emp_name"].ToString();
                ds.Tables[0].Rows.Add(dr);
            }
            ds.WriteXml(path);
       }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
       
    }
}
