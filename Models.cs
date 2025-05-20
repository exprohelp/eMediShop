using System;
using System.Collections.Generic;
using System.Data;

namespace eMediShop
{
    public class Localwarehouse
    {
        //unit_id,ForUnit,processAverage,ordermth,nProduct,login_id,logic,order_no,includeWh_Stocks
        public string unit_id { get; set; }
        public string ForUnit { get; set; }
        public string processAverage { get; set; }
        public string ordermth { get; set; }
        public string nProduct { get; set; }
        public string login_id { get; set; }
        public string logic { get; set; }
        public string includeWh_Stocks { get; set; }
        public string order_no { get; set; }
    }
    public class selectQry
    {
        public string unitID { get; set; }
        public string tranId { get; set; }
        public string Logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string prm_3 { get; set; }
        public string dtFrom { get; set; }
        public string dtTo { get; set; }
        public string loginId { get; set; }

    }
    public class challans
    {
        public string unitID { get; set; }
        public string challan_no { get; set; }
        public string customer_Id { get; set; }
        public string item_id { get; set; }
        public string master_key_id { get; set; }
        public int Challan_Qty { get; set; }
        public string Logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string loginId { get; set; }
        public string result { get; set; }

    }

    public class ipPharmacyInfo
    {
        public string unit_id { get; set; }
        public string SaleInvNos { get; set; }
        public string uhid { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string prm_3 { get; set; }
        public string ReportType { get; set; }
        public string IPDNos { get; set; }
        public string sale_inv_no { get; set; }
        public string IPDNo { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string login_id { get; set; }
        public string Logic { get; set; }
    }
    public class HALContractHeader
    {
        public string unitID { get; set; }
        public string orderNo { get; set; }
        public string ptname { get; set; }
        public string prescribedBy { get; set; }
        public int SrNo { get; set; }
        public string PBNO { get; set; }
        public string orderDate { get; set; }
        public string createdBy { get; set; }
        public string Logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
    }
    public class HALContractLineItem
    {
        public string unitID { get; set; }
        public string orderNo { get; set; }
        public string itemid { get; set; }
        public int qty { get; set; }
        public int itemname { get; set; }
        public string createdBy { get; set; }
        public string Logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string loginID { get; set; }
    }
    public class GetProductDiscountByItemID
    {
        public string unit_id { get; set; }
        public string cardLevel { get; set; }
        public string Itemid { get; set; }
        public int sold_qty { get; set; }
        public string ipdNo { get; set; }
        public string result { get; set; }
        public string orderNo { get; set; }
    }
    public class WalletMoney
    {
        public string unitID { get; set; }
        public string estimateNo { get; set; }
        public int walletMoney { get; set; }
        public string loginId { get; set; }
        public string result { get; set; }
        public string walletID { get; set; }
        public string Logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }

    }
    public class BillPosting
    {
        public string uhidNo { get; set; }
        public string ipopNo { get; set; }
        public string Oldsale_inv_no { get; set; }
        public string sale_inv_no { get; set; }
        public string customer_name { get; set; }
        public string card_no { get; set; }
        public string mobileNo { get; set; }
        public string prescribedBy { get; set; }
        public string panelName { get; set; }
        public string panelType { get; set; }
        public string AccountID { get; set; }
        public string HomeDelivery { get; set; }
        public string CallFrom { get; set; }
        public Int32 amount { get; set; }
        public string orderNo { get; set; }
        public string saleType { get; set; }
        public string gstNo { get; set; }
    }
    public class UpdatePayMode
    {
        public string unit_id { get; set; }
        public string sale_inv_no { get; set; }
        public string logic { get; set; }
        public string PayMode { get; set; }
        public string loginId { get; set; }
        public string shiftID { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
    }
    public class manualBilling
    {
        public string mnlType { get; set; }
        public string item_id { get; set; }
        public string item_name { get; set; }
        public string pack_Type { get; set; }
        public int pack_Qty { get; set; }
        public string batchNo { get; set; }
        public string exp_date { get; set; }
        public decimal disPer { get; set; }
        public decimal mrp { get; set; }
        public decimal usr { get; set; }
        public decimal discount { get; set; }
        public int SoldQty { get; set; }
        public decimal Amount { get; set; }
        public string Logic { get; set; }
    }
    public class FOCInfo
    {

