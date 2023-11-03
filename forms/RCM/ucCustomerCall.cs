using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.ServiceModel;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.forms.RCM
{
    public partial class ucCustomerCall : UserControl
    {
       
        string _CardNo = string.Empty; string _orderNo = string.Empty;
        string _result = string.Empty;
        DataSet dsTotalSale = new DataSet();
        DataSet dsMed = new DataSet();
        private System.Windows.Forms.TextBox txtqty = new System.Windows.Forms.TextBox();
        DataSet _ds = new DataSet();
        bool m_BackPressed = false;
          
        string _Logic = "";
        string _item_id = "";
        int oldQty = 0;
        private int X = 0;
        private int Y = 0;
        int position = 0;
        string _ItemName = "";
        private ListViewItem item;
        string _division = "";
        string subItemText = "";
        int selectedSubItem = 0;
        int _index = -1;
        SerialPort SP = new SerialPort();
     
        public ucCustomerCall(string cardno, string division)
        {
          
            _CardNo = cardno;
            _division = division;
            InitializeComponent();
            #region Initialize TextBox Order Quantity
            txtqty.Size = new System.Drawing.Size(46, 0);
            txtqty.Location = new System.Drawing.Point(0, 0);
            txtqty.TextAlign = HorizontalAlignment.Right;
            txtqty.BorderStyle = BorderStyle.FixedSingle;
            this.lvOrder.Controls.Add(this.txtqty);
            txtqty.LostFocus += new System.EventHandler(this.OrderQtyFocusExit);
            txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderQtyKeyPress);
            txtqty.Hide();
            //pnlModifyCard.Controls.Clear();
            //pnlModifyCard.Controls.Add(new UpdateHealthCard(_CardNo));
            #endregion
        }
        private void ucCustomerCall_Load(object sender, EventArgs e)
        {

            _orderNo = "New";
            cmbdeltime.SelectedIndex = 0;
            Cursor.Current = Cursors.WaitCursor;
            txtRemark.Text = "N/A";
            txtMessageForUnit.Text = "N/A";
            dtNextCalldate.MinDate = DateTime.Today;
            dtNextCalldate.Value = DateTime.Today.AddDays(15);
            dtpPromoDate.MinDate = DateTime.Today;


            lvOrder.Items.Clear();
            try
            {
                cm2 p = new cm2();
                p.unit_id = "MS-00001";p.login_id = GlobalUsage.Login_id;
                p.Logic = "CustomerInfo";p.prm_1 = _CardNo;p.prm_2 = "N/A";p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/CallingCardQueries", p);
                _ds = dwr.result;
                #region Card Information
                if (_ds.Tables.Count > 0)
                {
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        _CardNo = _ds.Tables[0].Rows[0]["card_no"].ToString();
                        lbCardNo.Text = _CardNo;
                        lblCustOC.Text = _ds.Tables[0].Rows[0]["cust_name"].ToString();
                        lblMobOC.Text = _ds.Tables[0].Rows[0]["MobileNo"].ToString();
                        lblPhoneOC.Text = _ds.Tables[0].Rows[0]["phoneno"].ToString();
                        lblAddressOC.Text = _ds.Tables[0].Rows[0]["address"].ToString();
                        lblLastPurOC.Text = _ds.Tables[0].Rows[0]["last_pur_date"].ToString();
                        txtPresBy.Text = _ds.Tables[0].Rows[0]["prescribed_by"].ToString();
                        string[] members = _ds.Tables[0].Rows[0]["members"].ToString().Split('~');
                        cmbMembers.DataSource = _ds.Tables[3];
                        cmbMembers.DisplayMember = "member_name";
                        cmbMembers.ValueMember = "member_name";

                        if (_ds.Tables[0].Rows[0]["DND_Flag"].ToString() == "Y")
                            chkDND.Checked = true;
                        else
                            chkDND.Checked = false;
                        if (_ds.Tables[0].Rows[0]["Mobile_Flag"].ToString() == "Y")
                            chkValidPhone.Checked = true;
                        else
                            chkValidPhone.Checked = false;
                        if (_ds.Tables[0].Rows[0]["Phone_Flag"].ToString() == "Y")
                            chkValidMobile.Checked = true;
                        else
                            chkValidMobile.Checked = false;
                    }
                    else { MessageBox.Show("Card Not Exists"); }
                    if (_ds.Tables[1].Rows.Count > 0)
                    {
                        cbxPharmacy.Items.Clear();
                        cbxPharmacy.Items.AddRange(GlobalUsage.FillCombo(_ds.Tables[1]));
                        cbxPharmacy.SelectedIndex = 0;
                    }

                    tabControl2.TabPages[1].Focus();
                    if (_ds.Tables[2].Rows.Count > 0)
                    {
                        int y = 2;
                        foreach (DataRow dr in _ds.Tables[2].Rows)
                        {
                            QuestionAnswer QA = new QuestionAnswer(_CardNo, lblMobOC.Text, _division);
                            QA.QNO = dr["QNo"].ToString();
                            QA.QType = dr["QType"].ToString();
                            QA.QInfo = dr["QInfo"].ToString();
                            QA.Location = new System.Drawing.Point(2, y);
                            QA.Remark = dr["remark"].ToString();
                            QA.RemarkCount = dr["countremark"].ToString();
                            if (dr["QType"].ToString() == "Written")
                                QA.Size = new System.Drawing.Size(472, 75);
                            else
                                QA.Size = new System.Drawing.Size(472, 39);
                          
                            panel2.Controls.Add(QA);
                            y = y + 45;
                        }
                    }
                }
                else { MessageBox.Show("Card Not Exists"); }
                #endregion
                Fill_OrderNo();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;

        }
        private void Fill_OrderNo()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataSet ds = new DataSet();
                customerOrders p = new customerOrders();
                p.unit_id = GlobalUsage.Unit_id;
                p.logic = "OpenOrders";p.prm_1 = "N/A";p.card_no = _CardNo;p.order_no = "N/A";p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RcmProductInfo", p);
                ds = dwr.result;
                rgv_orderNos.DataSource = ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }


        }
       
        private void OrderQtyFocusExit(object sender, System.EventArgs e)
        {
            txtqty.Hide();
        }
        private void OrderQtyKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 27)
            {
                if (e.KeyChar == 13)
                {
                    if (oldQty != Convert.ToInt16(txtqty.Text))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        //on case of new mediceine
                        if (_item_id == "New")
                            _ItemName = txtItemName.Text;
                        else
                            _ItemName = "-";
                        //end on case of new mediceine
                        item.SubItems[selectedSubItem].Text = txtqty.Text;
                        try
                        {
                            customerOrders p = new customerOrders();
                            p.unit_id = GlobalUsage.Unit_id;p.login_id = GlobalUsage.Login_id;
                            p.order_no = _orderNo;p.item_id = item.Text;p.delivery_date = dtdeldate.Value.ToString("yyyy/MM/dd");
                            p.delivery_time = cmbdeltime.Text;p.qty = Convert.ToInt32(txtqty.Text);
                            p.newProductName = _ItemName;
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMOnCallOrder", p);
                            if (_result.Contains("Success"))
                            {
                                string[] r = _result.Split('|');
                                _orderNo = r[1];
                                rcp_orderNo.HeaderText = "Order No " + _orderNo;
                                Fill_OrderNo();

                            }
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                        Cursor.Current = Cursors.Default;

                    }
                }
                lvOrder.Focus();
            }
        }
        private void ucPharmacyByAreaCall_Load(object sender, EventArgs e)
        {


        }
        
        protected int getXaxisWidth(ListView lv)
        {
            int start = X;
            int w = 0;
            int i = 0;
            for (i = 0; i < lv.Columns.Count; i++)
            {
                w = w + lv.Columns[i].Width;
                if (w > X)
                {
                    selectedSubItem = i;
                    position = w - lv.Columns[i].Width;
                    break;
                }
            }
            return position;
        }
        private void lv_Click(object sender, EventArgs e)
        {
            int x = getXaxisWidth(lvOrder);
            subItemText = item.SubItems[selectedSubItem].Text;
            string column = lvOrder.Columns[selectedSubItem].Text;
            if (column == "Qty")
            {
                int y = item.Bounds.Bottom - item.Bounds.Top;
                txtqty.Size = new System.Drawing.Size(46, y);
                txtqty.Location = new System.Drawing.Point(position, item.Bounds.Y);
                txtqty.Show();
                txtqty.Text = subItemText;
                oldQty = Convert.ToInt16(subItemText);
                txtqty.SelectAll();
                txtqty.Focus();
            }
        }
        private void lv_MouseDown(object sender, MouseEventArgs e)
        {

            ListView lv = (ListView)sender;
            item = lv.GetItemAt(e.X, e.Y);
            X = e.X;
            Y = e.Y;
        }
        private void lvMobileNo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            lvOrder.Items.Clear();
            try
            {
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "CustomerInfo"; p.prm_1 = _CardNo; p.prm_2 = "N/A"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/CallingCardQueries", p);
                _ds = dwr.result;
                if (_ds.Tables.Count > 0)
                {
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        lbCardNo.Text = _CardNo;
                        lblCustOC.Text = _ds.Tables[0].Rows[0]["cust_name"].ToString();
                        lblMobOC.Text = _ds.Tables[0].Rows[0]["MobileNo"].ToString();
                        lblPhoneOC.Text = _ds.Tables[0].Rows[0]["phoneno"].ToString();
                        lblAddressOC.Text = _ds.Tables[0].Rows[0]["address"].ToString();
                        lblLastPurOC.Text = _ds.Tables[0].Rows[0]["last_pur_date"].ToString();
                    }
                    else { MessageBox.Show("Card Not Exists"); }
                }
                else { MessageBox.Show("Card Not Exists"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (_CardNo.Length > 5)
                {
                    customerOrders p = new customerOrders();
                    p.logic = _Logic; p.prm_1 = "N/A"; p.card_no = _CardNo; p.order_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RcmProductInfo", p);

                    dsMed = dwr.result;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
        }
        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            
            if (txtItemName.Text.Length > 3 &&  m_BackPressed==false)
                
            {
                try
                {
                    lvNewproduct.Visible = true;
                    lvNewproduct.Location = new System.Drawing.Point(7, 202);
                    lvNewproduct.Size = new System.Drawing.Size(474, 200);
                    _result = DateTime.Now.Second.ToString();
                    cm1 p = new cm1();
                    p.Logic = "Search:ForTeleCaller"; p.prm_1 = txtItemName.Text.TrimEnd();
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/products/ProductQueries", p);
                    _ds = dwr.result;
                    lvNewproduct.Items.Clear();
                    if (_ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in _ds.Tables[0].Rows)
                        {
                            lvNewproduct.Items.Add(dr["item_id"].ToString());
                            lvNewproduct.Items[lvNewproduct.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        }
                        lvNewproduct.BringToFront();
                    }
                  
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }


        private void FillMediCineName(DataSet ds)
        {
            Cursor.Current = Cursors.WaitCursor;
            lvOrder.Items.Clear();
            if (dsMed.Tables.Count > 0)
            {
                if (dsMed.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsMed.Tables[0].Rows)
                    {
                        lvOrder.Items.Add(dr["item_id"].ToString());
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(dr["item_name"].ToString());
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(dr["new_med"].ToString());
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(Convert.ToInt16(dr["lstPurchQty"]).ToString());
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(Convert.ToInt16(dr["qty"]).ToString());
                    }
                }
                if (dsMed.Tables[1].Rows.Count > 0)
                {

                    lblCompInfo.Text = dsMed.Tables[1].Rows[0]["comp_info"].ToString();
                    txtSaleInvNo.Text = dsMed.Tables[1].Rows[0]["sale_inv_no"].ToString();

                    cbxPharmacy.Text = dsMed.Tables[1].Rows[0]["sh_name"].ToString();

                  

                }

            }
            Cursor.Current = Cursors.Default;
        }
        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { txtnewqty.Focus(); }
            if (e.KeyCode == Keys.Down)
            { lvNewproduct.Focus(); if (lvNewproduct.Items.Count > 0) { lvNewproduct.Items[0].Selected = true; } }
            if (e.KeyCode == Keys.Back)
                m_BackPressed = true;
            else
                m_BackPressed = false;
        }
        private void lvNewproduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _item_id = lvNewproduct.Items[lvNewproduct.FocusedItem.Index].Text;
                txtItemCode.Text = _item_id;
                txtItemName.Text = lvNewproduct.Items[lvNewproduct.FocusedItem.Index].SubItems[1].Text;
                lvNewproduct.Visible = false;
                txtnewqty.Focus();
            }
        }
        private void txtnewqty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtnewqty.Text != "" && txtItemName.Text != "")
                {
                    lvOrder.Items.Add(_item_id);
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(txtItemName.Text);
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add("");
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add("0");
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(txtnewqty.Text);
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _ItemName = "-";
                        customerOrders p = new customerOrders();
                        p.card_no = _CardNo;p.cust_name = cmbMembers.Text;p.unit_id = GlobalUsage.Unit_id;
                        p.order_no = _orderNo;p.item_id = _item_id;p.delivery_date = dtdeldate.Value.ToString("yyyy/MM/dd");
                        p.delivery_time = cmbdeltime.Text;p.qty = Convert.ToInt32(txtnewqty.Text);p.newProductName = _ItemName;
                        p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMOnCallOrder", p);
                        _result = dwr.message;
                        txtnewqty.Text = "";
                        txtItemName.Text = "";
                        if (_result.Contains("|"))
                        {
                            string[] r = _result.Split('|');
                            _orderNo = r[1];
                        }
                        else
                        {
                            rcp_orderNo.HeaderText = "Order No " + _orderNo;
                            Fill_OrderNo();
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    txtItemName.Focus();
                }
            }
        }
        private void btnMobile_Click(object sender, EventArgs e)
        {
            SP.Write("AT" + Environment.NewLine);
            System.Threading.Thread.Sleep(1000);
            string gsm_command = "ATD";
            string phone_number = lblMobOC.Text.Trim() + ";";
            string command1 = gsm_command + phone_number + "\r\n";
            Byte[] dcB = System.Text.Encoding.ASCII.GetBytes(command1);
            SP.Write(dcB, 0, dcB.Length);
            MessageBox.Show("Connecting...");
        }
        private void btnPhone_Click(object sender, EventArgs e)
        {
            SP.Write("AT" + Environment.NewLine);
            System.Threading.Thread.Sleep(1000);
            string gsm_command = "ATD";
            string phone_number = lblPhoneOC.Text + ";";
            string command1 = gsm_command + phone_number + "\r\n";
            Byte[] dcB = System.Text.Encoding.ASCII.GetBytes(command1);
            SP.Write(dcB, 0, dcB.Length);
            MessageBox.Show("Connecting...");
            //SP.Close(); 
        }
        private void lvBillInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _Logic = "Bill Info";
            if (_CardNo.Length > 5)
            {
                customerOrders p = new customerOrders();
                p.logic = _Logic; p.prm_1 = "N/A"; p.card_no = _CardNo; p.order_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RcmProductInfo", p);

                _ds = dwr.result;
            }

            rgvBillInfo.DataSource = _ds.Tables[0];
            Cursor.Current = Cursors.Default;
        }
        private void lnkCardModify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //eHealthCard.Pharmacy.modifyCard obj = new modifyCard(_CardNo);
            //obj.Show();
        }
        private void btnTag_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
               
                regulareQueries p1 = new regulareQueries();
                p1.card_no = _CardNo; p1.rmd_date = System.DateTime.Now.ToString("yyyy/MM/dd");
                p1.rmd_time = cmbNextCalltime.SelectedItem.ToString(); p1.unit_id = GlobalUsage.Unit_id;
                p1.remark = txtMessageForUnit.Text; p1.lastcallinfo = ""; p1.loginID = GlobalUsage.Login_id; p1.logic = "TagCardHolder";
                datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/customerdata/RCMCreateDataLog", p1);
                MessageBox.Show(dwr1.message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;

        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            //if (cbxPharmacy.Text == "Select" || cbxPharmacy.Text.Length<8)
            //{
            //    MessageBox.Show("Select Store", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cbxPharmacy.Focus();
            //    return;
            //}
            try
            {

                string home_delflag = "Y";
                if (chkHomeDel.Checked) { home_delflag = "Y"; } else { home_delflag = "N"; }
                if (txtMessageForUnit.Text.Trim().Length > 3)
                {
                    //
                    regulareQueries p1 = new regulareQueries();
                    p1.card_no = _CardNo;p1.rmd_date = dtNextCalldate.Value.ToString("yyyy/MM/dd");
                    p1.rmd_time = cmbNextCalltime.SelectedItem.ToString();p1.unit_id = GlobalUsage.Unit_id;
                    p1.remark = txtRemark.Text;p1.lastcallinfo = "";p1.loginID = GlobalUsage.Login_id;p1.logic = "OnCallEntry";
                    datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/customerdata/RCMCreateDataLog", p1);

                    msg = dwr1.message;
                    if (msg.Contains("Success"))
                    {
                        regulareQueries p2 = new regulareQueries();
                        p2.card_no = _CardNo; p2.uniqeID = "0"; p2.callType = "Scheduled"; p2.loginID = GlobalUsage.Login_id; p2.remark = txtRemark.Text;
                        p2.logic = "Insert";
                        datasetWithResult dwr2 = ConfigWebAPI.CallAPI("api/customerdata/InsertCustCallLog", p2);
                       
                     

                        if (_orderNo.Contains("|"))
                        {
                            string[] s = _orderNo.Split('|');
                            _orderNo = s[1];
                        }
                        string promoTag = string.Empty;
                        if (chkPromo.Checked) { promoTag = "Y"; } else { promoTag = "N"; }
                        {
                            customerOrders p = new customerOrders();
                            p.unit_id = GlobalUsage.Unit_id;p.isHomeDelivery = home_delflag;
                            p.TransferToUnit = GlobalUsage.Unit_id; //((AddValue)cbxPharmacy.SelectedItem).Value;
                            p.order_no = _orderNo;p.card_no = _CardNo;p.delivery_date = dtdeldate.Value.ToString("yyyy/MM/dd");
                            p.delivery_time = cmbdeltime.Text; p.remarks = txtMessageForUnit.Text;p.ref_by = txtPresBy.Text;
                            p.old_order_no = "-";p.sale_inv_no = "-";p.promo_flag = promoTag;p.prm_1 = dtpPromoDate.Value.ToString("yyyy/MM/dd");
                            p.logic = "FIRSTCALL_COM";p.login_id = GlobalUsage.Login_id;
                            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMCompleteOrder", p);
                          
                        }
                    }
                    lblMessage.Text = "Message: " + msg;
                  
                }
                else
                { MessageBox.Show("Remark is mandatory", "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }

        

        }
        private void lbCardNo_MouseHover(object sender, EventArgs e)
        {
            if (dsTotalSale.Tables.Count <= 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                cm2 p = new cm2();
                p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                p.Logic = "TotalSalesInfo"; p.prm_1 = _CardNo; p.prm_2 = "N/A"; p.prm_3 = "N/A";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/CallingCardQueries", p);
                dsTotalSale = dwr.result;
                if (dsTotalSale.Tables[0].Rows.Count > 0)
                {
                    PnlHower.Visible = true;
                    PnlHower.BringToFront();
                    txtPhTotal.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["ph_total"]).ToString("####");
                    txtPhDiscount.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["ph_discount"]).ToString("####");
                    txtPharmacyHits.Text = dsTotalSale.Tables[0].Rows[0]["PharmacyHits"].ToString();
                    txtDiagTotal.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["diag_total"]).ToString("####");
                    txtDiagRebate.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["diag_discount"]).ToString("####");
                    txtDiagHits.Text = dsTotalSale.Tables[0].Rows[0]["DiagnosticHits"].ToString();
                    PnlHower.Location = new System.Drawing.Point(116, 6);
                    PnlHower.Size = new System.Drawing.Size(474, 82);
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                PnlHower.Visible = true;
                PnlHower.BringToFront();
                txtPhTotal.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["ph_total"]).ToString("####");
                txtPhDiscount.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["ph_discount"]).ToString("####");
                txtPharmacyHits.Text = dsTotalSale.Tables[0].Rows[0]["PharmacyHits"].ToString();
                txtDiagTotal.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["diag_total"]).ToString("####");
                txtDiagRebate.Text = Convert.ToDecimal(dsTotalSale.Tables[0].Rows[0]["diag_discount"]).ToString("####");
                txtDiagHits.Text = dsTotalSale.Tables[0].Rows[0]["DiagnosticHits"].ToString();
                PnlHower.Location = new System.Drawing.Point(116, 6);
                PnlHower.Size = new System.Drawing.Size(474, 82);
            }

        }
        private void lbCardNo_MouseLeave(object sender, EventArgs e)
        {
            PnlHower.Visible = false;
        }
        

        private void btnAddReg_Click(object sender, EventArgs e)
        {
             add_regularorder OBJ = new add_regularorder(_CardNo);
            OBJ.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do you Cancel the Order ?", "ExPro Help", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (txtCancelRemark.Text.Trim().Length > 5 && lblOrderNo.Text.Length > 5)
                    {
                       
                        cm1 p = new cm1();
                        p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                        p.Logic = "update:CancelOrder"; p.tran_id = lblOrderNo.Text; p.prm_1 = txtCancelRemark.Text; p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/UpdateTablesInfo", p);
                      
                        string msg = dwr.message;
                        if (msg.Contains("Success"))
                        { MessageBox.Show("Successfully Cancelled"); }
                    }
                    else
                    { MessageBox.Show("Remark is mandatory and order is selected"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            GetOrder("GETORDER_BYNO", txtOrdNo.Text);
            fillOrder();
        }
        private void GetOrder(string logic, string input)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm3 p = new cm3();
                p.Logic = logic;p.dtFrom = dtFrom.Value.ToString("yyyy/MM/dd");
                p.dtTo = dtTo.Value.ToString("yyyy/MM/dd");p.prm_1 = input;p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMCallReport", p);
                _ds = dwr.result;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void fillOrder()
        {
            lv_order.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem li = new ListViewItem(dr["order_no"].ToString().Trim());
                        li.SubItems.Add(Convert.ToDateTime(dr["order_date"]).ToString("dd-MM-yyyy"));
                        li.SubItems.Add(dr["cust_name"].ToString());
                        li.SubItems.Add(dr["remark"].ToString());
                        li.SubItems.Add(dr["ord_status"].ToString());
                        lv_order.Items.Add(li);
                    }
                }
            }
        }
        private void fillOrderDetail()
        {
            lvOrderDetail.Items.Clear();
            if (_ds.Tables.Count > 0)
            {
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in _ds.Tables[0].Rows)
                    {
                        ListViewItem li = new ListViewItem(dr["autoid"].ToString().Trim());
                        li.SubItems.Add(dr["item_name"].ToString());
                        li.SubItems.Add(dr["new_med"].ToString());
                        //li.SubItems.Add(dr["lstPurchQty"].ToString());
                        li.SubItems.Add(dr["qty"].ToString());
                        lvOrderDetail.Items.Add(li);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetOrder("GETORDER_BYDATE", lbCardNo.Text);
            fillOrder();
        }

        private void lv_order_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lblOrderNo.Text = string.Empty;
            lvOrderDetail.Items.Clear();
        }

        private void lv_order_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblOrderNo.Text = lv_order.Items[lv_order.FocusedItem.Index].Text;
            GetOrder("Cancel_orderdetail", lblOrderNo.Text);
            fillOrderDetail();
        }
        private void UpdateItemByNewMed(object sender, EventCarrierArgs e)
        {
            string old_itemid = e.Paramenter.Split('|')[0];
            string new_itemid = e.Paramenter.Split('|')[1];
            string new_itemname = e.Paramenter.Split('|')[2];
   
            cm1 p = new cm1();
            p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
            p.Logic = "Update:OrderItemID"; p.tran_id = _orderNo; p.prm_1 = new_itemid;p.prm_2 = old_itemid; p.login_id = GlobalUsage.Login_id;
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/UpdateTablesInfo", p);
            string result = dwr.message;

            //string result = "Success";
            if (result.Contains("Success"))
            {
                lvOrder.Items[_index].Text = new_itemid;
                lvOrder.Items[_index].SubItems[1].Text = new_itemname;
            }
        }
        private void lvOrder_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void txtNewMed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNewMedQty.Text != "" && txtNewMedName.Text != "")
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        lvOrder.Items.Add("New");
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add("");
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(txtNewMedName.Text);
                        lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(txtNewMedQty.Text);

                        customerOrders p = new customerOrders();
                        p.card_no = _CardNo;p.order_no = _orderNo;p.delivery_date = dtdeldate.Value.ToString("yyyy/MM/dd");
                        p.delivery_time = cmbdeltime.Text;p.item_id = "New";p.newProductName = txtNewMedName.Text;p.cust_name = cmbMembers.Text;
                        p.qty = Convert.ToInt32(txtNewMedQty.Text);p.login_id= GlobalUsage.Login_id;p.unit_id = GlobalUsage.Unit_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMOnCallOrder", p);
                        _result = dwr.message;
                        txtNewMedQty.Text = "";
                        txtNewMedName.Text = "";
                        if (_result.Contains("|"))
                        {
                            string[] r = _result.Split('|');
                            _orderNo = r[1];
                        }
                        else
                        {
                            rcp_orderNo.HeaderText = "Order No " + _orderNo;
                            
                        }
                        Fill_OrderNo();
                        Cursor.Current = Cursors.Default;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                regulareQueries p = new regulareQueries();
                p.card_no = lbCardNo.Text; p.uniqeID = "0";p.callType = "DataCalling"; p.loginID = GlobalUsage.Login_id; p.remark = txtCallRemark.Text; p.logic = "Insert";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/InsertCustCallLog", p);
                MessageBox.Show(dwr.message);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Cursor.Current = Cursors.Default;
        }

        private void txtCallRemark_TextChanged(object sender, EventArgs e)
        {
            if (txtCallRemark.TextLength > 1)
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;

        }

        private void chkPromo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPromo.Checked)
            {
                dtpPromoDate.MinDate = OrderDate();
                dtpPromoDate.Value = dtpPromoDate.MinDate;
            }
            else
            {
                dtpPromoDate.MinDate = DateTime.Today;
                dtpPromoDate.Value = dtpPromoDate.MinDate;
            }
        }

        private DateTime OrderDate()
        {
            DateTime dt = DateTime.Today;
            //if (DateTime.Today.Day == 1 || DateTime.Today.Day == 15)
            //    dt = DateTime.Today;
            //else if (DateTime.Today.Day > 15)
            //    dt = Convert.ToDateTime(DateTime.Today.AddMonths(1).ToString("yyyy/MM/01"));
            //else if (DateTime.Today.Day < 15)
            //    dt = Convert.ToDateTime(DateTime.Today.ToString("yyyy/MM/15"));
            var date = DateTime.Now;
            var nextSunday = date.AddDays(7 - (int)date.DayOfWeek);
            dt = nextSunday;
            while (date <= nextSunday)
            {
                date = date.AddDays(1);
                if (date.Day == 1)
                {
                    dt = date;
                    break;
                }
            }
            return dt;
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {


        }

        private void btnFillRM_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (tabControl2.SelectedIndex == 1)
                {
                    _Logic = "CustomerMed_New1";
                    if (_CardNo.Length > 5)
                    {
                        customerOrders p = new customerOrders();
                        p.logic = _Logic; p.prm_1 = "ByTeleCaller"; p.card_no = _CardNo; p.order_no = _orderNo; p.login_id = GlobalUsage.Login_id;
                        datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RcmProductInfo", p);

                        dsMed =dwr.result;
                        FillMediCineName(dsMed);
                    }
                }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_orderNos_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            _orderNo = e.Row.Cells["order_no"].Value.ToString();
            rcp_orderNo.IsExpanded = false;
            rcp_orderNo.HeaderText = "Order No " + _orderNo;
            lvOrder.Items.Clear();
            btnFillRM.PerformClick();
        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                _Logic = "Last Bill Detail";
                if (_CardNo.Length > 5)
                {
                    customerOrders p = new customerOrders();
                    p.logic = _Logic; p.prm_1 = e.Row.Cells["sale_inv_no"].Value.ToString();
                    p.card_no = "N/A"; p.order_no = "N/A"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RcmProductInfo", p);
                    _ds = dwr.result;
                }

                rgvDetail.DataSource = _ds.Tables[0];
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    var itemSummary = from row in _ds.Tables[0].AsEnumerable()
                                      group row by new { ID = row.Field<string>("item_id"),
                                          item_name = row.Field<string>("item_name") } into grp
                                      select new
                                      {
                                          item_id = grp.Key.ID,
                                          item_name = grp.Key.item_name,
                                          qty = grp.Sum(r => r.Field<decimal>("saleqty"))
                                      };
                    rgvSummary.DataSource = itemSummary;
                }

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btnFillInRM_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _Logic = "CustomerMed_New1";

                lvOrder.Items.Clear();
                foreach (GridViewRowInfo gvr in rgvSummary.Rows)
                {
                    lvOrder.Items.Add(gvr.Cells["item_id"].Value.ToString());
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(gvr.Cells["item_name"].Value.ToString());
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add("");
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(Convert.ToInt16(gvr.Cells["qty"].Value).ToString());
                    lvOrder.Items[lvOrder.Items.Count - 1].SubItems.Add(Convert.ToInt16(gvr.Cells["qty"].Value).ToString());
                   
                    customerOrders p = new customerOrders();
                    p.unit_id = GlobalUsage.Unit_id; p.login_id = GlobalUsage.Login_id;
                    p.order_no = _orderNo; p.item_id = gvr.Cells["item_id"].Value.ToString(); p.delivery_date = dtdeldate.Value.ToString("yyyy/MM/dd");
                    p.delivery_time = cmbdeltime.Text; p.qty = Convert.ToInt16(gvr.Cells["qty"].Value);p.cust_name = cmbMembers.Text;
                    p.newProductName = _ItemName;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/customerdata/RCMOnCallOrder", p);
                    _result = dwr.message;
                    if (_orderNo != _result)
                    {
                        _orderNo = _result;
                        rcp_orderNo.HeaderText = "Order No " + _orderNo;
                        Fill_OrderNo();

                    }
                }



            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtdeldate_Leave(object sender, EventArgs e)
        {


        }

        private void dtpPromoDate_Leave(object sender, EventArgs e)
        {
            if (dtpPromoDate.Value.Day == 1)
                chkPromo.Checked = true;
            else if (dtpPromoDate.Value.ToString("dddd") == "Sunday")
                chkPromo.Checked = true;
            else
                chkPromo.Checked = false;
        }

        private void dtpPromoDate_ValueChanged(object sender, EventArgs e)
        {
            dtdeldate.MinDate = dtpPromoDate.Value;
        }

        private void btnCheckSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Stocks p = new pm_Stocks();
                p.unit_id = "MS-00001"; p.item_id = _item_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/stocks/StockAtOtherStores", p);
                rgv_InStock.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }
    }
}
