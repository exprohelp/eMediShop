using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.forms.Training
{
    public partial class TrainingInfo : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        string _traningid = string.Empty;
        int rating = 0;
        public TrainingInfo()
        {
            InitializeComponent();
        }

        private void TrainingInfo_Load(object sender, EventArgs e)
        {
            try
            {
                Rectangle rec = Screen.PrimaryScreen.WorkingArea;
                int size = (rec.Size.Width - this.Width) / 2;
                this.Location = new System.Drawing.Point(size, 160); 

                Cursor.Current = Cursors.WaitCursor;
                rating = 0;
                DataSet ds = GlobalUsage.accounts_proxy.Training_Queries(out _result, GlobalUsage.Unit_id, Application.ProductName, "", "", "1900/01/01", "1900/01/01", "OpenTraining");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txtNewVersion.Text = ds.Tables[0].Rows[0]["app_version"].ToString();
                    txtCurrentVer.Text = Application.ProductVersion;
                    txtDATE.Text = Convert.ToDateTime(ds.Tables[0].Rows[0]["cr_date"]).ToString("dd-MM-yyyy hh:mm tt");
                    txt_trPoint.Text = ds.Tables[0].Rows[0]["training_point"].ToString();
                    _traningid = ds.Tables[0].Rows[0]["trainingid"].ToString();
                }
                if (ds.Tables.Count > 0 && ds.Tables[1].Rows.Count > 0)
                {
                    txtRemark.Text = ds.Tables[1].Rows[0]["remark"].ToString();
                    rating = Convert.ToInt32(ds.Tables[1].Rows[0]["rating"]);
                }
          
                ddlTrainedBy.Items.AddRange(Config.FillTelrikCombo(ds.Tables[2]));
                ddlTrainedBy.SelectedIndex = 0;

                ucRating obj = new ucRating(rating);
                obj.RateUpdated += new RatingEventHandler(MarkRating);
                PnlRate.Controls.Add(obj);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void MarkRating(object sender, RatingEventArgs e)
        {
            txtrate.Text = e.Rating.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GlobalUsage.accounts_proxy.Insert_Modify_TrainingInfo(out _result, _traningid, GlobalUsage.Unit_id, ddlTrainedBy.SelectedValue.ToString(), GlobalUsage.Login_id, txtRemark.Text, "Y",Convert.ToInt32(txtrate.Text),"Insert");
                MessageBox.Show(_result);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
