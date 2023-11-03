using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class uploadexcel : Telerik.WinControls.UI.RadForm
    {
        private string Excel03Con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07Con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public uploadexcel()
        {
            InitializeComponent();
        }

        private void uploadexcel_Load(object sender, EventArgs e)
        {
            lblfilename.Text = "";
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                lblfilename.Text = openFileDialog1.SafeFileName;
                string filePath = openFileDialog1.FileName;
                string extension = Path.GetExtension(filePath);
                string header = "YES";
                string conStr, sheetName;
                conStr = string.Empty;
                switch (extension)
                {
                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03Con, filePath, header);
                        break;
                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07Con, filePath, header);
                        break;
                }
                //Get the name of the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcel = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcel.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }

                using (OleDbConnection cn = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = cn;
                            cn.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            cn.Close();

                            rdgrid.DataSource = dt;
                        }
                    }
                }

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message.ToString());
           }
        }
    }
}
