using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Linq;
using System.Configuration;
using Telerik.WinControls;
using Telerik.Windows.Zip;
using System.Net;
using Microsoft.AspNet.SignalR.Client;

namespace eMediShop
{
    public partial class mainMenu : Telerik.WinControls.UI.RadRibbonForm
    {
        Size sz = new Size(); string _result = string.Empty;
        string sMesssage = string.Empty; string _MsgType = string.Empty;
        DataSet dsUpdates = new DataSet(); DataSet dsUnits = new DataSet();
        int x, y = 0; static IHubProxy _hub;

        public mainMenu()
        {
            InitializeComponent();
            setQuota();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            RadButtonElement buttonElement = new RadButtonElement("View Order/Indent");
            buttonElement.Click += new EventHandler(buttonElement_Click);
            this.radDesktopAlert1.ButtonItems.Add(buttonElement);

            radDesktopAlert1.Popup.MouseClick += new MouseEventHandler(Popup_Click);
            rtb_empCode.Focus();
            try
            {
                GlobalUsage.pharmacy_proxy = new Pharmacy.Pharmacy_WebServicesSoapClient();
           
                GlobalUsage.accounts_proxy = new rmAccounts.Accounts_WebServiceSoapClient();
                GlobalUsage.healthcard_proxy = new HealthCard.HealthCard_WebServicesSoapClient();
                GlobalUsage.his_proxy = new his_proxy.ChandanPharmacyServicesSoapClient();
            }
            catch (Exception ex) { RadMessageBox.Show("Service Proxy Not Initialized.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            try
            {
                GlobalUsage.ManualBill = new CrystalReportsPharmacy.eMediShop.ManualDeliveryNote();
                GlobalUsage.PharmacyCashMemo = new CrystalReportsPharmacy.eMediShop.CashMemoGST();
                GlobalUsage.HospitalCashMemo = new CrystalReportsPharmacy.eMediShop.HP_CashMemo();
                GlobalUsage.opthCashMemo = new CrystalReportsPharmacy.eMediShop.CashMemoGST_opthalmic();
                GlobalUsage.HospitalInternalSheet = new CrystalReportsPharmacy.eMediShop.HP_MedicineSearchSheet();
                GlobalUsage.HAL_DeliveryNote = new CrystalReportsPharmacy.eMediShop.DeliveryNote_HAL();
            }
            catch (Exception ex) { RadMessageBox.Show("Crystal Library Issue.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }

            try
            {
                GlobalUsage.UniqueMachineId = accounts_library.UniqueMachineId.GetMACAddress();
            }
            catch (Exception ex) { MessageBox.Show("Problem in accessing MAC Address"); }

            GlobalUsage.mainFormCaption = "eMediShop Ver. " + Application.ProductVersion.ToString() + ",   By : ExProLogics";
            this.Text = GlobalUsage.mainFormCaption;



            //For Login Box
            x = this.Width - (rgb_LoginBox.Width + 30);
            y = this.Height - (rgb_LoginBox.Height + 35);
            //rgb_LoginBox.Location = new Point(x, y);

            //x = this.Width - (radClock1.Width + 135);
            //y = this.Height - (radClock1.Height+35);
            //radClock1.Location = new Point(0,y);

            //Change Background of MDI Form
            MdiClient ctlMDI;
            // Loop through all of the form's controls looking
            // for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;
                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException ex)
                {
                    //MessageBox.Show(ex.Message, "ExPro Help");
                }
            }
            //End Change Background of MDI Form
            GlobalUsage.SoftRight = ConfigurationManager.AppSettings["SoftRights"].ToString();
            GlobalUsage.CounterID = ConfigurationManager.AppSettings["Counter-ID"].ToString();
       
            Version version = new Version(Application.ProductVersion);
            string appVersion = version.Major.ToString() + '.' + version.Minor.ToString();//+ '.' + version.Minor.ToString() + '.' + version.MinorRevision.ToString();
            rle_version.Text = Application.ProductName.ToString() + " Ver. " + Application.ProductVersion.ToString();

            DateTime buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            GlobalUsage.mainFormCaption = Application.ProductName.ToString() + " Ver. " + Application.ProductVersion.ToString();
            //SingnalR_Process();


        }
        private void SingnalR_Process() {
            try
            {
                var connection = new HubConnection(ConfigWebAPI.SingnalRServer);
                _hub = connection.CreateHubProxy("MyHub");
                connection.Start().Wait();
                _hub.On<string, string>("addMessage", (name, message) =>
                 this.Invoke((Action)(() => textBox1.Text = message))
                 );

                string line = null;
                while ((line = System.Console.ReadLine()) != null)
                {
                    _hub.Invoke("DetermineLength", line).Wait();
                }
            }
            catch (Exception ex) { }
            Console.Read();
        }
        private void buttonElement_Click(object sender, EventArgs e)
        {
            if (GlobalUsage.Unit_id == "MS-H0048")
                openForm(new eMediShop.forms.CentralAccess.RCM.IPDOPDProcessInfo("-", "Billing"));
            else
                openControl(new eMediShop.forms.CentralAccess.RCM.ucIncomingOrder(), "Order Receiving");
        }
        private void TransferInfoTo_ITS()
        {
            try
            {
                string macAddress = accounts_library.UniqueMachineId.GetMACAddress();
                string MachineName = Environment.MachineName.ToString();
                string appVersion = Application.ProductVersion.ToString();
                string appName = Application.ProductName.ToString();
                pm_AppVersion p = new pm_AppVersion();
                p.unit_id = GlobalUsage.Unit_id; p.machine_id = GlobalUsage.computerName; p.new_version = "-"; p.cur_version = appVersion; p.checkedOn = DateTime.Now;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/InsertModifyAppVersion", p);
            }
            catch (Exception ex) { }
        }
        private void rbt_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string unitcode = string.Empty;

                string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
                //GlobalUsage.MySystemIP = Dns.GetHostEntry(hostName).AddressList[1].ToString();

                string userName = string.Empty;
                Cursor.Current = Cursors.WaitCursor;
                LoginInfo p = new LoginInfo();
                p.login_id = rtb_empCode.Text; p.password = rtb_Password.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/authentication", p);
                string[] r = dwr.message.Split('|');

                if (DateTime.Today.ToString("yyyyMMdd") == r[1])
                {
                    dsUnits = dwr.result;
                    lblMessage.Text = _result;
                    #region Login authentication Process
                    if (r[0].Contains("Login Successfully"))
                    {
                        dsUnits = dwr.result;
                        userName = r[2];
                        rgb_LoginBox.Visible = false;
                        rle_User.Text = "     Login : " + userName;
                        GlobalUsage.Login_Name = userName;
                        rgv_UnitInfo.DataSource = dsUnits.Tables[0];

                        dsUnits.Tables[0].DefaultView.RowFilter = "default_flag = 'Y'";
                        DataTable dt = (dsUnits.Tables[0].DefaultView).ToTable();
                        if (dt.Rows.Count > 0)
                        {
                            SetUnitInfo(dt.Rows[0]["unit_id"].ToString());
                        }
                        else if (dsUnits.Tables[0].Rows.Count > 0)
                        {
                            SetUnitInfo(dsUnits.Tables[0].Rows[0]["unit_id"].ToString());
                        }
                        else
                        {
                            rbeChangeUnit.PerformClick();
                        }
                    }
                    else
                    {
                        rtb_empCode.Focus();
                    }
                    #endregion
                }
                else
                {
                    GlobalUsage.Login_id = rtb_empCode.Text;
                    rbe_ChangePassword_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                RadMessageBox.Show(ex.ToString(), "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                rtb_Password.Focus();

            }

        }
        public void ControlLog()
        {
            #region Command Tab Menu
            for (int i = 0; i < this.rrb_menu.CommandTabs.Count; i++)
            {
                RibbonTab ribbonTab = this.rrb_menu.CommandTabs[i] as RibbonTab;
                for (int j = 0; j < ribbonTab.Items.Count; j++)
                {
                    RadRibbonBarGroup ribbonBarGroup = ribbonTab.Items[j] as RadRibbonBarGroup;
                    pm_Insert_Modify_menu_master p = new pm_Insert_Modify_menu_master();
                    for (int k = 0; k < ribbonBarGroup.Items.Count; k++)
                    {
                        RadItem currentItem = ribbonBarGroup.Items[k];
                        if (currentItem.GetType().ToString() == "Telerik.WinControls.UI.RadButtonElement")
                        {
                            p.AppName = Application.ProductName; p.cmd_name = ribbonTab.Name.ToString(); p.cmd_text = ribbonTab.Text;
                            p.grp_name = ribbonBarGroup.Name.ToString(); p.grp_text = ribbonBarGroup.Text; p.element_name = currentItem.Name.ToString();
                            p.element_text = currentItem.Text; p.element_name2 = "-"; p.element_text2 = "-"; p.Description = "-";
                            p.Status_Flag = "Y"; p.Logic = "Insert";
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/menu/InsertModifymenumasterEMediShop", p);

                        }
                        else if (currentItem.GetType().ToString() == "Telerik.WinControls.UI.RadRibbonBarButtonGroup")
                        {
                            RadRibbonBarButtonGroup ribbonBarButtonGroup = ribbonBarGroup.Items[k] as RadRibbonBarButtonGroup;
                            for (int l = 0; l < ribbonBarButtonGroup.Items.Count; l++)
                            {
                                RadItem currentItem2 = ribbonBarButtonGroup.Items[l];
                                if (currentItem2.GetType().ToString() == "Telerik.WinControls.UI.RadButtonElement")
                                {
                                    if (currentItem2.Text.Contains("Import From"))
                                    {
                                        p.AppName = Application.ProductName; p.cmd_name = ribbonTab.Name.ToString(); p.cmd_text = ribbonTab.Text;
                                        p.grp_name = ribbonBarGroup.Name.ToString(); p.grp_text = ribbonBarGroup.Text; p.element_name = currentItem.Name.ToString();
                                        p.element_text = currentItem.Text; p.element_name2 = currentItem2.Name.ToString(); p.element_text2 = currentItem2.Text;
                                        p.Description = "-"; p.Status_Flag = "Y"; p.Logic = "Insert";

                                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/menu/InsertModifymenumasterEMediShop", p);
                                                            }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
        }
    
        private void EnableAccordingToRights()
        {
            try
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "RetailMenuRights"; p.prm_1 = "-"; p.prm_2 = "-"; p.prm_3 = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/retailstorequeries", p);
                var menu = dwr.result.Tables[0].AsEnumerable()
                .Select(o => new
                {
                    menuName = o.Field<string>("element_name"),
                    allow_flag = o.Field<string>("allow")
                }).ToList();

                foreach (RadElement el in rrb_menu.RootElement.ChildrenHierarchy)
                {
                    if (el.GetType().ToString() == "Telerik.WinControls.UI.RadButtonElement")
                    {
                        string d = el.GetType().ToString();
                        var T = menu.Where(X => X.menuName == el.Name && X.allow_flag == "Y");
                        if (T.Count() > 0)
                        {
                            rrb_menu.Enabled = true;
                            el.Enabled = true;
                        }
                        else
                            el.Enabled = false;
                    }
                    else if (el.GetType().ToString() == "Telerik.WinControls.UI.RadRibbonBarButtonGroup")
                    {
                        RadRibbonBarButtonGroup ribbonBarButtonGroup = el as RadRibbonBarButtonGroup;
                        for (int l = 0; l < ribbonBarButtonGroup.Items.Count; l++)
                        {
                            RadItem currentItem2 = ribbonBarButtonGroup.Items[l];
                            if (currentItem2.GetType().ToString() == "Telerik.WinControls.UI.RadButtonElement")
                            {
                                var T = menu.Where(X => X.menuName == currentItem2.Name && X.allow_flag == "Y");
                                if (T.Count() > 0)
                                {
                                    rrb_menu.Enabled = true;
                                    currentItem2.Enabled = true;
                                }
                                else
                                    currentItem2.Enabled = false;
                            }
                        }
                    }
                }

                #region quick Access Tool Bar
                for (int i = 0; i < this.rrb_menu.QuickAccessToolBar.Items.Count; i++)
                {
                    RadItem currentItem = rrb_menu.QuickAccessToolBar.Items[i];
                    currentItem.Enabled = true;
                }
                #endregion
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { System.Windows.Forms.Cursor.Current = Cursors.Default; }
            //rbe_saltreport.Enabled = true;
        }

        private void rtb_empCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                rtb_Password.Focus();
        }

        private void rtb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                rbt_Submit.Focus();
        }

        #region Products Menu
        private void rbe_Products_New_New_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            forms.Product.ucNewMedicine uc = new forms.Product.ucNewMedicine();
            masterContainer UseForm = new masterContainer(uc, "New Product");
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void rbe_product_new_marklocal_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            forms.Product.ucMarkLocal uc = new forms.Product.ucMarkLocal();
            masterContainer UseForm = new masterContainer(uc, "Mark Local Product In New");
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }
        private void rbe_product_new_update_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            forms.Product.ucTrfNewMedicine uc = new forms.Product.ucTrfNewMedicine();
            masterContainer UseForm = new masterContainer(uc, "Mark Local Product In New");
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }

        #endregion

        private void rbe_product_locationSeting_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            forms.Product.ucChangeLocation uc = new forms.Product.ucChangeLocation();
            masterContainer UseForm = new masterContainer(uc, "Set Location For The Product");
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }


        private void rbe_prod_corr_properties_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            forms.Product.ucBatchExpMrpCorrection uc = new forms.Product.ucBatchExpMrpCorrection();
            masterContainer UseForm = new masterContainer(uc, "Batch, Expiry and MRP Correction");
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }


        private void openControl(UserControl uc, string Heading)
        {
            Cursor.Current = Cursors.WaitCursor;
            masterContainer UseForm = new masterContainer(uc, Heading);
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void openForm(Form UseForm)
        {
            Cursor.Current = Cursors.WaitCursor;
            UseForm.Owner = this;
            UseForm.Show();
            Cursor.Current = Cursors.Default;
        }
        #region Sales
        private void rbe_sales_pharmacy_Click(object sender, EventArgs e)
        {
            //openForm(new SaleMaster("New Invoice"));
            openForm(new sales.SaleMaster("Direct","New Invoice"));

        }

        private void rbe_sales_hospital_Click(object sender, EventArgs e)
        {

        }

        private void rbe_saleRegister_Click(object sender, EventArgs e)
        {
            openForm(new SaleRegister());
        }

        private void rbe_Sales_Analysis_Products_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.Sales.uc_SoldProductsInfo(), "Sold Product Movement Report");
        }
        #endregion

        #region Purchase Menu
        private void rbe_Purch_Bills_Feeding_Click(object sender, EventArgs e)
        {
            openForm(new Purchase_Entry());
        }

        private void rbe_purch_bill_ScanCopy_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Purchase.ucSendScanBill(), "Upload Scan Purchase Bills");
        }

