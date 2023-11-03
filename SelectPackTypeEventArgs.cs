using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMediShop
{
    public delegate void SelectPackTypeEventHandler(object sender, SelectPackTypeEventArgs e);
    public class SelectPackTypeEventArgs : System.EventArgs
    {
        private string Pack_Type;private Int32 Pack_Qty;
        public SelectPackTypeEventArgs(string pack_type, Int32 pack_qty)
        {
            this.Pack_Type = pack_type;
            this.Pack_Qty = pack_qty;
        }
        public string PackType
        {
            get
            {
                return this.Pack_Type;
            }
        }
        public Int32 PackQty
        {
            get
            {
                return this.Pack_Qty;
            }
        }

    }
}
