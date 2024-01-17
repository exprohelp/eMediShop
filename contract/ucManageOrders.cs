using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.contract
{
    public partial class ucManageOrders : UserControl
    {
        string _orderNo = string.Empty;
        public ucManageOrders()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd");
                p.prm_2 = "";
                p.Logic = "Get:AllOrders";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);
           
                rgvOrderHeaders.DataSource = dwr.result.Tables[0];
                
            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgvOrderHeaders_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           

                if (e.Column.Name== "tg")
                {
                    try
                    {
                        _orderNo = e.Row.Cells["orderno"].Value.ToString();
                        rgvItems.Text = "SNO.:" + e.Row.Cells["srno"].Value.ToString() + ", PBNO.: " + e.Row.Cells["pbno"].Value.ToString() + ", Name: " + e.Row.Cells["ptname"].Value.ToString();

                        cm2 p = new cm2();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                        p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd"); 
                        p.prm_2 = "toggle"; p.prm_3 = _orderNo;
                        p.Logic = "Get:AllOrders";
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);

                        rgvOrderHeaders.DataSource = dwr.result.Tables[0];

                    }
                    catch (Exception ex)
                    {
                        RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                    finally { Cursor.Current = Cursors.Default; }
                }
                else if (e.Column.Name == "click")
                {
                    try
                    {
                        _orderNo = e.Row.Cells["orderno"].Value.ToString();
                        rgvItems.Text = "SNO.:" + e.Row.Cells["srno"].Value.ToString() + ", PBNO.: " + e.Row.Cells["pbno"].Value.ToString() + ", Name: " + e.Row.Cells["ptname"].Value.ToString();

                        cm2 p = new cm2();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                        p.prm_1 = _orderNo;
                        p.prm_2 = "";
                        p.Logic = "Load:ItemsOfOrder";
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);

                        rgvLineItems.DataSource = dwr.result.Tables[0];

                    }
                    catch (Exception ex)
                    {
                        RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
                    }
                    finally { Cursor.Current = Cursors.Default; }
                }


        }

        private void rgvOrderHeaders_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["isactive"].Value.ToString() == "Y")
            { e.RowElement.ForeColor = Color.Black; }
            else
            { e.RowElement.ForeColor = Color.Red; }
        }

        private void MasterTemplate_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["isactive"].Value.ToString() == "Y")
            { e.RowElement.ForeColor = Color.Black; }
            else
            { e.RowElement.ForeColor = Color.Red; }
        }

        private void rgvOrderHeaders_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            //if (e.CellElement is GridCommandCellElement)
            //{
            //    if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "tg")
            //    {
            //        try
            //        {
            //            _orderNo = e.Row.Cells["orderno"].Value.ToString();
            //            rgvItems.Text = "SNO.:" + e.Row.Cells["srno"].Value.ToString() + ", PBNO.: " + e.Row.Cells["pbno"].Value.ToString() + ", Name: " + e.Row.Cells["ptname"].Value.ToString();
                        
            //            cm2 p = new cm2();
            //            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            //            p.prm_1 = rdtpFrom.Value.ToString("yyyy-MM-dd"); ;
            //            p.prm_2 = "toggle";p.prm_3 = _orderNo;
            //            p.Logic = "Load:ItemsOfOrder";
            //            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);

            //            rgvOrderHeaders.DataSource = dwr.result.Tables[0];

            //        }
            //        catch (Exception ex)
            //        {
            //            RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            //        }
            //        finally { Cursor.Current = Cursors.Default; }
            //    }
            //    else if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "click")
            //    {
            //        try
            //        {
            //            _orderNo = e.Row.Cells["orderno"].Value.ToString();
            //            rgvItems.Text = "SNO.:" + e.Row.Cells["srno"].Value.ToString() + ", PBNO.: " + e.Row.Cells["pbno"].Value.ToString() + ", Name: " + e.Row.Cells["ptname"].Value.ToString();

            //            cm2 p = new cm2();
            //            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            //            p.prm_1 = _orderNo;
            //            p.prm_2 = "";
            //            p.Logic = "Load:ItemsOfOrder";
            //            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);

            //            rgvOrderHeaders.DataSource = dwr.result.Tables[0];

            //        }
            //        catch (Exception ex)
            //        {
            //            RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            //        }
            //        finally { Cursor.Current = Cursors.Default; }
            //    }

            //}
        }

        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = _orderNo;
                p.prm_2 = "toggle";p.prm_3 = e.Row.Cells["itemid"].Value.ToString();
                p.Logic = "Load:ItemsOfOrder";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hal/halQueries", p);

                rgvLineItems.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
