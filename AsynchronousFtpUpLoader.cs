using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Xml;
using ExPro.Client;
using ExPro.Server;
namespace eMediShop
{
    public class AsynchronousFtpUpLoader
    {
        public static long count = 1;
        public static long bytesRead = 0;
        private static bool mUseBinaryMode = true;
        private static int mPort = 21;
        private static int mTimeOut = System.Threading.Timeout.Infinite;
        public static void send(string args)
        {
            // Create a Uri instance with the specified URI string.
            // If the URI is not correctly formed, the Uri constructor
            // will throw an exception.
            ManualResetEvent waitObject;
            FtpState state = new FtpState();
            FtpWebRequest request = CreateWebRequest(WebRequestMethods.Ftp.DownloadFile, args);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            // This example uses anonymous logon.
            // The request is anonymous by default; the credential does not have to be specified. 
            // The example specifies the credential only to
            // control how actions are logged on the server.
            request.Credentials = new NetworkCredential("ExPro", "Ex67Pro");
            /*
             * Following code working for non domain server
               request.Credentials = new NetworkCredential("ExPro", "Ex67Pro");, AsynchronousFtpUpLoader.getCurrentIP());
             *         
             */
            //e.g. reqFTP.Credentials = new NetworkCredential(UserName, Password);
            // Store the request in the object that we pass into the
            // asynchronous operations.
            state.Request = request;
            // state.FileName = "c:\temp.xml";
            // Get the event to wait on.
            waitObject = state.OperationComplete;
            // Asynchronously get the stream for the file contents.
            request.BeginGetRequestStream(
                new AsyncCallback(EndGetStreamCallback),
                state
            );
            // Block the current thread until all operations are complete.
            waitObject.WaitOne();
            // The operations either completed or threw an exception.
            if (state.OperationException != null)
            {
                throw state.OperationException;
            }
            else
            {
                Console.WriteLine("The operation completed - {0}", state.StatusDescription);
            }
        }
        private static void EndGetStreamCallback(IAsyncResult ar)
        {
            FtpState state = (FtpState)ar.AsyncState;
            Stream requestStream = null;
            // End the asynchronous call to get the request stream.
            try
            {
                requestStream = state.Request.EndGetRequestStream(ar);
                // Copy the file contents to the request stream.
                const int bufferLength = 2048;
                byte[] buffer = new byte[bufferLength];
                int readBytes = 0;

                FileStream stream = new FileStream(GlobalUsage.FileName, FileMode.Open, FileAccess.Read);
                FileInfo fi = new FileInfo(GlobalUsage.FileName);
                long li = fi.Length;
                do
                {
                    readBytes = stream.Read(buffer, 0, bufferLength);
                    requestStream.Write(buffer, 0, readBytes);
                    count += readBytes;
                    long perc = count * 100 / li;
                    GlobalUsage.Message = perc.ToString() + " % Transfered.\n";
                }
                while (readBytes != 0);
                // IMPORTANT: Close the request stream before sending the request.
                requestStream.Close();
                // Asynchronously get the response to the upload request.
                state.Request.BeginGetResponse(new AsyncCallback(EndGetResponseCallback), state);
            }
            //Return exceptions to the main application thread.
            catch (Exception e)
            {
               
                Console.WriteLine("Could not get the request stream.");
                state.OperationException = e;
                state.OperationComplete.Set();
                return;
            }

        }
        // The EndGetResponseCallback method  
        // completes a call to BeginGetResponse.
        private static FtpWebRequest CreateWebRequest(string method, string uri)
        {
            UriBuilder uriBuilder = new UriBuilder(uri);
            uriBuilder.Port = mPort;
            FtpWebRequest ftpWebRequest = (FtpWebRequest)FtpWebRequest.Create(uriBuilder.Uri);
            ftpWebRequest.Method = method;
            ftpWebRequest.UseBinary = mUseBinaryMode;
            ftpWebRequest.KeepAlive = false;
            ftpWebRequest.Timeout = mTimeOut;
            // ftpWebRequest.Credentials = new NetworkCredential(mUserName, mPassword);
            return ftpWebRequest;
        }
        private static void EndGetResponseCallback(IAsyncResult ar)
        {
            FtpState state = (FtpState)ar.AsyncState;
            FtpWebResponse response = null;
            try
            {
                response = (FtpWebResponse)state.Request.EndGetResponse(ar);
                response.Close();
                state.StatusDescription = response.StatusDescription;
                //Signal the main application thread that 
                //the operation is complete.
                state.OperationComplete.Set();
            }
            // Return exceptions to the main application thread.
            catch (Exception e)
            {
               
                Console.WriteLine("Error getting response.");
                state.OperationException = e;
                state.OperationComplete.Set();
            }
        }
        public static string getCurrentIP()
        {
            string curIP = "";
            string key = "eMediShop_Pharmacy_Pharmacy_WebServices";
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode settingsNode = doc.GetElementsByTagName("applicationSettings")[0];
            XmlNode node = settingsNode.SelectSingleNode(typeof(eMediShop.Properties.Settings).FullName + "/setting[@name='" + key + "']");
            if (node != null)
            {
                string[] ARRAY = node.InnerText.Split('/');
                curIP = ARRAY[2];
            }
            return curIP;

        }
    }
    public class FtpState
    {
        private ManualResetEvent wait;
        private FtpWebRequest request;
        private string fileName;
        private Exception operationException = null;
        string status;

        public FtpState()
        {
            wait = new ManualResetEvent(false);
        }

        public ManualResetEvent OperationComplete
        {
            get { return wait; }
        }

        public FtpWebRequest Request
        {
            get { return request; }
            set { request = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public Exception OperationException
        {
            get { return operationException; }
            set { operationException = value; }
        }
        public string StatusDescription
        {
            get { return status; }
            set { status = value; }
        }
    }
}
