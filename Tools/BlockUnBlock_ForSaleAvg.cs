using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.Tools
{
    public partial class BlockUnBlock_ForSaleAvg : Telerik.WinControls.UI.RadForm
    {
        string _result = string.Empty;
        public BlockUnBlock_ForSaleAvg()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string qry = string.Empty;
            try
            {
                ddProduct.Items.Clear();
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id; p.sale_inv_no = txtSearch.Text; p.item_id = txtSearch.Text;
                p.logic = "SearchProduct"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);
                ddProduct.Items.AddRange(GlobalUsage.FillTelrikCombo(dwr.result.Tables[0]));
                ddProduct.SelectedIndex = 0;
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string qry = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id; p.sale_inv_no = "-"; p.item_id = ddProduct.SelectedValue.ToString();
                p.logic = "List"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);
                dgList.DataSource = dwr.result.Tables[0];
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgList_CommandCellClick(object sender, EventArgs e)
        {
            string qry = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GridCommandCellElement gCommand = (sender as GridCommandCellElement);
                pm_sales p = new pm_sales();
                if (gCommand.CommandButton.Text == "Block")
                {
                    p.unit_id = dgList.CurrentRow.Cells["sh_code"].Value.ToString();
                    p.sale_inv_no = "-"; p.item_id = dgList.CurrentRow.Cells["item_id"].Value.ToString();
                    p.logic = "Block"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);
                    dgList.CurrentRow.Cells["purch_flag"].Value = "N";
                }
                else
                {
                    p.unit_id = dgList.CurrentRow.Cells["sh_code"].Value.ToString();
                    p.sale_inv_no = "-"; p.item_id = dgList.CurrentRow.Cells["item_id"].Value.ToString();
                    p.logic = "UnBlock"; p.login_id = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);
                    dgList.CurrentRow.Cells["purch_flag"].Value = "Y";
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string qry = string.Empty;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_sales p = new pm_sales();
                p.unit_id = GlobalUsage.Unit_id; p.sale_inv_no = "-"; p.item_id = "-";
                p.logic = "Block-List"; p.login_id = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/sales/BlockUnBlockForSalesAverage", p);
                dgBlocked.DataSource = dwr.result.Tables[0];

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void BlockUnBlock_ForSaleAvg_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 160);
        }
        private void dgList_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["purch_flag"].Value.ToString() == "N")
            {
                e.RowElement.ForeColor = Color.Red;
            }
            else
            {
                e.RowElement.ForeColor = Color.Black;
            }
        }

        private void dgList_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                if (e.CellElement.RowInfo.Cells["purch_flag"].Value.ToString() == "Y")
                    ((GridCommandCellElement)e.CellElement).CommandButton.Text = "Block";
                else
                    ((GridCommandCellElement)e.CellElement).CommandButton.Text = "UnBlock";
            }
        }

        private void btn_xl_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog(); dialog.FileName = "ItemblockedList.xlsx";
                dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Telerik.WinControls.Export.GridViewSpreadExport spreadExporter;

                    spreadExporter = new Telerik.WinControls.Export.GridViewSpreadExport(dgBlocked);
                    spreadExporter.ExportVisualSettings = true;
                    spreadExporter.ExportHierarchy = true;
                    spreadExporter.ExportFormat = Telerik.WinControls.Export.SpreadExportFormat.Xlsx;

                    spreadExporter.RunExport(dialog.FileName);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            finally { Cursor.Current = Cursors.Default; }
        }

    }
}
