using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
namespace eMediShop
{
    public class dbConnection
    {
        public dbConnection()
         {
         }
         public static SqlConnection getconnection()
         {
              string strcon = System.Configuration.ConfigurationSettings.AppSettings["constring"];
             SqlConnection con = new SqlConnection(strcon);
             return con;
         }    
    }
}
