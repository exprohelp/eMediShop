using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eMediShop
{
    public partial class NotifierMsg : Form
    {
        
        string Msg = "";
        private int flags;
        int animate_time = 0;
        Size clintsize;
        private int flag;
        string _MsgType = "";
        Size sz;
        public NotifierMsg( int flag_prm,int time,Size clint_size,string msg,string msgType)
        {
            this.Msg = msg;
            _MsgType = msgType;
            animate_time = time;
            flag = flag_prm;
            clintsize = clint_size;
            InitializeComponent();
        }
        private void NotifierMsg_Load(object sender, EventArgs e)
        {
            txtMsg.Text = Msg;
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            sz = rec.Size;
            int x=sz.Width-clintsize.Width;
            int y=sz.Height-clintsize.Height;
            x =x-this.Width;
            this.Location =new System.Drawing.Point(x-12,y);
            WinAPI.AnimateWindow(this.Handle, animate_time, flag);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_MsgType.Contains("SoftwareUpdate"))
            {
               GlobalUsage.pharmacy_proxy.QueryExecute("update PopupAlert  set uStatus='N',upd_date=getDate() where unit_id=" + GlobalUsage.Unit_id + " ", "eManagement");
               GlobalUsage.ViewStatus = "No";
               this.Close();
            }
            if (_MsgType.Contains("OnLineOrder"))
            {
                GlobalUsage.ViewStatus = "No";
             
                this.Close();    
            }
        }
    }
}
