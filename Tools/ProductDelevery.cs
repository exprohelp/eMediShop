using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;

namespace eMediShop.Tools
{
    public partial class ProductDelevery : Telerik.WinControls.UI.RadForm
    {
        string _jsonString = string.Empty;DataSet _ds = new DataSet();string _saleInvNo = string.Empty;
        DataSet _ds1 = new DataSet();
        public ProductDelevery()
        {
            InitializeComponent();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker helperBW = sender as BackgroundWorker;
                int arg = (int)e.Argument;
                e.Result = BackgroundProcessLogicMethod(helperBW, arg);
                if (helperBW.CancellationPending)
                {
                    e.Cancel = true;
                }
              }
            catch (Exception ex) { }
        }
        private int BackgroundProcessLogicMethod(BackgroundWorker bw, int a)
        {
            int result = 0;
            Thread.Sleep(20000);
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "RFD"; p.dtFrom = DateTime.Today.ToString("yyyy/MM/dd");
            p.dtTo = DateTime.Today.ToString("yyyy/MM/dd");
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/tokenqueries", p);
            _ds1 = dwr.result;
            return result;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rgv_tokenInfo.DataSource = _ds1.Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            if (!backgroundWorker1.IsBusy) //&& GlobalUsage.NetStatus
            {
                timer1.Stop();
                backgroundWorker1.RunWorkerAsync(2000);

                timer1.Start();
            }
            else
            {
                timer1.Start();
               
            }

        }

        private void ProductDelevery_Load(object sender, EventArgs e)
        {
            GlobalUsage.ViewStatus = "No";timer1.Start();
          }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (GlobalUsage.Dispatch_Rights == "Y")
                {
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "token_info:dispatch"; p.prm_1 = GlobalUsage.Login_Name; p.tran_id = _saleInvNo;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    rgv_detail.DataSource = new string[] { };
                    if(dwr.message.Contains("Success"))
                    rgv_tokenInfo.CurrentRow.Delete();
                }
                else { RadMessageBox.Show("Checking Not Allowed.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_tokenInfo_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _saleInvNo = e.Row.Cells["sale_inv_no"].Value.ToString();
                pm_BillInfo p = new pm_BillInfo();
                p.unit_id = GlobalUsage.Unit_id; p.Bill_No = _saleInvNo; p.login_id = GlobalUsage.Login_id;
                p.login_name = GlobalUsage.Login_Name;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/billInformation", p);

                _ds = dwr.result;
                rgv_detail.DataSource = _ds.Tables[1];
                lblTotal.Text = "Total No. : " + _ds.Tables[1].Rows.Count.ToString();
            }
             catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rtb_receive_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Return && rtb_receive.Text.Length>3)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p = new cm1();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.Logic = "token_info:updateBySaleInvNo"; p.prm_1 = GlobalUsage.Login_Name; p.tran_id = _saleInvNo;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p);
                    if (dwr.message.Contains("Success"))
                    {
                        rgv_detail.DataSource = new string[] { };
                        rtb_receive.Text = ""; rtb_receive.Focus();
                    }
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }
    }
}
