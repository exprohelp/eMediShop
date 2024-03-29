using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Reflection;
using System.Drawing;
using ZXing;
using ZXing.Common;

namespace eMediShop
{
    public static class FormExtensions
    {
        public static bool? SetScreenToFirstNonPrimary(this Form self)
        {
            try
            {
                // Retrieves the collection of available screens (monitors)
                var aScreens = Screen.AllScreens;
                // If count is not greater than 1 then exit
                if (aScreens.Length <= 1)
                    return false; // screen kept original

                // Saves current screen reference
                var screenOld = Screen.FromControl(self);
                foreach (var screen in aScreens)
                {
                    // Skips primary and current screen
                    if (screen.Primary || screen.Equals(screenOld))
                        continue;

                    var boundsScreen = screen.Bounds;

                    var oldState = self.WindowState;
                    // If form is currently maximized ...
                    if (oldState == FormWindowState.Maximized)
                    {
                        self.WindowState = FormWindowState.Normal;
                        self.StartPosition = FormStartPosition.Manual;
                        self.Location = boundsScreen.Location;
                        self.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        self.StartPosition = FormStartPosition.Manual;
                        // Center into new screen
                        var sizeGaps = boundsScreen.Size - self.Size;
                        var x = boundsScreen.Left + (sizeGaps.Width / 2);
                        var y = boundsScreen.Top + (sizeGaps.Height / 2);
                        self.Location = new Point(x, y);
                    }

                    return true; // screen has been changed
                }

                return false; // screen kept original
            }
            catch (Exception ex)
            {
                // process exception ex
                // ...

                return null; // error occurred
            }
        }
    }
    public class Config
    {
            public static DataTable GenericToDataTable<T>(List<T> items)
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                //Get all the properties by using reflection   
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names  
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
      



        public static string LeftAlign(string Info, Int32 Space)
        {
            Int32 len = Info.Length;
            if (Space < len)
                Space = Space + (len - Space);
            string sp = new String(' ', (Space - len));
            return sp;
        }
        public static string RightAlign(string First_Info, Int32 Space_1, string Second_Info, Int32 Space_2)
        {
            if (First_Info.Length > Space_1)
                Space_1 = First_Info.Length + 1;
            if (Second_Info.Length > Space_2)
                Space_2 = Second_Info.Length + 1;

            Int32 len = (Space_1 - First_Info.Length) + (Space_2 - Second_Info.Trim().Length);
            string sp = new String(' ', len);
            return sp;
        }
        public static List<RadListDataItem> FillTelrikCombo(System.Data.DataTable dt)
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
        public static List<RadListDataItem> FillTelrikCombo(System.Data.DataTable dt, bool Reverse)
        {
            List<RadListDataItem> list = new List<RadListDataItem>();
            RadListDataItem li = new Telerik.WinControls.UI.RadListDataItem();
            System.Windows.Forms.ComboBox cb = new System.Windows.Forms.ComboBox();
            li.Value = "Select";
            li.Text = "Select";
            list.Add(li);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Reverse)
                    list.Add(new Telerik.WinControls.UI.RadListDataItem(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString()));
                else
                    list.Add(new Telerik.WinControls.UI.RadListDataItem(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));

            }
            return list;
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
        public static bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
        {
            Double result;
            return Double.TryParse(val, NumberStyle,
                System.Globalization.CultureInfo.CurrentCulture, out result);
        }


      

     

        public static string GetSqlDate(string strDate)
        {
            string yyyy;
            string mm;
            string dd;
            yyyy = strDate.Substring(6, 4);
            mm = strDate.Substring(3, 2);
            dd = strDate.Substring(0, 2);
            return yyyy + "/" + mm + "/" + dd;
        }
     
        public static string getExpDate(string txtDate)
        {
            string _ExpDate = string.Empty;
            if (txtDate.Length == 0)
            { MessageBox.Show("Enter date", "ExPro Help"); return "Fail"; }
            if (txtDate.Length > 0)
            {
                if (txtDate == "-")
                { _ExpDate = "1900-01-01"; return _ExpDate; }

                int dasCaount = 0;
                char[] Char1 = txtDate.ToCharArray(0, txtDate.Length);
                foreach (char s in Char1)
                {
                    if (s == '-') { dasCaount = dasCaount + 1; }
                }
                if (dasCaount == 0 || dasCaount > 1)
                { return "Fail"; }

                if (txtDate.Length > 5 || txtDate.Length < 5)
                { return "Fail"; }
                string[] t = txtDate.Split('-');
                if (t[0].Length > 2 || t[0].Length < 2)
                { return "Fail"; }
                if (t[1].Length > 2 || t[1].Length < 2)
                { return "Fail"; }
                try { if (Convert.ToInt32(t[0]) > 12) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                try { if (Convert.ToInt32(t[1]) > 1000) { return "Fail"; } }
                catch (Exception ex) { return "Fail"; }
                string century = DateTime.Now.ToString("yyyy").Substring(0, 2);
                _ExpDate = century + t[1] + '-' + t[0] + '-' + "01";
            }
            return _ExpDate;
        }
        public static System.Data.DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            System.Data.DataTable dtReturn = new System.Data.DataTable();

            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

    }
    public class BarcodeGenerator
    {
        public Bitmap GenerateBarcode(string content, int width, int height)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128,
                Options = new EncodingOptions
                {
                    Width = width,
                    Height = height
                }
            };

            Bitmap barcodeImage = barcodeWriter.Write(content);
            return barcodeImage;
        }
    }

}
