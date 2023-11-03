using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace eMediShop.SetUp
{
    public partial class ucManagerSignature : UserControl
    {
        string _result = string.Empty;
        byte[] image;
        public ucManagerSignature()
        {
            InitializeComponent();
        }

        private void ucManagerSignature_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\managerSign.jpg"))
            {
                Image img = Image.FromFile(Application.StartupPath + "\\managerSign.jpg");
                byte[] bArr = imgToByteArray(img);
                pm_Authentication p = new pm_Authentication();
                p.unit_id = GlobalUsage.Unit_id; p.emp_code = "N/A"; p.sign_image = bArr; p.Login_id = GlobalUsage.Login_id;
                p.logic = "Select";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/Insert_Modify_manager_signature", p);
                DataTable table = dwr.result.Tables[0];
                if (table.Rows.Count > 0)
                {
                    byte[] imgData= Convert.FromBase64String(table.Rows[0]["sign_IMAGE"].ToString());
                    //    pic_sign.Image = System.Drawing.Image.FromStream(new MemoryStream(((byte[])table.Rows[0]["sign_IMAGE"])));
                    pic_sign.Image = System.Drawing.Image.FromStream(new MemoryStream(imgData));
                }
            }
        }
        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
        private void btnImportSignature_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                object o = new object();
                string qry = "execUTE Insert_Modify_manager_signature '"+GlobalUsage.Unit_id+"','"+GlobalUsage.Login_id+"',null,'"+GlobalUsage.Login_id+"','ImportSignature','-'";
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/utility/GetQueryResult?qry=" + qry, o);
                DataSet ds = dwr1.result;
                //DataSet ds = GlobalUsage.pharmacy_proxy.SelectQueries(out _result, GlobalUsage.Unit_id, "UnitSignatureList", "-", "-", "-", GlobalUsage.Login_id);
                byte[] imgBytes = Convert.FromBase64String(ds.Tables[0].Rows[0]["sign_IMAGE"].ToString());
                //pm_Authentication p = new pm_Authentication();
                //p.unit_id = GlobalUsage.Unit_id;
                //p.emp_code = ds.Tables[0].Rows[0]["manager_code"].ToString();
                //byte[] imgBytes = Convert.FromBase64String(ds.Tables[0].Rows[0]["sign_IMAGE"].ToString());
                //p.sign_image = imgBytes; p.Login_id = GlobalUsage.Login_id;
                //p.logic = "Insert";
                //datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/Insert_Modify_manager_signature", p);

                pic_sign.Image = System.Drawing.Image.FromStream(new MemoryStream(imgBytes));
                System.IO.File.WriteAllBytes(Application.StartupPath + "\\managerSign.jpg", imgBytes);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
