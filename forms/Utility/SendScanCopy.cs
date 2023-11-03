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
    public partial class SendScanCopy : Form
    {
        string toPerson = "";
        DataSet ds = new DataSet();
        DataSet temp_ds = new DataSet();
        
        string status = "";
        public SendScanCopy()
        {
            InitializeComponent();
        }

        private void SendScanCopy_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160); 
            
            if (File.Exists(Application.StartupPath + "\\Employee.xml"))
            {
                ds.ReadXml(Application.StartupPath + "\\Employee.xml");
                cbxEmpForMessage.ValueMember = "emp_code";
                cbxEmpForMessage.DisplayMember = "emp_name";
                cbxEmpForMessage.DataSource = ds.Tables[0];
                //cbxEmpForMessage.Items.Add("Select ..");
            }
            else
            {
                string path = Application.StartupPath + "\\Employee.xml";
                string xmlTemp = "<?xml version=\"1.0\" standalone=\"yes\"?>";
                        xmlTemp+="<NewDataSet>";
                        xmlTemp+="<Table>";
                        xmlTemp+="<emp_code>CHCL-00227</emp_code>";
                        xmlTemp+="<emp_name>Pankaj Kumar Singh</emp_name>";
                        xmlTemp+="</Table>";
                        xmlTemp+= "</NewDataSet>";
                        File.WriteAllText(path,xmlTemp);
                        ds.ReadXml(path);
                        cbxEmpForMessage.ValueMember = "emp_code";
                        cbxEmpForMessage.DisplayMember = "emp_name";
                        cbxEmpForMessage.DataSource = ds.Tables[0];
            }
            
            
            pictureBox1.Visible = false;
        }
        /// <summary>
        /// Upload any file to the web service; this function may be
        /// used in any application where it is necessary to upload
        /// a file through a web service
        /// </summary>
        /// <param name="filename">Pass the file path to upload</param>
        private void UploadFile(string filename)
        {
            try
            {
                // get the exact file name from the path
                String strFile = System.IO.Path.GetFileName(filename);
                // create an instance fo the web service
               // get the file information form the selected file
                FileInfo fInfo = new FileInfo(filename);
                // get the length of the file to see if it is possible
                // to upload it (with the standard 4 MB limit)
                long numBytes = fInfo.Length;
                double dLen = Convert.ToDouble(fInfo.Length / 1000000);

                // Default limit of 4 MB on web server
                // have to change the web.config to if
                // you want to allow larger uploads
                if (dLen < 4)
                {
                    // set up a file stream and binary reader for the 
                    // selected file
                    FileStream fStream = new FileStream(filename, 
                    FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fStream);

                    // convert the file to a byte array
                    byte[] data = br.ReadBytes((int)numBytes);
                    br.Close();

                    // pass the byte array (file) and file name to the web  service
                    string sTmp =GlobalUsage.pharmacy_proxy.UploadFileInfo(data, strFile, GlobalUsage.Login_id, GlobalUsage.Unit_id,toPerson  , "Pharmacy");
                    fStream.Close();
                    fStream.Dispose();
                    status = "release";
                   
                    // this will always say OK unless an error occurs,
                    // if an error occurs, the service returns the error  message
                    MessageBox.Show("File Upload Status: " + sTmp, "File Upload");
                }
                else
                {
                    // Display message if the file was too large to upload
                    MessageBox.Show("The file selected exceeds the size limit for uploads.", "File Size");
                }
            }
            catch (Exception ex)
            {
                // display an error message to the user
                MessageBox.Show(ex.Message.ToString(), "Upload Error");
                status = "release";
                   
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.FileName = "";

            try
            {
                openFileDialog1.InitialDirectory = GlobalUsage.BillDrive + "\\Temp";
            }
            catch
            {
                // skip it 
            }

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == "")
                return;
            else
                txtFileName.Text = openFileDialog1.FileName;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            timer1.Start();
            status = "wait";
            backgroundWorker1.RunWorkerAsync();               
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (status == "wait")
            {
                this.ControlBox = false;
                pictureBox1.Visible = true;
                btnUpload.Enabled = false;
                pictureBox1.Visible = true;

            }
            else
            {
                this.ControlBox = true;
                pictureBox1.Visible = false;
                timer1.Stop();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UploadFile(txtFileName.Text);
        }

        private void SendScanCopy_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            temp_ds = new DataSet();
            temp_ds =GlobalUsage.pharmacy_proxy.SearchStaff(txtkey.Text,"CHCL");
            cbxSearched.ValueMember = "emp_code";
            cbxSearched.DisplayMember = "emp_name";
            cbxSearched.DataSource = temp_ds.Tables[0];
            temp_ds.Dispose();
            groupBox1.Visible = true;
           
            Cursor.Current = Cursors.Default;
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

        private void chkSendMessage_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkSendMessage.Checked)
            //    groupBox2.Visible = true;
            //else
            //    groupBox2.Visible = false;
        }

        private void cbxEmpForMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            toPerson = cbxEmpForMessage.SelectedValue.ToString();
        }

    }
}
