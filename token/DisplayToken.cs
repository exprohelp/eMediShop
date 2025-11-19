using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop.token
{
    public partial class DisplayToken : Form
    {
        string _result = string.Empty;
        static IHubProxy _hub;
        public DisplayToken()
        {
            InitializeComponent();
            this.SetScreenToFirstNonPrimary();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // fillReadyToken();
        }
        private void fillReadyToken() {
            DataSet ds = new DataSet();
            rtb_Ready.Clear();
            cm2 p = new cm2();
            p.unit_id = GlobalUsage.Unit_id; p.Logic = "RFD"; p.dtFrom = "1900/01/01";
            p.dtTo = "1900/01/01";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/mis/tokenqueries", p);
            ds = dwr.result;
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                rtb_Ready.AppendText(dr["token_no"].ToString()+Environment.NewLine);
            }
        }

        private void DisplayToken_Load(object sender, EventArgs e)
        {
         
            //try
            //{
            //    var connection = new HubConnection(ConfigWebAPI.SingnalRServer);
            //    _hub = connection.CreateHubProxy("MyHub");
            //    connection.Start().Wait();
            //    _hub.On<string, string>("addMessage", (name, message) =>
            //     this.Invoke((Action)(() => rtb_Ready.Text=message))
            //     );

            //    string line = null;
            //    while ((line = System.Console.ReadLine()) != null)
            //    {
            //        _hub.Invoke("DetermineLength", line).Wait();
            //    }
            //}
            //catch (Exception ex) { }
            //Console.Read();
        }
    }
}
