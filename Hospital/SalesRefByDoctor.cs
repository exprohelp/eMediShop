using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Hospital
{
    public partial class SalesRefByDoctor : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        DataSet _ds = new DataSet();
        public SalesRefByDoctor()
        {
            InitializeComponent();
        }

        private void SalesRefByDoctor_Load(object sender, EventArgs e)
        {
            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today;
        }

        private void dtFrom_Leave(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report();
        }
        private void Report()
        {
            StringBuilder sb = new StringBuilder();
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "SalesData";p.prm_1 = dtFrom.Value.ToString("yyyyMMdd");p.prm_2 = dtTo.Value.ToString("yyyyMMdd");
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/PrescribedByQueries", p);

            _ds = dwr.result;
            radGridView1.DataSource = _ds.Tables[0];

            string date = "Date From " + dtFrom.Value.ToString("dd-MM-yyyy") + " To " + dtTo.Value.ToString("dd-MM-yyyy");
            sb.Append("<html><body>");
            sb.Append("<span style='text-align:center;width:100%;font-size:14px;background-color:lightgray'>Sales Report of Doctor<br/>" + date + "</span>");
            sb.Append("<table style='width:100%;border-collapse:collapse;' border='1' cellpadding='0' bordercolor='black' >");
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<th style='width:15%;font-size:12px;text-align:left'><b style='color:Maroon'>Name of Doctor</th>");
            sb.Append("<th style='width:20%;font-size:12px;text-align:left'><b style='color:Maroon'>Name of Prodcut</th>");
            sb.Append("<th style='width:10%;font-size:12px;text-align:left'><b style='color:Maroon'>Marketed By</th>");
            sb.Append("<th style='width:32%;font-size:12px;text-align:left'><b style='color:Maroon'>Salt Information</th>");
            sb.Append("<th style='width:11%;font-size:12px;text-align:right'><b style='color:Maroon'>NoS</th>");
            sb.Append("<th style='width:12%;font-size:12px;text-align:right'><b style='color:Maroon'>Amount</th>");
            sb.Append("</tr>");

            decimal t_amount = 0;
            decimal p_amount = 0;
            string temp = string.Empty;
            int count = 0;
            foreach (DataRow dr in _ds.Tables[0].Rows)
            {
                if (temp != dr["ref_name"].ToString())
                {
                    if (count > 0)
                    {
                        sb.Append("<tr style='background-color:lightgray'>");
                        sb.Append("<td style='width:15%;font-size:12px;text-align:left'></td>");
                        sb.Append("<td style='width:20%;font-size:12px;text-align:left'></td>");
                        sb.Append("<td style='width:10%;font-size:12px;text-align:right'>Summary</td>");
                        sb.Append("<td style='width:32%;font-size:12px;text-align:right'>&nbsp;</td>");
                        sb.Append("<td style='width:11%;font-size:12px;text-align:right'>&nbsp;</td>");
                        sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + p_amount.ToString("0") + "&nbsp;</td>");
                        sb.Append("</tr>");
                    }

                    sb.Append("<tr style='background-color:lightgray'>");
                    sb.Append("<td style='width:100%;font-size:12px;text-align:left' colspan='6'>" + dr["ref_name"].ToString() + "</td>");
                    sb.Append("</tr>");
                    temp = dr["ref_name"].ToString();
                    p_amount = 0;
                }
                sb.Append("<tr>");
                sb.Append("<td style='width:15%;font-size:12px;text-align:left'>" + dr["ref_name"].ToString() + "</td>");
                sb.Append("<td style='width:20%;font-size:12px;text-align:left'>" + dr["item_name"].ToString() + "</td>");
                sb.Append("<td style='width:10%;font-size:12px;text-align:left'>" + dr["mfd_name"].ToString() + "</td>");
                sb.Append("<td style='width:32%;font-size:12px;text-align:left'>" + dr["salt_info"].ToString() + "&nbsp;</td>");
                sb.Append("<td style='width:11%;font-size:12px;text-align:right'>" + Convert.ToDecimal(dr["NoS"]).ToString("0") + "&nbsp;</td>");
                sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + Convert.ToDecimal(dr["Amount"]).ToString("0") + "&nbsp;</td>");
                sb.Append("</tr>");

                p_amount += Convert.ToDecimal(dr["amount"]);

                t_amount += Convert.ToDecimal(dr["amount"]);

                count++;
            }
            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<td style='width:15%;font-size:12px;text-align:left'></td>");
            sb.Append("<td style='width:20%;font-size:12px;text-align:left'></td>");
            sb.Append("<td style='width:10%;font-size:12px;text-align:right'>Summary</td>");
            sb.Append("<td style='width:32%;font-size:12px;text-align:right'>&nbsp;</td>");
            sb.Append("<td style='width:11%;font-size:12px;text-align:right'>&nbsp;</td>");
            sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + p_amount.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");

            sb.Append("<tr style='background-color:lightgray'>");
            sb.Append("<td style='width:15%;font-size:12px;text-align:left'></td>");
            sb.Append("<td style='width:20%;font-size:12px;text-align:left'></td>");
            sb.Append("<td style='width:10%;font-size:12px;text-align:right'>Summary</td>");
            sb.Append("<td style='width:32%;font-size:12px;text-align:right'>&nbsp;</td>");
            sb.Append("<td style='width:11%;font-size:12px;text-align:right'>&nbsp;</td>");
            sb.Append("<td style='width:12%;font-size:12px;text-align:right'>" + t_amount.ToString("0") + "&nbsp;</td>");
            sb.Append("</tr>");
            sb.Append("</table>");
            sb.Append("</body></html>");
            webBrowser1.DocumentText = sb.ToString();

        }

        private void btnXl_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ExcelGenerator exporter = new ExcelGenerator();
                byte[] data = exporter.GetExcelFile(_ds);
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                string file_path = fbd.SelectedPath + "\\SaleByDoctor.xlsx";
                System.IO.File.WriteAllBytes(file_path, data);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }
    }
}
