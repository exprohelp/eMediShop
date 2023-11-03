using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using System.Security.Cryptography;
using System.ComponentModel;
using Telerik.WinControls.UI;

namespace eMediShop
{
    public delegate void UpdateMainPageTitleEventHandler(object sender, UpdateMainPageTitleEventArgs e);
    public delegate void SetParameterValueDeligate(string value);


    public static class GlobalUsage
    {
        public static SqlConnection Con = new SqlConnection();
        public static eMediShop.Pharmacy.Pharmacy_WebServicesSoapClient pharmacy_proxy = null; //cws
        
        public static eMediShop.rmAccounts.Accounts_WebServiceSoapClient accounts_proxy = null; //ac
        public static eMediShop.HealthCard.HealthCard_WebServicesSoapClient healthcard_proxy = null; //ac
   
        public static eMediShop.his_proxy.ChandanPharmacyServicesSoapClient his_proxy = null; //ac

        public static string BillDrive = System.Configuration.ConfigurationManager.AppSettings["BillDrive"].ToString();
        public static string CloudStoragePath = System.Configuration.ConfigurationManager.AppSettings["CloudStoragePath"].ToString();
        public static string ViewStatus = "No";
        public static string MySystemIP = string.Empty;
        public static string ClosingDate = string.Empty;
        public static string UniqueMachineId = string.Empty;
        public static bool NetStatus;
        public static string computerName = Environment.MachineName.ToString();
        public static string CurrentDate = "";
        public static string PrinterType = "DMP";
        public static int FeedingDay = 0;
        public static string couponCode = "-";
        public static string CounterID = string.Empty;
        public static string Audit_No = string.Empty;
        public static string Auditor_id = string.Empty;
        public static string Login_id = string.Empty;
        public static string Login_Name = string.Empty;
        public static string Unit_id = string.Empty;
        public static string UnitName = string.Empty;
        public static string Comp_id = string.Empty;
        public static string Company = string.Empty;
        public static string UnitAddress = string.Empty;
        public static string FileName = string.Empty;
        public static string Message = "Waiting For Action\n ";
        public static bool NetConnected = false;
        public static string mainFormCaption = string.Empty;
        public static string Old_Sale_Inv_No = string.Empty;
        public static string Purchase_Id = string.Empty;
        public static string Address = string.Empty;
        public static string CashMemoAddress = string.Empty;
        public static string PharmacistNo = string.Empty;
        public static string ContactNo = string.Empty;
        public static string DL_No = string.Empty;
        public static string CIN_No = string.Empty;
        public static string Warehouse_id = string.Empty;
        public static string ou_UnitName = string.Empty; //Oter Unit Name
        public static string ou_Address = string.Empty; //Oter Unit Address
        public static string ou_district = string.Empty; //Oter Unit Address
        public static string ou_TIN_No = string.Empty; //Oter Unit TIN No.
        public static string ou_DL_No = string.Empty; //Oter Unit DL No.
        public static string GST_No = string.Empty;
        public static string Rights = "Operator";
        public static string Billing_Rights = "N";
        public static string Dispatch_Rights = "N";
        public static string Posting_Rights = "N";
        public static string BillType = "UnPosted";

        public static string[] PswEncrypKey = { "7", "6", "r", "C", "d", "4", "y", "d" };
        public static string Temp = string.Empty;
        public static string LedgFrom = System.DateTime.Now.Date.ToString("dd-MM-yyyy");
        public static string LedgTo = System.DateTime.Now.Date.ToString("dd-MM-yyyy");
        public static string State = string.Empty;
        public static string District = string.Empty;
        public static string SoftRight = "N/A";
        public static string SmsAPI = "N/A";
        public static string SmsID = "N/A";
        public static CrystalReportsPharmacy.eMediShop.CashMemoGST PharmacyCashMemo;
        public static CrystalReportsPharmacy.eMediShop.ManualDeliveryNote ManualBill;
        public static CrystalReportsPharmacy.eMediShop.HP_CashMemo HospitalCashMemo;
        public static CrystalReportsPharmacy.eMediShop.HP_MedicineSearchSheet HospitalInternalSheet;
        public static CrystalReportsPharmacy.eMediShop.CashMemoGST_opthalmic opthCashMemo;


