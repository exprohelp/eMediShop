using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eMediShop
{
    public class UnitInfo
    {
        public string Unit_id { get; set; }
        public string ShortName { get; set; }
        public string Ledger_id { get; set; }
    }

    public class transferid_info
    {

        public string auto_id { get; set; }
        public string trf_id { get; set; }
        public string trf_to { get; set; }
        public string item_id { get; set; }
        public string item_name { get; set; }
        public string master_key_id { get; set; }
        public string batch_no { get; set; }
        public string exp_date { get; set; }
        public string pack_type { get; set; }
        public int pack_qty { get; set; }
        public int qty { get; set; }
        public decimal upr { get; set; }
        public decimal total { get; set; }
        public decimal tax_rate { get; set; }
        public decimal igst { get; set; }
        public decimal sgst { get; set; }
        public decimal cgst { get; set; }

    }
    public class ProductMovementInfo
    {
        public DateTime ClosingDate { get; set; }
        public string item_id { get; set; }
        public string item_name { get; set; }
        public string pack_type { get; set; }
        public decimal pack_qty { get; set; }
        public string Shelf_No { get; set; }
        public string batch_no { get; set; }
        public DateTime exp_date { get; set; }
        public decimal mrp { get; set; }
        public decimal OpeningQty { get; set; }
        public decimal rcptqty { get; set; }
        public decimal soldQty { get; set; }
        public decimal trfQty { get; set; }
        public decimal purchQty { get; set; }
        public decimal balQty { get; set; }
        public decimal stkQty { get; set; }

    }
}
