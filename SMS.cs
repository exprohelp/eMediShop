using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace eMediShop
{
    public class SmsClass
    {
        public string SendSms(string MobileNo, string msg)
        {
            String responseFromServer = string.Empty;
            try
            {
                    string url = GlobalUsage.SmsAPI + MobileNo + "&from="+GlobalUsage.SmsID+"&text=" + msg + "";
                    WebRequest request = WebRequest.Create(url);
                    request.Method = "GET";
                    //request.ContentLength = sURL.Length;
                    request.Credentials = CredentialCache.DefaultCredentials;
                    HttpWebResponse response1 = (HttpWebResponse)request.GetResponse();
                    Stream dataStream = response1.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    response1.Close();
            }
            catch (Exception ex)
            {
                responseFromServer = ex.Message;
            }
            return responseFromServer;
        }
    }

}
