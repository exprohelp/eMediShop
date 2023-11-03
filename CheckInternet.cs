using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
    public class CheckInternet
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref ConnectionState lpdwFlags, int dwReserved);

        [Flags]
       public enum ConnectionState : int 
        { 
            INTERNET_CONNECTION_MODEM = 0x1, 
            INTERNET_CONNECTION_LAN = 0x2, 
            INTERNET_CONNECTION_PROXY = 0x4, 
            INTERNET_RAS_INSTALLED = 0x10, 
            INTERNET_CONNECTION_OFFLINE = 0x20, 
            INTERNET_CONNECTION_CONFIGURED = 0x40 
        }

        public static string CheckNet() {
            ConnectionState Description = 0;
            string result=InternetGetConnectedState(ref Description, 0).ToString();
            return result.ToUpper();
        }

    }
