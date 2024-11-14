using Microsoft.AspNet.SignalR.Client;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.CashCounter
{
    public partial class CashCounter : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty; static IHubProxy _hub;
        DataSet _ds = new DataSet();
        public CashCounter()
        {
            InitializeComponent();
        }

        private void CashCounter_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    var connection = new HubConnection(ConfigWebAPI.SingnalRServer);
            //    _hub = connection.CreateHubProxy("MyHub");
            //    connection.Start().Wait();
            //    _hub.On<string, string>("addMessage", (name, message) =>
            //     this.Invoke((Action)(() => textBox1.Text = message))
            //     );

            //    string line = null;
            //    while ((line = System.Console.ReadLine()) != null)
            //    {
            //        _hub.Invoke("DetermineLength", line).Wait();
            //    }
            //}
            //catch (Exception ex) { }
            //Console.Read();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "PostingCounter"; p.dtFrom = "1900/01/01";
            p.dtTo = "1900/01/01";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/tokenqueries", p);
            _ds = dwr.result;
            fillestimateNumbers();

        }

        private void fillestimateNumbers()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                foreach (DataRow dr in _ds.Tables[0].Rows)
                {
                    var row = rgv_Pending.Rows.AsEnumerable().Where(x => x.Cells["token_no"].Value.ToString() == dr["token_no"].ToString()).ToList();
                    if (row.Count() == 0)
                    {
                        GridViewDataRowInfo rowInfo = new GridViewDataRowInfo(this.rgv_Pending.MasterView);
                        rowInfo.Cells[0].Value = dr["estimate_no"].ToString();
                        rowInfo.Cells[1].Value = dr["token_no"].ToString();
                        rowInfo.Cells[2].Value = dr["pt_name"].ToString();
                        rowInfo.Cells[3].Value = dr["sale_type"].ToString();
                        rowInfo.Cells[4].Value = dr["net"].ToString();
                        rowInfo.Cells[5].Value = dr["hosp_ipop_no"].ToString();
                        rowInfo.Cells["hosp_cr_no"].Value = dr["hosp_cr_no"].ToString();
                        rgv_Pending.Rows.Add(rowInfo);
                    }

                }
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_Pending_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (e.Row.Cells["sale_type"].Value.ToString() == "Walk-In")
                {
                    DisplayTokenNo(e);
                    //openForm(new SaleMaster(e.Row.Cells["estimate_no"].Value.ToString()));
                    eMediShop.sales.SaleMaster obj = new eMediShop.sales.SaleMaster("Cash Counter",e.Row.Cells["estimate_no"].Value.ToString());
                    obj.CashCounterUpdated += new CashCounterEventHandler(Update_CashCounterUpdated);
                    obj.Owner = this;
                    obj.Show();
                }
                else if (e.Row.Cells["sale_type"].Value.ToString() == "BYUHID")
                {
                    DisplayTokenNo(e);
                    SaleMaster_Hospital obj = new SaleMaster_Hospital("Cash Counter", e.Row.Cells["hosp_cr_no"].Value.ToString(), e.Row.Cells["estimate_no"].Value.ToString());
                    obj.CashCounterUpdated += new CashCounterEventHandler(Update_CashCounterUpdated);
                    obj.Owner = this;
                    obj.Show();

                }
                else if (e.Row.Cells["sale_type"].Value.ToString() == "INDENT")
                {
                    DisplayTokenNo(e);
                    ////openForm(new forms.CentralAccess.RCM.IPDOPDProcessInfo(e.Row.Cells["hosp_cr_no"].Value.ToString(), e.Row.Cells["hosp_ipop_no"].Value.ToString()));
                    //forms.CentralAccess.RCM.IPDOPDProcessInfo obj = new forms.CentralAccess.RCM.IPDOPDProcessInfo(e.Row.Cells["hosp_cr_no"].Value.ToString(), e.Row.Cells["hosp_ipop_no"].Value.ToString());
                    //obj.CashCounterUpdated += new CashCounterEventHandler(Update_CashCounterUpdated);
                    //obj.Owner = this;
                    //obj.Show();

                }
                else if (e.Row.Cells["sale_type"].Value.ToString() == "BYUHID" && Convert.ToDecimal(e.Row.Cells["net"].Value) < 0)
                {
                    DisplayTokenNo(e);
                    SaleMaster_Hospital obj = new SaleMaster_Hospital("Cash Counter", e.Row.Cells["hosp_cr_no"].Value.ToString(), e.Row.Cells["estimate_no"].Value.ToString());
                    obj.CashCounterUpdated += new CashCounterEventHandler(Update_CashCounterUpdated);
                    obj.Owner = this;
                    obj.Show();
                }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
        private void Update_CashCounterUpdated(object sender, CashCounterUpdatedEventArgs e)
        {
            if (e.result == "Success")
            {
                var row = rgv_Pending.Rows.AsEnumerable().Where(x => x.Cells["estimate_no"].Value.ToString() == e.SaleInvNo).ToList();
                row.First().Delete();
            }

        }
        private static void DisplayTokenNo(Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i].Name == "DisplayToken")
                {
                    Label form = (Label)((TableLayoutPanel)(Application.OpenForms[i].Controls["tlp_token"])).Controls["lblTokenNo"];
                    form.Text = e.Row.Cells["token_no"].Value.ToString();
                }
            }
        }

        private void openForm(Form UseForm)
        {
            Cursor.Current = Cursors.WaitCursor;
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy) //&& GlobalUsage.NetStatus
            {
                backgroundWorker1.RunWorkerAsync(2000);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fillestimateNumbers();
        }
        private int BackgroundProcessLogicMethod(BackgroundWorker bw, int a)
        {
            int result = 0;
            Thread.Sleep(2000);
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "PostingCounter";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/tokenqueries", p);
            _ds = dwr.result;
            return result;
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

        private void rgv_Pending_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["sale_type"].Value.ToString() == "INDENT")
                e.RowElement.ForeColor = Color.Green;
            else
                e.RowElement.ForeColor = Color.Blue;

        }

        private void rtb_receive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && rtb_receive.Text.Length > 3)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    cm1 p1 = new cm1();
                    p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                    p1.prm_1 = GlobalUsage.Login_Name; p1.prm_2 = GlobalUsage.Login_Name;
                    p1.Logic = "token_info:update"; p1.tran_id = rtb_receive.Text;
                    datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                    rtb_receive.Text = "";
                    btn_refresh.PerformClick();
                    rtb_receive.Focus();
                }
                catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
                finally { Cursor.Current = Cursors.Default; }
            }
        }
    }
}
