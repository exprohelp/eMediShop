using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using ExPro.Client;
using ExPro.Server;

namespace eMediShop
{
    public partial class ChangePassword : Telerik.WinControls.UI.RadForm
    {
        string _empCode = string.Empty; string _result =string.Empty;
           
        public ChangePassword(string emp_code)
        {
            InitializeComponent();
            _empCode = emp_code;
        }

        public static string Encryption(string strPwd)
        {
            string strHex = string.Empty;

            byte[] HashValue, MessageBytes = UnicodeEncoding.Default.GetBytes(strPwd);

            SHA512 sha512 = new SHA512Managed();

            HashValue = sha512.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
                strHex += string.Format("{0:x2}", b);
            return strHex;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Blank Field Not Allowed", "Expro Help");
                txtName.Focus();
                txtName.Clear();
                txtName.Select();
                return;
            }
            else
            {
                pm_Authentication p = new pm_Authentication();
                p.emp_code = txtName.Text;p.old_password = txtPassword.Text;p.new_password = txtNewPassword.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/ChangeLoginPassword", p);
                MessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

 
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtPassword.Focus();
 
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtName.Text = _empCode;
        }
    }
}
