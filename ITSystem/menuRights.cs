using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.ITSystem
{
    public partial class menuRights : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _productName = string.Empty;
        public menuRights(string productName)
        {
            _productName = productName;
            this.Text = "Assign Menu Rights For " + _productName;
            InitializeComponent();
        }

        private void menuRights_Load(object sender, EventArgs e)
        {
            Rectangle rec = Screen.PrimaryScreen.WorkingArea;
            int size = (rec.Size.Width - this.Width) / 2;
            this.Location = new System.Drawing.Point(size, 165);
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Menu_RightsQueries p = new pm_Menu_RightsQueries();
                p.unit_id = GlobalUsage.Unit_id; p.emp_code = "N/A"; p.Logic = _productName + ":LoginList";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/menu/MenuRightsQueries", p);
                _ds = dwr.result;
                rgv_employee.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void btn_FillMenu_Click(object sender, EventArgs e)
        {


        }

        private void MasterTemplate_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pm_Menu_RightsQueries p = new pm_Menu_RightsQueries();
                p.unit_id = GlobalUsage.Unit_id;p.emp_code = e.Row.Cells[0].Value.ToString();p.Logic = "WithAssignMenu";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/menu/MenuRightsQueries", p);
                _ds = dwr.result;
                rgv_info.DataSource = _ds.Tables[0];
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void rgv_info_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement.RowInfo.Cells["Allow"].Value != null && e.RowElement.RowInfo.Cells["Allow"].Value.ToString() == "Y")
            {
                e.RowElement.ForeColor = Color.Green;
            }
            else
            {
                e.RowElement.ForeColor = Color.Black;
            }
        }

        private void rgv_info_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (e.CellElement is GridCommandCellElement)
            {
                if (((GridCommandCellElement)e.CellElement).ColumnInfo.Name == "A")
                {
                    // ((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
                    if (e.CellElement.RowInfo.Cells["allow"].Value.ToString() == "Y")
                    {
                        //((GridCommandCellElement)e.CellElement).CommandButton.Image = Resources.attachment;
                        //((GridCommandCellElement)e.CellElement).CommandButton.Visibility = Telerik.WinControls.ElementVisibility.Visible;
                        ((GridCommandCellElement)e.CellElement).CommandButton.Text = "Disable";
                    }
                    else
                    {
                        ((GridCommandCellElement)e.CellElement).CommandButton.Text = "Enable";
                    }

                }
            }
        }

        private void rgv_info_CommandCellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                GridCommandCellElement gCommand = (sender as GridCommandCellElement);
                string logic = gCommand.CommandButton.Text;
                pm_Insert_Modify_menu_master p = new pm_Insert_Modify_menu_master();
                if (logic == "Enable")
                {
                    p.AppName = _productName;
                    p.empCode = rgv_employee.CurrentRow.Cells[0].Value.ToString();
                    p.element_name = rgv_info.CurrentRow.Cells["element_name"].Value.ToString();
                    p.isActive = "Y"; p.loginid = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/winmenu/InsertModifyMenuRights", p);
                    _result = dwr.message;
                    rgv_info.CurrentRow.Cells["allow"].Value = "Y";
                }
                else
                {
                    p.AppName = _productName;
                    p.empCode = rgv_employee.CurrentRow.Cells[0].Value.ToString();
                    p.element_name = rgv_info.CurrentRow.Cells["element_name"].Value.ToString();
                    p.isActive = "N"; p.loginid = GlobalUsage.Login_id;
                    datasetWithResult dwr = ConfigWebAPI.CallAPI("api/winmenu/InsertModifyMenuRights", p);
                    _result = dwr.message;
                    rgv_info.CurrentRow.Cells["allow"].Value = "N";

                }
                rgv_info.Refresh();
            }

            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }
        }
    }
}
