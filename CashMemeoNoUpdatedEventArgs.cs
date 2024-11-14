using System;
using System.Collections.Generic;
using System.Text;

namespace eMediShop
{
    public delegate  void SearchCashMemoEventHandler(object  sender ,CashMemeoNoUpdatedEventArgs e);
    public class CashMemeoNoUpdatedEventArgs:System .EventArgs 
    {
        private string CashMemoNo;
        public CashMemeoNoUpdatedEventArgs(string CashMemoNo)
        {
            this.CashMemoNo = CashMemoNo;

        }
        public string CASHMEMONO
        {
            get
            {
                return this.CashMemoNo;
            }
        }
    }
    public delegate void SetStaffEventHandler(object sender, SetStaffUpdatedEventArgs e);
    public class SetStaffUpdatedEventArgs : System.EventArgs
    {
        private string Result;
        public SetStaffUpdatedEventArgs(string result)
        {
            this.Result = result;

        }
        public string RESULT
        {
            get
            {
                return this.Result;
            }
        }
    }

    public delegate void CashCounterEventHandler(object sender, CashCounterUpdatedEventArgs e);
    public class CashCounterUpdatedEventArgs : System.EventArgs
    {
        private string Sale_Inv_No; private string Result;
        public CashCounterUpdatedEventArgs(string SaleInvNo,string result)
        {
            this.Sale_Inv_No = SaleInvNo;
            this.Result = result;
        }
        public string SaleInvNo
        {
            get { return this.Sale_Inv_No; }
        }
        public string result
        {
            get { return this.Result; }
        }
    }
    public delegate void  BillPostingEventHandler(object sender, BillPostingUpdatedEventArgs e);
    public class BillPostingUpdatedEventArgs : System.EventArgs
    {
        private string Sale_Inv_No; private string Result;
        public BillPostingUpdatedEventArgs(string SaleInvNo, string result)
        {
            this.Sale_Inv_No = SaleInvNo;
            this.Result = result;
        }
        public string SaleInvNo
        {
            get { return this.Sale_Inv_No; }
        }
        public string result
        {
            get { return this.Result; }
        }
    }
}

