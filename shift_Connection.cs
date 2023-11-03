using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;
using System.Xml;

namespace eMediShop
{
    public partial class shift_Connection : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        public shift_Connection()
        {
            InitializeComponent();
        }
        private void btnTATA_Click(object sender, EventArgs e)
        {

            string[] key = { "eMediShop_Pharmacy_Pharmacy_WebServices", "eMediShop_Utility_Utility_WebServices", "eMediShop_HealthCard_HealthCard_WebServices", "eMediShop_FileUpload_FileUploader", "eMediShop_Staff_Management_Staff_Management" };
            string[] value = { "http://115.108.228.98/exprologic/pharmacy_webservices.asmx", "http://115.108.228.98/exprologic/utility_webServices.asmx", "http://115.108.228.98/exprologic/healthcard_webservices.asmx", "http://115.108.228.98/exprologic/FileUploader.asmx", "http://115.108.228.98/exprologic/staff_management.asmx" };
            changeconfig(key, value);        
        }
        private void changeconfig(string[] key,string[] value)
        {
           
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode settingsNode = doc.GetElementsByTagName("applicationSettings")[0];
            for (int i = 0; i < 5; i++)
            {
                XmlNode node = settingsNode.SelectSingleNode(typeof(eMediShop.Properties.Settings).FullName + "/setting[@name='" + key[i] + "']");
                if (node != null)
                {
                    XmlNode valueNode = node.SelectSingleNode("value");
                    if (valueNode != null)
                    {
                        valueNode.FirstChild.Value = value[i];
                    }
                }
                doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }
            MessageBox.Show("Connection Successfully Configured");
        }

        private void btnSetAirtel_Click(object sender, EventArgs e)
        {
            string[] key = { "eMediShop_Pharmacy_Pharmacy_WebServices", "eMediShop_Utility_Utility_WebServices", "eMediShop_HealthCard_HealthCard_WebServices", "eMediShop_FileUpload_FileUploader", "eMediShop_Staff_Management_Staff_Management" };
            string[] value = { "http://122.160.111.70/exprologic/pharmacy_webservices.asmx", "http://122.160.111.70/exprologic/utility_webServices.asmx", "http://122.160.111.70/exprologic/healthcard_webservices.asmx", "http://122.160.111.70/exprologic/FileUploader.asmx", "http://122.160.111.70/exprologic/staff_management.asmx" };
            changeconfig(key, value); 
        }

       
    
      
    }
}