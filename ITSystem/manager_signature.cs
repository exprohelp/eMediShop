using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Newtonsoft.Json;
namespace eMediShop.ITSystem
{
    public partial class manager_signature : Telerik.WinControls.UI.RadForm
    {
        string _report_name = string.Empty;
        private bool _selecting;
        private System.Drawing.Rectangle _selection;
        string _result = string.Empty;
        string _SH_CODE = string.Empty;
        string _EMP_CODE = string.Empty;
        string _jsonString = string.Empty;
        public manager_signature()
        {
            InitializeComponent();
            imageResizer1.WorkComplete += new ImageResizer.WorkCompleteDelegate(imageResizer1_WorkComplete);
        }

        void imageResizer1_WorkComplete(object sender, bool complete)
        {
            if (complete)
            {
                pic_sign.Image = imageResizer1.GetEditedImage();
            }
            //else
            //{
            //    pic_sign.Image = TestApp.Properties.Resources.NoImage;
            //}

            imageResizer1.Reset();
            //imageResizer1.Visible = false;
        }
        private void BlockUnBlock_ForSaleAvg_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            string qry = string.Empty;
            try
            {
                
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "ByLoginID";
                p.prm_1 = "N/A"; p.prm_2 = "N/A"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);
                dgShop.DataSource = dwr.result.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #region Croping Region
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        #endregion
        private void dgShop_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            _SH_CODE = dgShop.CurrentRow.Cells["unit_id"].Value.ToString();
            lblUnitName.Text = dgShop.CurrentRow.Cells["sh_name"].Value.ToString();
            GetSignatureList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                _EMP_CODE = ddlManager.SelectedValue.ToString();
                Cursor.Current = Cursors.WaitCursor;
                if (_SH_CODE.Length > 2 && _EMP_CODE.Length > 0)
                {
                    byte[] img = imageToByteArray(pic_sign.Image);
                    pm_Authentication p = new pm_Authentication();
                    p.unit_id = _SH_CODE;p.manager_code = _EMP_CODE;p.sign_image = img;p.Login_id = GlobalUsage.Login_id;
                    p.logic = "Insert";
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/Insert_Modify_manager_signature", p);

                    MessageBox.Show(dwr.message);
                    if (_result.Contains("Success"))
                    {
                        dgSignList.DataSource = dwr.result.Tables[0];
                    }
                }
                else
                { MessageBox.Show("please select proper information"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void GetSignatureList()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Authentication p = new pm_Authentication();
                p.unit_id = _SH_CODE; p.Login_id = GlobalUsage.Login_id;
                p.logic = "UnitManagerList";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/Insert_Modify_manager_signature", p);
                DataTable dt = new DataTable();
                dt.Columns.Add("auto_id", typeof(string));
                dt.Columns.Add("emp_name", typeof(string));
                dt.Columns.Add("sign_image", typeof(byte[]));
                dt.Columns.Add("sh_name", typeof(string));
                foreach (DataRow dr in dwr.result.Tables[0].Rows)
                {
                    DataRow dr1 = dt.NewRow();
                    dr1["auto_id"] = dr["auto_id"];
                    dr1["emp_name"] = dr["emp_name"];
                    dr1["sign_image"] =Convert.FromBase64String(dr["sign_image"].ToString());
                    dr1["sh_name"] = dr["sh_name"];
                    dt.Rows.Add(dr1);
                }
                dgSignList.DataSource = dt;
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = "SearchStaff";
                p.prm_1 = txtSearch.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hr/HRQueries", p);
                ddlManager.Items.AddRange(Config.FillTelrikCombo(dwr.result.Tables[0]));
                ddlManager.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void dgSignList_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "Delete:ManageSignature"; 
                p.tran_id = dgSignList.CurrentRow.Cells["auto_id"].Value.ToString();
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                GetSignatureList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

    }
}