        public static void ManageButton(Control container, Control target)
        {
            foreach (Control c in container.Controls)
            {
                if (c.HasChildren)
                {
                    foreach (Control c1 in c.Controls)
                    {
                        if (c1.GetType() == typeof(Button))
                        {
                            if (c1.Name != target.Name)
                            {
                                c1.Enabled = true;
                            }
                            else { c1.Enabled = false; }
                        }
                    }
                }
                else
                {
                    if (c.GetType() == typeof(Button))
                    {
                        if (c.Name != target.Name)
                        {
                            c.Enabled = true;
                        }
                        else { c.Enabled = false; }
                    }
                }
            }
        }
        public static byte[] Encrypt(byte[] DataToEncrypt, RSAParameters keyInfo)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(keyInfo);
            return RSA.Encrypt(DataToEncrypt, false);
        }
        public static byte[] Decrypt(byte[] DataToDecrypt, RSAParameters keyInfo)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(keyInfo);
            return RSA.Decrypt(DataToDecrypt, false);
        }
        public static List<Telerik.WinControls.UI.RadListDataItem> FillTelrikCombo(DataTable dt)
        {
            List<RadListDataItem> list = new List<RadListDataItem>();
            RadListDataItem li = new Telerik.WinControls.UI.RadListDataItem();
            System.Windows.Forms.ComboBox cb = new System.Windows.Forms.ComboBox();
            li.Value = "Select";
            li.Text = "Select";
            list.Add(li);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new Telerik.WinControls.UI.RadListDataItem(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
            }
            return list;
        }

        public static void ListViewToCSV(ListView lvCnt, string folder, string fileName)
        {
            StringBuilder sb = new StringBuilder();

            string mydocpath =
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            mydocpath += "\\" + folder;
            if (!System.IO.Directory.Exists(mydocpath))
            {
                System.IO.Directory.CreateDirectory(mydocpath);
            }
            //Making columns!
            foreach (ColumnHeader ch in lvCnt.Columns)
            {
                sb.Append(ch.Text + ",");
            }

            sb.AppendLine();


            //Looping through items and subitems
            foreach (ListViewItem lvi in lvCnt.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    if (lvs.Text.Trim() == string.Empty)
                        sb.Append(" ,");
                    else
                        sb.Append(lvs.Text + ",");
                }
                sb.AppendLine();
            }

            using (StreamWriter outfile =
             new StreamWriter(mydocpath + @"\" + fileName + ".csv"))
            {
                outfile.Write(sb.ToString());
            }
        }
        public static void ListViewToCSV(ListView lvCnt, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            //Making columns!
            foreach (ColumnHeader ch in lvCnt.Columns)
            {
                sb.Append(ch.Text + ",");
            }

            sb.AppendLine();
            //Looping through items and subitems
            foreach (ListViewItem lvi in lvCnt.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    if (lvs.Text.Trim() == string.Empty)
                        sb.Append(" ,");
                    else
                        sb.Append(lvs.Text + ",");
                }
                sb.AppendLine();
            }
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            Fbd.ShowDialog();
            using (StreamWriter outfile = new StreamWriter(Fbd.SelectedPath + @"\" + fileName + ".csv"))
            {
                outfile.Write(sb.ToString());
            }
        }
        public static void ListViewToCSV(DataTable dt, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            //Making columns!
            foreach (DataColumn ch in dt.Columns)
            {
                sb.Append(ch.ColumnName + ",");
            }
            sb.AppendLine();
            //Looping through items and subitems
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn lvs in dt.Columns)
                {
                    if (dr[lvs.ColumnName].ToString().Trim() == string.Empty)
                        sb.Append(" ,");
                    else
                        sb.Append(dr[lvs.ColumnName].ToString().Trim() + ",");
                }
                sb.AppendLine();
            }
            FolderBrowserDialog Fbd = new FolderBrowserDialog();
            Fbd.ShowDialog();
            using (StreamWriter outfile = new StreamWriter(Fbd.SelectedPath + @"\" + fileName + ".csv"))
            {
                outfile.Write(sb.ToString());
            }
        }
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        public static object[] FillCombo(DataTable dt)
        {
            ComboBox cb = new ComboBox();
            cb.Items.Add(new AddValue("Select", "Select"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(new AddValue(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));
            }
            cb.SelectedIndex = 0;
            object[] obj = new object[cb.Items.Count];
            cb.Items.CopyTo(obj, 0);

            return obj;
        }
    }
    public class UpdateMainPageTitleEventArgs : System.EventArgs
    {
        private string _result;
        public UpdateMainPageTitleEventArgs(string result)
        {
            this._result = result;
        }
        public string Result { get { return this._result; } }
    }
    public static class ControlID
    {
        public static string TextData { get; set; }
    }

}
