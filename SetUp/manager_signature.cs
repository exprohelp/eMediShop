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

namespace eMediShop.SetUp
{
    public partial class manager_signature : Telerik.WinControls.UI.RadForm
    {
        string _report_name = string.Empty;
        private bool _selecting;
        private System.Drawing.Rectangle _selection;
        string _result = string.Empty;
        string _unitid = string.Empty;
        string _EMP_CODE = string.Empty;

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
                GetSignatureList();
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.Logic = "AllUnit"; p.unit_id = GlobalUsage.Unit_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/units/UnitInfoQueries", p);
                dgShop.DataSource = dwr.result.Tables[0] ;
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
            _unitid = dgShop.CurrentRow.Cells["unit_id"].Value.ToString();
            lblUnitName.Text = dgShop.CurrentRow.Cells["sh_name"].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                _EMP_CODE = ddlManager.SelectedValue.ToString();
                Cursor.Current = Cursors.WaitCursor;
                if (_unitid.Length > 2 && _EMP_CODE.Length > 0)
                {
                    byte[] img = imageToByteArray(pic_sign.Image);
                    pm_Authentication p = new pm_Authentication();
                    p.unit_id = _unitid;p.emp_code = _EMP_CODE;p.sign_image = img;p.logic = "Insert";p.Login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/Insert_Modify_manager_signature", p);
                    DataSet ds = dwr.result;
                    MessageBox.Show(_result);
                    if (dwr.message.Contains("Success"))
                    {
                        GetSignatureList();
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
                p.logic = "SignatureList";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/StaffManagement", p);
                dgSignList.DataSource = dwr.result.Tables[0];
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
                p.unit_id = GlobalUsage.Unit_id; p.prm_1 = txtSearch.Text;p.Logic = "SearchStaff";
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