        public string unitID { get; set; }
        public string estimateNo { get; set; }
        public string SendBy { get; set; }
        public string attachmentPath { get; set; }
        public string Remarks { get; set; }
        public string approveBy { get; set; }
        public string isApproved { get; set; }
        public string Logic { get; set; }
        public string result { get; set; }
    }
    public class ip_manualBilling
    {
        public string unit_id { get; set; }
        public string uhid { get; set; }
        public string ipopType { get; set; }
        public string ipdNo { get; set; }
        public string mobileNo { get; set; }
        public string CardNo { get; set; }
        public string custName { get; set; }
        public string refName { get; set; }
        public string payMode { get; set; }
        public string PayDetail { get; set; }
        public string Remarks { get; set; }
        public string Logic { get; set; }
        public string loginId { get; set; }
        public List<manualBilling> mbItemlist { get; set; }
    }
    public class regulareQueries
    {
        public string card_no { get; set; }
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public string logic { get; set; }
        public string loginID { get; set; }
        public string order_no { get; set; }
        public string rmd_date { get; set; }
        public string rmd_time { get; set; }
        public string remark { get; set; }
        public string callType { get; set; }
        public string uniqeID { get; set; }
        public string lastcallinfo { get; set; }

    }
    public class Hoto
    {
        public string unit_id { get; set; }
        public string login_id { get; set; }
        public string logic { get; set; }
        public string shiftID { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string autoId { get; set; }
        public string tnxDate { get; set; }
        public string tnxBy { get; set; }
        public string tnxTo { get; set; }
        public decimal amount { get; set; }
        public string result { get; set; }
        public string uniqueID { get; set; }
    }
    public class CustomerInfo
    {
        public string Card_No { get; set; }
        public string Child_DOB_5 { get; set; }
        public string Child_Name_5 { get; set; }
        public string Child_DOB_4 { get; set; }
        public string Child_Name_4 { get; set; }
        public string Child_DOB_3 { get; set; }
        public string Child_Name_3 { get; set; }
        public string Child_DOB_2 { get; set; }
        public string Child_Name_2 { get; set; }
        public string Child_DOB_1 { get; set; }
        public string Child_Name_1 { get; set; }
        public string Spouse_DOB { get; set; }
        public string Spouse_Name { get; set; }
        public string email { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string PIN { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Locality { get; set; }
        public string Area { get; set; }
        public string DOB { get; set; }
        public string Cust_Name { get; set; }
        public string CardType { get; set; }
        public string login_id { get; set; }
        public string logic { get; set; }
        public string DistType { get; set; }
        public string PayType { get; set; }
        public string Inst_Code { get; set; }
        public string ActDate { get; set; }
    }
    public class customerOrders
    {
        public string card_no { get; set; }
        public string cust_name { get; set; }
        public string unit_id { get; set; }
        public string old_order_no { get; set; }
        public string login_id { get; set; }
        public string item_id { get; set; }
        public string new_med { get; set; }
        public int qty { get; set; }
        public string order_no { get; set; }
        public string remarkfrom { get; set; }
        public string remarks { get; set; }
        public string delivery_date { get; set; }
        public string delivery_time { get; set; }
        public string delivery_by { get; set; }
        public string ref_by { get; set; }
        public string sale_inv_no { get; set; }
        public string promo_flag { get; set; }
        public string prm_1 { get; set; }
        public string logic { get; set; }
        public string rec_flag { get; set; }
        public string master_key_id { get; set; }
        public string old_item_id { get; set; }
        public string cancel_flag { get; set; }
        public string division { get; set; }
        public string mobileno { get; set; }
        public string couponNo { get; set; }
        public string isHomeDelivery { get; set; }
        public string TransferToUnit { get; set; }
        public string newProductName { get; set; }

    }
    public class pmIndentToUnit
    {
        public string auto_id { get; set; }
        public string indent_no { get; set; }
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public int qty { get; set; }
        public int conf_qty { get; set; }
        public string createdby { get; set; }
        public string confirmby { get; set; }
        public string remarks { get; set; }
        public string tran_id { get; set; }
        public string logic { get; set; }
        public string tran_type { get; set; }
        public string conf_flag { get; set; }
        public DataTable dt { get; set; }
    }
    public class pm_HospitalQueries
    {
        public string logic { get; set; }
        public string unit_id { get; set; }
        public string uhid { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string prm_3 { get; set; }
        public string login_id { get; set; }
    }
    public class prescribedby
    {
        public string unit_id { get; set; }
        public string refCode { get; set; }
        public string ref_Name { get; set; }
        public string mobile_no { get; set; }
        public string address { get; set; }
        public string logic { get; set; }
    }

    public class pm_documents
    {
        public string unit_id { get; set; }
        public string DocId { get; set; }
        public string DocType { get; set; }
        public string login_id { get; set; }
        public byte[] dataInBytes { get; set; }
        public string doc_path { get; set; }
        public string filename { get; set; }
        public string extension { get; set; }

    }
    public class pm_sales
    {
        public decimal freeItems { get; set; }
        public decimal SoldQtyInPacks { get; set; }
        public decimal npr { get; set; }
        public decimal cgst { get; set; }
        public decimal Dis_Per { get; set; }
        public decimal discount { get; set; }
        public decimal discountPercent { get; set; }
        public decimal igst { get; set; }
        public decimal Mrp { get; set; }
        public decimal net { get; set; }
        public decimal Pack_Qty { get; set; }
        public decimal Received { get; set; }
        public decimal RoundOff { get; set; }
        public decimal Sale_qty { get; set; }
        public decimal sgst { get; set; }
        public decimal sv { get; set; }
        public decimal Tax { get; set; }
        public decimal tax_rate { get; set; }
        public decimal taxablevalue { get; set; }
        public decimal taxValue { get; set; }
        public decimal total { get; set; }
        public decimal unit_mrp { get; set; }
        public decimal usr { get; set; }
        public int action { get; set; }
        public int FlexiDiscountAmt { get; set; }
        public int Line_Num { get; set; }
        public int sale_qty { get; set; }
        public int UOM { get; set; }
        public string account_id { get; set; }
        public string party_id { get; set; }
        public string pack_type { get; set; }
        public string Address { get; set; }
        public string amount { get; set; }
        public string area { get; set; }
        public string batch_no { get; set; }
        public string Bill_No { get; set; }
        public string card_level { get; set; }
        public string Category_Name { get; set; }
        public string CinNo { get; set; }
        public string Comp_Name { get; set; }
        public string computer_id { get; set; }
        public string computerName { get; set; }
        public string contact_no { get; set; }
        public string counter_id { get; set; }
        public string Cur_sale_inv_no { get; set; }
        public string cust_name { get; set; }
        public string disc_percentage { get; set; }
        public string Discount { get; set; }
        public string DiscountLogic { get; set; }
        public string district { get; set; }
        public string DL_No { get; set; }
        public string exp_date { get; set; }
        public string f_date { get; set; }
        public string FirstValue { get; set; }
        public string gstn_no { get; set; }
        public string hd_flag { get; set; }
        public string HealthCardNo { get; set; }
        public string hosp_cr_no { get; set; }
        public string hosp_ipop_no { get; set; }
        public string hsn { get; set; }
        public string item_id { get; set; }
        public string item_name { get; set; }
        public string l_date { get; set; }
        public string locality { get; set; }
        public string logic { get; set; }
        public string login_id { get; set; }
        public string login_name { get; set; }
        public string MarginPercentage { get; set; }
        public string master_key_id { get; set; }
        public string mfd_name { get; set; }
        public string MobileNo { get; set; }
        public string msg_flag { get; set; }
        public string MwithoutT { get; set; }
        public string MwithT { get; set; }
        public string NetSales { get; set; }
        public string NoS { get; set; }
        public string NPV { get; set; }
        public string NSV { get; set; }
        public string old_sale_inv_no { get; set; }
        public string order_no { get; set; }
        public string Pay_Mode { get; set; }
        public string payDetail { get; set; }
        public string paymode { get; set; }
        public string Pharma_Reg_No { get; set; }
        public string Phone { get; set; }
        public string prescribedBy { get; set; }
        public string promo_flag { get; set; }
        public string pt_name { get; set; }
        public string rcmOrderNo { get; set; }
        public string ref_name { get; set; }
        public string refCode { get; set; }
        public string reg_office { get; set; }
        public string sale_date { get; set; }
        public string sale_inv_no { get; set; }
        public string sale_trn_no { get; set; }
        public string sale_type { get; set; }
        public string salt_info { get; set; }
        public string SecondValue { get; set; }
        public string Shelf_No { get; set; }
        public string Shop_Name { get; set; }
        public string stateName { get; set; }
        public string sType { get; set; }
        public string SystemName { get; set; }
        public string tax { get; set; }
        public string tax_info { get; set; }
        public string ThiredValue { get; set; }
        public string tin_no { get; set; }
        public string Total { get; set; }
        public string unit_id { get; set; }
        public string unit_name { get; set; }
        public string remarks { get; set; }
        public string searchkey { get; set; }
        public System.Data.DataSet ds { get; set; }
    }
    public class pm_Authentication
    {
        public string emp_code { get; set; }
        public string old_password { get; set; }
        public string new_password { get; set; }
        public string unit_id { get; set; }
        public string manager_code { get; set; }
        public byte[] sign_image { get; set; }
        public string logic { get; set; }
        public string Login_id { get; set; }
        public DataSet ds { get; set; }
        public string prm1 { get; set; }
        public string prm2 { get; set; }
        public string machine_id { get; set; }
        public string new_version { get; set; }
        public string cur_version { get; set; }
        public DateTime checkedOn { get; set; }
    }
    public class sms
    {
        public string smsProvider { get; set; }
        public string templateID { get; set; }
        public string smsAPI { get; set; }
        public string smsID { get; set; }
        public string MobileNo { get; set; }
        public string msg { get; set; }
    }
    public class pm_promoQueries
    {
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string searchKey { get; set; }
        public decimal Disc_per { get; set; }
        public int qty { get; set; }
        public string Logic { get; set; }
        public string login_id { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string category { get; set; }
        public string master_key_id { get; set; }
        public string input_date { get; set; }
    }
    public class pm_salts
    {
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string salt_Code { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public int prm_2 { get; set; }
        public string salt_code { get; set; }
        public string Salt_Name { get; set; }
        public string result { get; set; }
        public string str_code { get; set; }
        public string str_type { get; set; }
        public decimal Strength { get; set; }
        public string login_id { get; set; }
    }
    public class pm_PurchaseReturn
    {
        public int ret_packs { get; set; }
        public string autoid { get; set; }
        public string origin { get; set; }
        public string order_no { get; set; }
        public string updateInfo { get; set; }
        public string item_id { get; set; }
        public string master_key_id { get; set; }
        public int qty { get; set; }
        public string unit_id { get; set; }
        public string logic { get; set; }
        public string master_gr_no { get; set; }
        public string sub_gr_no { get; set; }
        public string gr_no { get; set; }
        public string trf_id { get; set; }
        public string entryDate { get; set; }
        public string vendor_id { get; set; }
        public string login_id { get; set; }
        public string purch_id { get; set; }
        public int adj_pack { get; set; }
        public string party_name { get; set; }
        public decimal amount { get; set; }
    }
    public class pm_debitCreditNotes
    {
        public string unit_id { get; set; }
        public string logic { get; set; }
        public string Note_No { get; set; }
        public string entryDate { get; set; }
        public string vendor_id { get; set; }
        public string inv_no { get; set; }
        public string inv_date { get; set; }
        public string item_id { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string hsn { get; set; }
        public string batch_no { get; set; }
        public decimal qty { get; set; }
        public int taxid { get; set; }
        public decimal discount { get; set; }
        public string expdate { get; set; }
        public decimal mrp { get; set; }
        public decimal ptr { get; set; }
        public string pack_type { get; set; }
        public int pack_qty { get; set; }
        public string login_id { get; set; }
        public string debitNote_No { get; set; }
        public string debitNote_Date { get; set; }
        public string creditNote_No { get; set; }
        public string creditNote_Date { get; set; }
        public string autoId { get; set; }
        public string master_key_id { get; set; }
        public string org_saleInvNo { get; set; }
        public string searchkey { get; set; }

    }
    public class pm_Stocks
    {
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string master_key_id { get; set; }
        public string searchKey { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string dtFrom { get; set; }
        public int qty { get; set; }
        public string dtTo { get; set; }
        public string login_id { get; set; }
    }
    public class pm_Transfer
    {
        public string orderNo { get; set; }
        public string orderFor { get; set; }
        public string unit_id { get; set; }
        public string transfer_id { get; set; }
        public string transaction_id { get; set; }
        public string vendor_id { get; set; }
        public string tran_type { get; set; }
        public string TransferFromUnit { get; set; }
        public string TransferToUnit { get; set; }
        public string TrfUnit_AccountNo { get; set; }
        public string party_id { get; set; }
        public string party_account_no { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string prm_3 { get; set; }
        public string login_id { get; set; }
        public string dtFrom { get; set; }
        public string dtTo { get; set; }
        public string item_id { get; set; }
        public string master_key_id { get; set; }
        public int qty { get; set; }
        public string cart_name { get; set; }
        public string GenFrom { get; set; }
        public int RcptQty { get; set; }
        public string CheckFlag { get; set; }
    }

    public class pm_PurchaseOrders
    {
        public string unit_id { get; set; }
        public DataSet ds { get; set; }
        public string forunit { get; set; }
        public string processAverage { get; set; }
        public decimal orderFormonth { get; set; }
        public int nProduct { get; set; }
        public string order_no { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string dtfrom { get; set; }
        public string dtTo { get; set; }
        public string login_id { get; set; }
        public string SeltdUnits { get; set; }
      
    }
    public class pm_DailyDispatch
    {
        public string unit_id { get; set; }
        public string tounitid { get; set; }
        public string item_id { get; set; }
        public int QtyInPacks { get; set; }
        public string Logic { get; set; }
        public string login_id { get; set; }
    }
    public class pmOpenOrder
    {
        public string unit_id { get; set; }
        public string order_no { get; set; }
        public string vendorName { get; set; }
        public string contactNo { get; set; }
        public string email { get; set; }
        public string item_id { get; set; }
        public string item_name { get; set; }
        public string pack_size { get; set; }
        public int ord_qty { get; set; }
        public string ord_by { get; set; }
        public int sup_qty { get; set; }
        public string sup_chk_by { get; set; }
        public string logic { get; set; }
        public string login_id { get; set; }
        public string remarks { get; set; }
    }
    public class pm_MergePurchaseIDs
    {
        public string unit_id { get; set; }
        public string OldPurchId { get; set; }
        public string NewPurchId { get; set; }
        public string login_id { get; set; }
    }
    public class pm_BulkTrfSales
    {
        public string unit_id { get; set; }
        public string transfer_id { get; set; }
        public string order_no { get; set; }
        public string sold_to { get; set; }
        public string party_id { get; set; }
        public string account_id { get; set; }
        public string TransferToUnit { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string login_id { get; set; }
    }
    public class pm_SaltInfo
    {
        public string item_id { get; set; }
        public string salt_code { get; set; }
        public string Salt_Name { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public int prm_2 { get; set; }
        public string result { get; set; }
        public string str_code { get; set; }
        public string str_type { get; set; }
        public decimal Strength { get; set; }
        public string login_id { get; set; }
    }
    public class prm_newProduct
    {
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string item_name { get; set; }
        public int qty { get; set; }
        public string action_flag { get; set; }
        public string sale_inv_no { get; set; }
        public string order_no { get; set; }
        public string logic { get; set; }
        public string login_id { get; set; }
    }
    public class datasetWithResult
    {
        public DataSet result { get; set; }
        public string message { get; set; }
    }
    public class resultSetMIS
    {
        public DataSet ResultSet { get; set; }
        public string Msg { get; set; }
    }
    public class Search
    {
        public string unit_id { get; set; }
        public string Logic { get; set; }
        public string po_number { get; set; }
        public string SearchKey { get; set; }
        public string Prm_1 { get; set; }
        public string Prm_2 { get; set; }
        public string LoginId { get; set; }
    }
    public class purchSearch
    {
        public string unit_id { get; set; }
        public string purch_id { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string login_id { get; set; }
    }
    public class transferSearch
    {
        public string unit_id { get; set; }
        public string trf_id { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string login_id { get; set; }
    }
    public class productSearch
    {
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string searchKey { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string login_id { get; set; }
    }
    public class opoVerifiy
    {
        public string unit_id { get; set; }
        public string order_no { get; set; }
        public DataTable tblInfo { get; set; }
        public string login_id { get; set; }
    }
    public class poSearch
    {
        public string unit_id { get; set; }
        public string Logic { get; set; }
        public string po_number { get; set; }
        public string SearchKey { get; set; }
        public string Prm_1 { get; set; }
        public string Prm_2 { get; set; }
        public string LoginId { get; set; }
    }
    public class cm1
    {
        public string trf_tounit { get; set; }
        public string tran_id { get; set; }
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string Logic { get; set; }
        public string login_id { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string prm_3 { get; set; }
        public string prm_4 { get; set; }
        public string tranType { get; set; }
        public string FileOutPutType { get; set; }
    }
    public class cm2 : cm1
    {
        public string comp_id { get; set; }
        public string dtFrom { get; set; }
        public string dtTo { get; set; }
        public string batch_no { get; set; }
        public int mth { get; set; }
        public int qty { get; set; }

    }
    public class cm3 : cm2
    {
        public int prm_num { get; set; }
        public DataTable dt { get; set; }
    }
    public class RetailSaleBillPosting
    {
        public string unit_id { get; set; }
        public string estimateNo { get; set; }
        public string panelName { get; set; }
        public string computerName { get; set; }
        public string counter_id { get; set; }
        public string Sale_Inv_No { get; set; }
        public string pt_name { get; set; }
        public string gstn_no { get; set; }
        public string HealthCardNo { get; set; }
        public string Hosp_Cr_No { get; set; }
        public string Hosp_IPOP_No { get; set; }
        public string OrderNo { get; set; }
        public string hd_flag { get; set; }
        public string refBy { get; set; }
        public string ref_name { get; set; }
        public string login_id { get; set; }
        public string sale_type { get; set; }
        public string couponCode { get; set; }
        public string ContactNo { get; set; }
        public string loginName { get; set; }
        public List<BillPaymentInfo> BillPaymentDetail { get; set; }
    }
    public class SaleInvoiceFinalization
    {
        public string unit_id { get; set; }
        public string estimateNo { get; set; }
        public string panelName { get; set; }
        public string vendorID { get; set; }
        public string accountID { get; set; }
        public string purchaseID { get; set; }
        public string remarks { get; set; }
        public string computerName { get; set; }
        public string counter_id { get; set; }
        public string Sale_Inv_No { get; set; }
        public string pt_name { get; set; }
        public string gstn_no { get; set; }
        public string HealthCardNo { get; set; }
        public string Hosp_Cr_No { get; set; }
        public string Hosp_IPOP_No { get; set; }
        public string rcmOrderNo { get; set; }
        public string hd_flag { get; set; }
        public string refBy { get; set; }
        public string ref_name { get; set; }
        public string payMode { get; set; }
        public string payDetail { get; set; }
        public string login_id { get; set; }
        public string sale_type { get; set; }
        public string couponCode { get; set; }
        public string ContactNo { get; set; }
        public string swipeMacNo { get; set; }
        public string loginName { get; set; }
        public string isDischargeMedicine { get; set; }

        public List<BillPaymentInfo> BillPaymentDetail { get; set; }
    }
    public class BillPaymentInfo
    {
        public string unit_id { get; set; }
        public string InvNo { get; set; }
        public decimal TotalAmt { get; set; }
        public string PayMode { get; set; }
        public string AccountNo { get; set; }
        public decimal Amount { get; set; }
        public string referenceNo { get; set; }
        public string PayDetail { get; set; }
    }
    public class pm_InsertRetailSales
    {
        public string unit_id { get; set; }
        public string Sale_Type { get; set; }
        public string cust_name { get; set; }
        public string refCode { get; set; }
        public string prescribedBy { get; set; }
        public string item_id { get; set; }
        public string master_key_id { get; set; }
        public string card_no { get; set; }
        public string card_level { get; set; }
        public decimal discountPercent { get; set; }
        public double sold_qty { get; set; }
        public string old_sale_inv_no { get; set; }
        public string gstn_no { get; set; }
        public string hosp_cr_no { get; set; }
        public string hosp_ipop_no { get; set; }
        public string Cur_sale_inv_no { get; set; }
        public string DiscountLogic { get; set; }
        public string order_no { get; set; }
        public string promo_flag { get; set; }
        public string counter_id { get; set; }
        public string computer_id { get; set; }
        public string stateName { get; set; }
        public string login_id { get; set; }
        public string couponCode { get; set; }
        public string ContactNo { get; set; }
        public string accountID { get; set; }
        public string panelID { get; set; }
        public string panelName { get; set; }

    }
    public class LoginInfo
    {
        public string unit_id { get; set; }
        public string login_id { get; set; }
        public string password { get; set; }
        public string login_name { get; set; }
    }
    public class pm_SalesAction1
    {
        public string unit_id { get; set; }
        public string Sales_Inv_No { get; set; }
        public string order_no { get; set; }
        public string logic { get; set; }
        public string master_key_id { get; set; }
        public string Sale_Trn_No { get; set; }
        public string login_id { get; set; }
    }
    public class pm_SaleRegister
    {
        public string counter_id { get; set; }
        public string unit_id { get; set; }
        public string f_date { get; set; }
        public string l_date { get; set; }
        public string sType { get; set; }
        public string prm_1 { get; set; }
        public string login_id { get; set; }
    }
    public class pm_BillInfo
    {
        public string unit_id { get; set; }
        public string Bill_No { get; set; }
        public string login_id { get; set; }
        public string login_name { get; set; }
    }
    public class pm_IPOPQueries
    {
        public string unit_id { get; set; }
        public string card_no { get; set; }
        public string uhid { get; set; }
        public string IPOPNo { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string prm_1 { get; set; }
        public string logic { get; set; }
        public string login_id { get; set; }

    }
    public class pm_LockSalesInv
    {
        public string unit_id { get; set; }
        public string sale_inv_no { get; set; }
        public int action { get; set; }
        public string SystemName { get; set; }
        public string login_id { get; set; }

    }
    public class pm_UpdateIndent
    {
        //   unit_id,ipopno,indent_no,item_id,qty,prm_1,logic,login_id
        public string unit_id { get; set; }
        public string uhid { get; set; }
        public string remarks { get; set; }
        public string ipopno { get; set; }
        public string indent_no { get; set; }
        public string item_id { get; set; }
        public int qty { get; set; }
        public string prm_1 { get; set; }
        public string logic { get; set; }
        public string login_id { get; set; }
    }
    public class pm_FlexiDiscount
    {
        public string unit_id { get; set; }
        public string sale_inv_no { get; set; }
        public int FlexiDiscountAmt { get; set; }
        public string login_id { get; set; }
    }
    public class pm_AppVersion
    {
        public string unit_id { get; set; }
        public string machine_id { get; set; }
        public string new_version { get; set; }
        public string cur_version { get; set; }
        public DateTime checkedOn { get; set; }
    }
    public class pm_PullHISIndent
    {
        public string unit_id { get; set; }
        public string inputstring { get; set; }
        public string login_id { get; set; }
    }
    #region Purchase and Challan Method
    public class pm_PurchaseQueries
    {
        public string unit_id { get; set; }
        public string Purchase_id { get; set; }
        public string logic { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string login_id { get; set; }
    }
    public class pm_CheckBatchInfo
    {
        public string logic { get; set; }
        public string unit_id { get; set; }
        public string item_id { get; set; }
        public string batch_no { get; set; }
        public string login_id { get; set; }

    }
    public class pm_PurchaseInsert
    {
        public string unit_id { get; set; }
        public string order_no { get; set; }
        public string purch_id { get; set; }
        public string vendor_id { get; set; }
        public string inv_no { get; set; }
        public string inv_date { get; set; }
        public string item_id { get; set; }
        public string hsn { get; set; }
        public string batch_no { get; set; }
        public decimal qty { get; set; }
        public decimal free { get; set; }
        public int taxid { get; set; }
        public decimal dis { get; set; }
        public string expdate { get; set; }
        public decimal mrp { get; set; }
        public decimal ptr { get; set; }
        public string pack_type { get; set; }
        public int pack_qty { get; set; }
        public string barcode_no { get; set; }
        public string inv_type { get; set; }
        public string state { get; set; }
        public string login_id { get; set; }
    }
    public class pm_PurchaseDelete
    {
        public string unit_id { get; set; }
        public string purch_id { get; set; }
        public string master_key_id { get; set; }
        public string order_no { get; set; }
        public string item_id { get; set; }
        public string auto_id { get; set; }
        public int qty { get; set; }
        public string login_id { get; set; }
    }
    public class pm_PurchasePosting
    {
        public string unit_id { get; set; }
        public string purch_id { get; set; }
        public string credit_cash { get; set; }
        public string Chq_date { get; set; }
        public string Narration { get; set; }
        public string login_id { get; set; }
        public decimal adj_amt { get; set; }
        public decimal plusminus { get; set; }
        public string CrAdvLedger { get; set; }
        public string purch_By { get; set; }
        public string chkd_by { get; set; }
        public string tcs_flag { get; set; }
        public string ohCharges { get; set; }
        public string ohNature { get; set; }
    }
    public class pm_ChallanSettlement
    {
        public string unit_id { get; set; }
        public string challan_id { get; set; }
        public string purchase_id { get; set; }
        public string login_id { get; set; }
    }
    public class ipSms
    {
        public string MobileNo { get; set; }
        public string Message { get; set; }
    }
    #endregion
    #region MIS External APIs
    public class ipCardUpgrade
    {
        public string division { get; set; }
        public string unit_id { get; set; }
        public string sale_inv_no { get; set; }
        public string sale_Date { get; set; }
        public string order_no { get; set; }
        public string healthCardNo { get; set; }
        public string billAmt { get; set; }
    }
    public class ipHealthCard
    {
        public string unit_id { get; set; }
        public string card_no { get; set; }
        public string old_cardno { get; set; }
        public string mobile { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string login_id { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string Logic { get; set; }
    }
    public class ipCardDetail
    {
        public string unit_id { get; set; }
        public string card_no { get; set; }
        public string member_id { get; set; }
        public string m_type { get; set; }
        public string cust_name { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string mobileno { get; set; }
        public string area { get; set; }
        public string Locality { get; set; }
        public string district { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public string pin { get; set; }
        public string logic { get; set; }
        public string login_id { get; set; }

    }
    #endregion
    #region Menu
    public class pm_Insert_Modify_menu_master
    {
        public string isActive { get; set; }
        public string loginid { get; set; }
        public string AppName { get; set; }
        public string empCode { get; set; }
        public string cmd_name { get; set; }
        public string cmd_text { get; set; }
        public string grp_name { get; set; }
        public string grp_text { get; set; }
        public string element_name { get; set; }
        public string element_text { get; set; }
        public string element_name2 { get; set; }
        public string element_text2 { get; set; }
        public string Description { get; set; }
        public string Status_Flag { get; set; }
        public string Logic { get; set; }
    }
    public class pm_Menu_RightsQueries
    {
        public string unit_id { get; set; }
        public string emp_code { get; set; }
        public string element_name { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public int prm_3 { get; set; }
        public string Logic { get; set; }
    }
    #endregion
    #region Audit
    public class pm_Audit_Queries
    {
        public string unit_id { get; set; }
        public string logic { get; set; }
        public string audit_no { get; set; }
        public string keyString { get; set; }
        public string login_id { get; set; }
        public string item_id { get; set; }
        public string item_name { get; set; }
        public string master_key_id { get; set; }
        public int short_qty { get; set; }
        public int extra_qty { get; set; }
        public string m_batch { get; set; }
        public string m_expiry { get; set; }
        public string m_pack { get; set; }
        public string remarks { get; set; }
        public string prm_1 { get; set; }
        public string prm_2 { get; set; }
        public string prm_3 { get; set; }
    }
    #endregion

}
