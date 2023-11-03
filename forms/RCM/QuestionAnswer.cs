using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace eMediShop.forms.RCM
{
    public partial class QuestionAnswer : UserControl
    {
        string _QNO = "";
        string _QType = "";
        string _QInfo = "";
        string _CardNo = "";
        string _MobileNo = "";
        string _result = "";
        string _remark = "";
        string _remarkCount = "";
        public event eMediShop.UpdateMainPageTitleEventHandler MainPageTitle;
        PictureBox picTick = new PictureBox();
        PictureBox picCross = new PictureBox();
        string _division = "";
        public string QNO
        {
            get { return _QNO; }
            set { _QNO = value; }
        }
        public string QType
        {
            get { return _QType; }
            set { _QType = value; }
        }
        public string QInfo
        {
            get { return _QInfo; }
            set { _QInfo = value; }
        }
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        public string RemarkCount
        {
            get { return _remarkCount; }
            set { _remarkCount = value; }
        }
        public QuestionAnswer(string cardNo, string mobileno, string division)
        {
            _division = division;
            _CardNo = cardNo;
            _MobileNo = mobileno;
            InitializeComponent();
        }
        private void QuestionAnswer_Load(object sender, EventArgs e)
        {
            picTick.ImageLocation = Application.StartupPath + "\\" + "tick_circle.png";
            picCross.ImageLocation = Application.StartupPath + "\\" + "icq_dnd.png";
            picTick.Size = new System.Drawing.Size(52, 23);
            picCross.Size = new System.Drawing.Size(52, 23);
            lblQuestion.Text = _QInfo;
            if (_QType == "Optional")
            {
                Button btnYes = new Button();
                btnYes.Name = "btnYes";
                btnYes.Image = global::eMediShop.Properties.Resources.yes;
                btnYes.Size = new System.Drawing.Size(52, 30);
                btnYes.Tag = _QNO;
                btnYes.Click += new System.EventHandler(btnYes_Click);
                Pnl1.Controls.Add(btnYes);
                Button btnNo = new Button();
                btnNo.Size = new System.Drawing.Size(52, 30);
                btnNo.Image = global::eMediShop.Properties.Resources.No;
                btnNo.Name = "btnNo";
                btnNo.Tag = _QNO;
                btnNo.Click += new System.EventHandler(btnNo_Click);
                pnl2.Controls.Add(btnNo);

            }
            else
            {
                TextBox txtAns = new TextBox();
                txtAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                txtAns.Size = new System.Drawing.Size(350, 30);
                txtAns.Multiline = true;
                txtAns.Text = _remark;
                txtAns.TabIndex = 1;
                txtAns.Name = "txtAns" + _QNO;
                txtAns.BringToFront();
                PnlAnswer.Height = 30;
                PnlAnswer.Width = 350;
                PnlAnswer.Controls.Add(txtAns);
                this.Controls.Add(AddCombo());
                Button btnSave = new Button();
                btnSave.Text = "Save";
                btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnSave.Size = new System.Drawing.Size(53, 27);
                btnSave.Name = "btnSave";
                btnSave.Tag = _QNO;
                btnSave.Click += new System.EventHandler(btnSave_Click);
                btnSave.BringToFront();
                pnl2.Controls.Add(btnSave);
                LinkLabel llk = new LinkLabel();
                llk.Size = new System.Drawing.Size(53, 27);
                llk.Name = "llk";
                llk.Text = "T.C:" + _remarkCount;
                llk.Click += new System.EventHandler(llk_Click);
                Pnl1.Controls.Add(llk);

            }
        }
        private ComboBox AddCombo()
        {
            ComboBox cbxPredefinedRemark = new ComboBox();
            cbxPredefinedRemark.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbxPredefinedRemark.FormattingEnabled = true;
            cbxPredefinedRemark.Items.AddRange(new object[] {
            "Select Remark ",
            "No Answer ",
            "Number not in use ",
            "Number not exists ",
            "Number is busy later calling",
            "Out of Coverage",
            "Out of Service",
            "Out of city call later",
            "Present time not required ",
            "Require self call",
            "Regular users",
            "Self Purchase",

            });
            cbxPredefinedRemark.Location = new System.Drawing.Point(3, 48);
            cbxPredefinedRemark.Name = "cbxPredefinedRemark";
            cbxPredefinedRemark.Size = new System.Drawing.Size(485, 24);
            cbxPredefinedRemark.SelectedIndex = 0;
            cbxPredefinedRemark.TabIndex = 39;
            cbxPredefinedRemark.SelectedIndexChanged += new System.EventHandler(cbxPredefinedRemark_SelectedIndexChanged);
            return cbxPredefinedRemark;
        }
        private void llk_Click(object sender, EventArgs e)
        {
            eMediShop.forms.RCM.remarks obj = new eMediShop.forms.RCM.remarks(_CardNo);
            obj.Show();

        }
        private void cbxPredefinedRemark_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((TextBox)PnlAnswer.Controls["txtAns018"]).Text = ((ComboBox)this.Controls["cbxPredefinedRemark"]).Text;
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            string Qno = ((Button)sender).Tag.ToString();
            string qry = @"execute pInsQuestionAnswer '" + _CardNo + "','" + _MobileNo + "','" + Qno + "','Yes','" + _division + "','" + GlobalUsage.Login_id + "' ";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GlobalUsage.pharmacy_proxy.QueryExecute(qry, "customer_data");
                AddMsg("Yes");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { Cursor.Current = Cursors.Default; MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            string Qno = ((Button)sender).Tag.ToString();
            string qry = @"execute pInsQuestionAnswer '" + _CardNo + "','" + _MobileNo + "','" + Qno + "','No','" + _division + "','" + GlobalUsage.Login_id + "' ";
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GlobalUsage.pharmacy_proxy.QueryExecute(qry, "customer_data");
                AddMsg("No");
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { Cursor.Current = Cursors.Default; MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Qno = ((Button)sender).Tag.ToString();
            string answer = ((TextBox)PnlAnswer.Controls["txtAns" + Qno]).Text;
            if (answer.Trim().Length > 1)
            {
                string qry = @"execute pInsQuestionAnswer '" + _CardNo + "','" + _MobileNo + "','" + Qno + "','" + answer + "','" + _division + "','" + GlobalUsage.Login_id + "' ";
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    GlobalUsage.pharmacy_proxy.QueryExecute(qry, "customer_data");
                    _result = "Success";
                    AddMsg("Saved");
                    UpdateMainPageTitleEventArgs valueArgs = new UpdateMainPageTitleEventArgs(_result);
                    MainPageTitle(this, valueArgs);
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex) { Cursor.Current = Cursors.Default; MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else
            { MessageBox.Show("Remark is mandatory"); }
        }
        public void AddMsg(string msg)
        {
            PnlMsg.Controls.Clear();
            Label lblYes = new Label();
            lblYes.Text = msg;
            lblYes.Name = "lblAns";
            lblYes.Size = new System.Drawing.Size(52, 23);
            if (msg == "Yes" || msg == "Saved")
                PnlMsg.Controls.Add(picTick);
            else
                PnlMsg.Controls.Add(picCross);
        }
    }
}