        private void rbe_purch_Bill_unposted_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.forms.CentralAccess.Purchase.UnPostedBill());
        }

        private void rbe_PO_Click(object sender, EventArgs e)
        {
            openForm(new Zero_Stock_Order());
        }


        private void rbe_purch_lp_help_Click(object sender, EventArgs e)
        {
            openForm(new PurchaseHelp());
        }

        private void rbe_purch_lp_CheckList_Click(object sender, EventArgs e)
        {
            openForm(new IsCorrectPurchase());
        }

        private void rrbg_purch_Analysis_Products_Click(object sender, EventArgs e)
        {
            openForm(new GetPurchaseInfo());
        }


        private void rrbg_purch_Vendor_New_Click(object sender, EventArgs e)
        {
            openForm(new VendorApp());
        }

        private void rrbg_purch_Vendor_Register_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Inventory Menu Option
        private void rrbg_inv_rt_Receive_Click(object sender, EventArgs e)
        {
            openControl(new forms.TransferIds.uc_ImportTransferId(), "Stock Receving Window");
        }

        private void rrbg_inv_rt_Transfer_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Stock.ucStockTransfer("InterUnitStockTransfer"), "Inter Unit Stocks Transfer Window");
        }

        private void rrbg_GR_gr1_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Stock.ucStockTransfer("Purchase Return"), "Goods Return To Original Vendor");
        }

        private void rrbg_GR_gr2_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Stock.ucStockTransfer("Purchase Return By Vendor"), "Goods Return To Selected Vendor");
        }

        private void rrbg_GR_slip_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Stock.ucPurchaseReturnSlip(), "Goods Return Slip By Vendor");
        }

        private void rrbg_inv_exp_Local_Click(object sender, EventArgs e)
        {
            openControl(new forms.Stock.ucExpiryProcess("LP-EXPIRY"), "Local Purchase Expiry Process");
        }

        private void rrbg_inv_exp_Other_Click(object sender, EventArgs e)
        {
            openControl(new forms.Stock.ucExpiryProcess("OT-EXPIRY"), "Other Units Purchased Product Expiry Transfer To Linked  Warehouse");
        }

        private void rrbg_inv_exp_register_Click(object sender, EventArgs e)
        {
            openControl(new forms.Stock.ucGR_Report("LP-EXPIRY"), "Expiry Return Register");
        }



        private void rrbg_inv_rt_Receive_Verify_Click(object sender, EventArgs e)
        {
            openForm(new forms.Stock.StockRcvdInfoByDateAndIds());
        }
        #endregion

        #region Accounts
        private void Acc_CEA_New_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.ucNewCashOutApproval(GlobalUsage.Unit_id, GlobalUsage.Unit_id, "Pharmacy", GlobalUsage.Login_id), "New Expense Approval");
        }

        private void Acc_CEA_Import_Click(object sender, EventArgs e)
        {
            openControl(new ucImportApprovals(), "Check & Import Approvals");
        }

        private void Acc_CEA_Register_Click(object sender, EventArgs e)
        {
            openControl(new ucApprovalReport(), "Approval Register");
        }
        private void rbe_ac_contra_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.Contra_Voucher(GlobalUsage.Unit_id, "eAccounts", GlobalUsage.Login_id), "Contra Voucher");
        }


        private void rbe_ac_Journal_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.Journal_Voucher(GlobalUsage.Unit_id, "eAccounts", GlobalUsage.Login_id), "Journal Voucher");
        }

        private void rbe_ac_Payments_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.Payment_Voucher(GlobalUsage.Unit_id, "eAccounts", GlobalUsage.Login_id), "Payment Voucher");
        }

        private void rbe_ac_Receipt_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.Receipt_Voucher(GlobalUsage.Unit_id, "eAccounts", GlobalUsage.Login_id), "Receipt Voucher");
        }

        private void rbe_ac_VewLedger_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.View_Accounts(GlobalUsage.UnitName, GlobalUsage.UnitAddress, GlobalUsage.Unit_id, "eAccounts", GlobalUsage.Login_id, "LOCAL", GlobalUsage.Rights, "Pharmacy"), "Display Ledger");
        }

        private void rbe_ac_Import_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.ucImportSingleLedger(GlobalUsage.Unit_id, "eAccounts"), "Import Ledger");
        }
        #endregion
        //===================================================
        private void rrbg_sales_help_Stocks_Click(object sender, EventArgs e)
        {
            openForm(new CheckMedicineAtStores());
        }

        private void rrbg_sales_help_InTransit_Click(object sender, EventArgs e)
        {
            openControl(new forms.TransferIds.ucSearchInTransit(), "Search In Transit Stocks");
        }

        private void rbe_product_Misc_Promo_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.Promo.ucPromoProducts(), "Promotional Information");
        }
        //CGHS
        private void rbe_Calculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                GlobalUsage.ViewStatus = "No";
                object o = new object();
                string qry = "select * from popupmsg where msgflag='Y' and unit_id='" + GlobalUsage.Unit_id + "' order by msgHead  ";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/utility/GetQueryResult?qry=" + qry, o);
                dsUpdates = dwr.result;
            }
            catch (Exception ex) { }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CompleteNotification();
        }
        private void CompleteNotification()
        {

            try
            {
                sMesssage = string.Empty; _MsgType = string.Empty;
                #region Notification Information
                if (dsUpdates.Tables.Count > 0 && dsUpdates.Tables[0].Rows.Count > 0)
                {
                    #region Notification Alert
                    if (GlobalUsage.ViewStatus == "No")
                    {
                        if (dsUpdates.Tables[0].Rows.Count > 0)
                        {
                            int t = 0;
                            foreach (DataRow dr in dsUpdates.Tables[0].Rows)
                            {
                                if (t > 0)
                                { 
                                    sMesssage += "/";
                                    _MsgType += "/";
                                }

                                sMesssage += dr["msgtext"].ToString();//Environment.NewLine;
                                _MsgType += dr["msghead"].ToString(); // +Environment.NewLine;
                                t++;
                            }

                            radDesktopAlert1.CaptionText = _MsgType;// "Orders/Indents";
                            radDesktopAlert1.ContentText = sMesssage;
                            radDesktopAlert1.Show();
                        }
                    }
                    #endregion

                }
                #endregion
            }
            catch (Exception) { }
            finally { timer1.Start(); }
        }
        void Popup_Click(object sender, MouseEventArgs e)
        {
            DesktopAlertPopup popup = (DesktopAlertPopup)sender;

            if (!(popup.ElementTree.GetElementAtPoint(e.Location) is RadButtonElement))
            {
                if (popup.ContentText.Contains("Order"))
                {
                    openControl(new eMediShop.forms.CentralAccess.RCM.ucIncomingOrder(), "Order Receiving");
                }
            }
        }
     

        private void radLabelElement1_Click(object sender, EventArgs e)
        {

        }
        #region Consumables





        #endregion
        #region Audit


        private void rbe_audit_FixLooseExpiry_Click(object sender, EventArgs e)
        {
            //openControl(new forms.Audit.ucFixLooseExpiry(), "Audit: Fix Loose Expiry");
            openControl(new forms.Stock.ucExpiryProcess("LooseExpiry"), "Audit: Fix Loose Expiry");
        }


        #endregion
        //Staff Options


        private void rrbg_GroupComp_Upload_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.GC.ucGCUpdReport(), "Govt. Compliances Related Information");
        }

        private void rb_gc_Misc_Reports_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.GC.uc_Miscellenious(), "Govt. Compliances Related Reports");
        }

        private void rbe_legal_InfoUpload_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.GC.ucGC_Legallogin(), "Other Than Govt. Compliances Information e.g. Labour Notice, Sales Tax Notice, Income Tax Notice etc.");
        }





        private void inv_ana_curStocks_Click(object sender, EventArgs e)
        {
            openControl(new forms.Stock.uc_StocksAsOn(), "Current Stocks Value");
        }
        //System



        //Customer Care
        private void rbe_hc_New_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.HealthCards.ucNewCardEntry(), "Health Card : New Entry");
        }

        private void rbe_card_update_Click(object sender, EventArgs e)
        {
            //openControl(new eMediShop.forms.CentralAccess.HealthCards.ucUpdateCard(), "Health Card : Update Information");
          
        }

        private void rbe_card_status_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.HealthCards.ucCheckCardStatus(), "Health Card : Status");
        }

        private void rbe_card_dist_report_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.HealthCards.ucDistributionReport(), "Health Card : Distribution Report");
        }

        private void rbe_hc_calling_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.RCM.RCMarkCustomer());
        }

        private void rbe_ord_receive_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.RCM.ucIncomingOrder(), "Order Receiving");
        }

        private void rbe_ord_process_Click(object sender, EventArgs e)
        {
            // openForm(new eMediShop.forms.CentralAccess.RCM.ProcessOrder());
            openForm(new eMediShop.sales.ProcessOrder());
        }

        private void rbe_ord_complete_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.RCM.ucCompleteOrder(), "Complete Order");
        }

        private void rbe_mo_new_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.RCM.ucTakeOrder(), "New Order Taking");
        }

        private void rbe_audit_ids_Click(object sender, EventArgs e)
        {
            //openControl(new eMediShop.forms.Audit.uc_AuditTransferIds(), "Audit Transfer Ids: Transfer & Receiving");
        }

      

        private void rbe_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword UseForm = new ChangePassword(GlobalUsage.Login_id);
            UseForm.Owner = this;
            UseForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            UseForm.Show();
        }



        private void rbe_db_project_Click(object sender, EventArgs e)
        {
            openForm(new Download_App());
        }

        private void rbe_deleteXML_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string[] filePaths = Directory.GetFiles(Application.StartupPath, "*.xml");
                foreach (string s in filePaths)
                {
                    File.Delete(s);
                }
                MessageBox.Show("Succsessfully Reset.", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Cursor.Current = Cursors.Default;

        }


        private void rbe_purch_Register_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.Purchase.uc_PurchaseRegister(), "Purchase Register");
        }

        private void rbe_product_report_HighSelling_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.Audit.ucHSP_ManualAudit(), "High Selling Product In Given Days");
        }

        private void rbe_product_report_SoldItems_Click(object sender, EventArgs e)
        {

        }



        private void rbe_purch_LP_ZeroStocks_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.Purchase.ucZeroStockProduct(), "Zero Stock : By Sales In Given Date");
        }
        //============================================= Assets=================================================
        #region Assets Management
        private void asset_new_Click(object sender, EventArgs e)
        {
            openControl(new Asset.ucLodgeComplaint(), "Generate New Complaint");
        }

        private void asset_status_Click(object sender, EventArgs e)
        {
            openControl(new Asset.ucComplaintStatus(), "Complaint Status");
        }

        private void asset_pending_Click(object sender, EventArgs e)
        {
            openControl(new Asset.ucNotClosedComplaint(), "Not Closed Complaint Information");
        }

        private void assetTransfer_Click(object sender, EventArgs e)
        {
            openControl(new Asset.ucTransferAsset(), "Transfer Asset To Other Unit");
        }

        private void asset_TransferForm_Click(object sender, EventArgs e)
        {
            openControl(new Asset.ucPrintTransferForm(), "Printing of Asset Transfer Form");
        }

        private void assets_attach_Click(object sender, EventArgs e)
        {
            openControl(new Asset.ucAttachSubAsset(), "Attach Sub Asset In Parent Asset");
        }

        private void asset_register_Click(object sender, EventArgs e)
        {
            openControl(new ucAssetList(), "Asset Register");
        }
        #endregion 

        private void rrbg_inv_rt_Register_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Stock.uc_TransferRegister(), "Transfer Register");
        }

        private void inv_anls_expiry_Click(object sender, EventArgs e)
        {
            openControl(new forms.Stock.uc_ShortExpiryList(), "Expiry Analysis");
        }



        private void sales_help_SearchBill_Click(object sender, EventArgs e)
        {
            openForm(new ProductOnSaleInvoice());
        }






        private void rbe_UpdateSoftware_Click(object sender, EventArgs e)
        {
            openForm(new AutoUpdater());
        }

        private void inv_Ana_UnResolved_Click(object sender, EventArgs e)
        {
            openForm(new forms.Reconcilation.HoldIdManagement());
        }

        private void sales_promo_generic_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.Promo.uc_GenericPromo(), "Generic Product Promotion Report");
        }

        private void rbe_Manual_Click(object sender, EventArgs e)
        {
            openForm(new HelpManual());
        }
        
        private void sales_Dosctor_manage_Click(object sender, EventArgs e)
        {
    
            openControl(new eMediShop.forms.Product.ucRefDataProcess(), "Prescriber Information");
        }



        private void rbe_sales_CardStatus_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.HealthCards.ucCheckCardStatus(), "Health Card : Status");
        }

        private void rrb_menu_Click(object sender, EventArgs e)
        {

        }

        private void rbe_purch_CheckBPO_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.Purchase.ucBulkOrderChecking(), "Bulk Order Purchase Checking");
        }

        private void rbe_purch_BulkPO_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.forms.CentralAccess.Purchase.Gen_UnitOrder());
        }

        private void rbe_audit_Report_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.Audit.AuditMaster());
        }

        private void rbe_Theme1_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = "Office2010Blue";
        }

        private void rbe_Theme2_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = "Windows7";
        }

        private void rbe_Theme3_Click(object sender, EventArgs e)
        {
            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = "Windows8";
        }

        private void mainMenu_LocationChanged(object sender, EventArgs e)
        {

        }
        //=================================================eof Asset Tarnsfer



        protected void setQuota()
        {
            System.ServiceModel.BasicHttpBinding bind = new System.ServiceModel.BasicHttpBinding();
            bind.CloseTimeout.Equals("01:10:00");
            bind.OpenTimeout.Equals("01:10:00");
            bind.ReceiveTimeout.Equals("00:40:00");
            bind.SendTimeout.Equals("00:40:00");
            bind.AllowCookies = false;
            bind.BypassProxyOnLocal = false;
            bind.HostNameComparisonMode.Equals("StrongWildcard");

            bind.ReaderQuotas.MaxStringContentLength = 2147483647;
            bind.ReaderQuotas.MaxArrayLength = 2147483647;
            bind.ReaderQuotas.MaxNameTableCharCount = 2147483647;
            bind.MaxBufferPoolSize = 2147483647;
            bind.MaxBufferSize = 2147483647;
            bind.MaxReceivedMessageSize = 2147483647;
        }





        private void prod_rep_expProd_Click(object sender, EventArgs e)
        {
            openControl(new uc_ExpensiveItems(), "Expensive Products Information");
        }

        private void prod_rep_SalesAverage_Click(object sender, EventArgs e)
        {
            openForm(new forms.CentralAccess.Product.allunitSalesAverage());
        }

        private void cc_mo_stockStatus_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.RCM.uc_GenOnlineOrderPO(GlobalUsage.Unit_id), "Stock Status of Order");
        }



        private void rbe_training_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.forms.Training.TrainingInfo());
        }

        private void rbe_FromStore_Click(object sender, EventArgs e)
        {
            //openControl(new eMediShop.cghs.ucProductFromStore(), "CGHS:Product Consider In Order, Available in Store");
        }




        private void rbe_help_HoldBills_Click(object sender, EventArgs e)
        {
            openForm(new forms.Reconcilation.HoldIdManagement());
        }



        private void rbe_prov_bill_Click(object sender, EventArgs e)
        {
            openForm(new forms.Sales.ProvisionalReceipt());
        }

        private void rbe_CreateSend_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.forms.Product.UploadSubstitute_Doc());
        }

        private void rbeUpdatesRights_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.forms.Utility.menuRights());
        }












        private void rbe_blockProducts_Click(object sender, EventArgs e)
        {
            openForm(new forms.Product.BlockedProducts());
        }



        private void rbe_healthCardStockRegister_Click(object sender, EventArgs e)
        {
            //openControl(new forms.HealthCards.ucHealthCardStockRegister(), "Health Card Stocks");
        }

        private void rbe_analisedGR_Click(object sender, EventArgs e)
        {
            openControl(new GR.ucAnalisedPurchaseReturn(), "Purchase Return Product Forced By Central Management");
        }

        private void rbe_Generic_Click(object sender, EventArgs e)
        {

        }

        //private static void SaveFile(ZipPackageEntry entry, string folderPath)
        //{

        //    Stream stream = entry.OpenInputStream();
        //    var fileName = folderPath + "\\" + entry.FileNameInZip;

        //    var directoryName = Path.GetDirectoryName(fileName);

        //    if (directoryName != null)
        //    {
        //        if (!Directory.Exists(directoryName))
        //        {
        //            Directory.CreateDirectory(directoryName);
        //        }

        //        StreamReader reader = new StreamReader(stream);
        //        string text = reader.ReadToEnd();
        //        File.WriteAllText(fileName, text);
        //    }
        //}

        private void rbe_taxCalculator_Click(object sender, EventArgs e)
        {

        }

        private void rbeTHS_Click(object sender, EventArgs e)
        {


        }
        public byte[] Get_ZipReconcileMasterKey_Summary(DataSet ds, string filename)
        {
            string processInfo = "";
            byte[] data = null;
            try
            {

                string path_xml = System.Windows.Forms.Application.StartupPath + "\\" + GlobalUsage.Unit_id.Replace("-", "") + "\\" + filename + ".xml";
                string path_zip = System.Windows.Forms.Application.StartupPath + "\\" + GlobalUsage.Unit_id.Replace("-", "") + ".Zip";

                if (!Directory.Exists(System.Windows.Forms.Application.StartupPath + "\\" + GlobalUsage.Unit_id.Replace("-", "") + "\\"))
                    Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath + "\\" + GlobalUsage.Unit_id.Replace("-", "") + "\\");
                ds.WriteXml(path_xml);
                CreateZipFileFromDirectory(System.Windows.Forms.Application.StartupPath + "\\" + GlobalUsage.Unit_id.Replace("-", "") + "\\", path_zip, "");
                data = System.IO.File.ReadAllBytes(path_zip);
                System.IO.File.Delete(path_zip);
                System.IO.File.Delete(path_xml);
                processInfo = "No Error";
            }
            catch (Exception Ex)
            {
                processInfo = Ex.ToString();
            }
            return data;
        }
        private string CreateZipFileFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, string password)
        {
            string result = "";
            try
            {
                char[] directorySeparatorChar = new char[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar };
                if (!string.IsNullOrEmpty(sourceDirectoryName))
                {
                    using (FileStream archiveStream = File.Open(
                        destinationArchiveFileName,
                        FileMode.Create))
                    {
                        //Set password to protect ZIP archive
                        //DefaultEncryptionSettings encryptionSettings = new DefaultEncryptionSettings();
                        //encryptionSettings.Password = password;

                        using (ZipArchive archive = new ZipArchive(
                            archiveStream,
                            ZipArchiveMode.Create,
                            true,
                            null,
                            null,
                            null))
                        {
                            foreach (string fileName in Directory.GetFiles(sourceDirectoryName))
                            {
                                using (FileStream file = File.OpenRead(fileName))
                                {
                                    int length = fileName.Length - sourceDirectoryName.Length;
                                    string entryName = fileName.Substring(sourceDirectoryName.Length, length);
                                    entryName = entryName.TrimStart(directorySeparatorChar);

                                    using (ZipArchiveEntry entry = archive.CreateEntry(entryName))
                                    {
                                        using (Stream entryStream = entry.Open())
                                        {
                                            file.CopyTo(entryStream);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Directory.Delete(sourceDirectoryName);
            }
            catch (Exception ex)
            {
                result = ex.Message;

            }
            return result;
        }

        private void rbe_aud_XtraByPurchase_Click(object sender, EventArgs e)
        {
            openForm(new forms.Audit.ImportXtraByPurchase());
        }

        private void rbe_isic_bills_Click(object sender, EventArgs e)
        {

        }



        private void rbeInToStocks_Click(object sender, EventArgs e)
        {
            openControl(new uc_ImportPurchaseid(), "Take Product In Stock");

        }

        private void rbe_cn_feeding_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.creditNote.CreditNote_Entries());

        }

        private void MasterTemplate_CommandCellClick(object sender, GridViewCellEventArgs e)
        {

            SetUnitInfo(e.Row.Cells[0].Value.ToString());
            CloseAllOpenForm();
        }
        private void CloseAllOpenForm()
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form thisForm in forms)
            {
                if (thisForm.Name != "mainMenu") thisForm.Close();
            }
        }
        private void SetUnitInfo(string selUnitId)
        {
            #region Load basic Information
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                rgb_SelectUnit.Visible = false;
                GlobalUsage.Unit_id = selUnitId;

                dsUnits.Tables[0].DefaultView.RowFilter = "unit_id = '" + GlobalUsage.Unit_id + "'";
                DataTable dt = (dsUnits.Tables[0].DefaultView).ToTable();
                GlobalUsage.ClosingDate = Convert.ToDateTime(dsUnits.Tables[0].Rows[0]["Stock_Closing_Date"]).ToString("yyyy/MM/dd");
                GlobalUsage.Unit_id = dt.Rows[0]["unit_id"].ToString();
                GlobalUsage.Comp_id = dt.Rows[0]["comp_id"].ToString();
                GlobalUsage.Company = dt.Rows[0]["comp_name"].ToString();
                GlobalUsage.UnitName = dt.Rows[0]["unit_name"].ToString();
                GlobalUsage.DL_No = dt.Rows[0]["drug_lic_no"].ToString();
                GlobalUsage.GST_No = dt.Rows[0]["gstn_no"].ToString();
                GlobalUsage.CIN_No = dt.Rows[0]["cin_no"].ToString();
                GlobalUsage.Warehouse_id = dt.Rows[0]["wh_id"].ToString();
                GlobalUsage.UnitAddress = dt.Rows[0]["unit_address"].ToString();
                GlobalUsage.CashMemoAddress = dt.Rows[0]["unit_address"].ToString();
                GlobalUsage.ContactNo = dt.Rows[0]["mobile"].ToString();
                GlobalUsage.District = dt.Rows[0]["city"].ToString();
                GlobalUsage.State = dt.Rows[0]["state_name"].ToString();
                GlobalUsage.SmsAPI= dt.Rows[0]["smsAPI"].ToString();
                GlobalUsage.SmsID = dt.Rows[0]["SMS_ID"].ToString();
                GlobalUsage.smsProvider = dt.Rows[0]["sms_provider"].ToString();

                this.rrb_menu.Text = GlobalUsage.UnitName + " [" + GlobalUsage.Unit_id + "], " + GlobalUsage.UnitAddress;
                GlobalUsage.PrinterType = "LASER";
                rbbg_SalesMaster.Enabled = true;
                if (Convert.ToDecimal(dt.Rows[0]["expiredin"].ToString()) < Convert.ToDecimal(dt.Rows[0]["alertdays"].ToString()))
                {
                    MessageBox.Show("License Validity is " + Convert.ToDecimal(dt.Rows[0]["expiredin"].ToString()).ToString("##"), "ExPro Help", MessageBoxButtons.OK);
                }
                #endregion
                #region After Success Login Body
                ((RibbonTab)rrb_menu.CommandTabs["rt_Sales"]).IsSelected = true;
                timer1.Enabled = true; timer1.Start();

                backgroundWorker1.RunWorkerAsync();

                GlobalUsage.Login_id = rtb_empCode.Text.ToUpper();
                GlobalUsage.Rights = "N/A";
                GlobalUsage.Billing_Rights = dt.Rows[0]["billing_flag"].ToString();
                GlobalUsage.Dispatch_Rights = dt.Rows[0]["dispatch_flag"].ToString();
                GlobalUsage.Posting_Rights = dt.Rows[0]["posting_flag"].ToString();

                //Transfer Information to IT Section
                TransferInfoTo_ITS();


                if (GlobalUsage.Login_id == "CHCL-00009" )
                {
                    try
                    {
                        DialogResult res = RadMessageBox.Show("Do You want to rebuild Menu ? ", "ExPro Help", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            ControlLog();
                            Cursor.Current = Cursors.Default;
                        }
                    }
                    catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
                    finally { Cursor.Current = Cursors.Default; }


                };



                rrb_menu.Enabled = true;

                EnableAccordingToRights();
                if (Application.ProductVersion != dt.Rows[0]["cur_version"].ToString())
                {
                    rbe_UpdateSoftware.PerformClick();
                }
                #region Remove Default Unit
                dsUnits.Tables[0].DefaultView.RowFilter = "1=1";
                #endregion
                // rbeUpdatesRights.Enabled = true;
                //rb_assign_menu.Enabled = true;

                #endregion
            }
            catch (Exception ex) { RadMessageBox.Show("Try Login After Sometimes", "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rt_Sales_Click(object sender, EventArgs e)
        {

        }

        private void rbe_ImportCSV_Click(object sender, EventArgs e)
        {

        }

        private void rbe_NewItems_Click(object sender, EventArgs e)
        {

        }

        private void rbe_MrpCheck_Click(object sender, EventArgs e)
        {

        }

        private void rbe_CurrentPO_Click(object sender, EventArgs e)
        {

        }

        private void rbe_PendingPO_Click(object sender, EventArgs e)
        {

        }

        private void rbe_PendingRegister_Click(object sender, EventArgs e)
        {

        }

        private void rbe_cghs_staffCard_Click(object sender, EventArgs e)
        {

        }

        private void rbe_cghsProdRegister_Click(object sender, EventArgs e)
        {

        }

        private void rbe_cghs_nc_register_Click(object sender, EventArgs e)
        {

        }

        private void cghs_purchMatching_Click(object sender, EventArgs e)
        {

        }

        private void cghs_Distribution_Click(object sender, EventArgs e)
        {

        }

        private void cghs_nw_closingSheet_Click(object sender, EventArgs e)
        {

        }

        private void cghs_DistributeFromStore_Click(object sender, EventArgs e)
        {

        }

        private void rbe_product_report_NotSold_Click_1(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.Product.ucProductNotSold(), "Product Not Sold : as Given Condition");
        }

        private void inv_anl_salesavg_Click(object sender, EventArgs e)
        {

        }

        private void rbe_transferByPurchaseid_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.Stock.ucStockTransfer(), "Stock Tranfsre Option By Purchase id's");
        }

        private void rbe_TransferPaper_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.PrintMaster.uc_idPrintig(), "Stock Transfer:Printing of Forms");
        }

        private void rbe_unitallotment_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.ITSystem.ucUnitAllotment(), "Unit Allottment");
        }

        private void rbe_NewVendorApproval_Click(object sender, EventArgs e)
        {
            openForm(new VendorApp());
        }

        private void rbe_auditStocks_Click(object sender, EventArgs e)
        {
            openForm(new forms.Reconcilation.StockReconcilation());
        }

        private void rbe_sm_wholesale_Click(object sender, EventArgs e)
        {
            openForm(new WholeSales.WholeSale_Window());
        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            openForm(new forms.Stock.GR_TakenBack());
        }

        private void rbe_salesInvoice_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.PrintMaster.uc_SalesInvoice("Trade"), "Trade Invoice:Printing Forms");
        }

        private void rbe_retailInvoice_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.PrintMaster.uc_SalesInvoice("Retail"), "Retail Invoice:Printing Forms");
        }

        private void rbe_mrppackexp_Click(object sender, EventArgs e)
        {
            openControl(new forms.Product.ucBatchExpMrpCorrection(), "MRP, Pack Type, Pack Qty, Expiry Correction ");
        }

        private void rbe_cor_update_Click(object sender, EventArgs e)
        {
            openControl(new forms.Product.ucMkeyCorrection(), "Update Correct Information");
        }

        private void rbe_Signature_Click(object sender, EventArgs e)
        {
            openControl(new SetUp.ucManagerSignature(), "Manager Signature Updation");
        }

        private void rde_distribution_Click(object sender, EventArgs e)
        {
            openForm(new warehouse.Bulk_PO_Distribution());
        }



        private void rbe_saltreport_Click_1(object sender, EventArgs e)
        {
            openForm(new forms.Products.PrintSaltExistensce());
        }

        private void rbe_ipdopdsales_Click(object sender, EventArgs e)
        {
 
            openForm(new Hospital.Sales.IPDOPDProcessInfo("-", "Billing"));

        }

        private void rbeCartReport_Click(object sender, EventArgs e)
        {
            openForm(new Hospital.frmCartReport());
        }

        private void rbe_HospitalSales_Click(object sender, EventArgs e)
        {
            openForm(new SaleMaster_Hospital("Billing","-","-"));
        }

        private void rbe_tools_block_Click(object sender, EventArgs e)
        {
            openForm(new Tools.toolsPharmacy());
        }

        private void radButtonElement12_Click(object sender, EventArgs e)
        {
            openForm(new Tools.BlockUnBlock_ForSaleAvg());
        }

        private void rbeDelivery_Click(object sender, EventArgs e)
        {
            openForm(new Tools.ProductDelevery());
        }

        private void rbe_OpenAudit_Click(object sender, EventArgs e)
        {
            openForm(new forms.Audit.AuditOpen());
        }

        private void rbe_bySalesAvg_Click(object sender, EventArgs e)
        {
            openForm(new warehouse.Bulk_TrfSalesBysaleAvg("BulkTrfUnits", "Transfer By Purchasse Order"));
        }

        private void rbe_sales_bysalesAvg_Click(object sender, EventArgs e)
        {
            openForm(new warehouse.Bulk_TrfSalesBysaleAvg("BulkSalesUnits", "Sales By Purchasse Order"));
        }

        private void rbe_hosp_rep_refbydoctor_Click(object sender, EventArgs e)
        {
            openForm(new Hospital.SalesRefByDoctor());
        }

        private void rbe_issue_Click(object sender, EventArgs e)
        {
            //openControl(new Hospital.CartIssueProduct(), "Issue Product From Cart");
        }

        private void rbe_search_Click(object sender, EventArgs e)
        {
            openControl(new Hospital.ucSearchInHospitalCart(), "Search In Cart");
        }

        private void rbe_Cons_Report_Click(object sender, EventArgs e)
        {
            openControl(new Hospital.uc_ConsumptionReport(), "Hospital Consumption Report");
        }

        private void rbeByChallan_Click(object sender, EventArgs e)
        {
            openForm(new Challan_Entry());
        }

        private void rbe_audit_short_extra_Click(object sender, EventArgs e)
        {
            string auditNo = string.Empty;
            pm_Audit_Queries p = new pm_Audit_Queries();
            p.unit_id = GlobalUsage.Unit_id; p.logic = "GetOpenAudit"; p.keyString = "N/A"; p.audit_no = "N/A"; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/audit/AuditQueries", p);
            DataSet ds = dwr.result;
            if (ds.Tables[0].Rows.Count == 1)
            {
                auditNo = ds.Tables[0].Rows[0]["audit_no"].ToString();
            }
            openControl(new forms.Audit.ucCheckAuditRecords(auditNo), "Audit Records Checking before Process.");
        }

        private void rbe_indentInfo_Click(object sender, EventArgs e)
        {
            openControl(new Hospital.ucIPD_Indent(), "Indent Rejection/Reports");
        }

        private void rbe_cc_ipd_Click(object sender, EventArgs e)
        {
            //openForm(new forms.CentralAccess.RCM.IPDOPDProcessInfo("Cash Counter"));
            openForm(new CashCounter.CashCounter());
        }

        private void rbe_cc_opd_Click(object sender, EventArgs e)
        {
            openForm(new SaleMaster_Hospital("Cash Counter", "-", "-"));
        }

        private void rbe_debitnote_Click(object sender, EventArgs e)
        {
            openForm(new purchase.debitNote.DebitNoteFeedingForm());
        }

        private void rbe_prod_tracking_Click(object sender, EventArgs e)
        {
            openForm(new forms.Reconcilation.ReconcileProduct());
        }

        private void rbe_exp_receiving_Click(object sender, EventArgs e)
        {
            openControl(new warehouse.uc_ExpiryReceiving(), "Expiry Management:Expiry Receiving of Other Units");
        }

        private void rbe_expwh_vendSetting_Click(object sender, EventArgs e)
        {
            openControl(new warehouse.uc_SettingofVendorAgainstKeys(), "Expiry Management:Setting of Vendor Against Keys");
        }

        private void rbe_whexp_processReport_Click(object sender, EventArgs e)
        {
            openControl(new warehouse.uc_ProcessedExpiry(), "Expiry Management:Processing and Printing of GR Slips");
        }

        private void po_checking_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.CentralAccess.Purchase.ucPurchaseOrder_Analysis(), "Purchase Order Analysis");
        }

        private void prod_newItemSales_Click(object sender, EventArgs e)
        {
            openControl(new eMediShop.forms.Sales.uc_NewPurchases(), "New Product Sales Report");
        }

        private void rbe_ImportFromOld_Click(object sender, EventArgs e)
        {
            //openForm(new Imports.ImportTrfIdsFromOldSystem());
        }

        private void rbe_displayToken_Click(object sender, EventArgs e)
        {
            openForm(new token.DisplayToken());
        }

        private void rbeCashCounter_Click(object sender, EventArgs e)
        {
            openForm(new CashCounter.CashCounter());
        }

        private void rbe_cn_register_Click(object sender, EventArgs e)
        {
            openControl(new creditNote.ucCreditNoteRegister(), "Credit Note Register");
        }

        private void rbe_debitnoteRegister_Click(object sender, EventArgs e)
        {
            openControl(new purchase.debitNote.ucDebitNoteRegister(), "Debit Note Register");
        }

        private void ipd_sales_return_Click(object sender, EventArgs e)
        {
            openForm(new Hospital.IPD_BulkSalesReturn());
        }

        private void rbe_setmgrSign_Click(object sender, EventArgs e)
        {
            openForm(new ITSystem.manager_signature());
        }

        private void extraprocess_Click(object sender, EventArgs e)
        {
            openForm(new Stock.ExtraStockProcess());
        }

        private void rbe_OrderToCompany_Click(object sender, EventArgs e)
        {
            openControl(new Imports.ucImportCompanyOrderXL(), "Upload order For Company and Generate Order No.");
        }

        private void radButtonElement15_Click(object sender, EventArgs e)
        {

        }

        private void rbe_ic_gr_return_Click(object sender, EventArgs e)
        {
            openForm(new GR.StockInByPurRetNo());
        }
        private void rbe_Au_SheetForAuditors_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.Audit.AuditMaster());
        }

        private void rbe_au_importExtra_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.forms.Audit.ImportXtraByPurchase());
        }

        private void rbe_verifyopo_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Purchase.VerifyOPO(), "Open Manual Order Receiving Verification");
        }

        private void rbe_SetChallan_Click(object sender, EventArgs e)
        {
            openControl(new challan.uc_ChallanSettlement(), "Settlement of Challan");
        }

        private void rbeChallanRegister_Click(object sender, EventArgs e)
        {
            openControl(new challan.uc_ChallanRegister(), "Challan register");
        }

        private void rbe_SaltAdd_Click(object sender, EventArgs e)
        {
            openForm(new Substitute.addSaltToProduct());
        }

        private void rbe_SaltInfo_Click(object sender, EventArgs e)
        {
            openControl(new Substitute.UCSaltInfo(), "Salt Name : Create, Modify|| Ctrl+D:To Delete");
        }

        private void rbe_saltStockReport_Click(object sender, EventArgs e)
        {
            openForm(new Substitute.PrintSaltExistensce());
        }

        private void rbe_SaltStrength_Click(object sender, EventArgs e)
        {
            openControl(new Substitute.UCStrength(), "Manage Strength of Salt");
        }

        private void rbe_purch_merge_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Purchase.ucMergePurchaseId(), "Merge Purchase Purchase Ids");
        }

        private void rbe_NewProdProcess_Click(object sender, EventArgs e)
        {
            openForm(new Products.frmNewMedicine());
        }

        private void rbeDailyDispatch_Click(object sender, EventArgs e)
        {
            openControl(new Stock.ucDailyDispatch(), "Daily Dispatch of product By Daily Master");
        }

        private void rbePurchRec_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Purchase.BulkPOReceiving(), "Purchase Order Receiving");
        }

        private void rbeChangeUnit_Click(object sender, EventArgs e)
        {
            //if (dsUnits.Tables[0].Rows.Count > 3)
            //{
            //    //rgb_SelectUnit.Height = dsUnits.Tables[0].Rows.Count * 30;
            //    //rgv_UnitInfo.Height = dsUnits.Tables[0].Rows.Count * 20;
            //    rgv_UnitInfo.Height = Screen.PrimaryScreen.Bounds.Height;

            //}
            int poX = Screen.PrimaryScreen.Bounds.Width - rgv_UnitInfo.Width-20;
            int poY = Screen.PrimaryScreen.Bounds.Height-300;

            x = this.Width - (rgb_SelectUnit.Width + 30);
            y = this.Height - (rgb_SelectUnit.Height - 30);

            rgb_SelectUnit.Location = new Point(poX, poY);
            rgb_SelectUnit.Visible = true;
            if (dsUnits.Tables[0].Rows.Count > 4)
                rgv_UnitInfo.EnableFiltering = true;

        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            openControl(new Stock.ucCheckWholeStockAudit(), "Mismatch Detail by Stock Verification");
        }

        private void rbe_opticalAdv_Click(object sender, EventArgs e)
        {
            openForm(new Optical.Optical_Booking());
        }

        private void rbe_promoAdd_Click(object sender, EventArgs e)
        {
            openForm(new Promo.PromoProducts());
        }

        private void rbe_promoRegister_Click(object sender, EventArgs e)
        {
            openControl(new Promo.uc_PromoRegister(), "Add Promotional Products");
        }

        private void rbe_unitindent_Click(object sender, EventArgs e)
        {
            openForm(new Indents.IndentToUnit());
        }

        private void rbe_IndentVerify_Click(object sender, EventArgs e)
        {
            openControl(new Indents.ucIndentProcess(), "Verification of Indent/Process");
        }

        private void rbeUpdateCardInfo_Click(object sender, EventArgs e)
        {
            openForm(new UpdateHealthCard("-"));
        }

        private void rbe_mapCreditNote_Click(object sender, EventArgs e)
        {

        }

        

        private void rbe_InterCompDebitNote_Click(object sender, EventArgs e)
        {
            openControl(new purchase.debitNote.ucInterCompany_DebitNoteImport(), "Generate Credit Note from Inter-Company Debit Note");
        }

        private void rbe_MapCreditNote_Click_1(object sender, EventArgs e)
        {
            openControl(new purchase.debitNote.ucMapByCreditNote(), "Map with Credit Note Happenings");
        }

        private void radButtonElement18_Click(object sender, EventArgs e)
        {
            if (GlobalUsage.Unit_id == "MS-C0045")
                openForm(new eMediShop.Hospital.Wh_IndentProcessInfo("-", "Billing"));
            else
                RadMessageBox.Show("Only For CPL Warehouse.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string v = string.Empty;
            v = textBox1.Text;
        }

        private void rbeIndentChecking_Click(object sender, EventArgs e)
        {
            openControl(new Hospital.ucIndentChecking(), "Indent Process Checking");
        }

        private void rbe_hospCons_Click(object sender, EventArgs e)
        {
            openControl(new forms.CentralAccess.Stock.usStockTransferToConsumption(), "Stock Transfer For Hospital Conusmption");
        }

        private void rbeEstimateDelivery_Click(object sender, EventArgs e)
        {
            openControl(new Hospital.ucEstimateDelivery(), "Estimate Delivery and Hospital Advance Setting");
        }

        private void rbeBarcodePrinting_Click(object sender, EventArgs e)
        {
            openControl(new barcode.ucBarcodePrinting(), "Barcode Printing");
        }

        private void rbeExtraIn_Click(object sender, EventArgs e)
        {
            openControl(new Hospital.ucIPD_ExtraIn(), "TPA Extra In");
        }

        private void rbeView_Click(object sender, EventArgs e)
        {
            openControl(new accounts_library.View_AccountsNew(GlobalUsage.UnitName, GlobalUsage.UnitAddress, GlobalUsage.Unit_id, "eAccounts", GlobalUsage.Login_id, "LOCAL", GlobalUsage.Rights, "Pharmacy"), "Display Ledger");

        }

        private void rbeImplantSales_Click(object sender, EventArgs e)
        {
            openControl(new Implants.ucImplantBulkSales(), "Implant's Purchase Bill Bulk Sales To Hospital.(MS-H0048)");

        }

        private void rbeDailyDispatchOrSales_Click(object sender, EventArgs e)
        {
            openControl(new Hospital.ucDailyDispatch_Sales(), "Important Process For Hospital Units Only");
        }

        private void rbehoto_Click(object sender, EventArgs e)
        {
            openControl(new CashCounter.ucHandOver(), "Hand Over and Take Over of Duty");
        }

        private void rbeManualSale_Click(object sender, EventArgs e)
        {
            openForm(new ManualSales.manualSales());
        }

        private void rbeChangePayMode_Click(object sender, EventArgs e)
        {
            //openControl(new CashCounter.ucChangePayMode(), "Modify Pay Mode of a Sales Invoice No. Which You Generated.");
            openForm(new sales.SaleBill_Correction());
        }

        private void rbeBulkBills_Click(object sender, EventArgs e)
        {
            openControl(new Utility.ucBulkBillPrinting(), "Bulk Bill Printing Option");
        }

        private void rbeManualFinal_Click(object sender, EventArgs e)
        {
            openForm(new eMediShop.ManualSales.ucManualSalesProcess());
        }

        private void rbeFOC_Click(object sender, EventArgs e)
        {
            openControl(new FOC.ucFOC(), "FOC Approval Process");
        }

        private void rbeResolveBlocking_Click(object sender, EventArgs e)
        {
            openControl(new ITSystem.ucCheckandKillBlockingProcess(), "Check and Kill Blocking Process");
        }

        private void rbeMonthlyOrders_Click(object sender, EventArgs e)
        {
            openForm(new purchase.orders.MonthlyPurchaseOrderForUnits());
        }

        private void rbeInvRecRegister_Click(object sender, EventArgs e)
        {
            openControl(new Inventory.ucStockRecRegister(), "Location Sheet");
        }

        private void rbeCancelManualSales_Click(object sender, EventArgs e)
        {
            openControl(new ManualSales.ucCancelSales(), "Cancel Manual Bill");
        }

        private void rbeHAlOrderEntry_Click(object sender, EventArgs e)
        {
            openForm(new contract.HAL_Orders());
        }

        private void rbeHAL_OrderProcess_Click(object sender, EventArgs e)
        {
            openForm(new contract.ProcessOrder());
        }

        private void rbeHAL_RawData_Click(object sender, EventArgs e)
        {
            openControl(new contract.ucOrderData(), "Order Data");
        }

        private void rbeHAlEditOrders_Click(object sender, EventArgs e)
        {
            openControl(new contract.ucManageOrders(), "Item/Order Cancellation");
        }

        private void rbeHAlBilling_Click(object sender, EventArgs e)
        {
            openControl(new contract.ucMasterBilling(), "HAL Billing");
        }

        private void rbeDelProcess_Click(object sender, EventArgs e)
        {
            openForm(new contract.ProcessOrderDelivery());
        }

        private void rbeConsBillProcess_Click(object sender, EventArgs e)
        {
            openControl(new contract.ucGroupBilling(), "HAL Delivery Billing");
        }

        private void rdpDeliveryData_Click(object sender, EventArgs e)
        {
            openControl(new contract.ucOrderDeliveryData(), "HAL Delivery Records");
        }

       

        private void rbeStockist_newChallan_Click(object sender, EventArgs e)
        {
        
            openForm(new challan.Challan_Window());
        }

        private void rbeStockist_Sales_Click(object sender, EventArgs e)
        {
            openForm(new WholeSales.WholeSale_Pharma());

        }

        private void rb_assign_menu_Click(object sender, EventArgs e)
        {
            openForm(new ITSystem.menuRights("eMediShop"));
        }
    } // Second Last
}
