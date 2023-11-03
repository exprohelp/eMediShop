using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace eMediShop.forms.Utility
{
    public partial class menuRights : Telerik.WinControls.UI.RadForm
    {
        DataSet _ds = new DataSet(); string _result = string.Empty; string _productName = string.Empty; string _empCode = string.Empty;
        string _oldValue = string.Empty; string _newValue = string.Empty;
        public menuRights()
        {
            this.Text = "Import Assigned Menu Rights";
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
                _productName = Application.ProductName;
                pm_Menu_RightsQueries p = new pm_Menu_RightsQueries();
                p.unit_id = GlobalUsage.Unit_id;p.emp_code = GlobalUsage.Login_id;p.Logic= "ListForRights";
                    p.element_name = "EN";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/menu/MenuRightsQueries", p);
                _ds = dwr.result;
                rgv_employee.DataSource = _ds.Tables[0];
                FillUserInfo();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
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
                _empCode = e.Row.Cells["emp_code"].Value.ToString();
                pm_Menu_RightsQueries p = new pm_Menu_RightsQueries();
                p.unit_id = GlobalUsage.Unit_id;p.emp_code = _empCode;p.Logic = "WithAssignMenu";
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/menu/MenuRightsQueries",p);
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
            Cursor.Current = Cursors.WaitCursor;
            GridCommandCellElement gCommand = (sender as GridCommandCellElement);
            string logic = gCommand.CommandButton.Text;
            pm_Insert_Modify_menu_master p = new pm_Insert_Modify_menu_master();
            p.AppName = _productName;
            if (logic == "Enable")
            {
                p.empCode = rgv_employee.CurrentRow.Cells[0].Value.ToString();
                p.element_name = rgv_info.CurrentRow.Cells["element_name"].Value.ToString();
                p.isActive = "Y";p.loginid = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/winmenu/InsertModifyMenuRights", p);
                rgv_info.CurrentRow.Cells["allow"].Value = "Y";
            }
            else
            {
                p.empCode = rgv_employee.CurrentRow.Cells[0].Value.ToString();
                p.element_name = rgv_info.CurrentRow.Cells["element_name"].Value.ToString();
                p.isActive = "N"; p.loginid = GlobalUsage.Login_id;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/winmenu/InsertModifyMenuRights", p);
                rgv_info.CurrentRow.Cells["allow"].Value = "N";

            }
            rgv_info.Refresh();
        }

        private void rgv_info_RowFormatting_1(object sender, RowFormattingEventArgs e)
        {

        }

        private void rgv_info_ViewCellFormatting_1(object sender, CellFormattingEventArgs e)
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
                        e.CellElement.RowElement.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        ((GridCommandCellElement)e.CellElement).CommandButton.Text = "Enable";
                        e.CellElement.RowElement.ForeColor = Color.Black;
                    }

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                cm1 p = new cm1();
                p.unit_id = GlobalUsage.Unit_id; p.Logic = "SearchStaff";
                p.prm_1 = searchText.Text;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/hr/HRQueries", p);
                _ds = dwr.result;
                cmbStaff.Items.Clear();
                cmbStaff.Items.AddRange(Config.FillCombo(_ds.Tables[0]));
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.YesNo, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable dt = new DataTable();
                dt.Columns.Add("unit_id");
                dt.Columns.Add("user_code");
                dt.Columns.Add("user_name");
                dt.Columns.Add("purchaser_flag");
                dt.Columns.Add("checkedby_flag");


                DataRow rowfn = dt.NewRow();
                rowfn["unit_id"] = GlobalUsage.Unit_id;
                rowfn["user_code"] = ((AddValue)cmbStaff.SelectedItem).Value;
                rowfn["user_name"] = ((AddValue)cmbStaff.SelectedItem).NewDescription;
                rowfn["purchaser_flag"] = "N";
                rowfn["checkedby_flag"] = "N";
                dt.Rows.Add(rowfn);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                pm_Authentication p = new pm_Authentication();
                p.ds = ds;
                datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/InsertModifyUnitStaffInfo", p);
                RadMessageBox.Show(dwr.message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                FillUserInfo();
            }
            catch (Exception ex) { RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info); }
            finally { Cursor.Current = Cursors.Default; }

        }

        private void FillUserInfo()
        {
            DataSet ds = new DataSet();
            pm_Authentication pm = new pm_Authentication();
            pm.unit_id = GlobalUsage.Unit_id; pm.Login_id = GlobalUsage.Login_id; pm.logic = "userList";
            datasetWithResult dwr = ConfigWebAPI.CallAPI("api/login/StaffManagement", pm);
            ds = dwr.result;
            rgv_staff.DataSource = ds.Tables[0];
        }

        private void rgv_staff_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (e.Row.Cells[e.ColumnIndex].Value != null)
            {
                _oldValue = (string)e.Row.Cells[e.ColumnIndex].Value;
            }
        }

        private void rgv_staff_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            string qry = string.Empty;
            if (e.Column.Name == "purch_flag")
            {
                #region Purchase Flag Marking
                if (e.Row.Cells["purch_flag"].Value.ToString() != _oldValue)
                {
                    _newValue = e.Row.Cells["purch_flag"].Value.ToString().ToUpper();
                    if (_oldValue != _newValue)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            cm1 p1 = new cm1();
                            p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                            p1.prm_1 = _newValue; p1.prm_2 = e.Row.Cells["emp_code"].Value.ToString();
                            p1.Logic = "Unit_Staff_Info:purchaser_flag";
                            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);

                            if (dwr1.message.Contains("Success"))
                                RadMessageBox.Show("Successfully Marked.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                            else
                                RadMessageBox.Show("Error During PO updation or already linked.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);



                        }
                        catch (Exception ex)
                        {
                            RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }

                }
                #endregion

            }
            else if (e.Column.Name == "check_flag")
            {
                _oldValue = "X";
                #region Checker Flag Marking
                if (e.Row.Cells["check_flag"].Value.ToString() != _oldValue)
                {
                    _newValue = e.Row.Cells["check_flag"].Value.ToString().ToUpper();
                    if (_oldValue != _newValue)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            cm1 p1 = new cm1();
                            p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                            p1.prm_1 = _newValue; p1.prm_2 = e.Row.Cells["emp_code"].Value.ToString();
                            p1.Logic = "Unit_Staff_Info:checkedby_flag";
                            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);
                            if (dwr1.message.Contains("Success"))
                                RadMessageBox.Show("Successfully Marked.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                            else
                                RadMessageBox.Show("Error During PO updation or already linked.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);



                        }
                        catch (Exception ex)
                        {
                            RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }

                }
                #endregion
            }
            else if (e.Column.Name == "status")
            {
                _oldValue = "X";
                #region Checker Flag Marking
                if (e.Row.Cells["status"].Value.ToString() != _oldValue)
                {
                    _newValue = e.Row.Cells["status"].Value.ToString().ToUpper();
                    if (_oldValue != _newValue)
                    {
                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            cm1 p1 = new cm1();
                            p1.unit_id = GlobalUsage.Unit_id; p1.login_id = GlobalUsage.Login_id;
                            p1.prm_1 = _newValue; p1.prm_2 = e.Row.Cells["emp_code"].Value.ToString();
                            p1.Logic = "Unit_Staff_Info:update"; 
                            datasetWithResult dwr1 = ConfigWebAPI.CallAPI("api/common/UpdateTablesInfo", p1);

                            if (dwr1.message.Contains("Success"))
                                RadMessageBox.Show("Successfully Marked.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                            else
                                RadMessageBox.Show("Error During PO updation or already linked.", "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        }
                        catch (Exception ex)
                        {
                            RadMessageBox.Show(ex.Message, "ExPro Help", MessageBoxButtons.OK, RadMessageIcon.Info);
                        }
                        finally
                        {
                            Cursor.Current = Cursors.Default;
                        }
                    }

                }
                #endregion
            }
        }
    }
}
