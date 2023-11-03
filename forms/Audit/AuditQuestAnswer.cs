using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using eMediShop;
public partial class AuditQuestAnswer : UserControl
{
    string _QNO = "";
    string _QStatus = "";
    string _QInfo = "";
    string _Ans = "";
    string _HeadId = string.Empty;
    string _AuditId = string.Empty;
    int _rate = 0;
    int _max_rate = 0;
    PictureBox picTick = new PictureBox();
    PictureBox picCross = new PictureBox();
    public string QNO
    {
        get { return _QNO; }
        set { _QNO = value; }
    }
    public string QStatus
    {
        get { return _QStatus; }
        set { _QStatus = value; }
    }
    public string QInfo
    {
        get { return _QInfo; }
        set { _QInfo = value; }
    }
    public string QAans
    {
        get { return _Ans; }
        set { _Ans = value; }
    }
    public int MaxRate
    {
        get { return _max_rate; }
        set { _max_rate = value; }
    }
    public int Rating
    {
        get { return _rate; }
        set { _rate = value; }
    }
    public AuditQuestAnswer(string HeadId, string AuditId)
    {
        _HeadId = HeadId;
        _AuditId = AuditId;
        InitializeComponent();
    }
    private void QuestionAnswer_Load(object sender, EventArgs e)
    {
        btnSave.Tag = _QNO;
        txtRemark.Text = _Ans;
        lblQuestion.Text = _QInfo;
        txtrate.Text = _rate.ToString();
        txtMaxRate.Text = _max_rate.ToString();
        if (_QStatus == "Y")
        { rbOk.Checked = true; rbNotOk.Checked = false; }
        else
        { rbOk.Checked = false; rbNotOk.Checked = true; }
    }
    private void btnSave_Click_1(object sender, EventArgs e)
    {
        string _result = "";
        string status_flag = "N";
        if (rbOk.Checked)
            status_flag = "Y";
        else
            status_flag = "N";
        string Qno = btnSave.Tag.ToString();
        string answer = txtRemark.Text;
        try
        {
            Cursor.Current = Cursors.WaitCursor;
            _result = DateTime.Now.Second.ToString();
            GlobalUsage.pharmacy_proxy.QuestAuditAnswerInsWithRating(out _result, _AuditId, GlobalUsage.Unit_id, Convert.ToInt32(_HeadId), Convert.ToInt32(Qno), Convert.ToInt32(txtrate.Text), status_flag, answer, GlobalUsage.Login_id);
            lblMsg.Text = _result;
            Cursor.Current = Cursors.Default;
        }
        catch (Exception ex) { Cursor.Current = Cursors.Default; MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
    }
}
