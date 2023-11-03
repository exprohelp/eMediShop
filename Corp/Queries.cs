using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinForms.Documents.Layout;
using Telerik.WinForms.Documents.Model;

namespace eMediShop.Corp
{
    public partial class Queries : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet();
        string _result = string.Empty;
        public Queries()
        {
            InitializeComponent();
        }

        private void Queries_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
            fill_Pending();
           }
        private void fill_Pending() 
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                _ds = GlobalUsage.pharmacy_proxy.Corporate_AnalysisQueries(out _result,GlobalUsage.Unit_id,"N/A","Pending","N/A","N/A","N/A","1900/01/01","1900/01/01");
                radGridView1.DataSource = _ds.Tables[0];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message,"ExPro Help",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default;}
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            Fill_Remarks();
        }

        private void Fill_Remarks()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                RadDocument document = new RadDocument();

                Paragraph paragraph1 = new Paragraph();
                _ds = GlobalUsage.pharmacy_proxy.Corporate_AnalysisQueries(out _result, GlobalUsage.Unit_id, "N/A", "Remark_2", radGridView1.CurrentRow.Cells["sale_inv_no"].Value.ToString(), "N/A", "N/A", "1900/01/01", "1900/01/01");
                foreach (DataRow dr in _ds.Tables[0].Rows)
                {
                    Paragraph paragraph = new Paragraph();
                    Section section = new Section();
                    Span head = new Span(dr["emp_name"].ToString() + Environment.NewLine);
                    Span remark = new Span(dr["remarks"].ToString());
                    head.ForeColor = Color.Blue;
                    head.FontSize = 11;
                    paragraph.Inlines.Add(head);
                    remark.FontStyle = FontStyle.Italic;
                    remark.FontSize = 11;
                    paragraph.Inlines.Add(remark);
                    section.Blocks.Add(paragraph);
                    document.Sections.Add(section);
                }
                this.radRichTextEditor1.Document = document;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.WaitCursor; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GlobalUsage.pharmacy_proxy.Verify_UPPoliceDoc(out _result, radGridView1.CurrentRow.Cells["sale_inv_no"].Value.ToString(), txtRemarks.Text, GlobalUsage.Login_id, "U");
                Fill_Remarks();
                txtRemarks.Text = "N/A";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

    }
}
