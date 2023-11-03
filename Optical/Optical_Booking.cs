using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace eMediShop.Optical
{
    public partial class Optical_Booking : Telerik.WinControls.UI.RadForm
    {
        Microsoft.Reporting.WinForms.LocalReport report = new Microsoft.Reporting.WinForms.LocalReport();
        string _patientId = string.Empty;
        public Optical_Booking()
        {
            InitializeComponent();
        }

        private void Optical_Booking_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id;p.Logic = "OpticalItems";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/Opthalmic/OpticalQueries", p);
                dgProduct.DataSource = dwr.result.Tables[0];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }

        private void dgProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GridViewRowInfo row =dgItemList.Rows.AddNew();
                row.Cells["item_id"].Value = dgProduct.CurrentRow.Cells["item_id"].Value.ToString();
                row.Cells["item_name"].Value = dgProduct.CurrentRow.Cells["item_name"].Value.ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtPatientName.Text.Length < 2) {
                MessageBox.Show("Enter proper patient name");
                return;
            }
            if (txtMobile.Text.Length!=10)
            {
                MessageBox.Show("Enter proper mobile number");
                return;
            }
            if (Convert.ToInt32(txtNet.Text)<=0)
            {
                MessageBox.Show("Net Amount is mandatory");
                return;
            }
            if (dgItemList.Rows.Count==0)
            {
                MessageBox.Show("Item is not selected");
                return;
            }
            string ItemIdList = string.Empty;
            string ItemNameList = string.Empty;
            foreach (GridViewRowInfo gr in dgItemList.Rows)
            {
                ItemIdList= ItemIdList+ gr.Cells["item_id"].Value.ToString()+",";
                ItemNameList = ItemIdList + gr.Cells["item_name"].Value.ToString() + ",";
            }
            ipOpticalBooking obj = new ipOpticalBooking();
            obj.unit_id = GlobalUsage.Unit_id;
            obj.CustomerId = txtPatientName.Text;
            obj.PatientName = txtPatientName.Text;
            obj.MobileNo = txtMobile.Text;
            obj.Address = txtAddress.Text;
            obj.ItemIdList = ItemIdList;
            obj.ItemNameList = ItemNameList;
            obj.NetAmount =Convert.ToDecimal(txtNet.Text);
            obj.AdvAmount = Convert.ToDecimal(txtAdvance.Text);
            obj.login_id = GlobalUsage.Login_id;
            obj.Logic = "Insert";
            try
            {
                string message=ConfigWebAPI.CallAPIObject("api/Opthalmic/Insert_OpticalBooking",obj);
                ipOpticalResponse ir = JsonConvert.DeserializeObject<ipOpticalResponse>(message);
                if (ir.Message.Contains("Success"))
                {
                    _patientId = ir.CustomerId;
                }
                MessageBox.Show(ir.Message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintSlip();
        }
        public void PrintSlip()
        {
            Cursor.Current = Cursors.WaitCursor;
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "SlipInfo";p.tran_id = _patientId;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/Opthalmic/OpticalQueries", p);

            dgProduct.DataSource = dwr.result.Tables[0];

            report.Refresh();
            report.DataSources.Clear();
            report.ReportPath = @"rdlc\OpticalAdvanceSlip.rdlc";
            report.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dwr.result.Tables[0]));
            report.PrintToPrinter(3.2f, 8.3f, 0.1f, 0.1f, 0.1f, 0.1f); //parameter in Inches 
            Cursor.Current = Cursors.Default;
        }
    }
    public class ipOpticalBooking
    {
        public string unit_id { set; get; }
        public string CustomerId { set; get; }
        public string PatientName { set; get; }
        public string MobileNo { set; get; }
        public string Address { set; get; }
        public string ItemIdList { set; get; }
        public string ItemNameList { set; get; }
        public decimal NetAmount { set; get; }
        public decimal AdvAmount { set; get; }
        public string login_id { set; get; }
        public string Logic { set; get; }
    }
    public class ipOpticalResponse
    {
        public string CustomerId { set; get; }
        public string Message { set; get; }

    }
}
