using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.Audit
{
    public partial class AuditMaster : Telerik.WinControls.UI.RadForm
    {
        string _HeadId = string.Empty;
        string _AuditId = string.Empty;
        public AuditMaster()
        {
            InitializeComponent();
        }
        private void FillQuestion()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                panel2.Controls.Clear();
                object o = new object();
                string qry = "execute Assets_data.dbo.pQuestPDFReport 'QInfo'," + _HeadId + ",'" + GlobalUsage.Unit_id + "','" + _AuditId + "' ";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/utility/GetQueryResult?qry=" + qry, o);
                DataSet _ds = dwr.result;
               
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    int y = 2;
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        AuditQuestAnswer QA = new AuditQuestAnswer(_HeadId, _AuditId);
                        QA.QNO = dr["QNo"].ToString();
                        QA.QStatus = dr["status_flag"].ToString();
                        QA.QInfo = dr["QInfo"].ToString();
                        QA.Location = new System.Drawing.Point(2, y);
                        QA.QAans = dr["audit_remark"].ToString();
                        QA.Rating = Convert.ToInt32(dr["rating"]);
                        QA.MaxRate = Convert.ToInt32(dr["max_rate"]);
                        panel2.Controls.Add(QA);
                        y = y + 98;
                    }
                }
                else { MessageBox.Show("Record Not Exists"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }
        private void AuditMaster_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 125);
            try
            {
                object o = new object();
                string qry = "execute Assets_data.dbo.pQuestPDFReport 'FillHeads',0,'" + GlobalUsage.Unit_id + "','" + _AuditId + "'";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/utility/GetQueryResult?qry=" + qry, o);
                DataSet _ds = dwr.result;
                if (_ds.Tables.Count > 0)
                {
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        cbxHead.SelectedIndexChanged -= new EventHandler(cbxHead_SelectedIndexChanged);
                        cbxHead.Items.Clear();
                        cbxHead.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
                        cbxHead.SelectedIndex = 0;
                        cbxHead.SelectedIndexChanged += new EventHandler(cbxHead_SelectedIndexChanged);
                    }

                    if (_ds.Tables[1].Rows.Count > 0)
                    {
                        cbxAudit.SelectedIndexChanged -= new EventHandler(cbxAudit_SelectedIndexChanged);
                        cbxAudit.Items.Clear();
                        cbxAudit.Items.AddRange(Config.FillCombo(_ds.Tables[1]));
                        cbxAudit.SelectedIndex = 0;
                        cbxAudit.SelectedIndexChanged += new EventHandler(cbxAudit_SelectedIndexChanged);
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }
        private void cbxHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            _HeadId = ((AddValue)cbxHead.SelectedItem).Value;
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (((AddValue)cbxAudit.SelectedItem).Value != "Select")
                FillQuestion();
            else
                MessageBox.Show("Please Select Audit Id");
        }
        private void cbxAudit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _AuditId = ((AddValue)cbxAudit.SelectedItem).Value;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            object o = new object();
            string qry = "execute asset_data.dbo.pQuestPDFReport 'LockAudit',0,'" + GlobalUsage.Unit_id + "','" + _AuditId + "' ";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/utility/GetQueryResult?qry=" + qry, o);
            DataSet _ds = dwr.result;
            Cursor.Current = Cursors.Default;
        }
        private void lnkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string _result = "";
            Cursor.Current = Cursors.WaitCursor;
            byte[] data = GlobalUsage.pharmacy_proxy.GetAuditReport(GlobalUsage.Unit_id, out _result);
            Cursor.Current = Cursors.Default;
            if (data.Length > 0)
            {
                FolderBrowserDialog Fbd = new FolderBrowserDialog();
                Fbd.ShowDialog();
                string path = Fbd.SelectedPath + "\\" + "AuditReport.pdf";
                System.IO.File.WriteAllBytes(path, data);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string _result = "";
            Cursor.Current = Cursors.WaitCursor;
            byte[] data = GlobalUsage.pharmacy_proxy.GetAuditReportByAuditId(cbxAudit.Text, GlobalUsage.Unit_id, out _result);
            Cursor.Current = Cursors.Default;
            if (data.Length > 0)
            {
                FolderBrowserDialog Fbd = new FolderBrowserDialog();
                Fbd.ShowDialog();
                string path = Fbd.SelectedPath + "\\" + "Audit_" + GlobalUsage.Unit_id + cbxAudit.Text + ".pdf";
                System.IO.File.WriteAllBytes(path, data);
            }
        }

    }
}
