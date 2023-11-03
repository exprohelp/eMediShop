using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace eMediShop.GC
{
    public partial class uc_Miscellenious : UserControl
    {
        string _ReportType = "";
        string _UnitId = "";
        string _Result = "";
        public uc_Miscellenious()
        {
            InitializeComponent();
        }

        private void uc_Miscellenious_Load(object sender, EventArgs e)
        {
            FillUnit();
        }
        public void FillUnit()
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet _ds = GlobalUsage.pharmacy_proxy.GetQueryResult2("EXEC [dbo].[pGC_ReportQuerries] 'Pharmacy','','" + GlobalUsage.Unit_id + "',null,'UnitList','','' ", "ExHrd");
            if (_ds.Tables[0].Rows.Count > 0)
            {
                cmbUnit.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
                cmbUnit.SelectedIndex = 0;
            }
            Cursor.Current = Cursors.Default;
        }
        private void rbFines_CheckedChanged(object sender, EventArgs e)
        {
          
     
        }
        private void downloadSelectedReport(byte [] data)
        {
           
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                if (fd.SelectedPath != "")
                {
                    string stored_at = fd.SelectedPath + "\\" + _ReportType+".pdf";
                    File.WriteAllBytes(stored_at, data);
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }
        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnit.Text.ToUpper() != "SELECT")
            {
                _UnitId = ((AddValue)cmbUnit.SelectedItem).Value.ToString();
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (rbFines.Checked)
                _ReportType = "RegisterOfFines(FormI)";
            else if (rbDeduction.Checked)
                _ReportType = "RegisterOfDeduction(FormII)";
            else if (rbWeekDayOff.Checked)
                _ReportType = "WeekDayOFFRegister(FormIII)";
            else if (rbOverTime.Checked)
                _ReportType = "OverTimeRegister(IV)";
            else if (rbEqualRenum.Checked)
                _ReportType = "EqualRenumeration(Form D)";
            else if (rbNoticeOfChange.Checked)
                _ReportType = "NoticeOfChange";
            else if (rdbtnNoticeOfCloseDay.Checked)
                _ReportType = "NoticeOfCloseDay";
        
            else if (radioButton1.Checked)
                _ReportType = "DamageOrLoss";
            else if (rbAnnualReturn.Checked)
                _ReportType = "AnnualReturn";
            byte[] data = null;
            try
            {
                if (_ReportType == "RegisterOfFines(FormI)")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_RegisterForFines("Pharmacy", "CHCL", _UnitId, null, "EmployeesOnUnit", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
                if (_ReportType == "RegisterOfDeduction(FormII)")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_RegisterForDeduction("Pharmacy", "CHCL", _UnitId, null, "EmployeesOnUnit", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
                if (_ReportType == "WeekDayOFFRegister(FormIII)")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_Weekdayoff("Pharmacy", "CHCL", _UnitId, null, "WeekDayOff", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
                if (_ReportType == "OverTimeRegister(IV)")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_OverTimeRegister("Pharmacy", "CHCL", _UnitId, DateTime.Now.AddMonths(-1).ToString("MM-yyyy"), "EmployeesOnUnit", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
                if (_ReportType == "EqualRenumeration(Form D)")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_FormDRemunRule("Pharmacy", "CHCL", _UnitId, null, "RemunerationRule", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
                if (_ReportType == "NoticeOfChange")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_NoticeOfChanges("Pharmacy", "CHCL", _UnitId, null, "NoticeOfChanges", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
                if (_ReportType == "NoticeOfCloseDay")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_NoticeOfChangesOfOtherStates("Pharmacy", "CHCL", _UnitId, null, "NoticeOfChanges", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
              
                if (_ReportType == "DamageOrLoss")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_DamageOrLoss("Pharmacy", "CHCL", _UnitId, null, "EmployeesOnUnit", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
                if (_ReportType == "AnnualReturn")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_AnualReturn("Pharmacy", "CHCL", _UnitId, null, "AnnualReturn", GlobalUsage.Login_id, out _Result);
                    downloadSelectedReport(data);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); } finally { Cursor.Current = Cursors.Default; }
            Cursor.Current = Cursors.Default;
        }
        private void btnDownload2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (rbAttendance.Checked)
                _ReportType = "AttendanceRegister";
            else
                _ReportType = "WagesRegister";

            byte[] data = null;
            try
            {
                if (_ReportType == "AttendanceRegister")
                {
                    data = GlobalUsage.pharmacy_proxy.GC_AttendenceRegisterOfUnit("CHCL", _UnitId, dtDate.Value,GlobalUsage.Login_id, "AttRegister",out _Result);
                    downloadSelectedReport(data);
                }
                else if (_ReportType == "WagesRegister")
                {
                    data = GlobalUsage.pharmacy_proxy.gc_SalaryChart(dtDate.Value.ToString("yyyy/MM/dd"), _UnitId);
                    downloadSelectedReport(data);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            Cursor.Current = Cursors.Default;
        }

     

       
    }
}
