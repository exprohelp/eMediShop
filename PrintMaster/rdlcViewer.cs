using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMediShop.PrintMaster
{
    public partial class rdlcViewer : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();string _title = string.Empty;string _rdlcpathWithFileName = string.Empty; string _logic = string.Empty;
        public rdlcViewer(DataSet ds,string title,string rdlcpathWithFileName,string logic)
        {
            _ds = ds;_title = title; _rdlcpathWithFileName = rdlcpathWithFileName;_logic = logic;
            this.Text = _title;
            InitializeComponent();
        }

        private void rdlcViewer_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.Refresh();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = _rdlcpathWithFileName;

            if (_logic == "Credit Note")
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("CreditNote", _ds.Tables[0]));
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _ds.Tables[1]));
            }
            else if (_logic == "EstimateFeeding")
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("est_info", _ds.Tables[0]));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("transfer_id", _title));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("unit_name", GlobalUsage.UnitName));
                reportViewer1.LocalReport.SetParameters(new ReportParameter("address", GlobalUsage.UnitAddress));
            }
            else if (_logic == "Trf_Internal_Sheet")
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("trf_headers", _ds.Tables[0]));
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("trf_items", _ds.Tables[1]));
            }
            else if (_logic == "TransferPaper")
            {
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("trf_headers", _ds.Tables[0]));
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("trf_items", _ds.Tables[1]));
            }
            

            reportViewer1.RefreshReport();
        }
    }
}
