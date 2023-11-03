using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportAppServer;
using System.Data.SqlClient;

namespace eMediShop
{
    public partial class ReportViewer : Form
    {
        ParameterFields paramFields = new ParameterFields();
        public ReportViewer()
        {
            InitializeComponent();
        }
      
        public void setldName(string ldName)
        {

            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue dsValue = new ParameterDiscreteValue();
            paramField.ParameterFieldName = "ldname";
            dsValue.Value = ldName;
            paramField.CurrentValues.Add(dsValue);
            paramFields.Add(paramField);
            crystalReportViewer1.ParameterFieldInfo = paramFields;
        }
        public void setFrDate(string FrDt)
        {
            ParameterField paramField1 = new ParameterField();
            ParameterDiscreteValue dsValue1 = new ParameterDiscreteValue();
            paramField1.ParameterFieldName = "frDate";
            dsValue1.Value = FrDt;
            paramField1.CurrentValues.Add(dsValue1);
            paramFields.Add(paramField1);
            crystalReportViewer1.ParameterFieldInfo = paramFields;
        }
        public void setToDate(string toDt)
        {
            ParameterField paramField2 = new ParameterField();
            ParameterDiscreteValue dsValue2 = new ParameterDiscreteValue();
            paramField2.ParameterFieldName = "Todate";
            dsValue2.Value = toDt;
            paramField2.CurrentValues.Add(dsValue2);
            paramFields.Add(paramField2);
            crystalReportViewer1.ParameterFieldInfo = paramFields;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            setldName(txtLdName.Text);
            setFrDate(txtFrom.Text);
            setToDate(txtTo.Text);
        }
    }
}
