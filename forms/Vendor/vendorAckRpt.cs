using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;

namespace eMediShop
{
    public partial class vendorAckRpt : Form
    {
        CrystalReportsPharmacy.Reports.vendorAckRept rpt = new CrystalReportsPharmacy.Reports.vendorAckRept();
         string vendorCode = "";
         public vendorAckRpt(string vCode)
        {
            InitializeComponent();
            vendorCode = vCode;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void vendorAckRpt_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
            // crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                DataSet ds = new DataSet();
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "Info:ForAckletter"; p.login_id = GlobalUsage.Login_id;
                p.prm_1 = vendorCode;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/vendor/VendorQueries", p);
                ds = dwr.result;
                ParameterFields pFeilds = new ParameterFields();
                ParameterField pUnit = new ParameterField();
                ParameterDiscreteValue disUnit = new ParameterDiscreteValue();
                pUnit.ParameterFieldName = "VendorName";
                disUnit.Value = ds.Tables[0].Rows[0]["Vendor_Name"].ToString();
                pUnit.CurrentValues.Add(disUnit);
                pFeilds.Add(pUnit);

                ParameterField pAdress = new ParameterField();
                ParameterDiscreteValue disAdress = new ParameterDiscreteValue();
                pAdress.ParameterFieldName = "Address";
                disAdress.Value = ds.Tables[0].Rows[0]["address1"].ToString();
                pAdress.CurrentValues.Add(disAdress);
                pFeilds.Add(pAdress);

                ParameterField pPhone = new ParameterField();
                ParameterDiscreteValue disPhone = new ParameterDiscreteValue();
                pPhone.ParameterFieldName = "Phone";
                disPhone.Value = ds.Tables[0].Rows[0]["Phone"].ToString();
                pPhone.CurrentValues.Add(disPhone);
                pFeilds.Add(pPhone);

                ParameterField pShName = new ParameterField();
                ParameterDiscreteValue disShName = new ParameterDiscreteValue();
                pShName.ParameterFieldName = "shopName";
                disShName.Value = ds.Tables[1].Rows[0]["nameasonlic"].ToString();
                pShName.CurrentValues.Add(disShName);
                pFeilds.Add(pShName);

                ParameterField pShAdd = new ParameterField();
                ParameterDiscreteValue disShAdd = new ParameterDiscreteValue();
                pShAdd.ParameterFieldName = "shopAdd";
                disShAdd.Value = ds.Tables[1].Rows[0]["sh_address"].ToString();
                pShAdd.CurrentValues.Add(disShAdd);
                pFeilds.Add(pShAdd);

                ParameterField ptinNo = new ParameterField();
                ParameterDiscreteValue disTinNo = new ParameterDiscreteValue();
                ptinNo.ParameterFieldName = "gstn";
                disTinNo.Value = ds.Tables[1].Rows[0]["gst_no"].ToString();
                ptinNo.CurrentValues.Add(disTinNo);
                pFeilds.Add(ptinNo);

                ParameterField pDlNo = new ParameterField();
                ParameterDiscreteValue disDlNo = new ParameterDiscreteValue();
                pDlNo.ParameterFieldName = "dlNo";
                disDlNo.Value = ds.Tables[1].Rows[0]["dl_no"].ToString();
                pDlNo.CurrentValues.Add(disDlNo);
                pFeilds.Add(pDlNo);

                ParameterField pState = new ParameterField();
                ParameterDiscreteValue disState = new ParameterDiscreteValue();
                pState.ParameterFieldName = "State";
                disState.Value = ds.Tables[1].Rows[0]["state_name"].ToString();
                pState.CurrentValues.Add(disState);
                pFeilds.Add(pState);

                ParameterField pCompany = new ParameterField();
                ParameterDiscreteValue p2Company = new ParameterDiscreteValue();
                pCompany.ParameterFieldName = "Company";
                p2Company.Value = ds.Tables[1].Rows[0]["company"].ToString();

                pState.CurrentValues.Add(p2Company);
                pFeilds.Add(pCompany);

                // rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                //rpt.Data`base.Tables[1].SetDataSource(ds.Tables[1]);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.ParameterFieldInfo = pFeilds;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }
    }
}
