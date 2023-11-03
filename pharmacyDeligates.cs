using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMediShop
{
    public delegate void PurchaseBillPostingEventHandler(object sender, PurchaseBillPostingEventArgs e);
    public class PurchaseBillPostingEventArgs : System.EventArgs
    {
        private string PurchaseId; private string Result;
        public PurchaseBillPostingEventArgs(string purchaseid, string result)
        {
            this.PurchaseId = purchaseid;
            this.Result = result;
        }
        public string purchaseId
        {
            get
            {
                return this.PurchaseId;
            }
        }
        public string result
        {
            get
            {
                return this.Result;
            }
        }

    }
    public delegate void SearchUpdateEventHandler(object sender, SearchUpdatedEventArgs e);
    public class SearchUpdatedEventArgs : System.EventArgs
    {
        private string productID;
        public SearchUpdatedEventArgs(string productID)
        {
            this.productID = productID;

        }
        public string ProductID
        {
            get
            {
                return this.productID;
            }
        }
    }
}
