using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
namespace eMediShop
{
    public class CheckInternet
    {
        
        [DllImport("wininet", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);
        public static int counter = 1;
        [Flags]
        enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }
        //Not Working
        //public static bool IsConnectedToInternet()
        //{
        //    InternetConnectionState flags = 0;

        //    bool isConfigured = (flags & InternetConnectionState.INTERNET_CONNECTION_CONFIGURED) != 0;
        //    bool isOffline = (flags & InternetConnectionState.INTERNET_CONNECTION_OFFLINE) != 0;
        //    bool isConnectedUsingModem = (flags & InternetConnectionState.INTERNET_CONNECTION_MODEM) != 0;
        //    bool isConnectedUsingLAN = (flags & InternetConnectionState.INTERNET_CONNECTION_LAN) != 0;
        //    bool isProxyUsed = (flags & InternetConnectionState.INTERNET_CONNECTION_PROXY) != 0;
        //    bool isRasEnabled = (flags & InternetConnectionState.INTERNET_RAS_INSTALLED) != 0;

        //    bool isConnected = InternetGetConnectedState(ref flags, 0);
        //    return isConnected;
        //}


        public static string CheckNet()
        {
            if (HasInternet())
                return "TRUE";
            else
                return "FALSE";
        }

        public static void InitializeCheckNetLoop()
        {
            var netTask = Task.Factory.StartNew(() => CheckNetLoop());
        }
        public static void CheckNetLoop()
        {

            do
            {
                System.Threading.Thread.Sleep(1000);
                if (HasInternet())
                    GlobalUsage.NetStatus = true;
                else
                    GlobalUsage.NetStatus = false;
                counter++;
                if (counter >= 90)
                    counter = 1;
            }
            while (counter < 90);
        }

        private static bool HasInternet()
        {
            bool response = false;
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;
            try
            {
                // Create a buffer of 32 bytes of data to be transmitted.
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;
                PingReply reply = pingSender.Send("www.google.co.in", timeout, buffer, options);
                response = true;
            }
            catch (Exception ex)
            {
                response = false;
            }
            return response;
        }
        public static bool IsConnectedToInternet()
         {
             string host = "www.google.co.in";
             bool result = false;
             Ping p = new Ping();
             try
            {
                 PingReply reply = p.Send(host, 3000);
                 if (reply.Status == IPStatus.Success)
                     return true;
             }
             catch { }
             return result;
         }

    }
}
     
