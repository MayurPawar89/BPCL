using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DBLayer;

namespace PROJ_BPCL
{
    public partial class Form1 : Form
    {
        DBAccess dbAccessLayer = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbAccessLayer = new DBAccess();
            //PerformFormLoad();
            if (CheckApplication())
                PerformFormLoad();
            else
                Application.Exit();
        }

        #region " Private methods "
        string sDefaultTahsil = string.Empty;
        private void PerformFormLoad()
        {
            DataTable dtTemp = null;
            sDefaultTahsil = Convert.ToString(ConfigurationSettings.AppSettings["DefaultTahsil"]);
            try
            {
                dbAccessLayer = new DBAccess();

                //Fill Gender dropdownlist
                dtTemp = dbAccessLayer.GetGender();
                BindDropDownList(dtTemp.Copy());
                dtTemp = null;

                //Fill Tehsil dropdownlist
                dtTemp = dbAccessLayer.GetTehsil();
                BindDropDownList(dtTemp.Copy());
                dtTemp = null;

                //Fill Grampanchayat dropdownlist
                dtTemp = dbAccessLayer.GetGrampanchayat(Convert.ToString(cmbTaluka.Text));
                BindDropDownList(dtTemp.Copy());
                dtTemp = null;

                //Fill Town dropdownlist
                dtTemp = dbAccessLayer.GetTown(Convert.ToString(cmbTaluka.Text), Convert.ToString(cmbGrampanchayat.Text));
                BindDropDownList(dtTemp.Copy());
                dtTemp = null;

                rdInformation.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form data: " + ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dtTemp != null) { dtTemp.Dispose(); dtTemp = null; }  
            }
        }

        private DataTable AddAllOption(DataTable dt)
        {
            DataRow dr = null;
            try
            {
                if (dt != null)
                {
                    switch (dt.TableName)
                    {
                        case "Gender":
                            {
                                dr = dt.NewRow();
                                dr["GENDERID"] = "ALL";
                                dt.Rows.InsertAt(dr, 0);
                                dt.AcceptChanges();
                            }
                            break;
                        case "Tehsil":
                            {
                                dr = dt.NewRow();
                                dr["TEHSILCODE"] = "TEHSIL";
                                dr["TEHSILNAME"] = "ALL";
                                dt.Rows.InsertAt(dr, 0);
                                dt.AcceptChanges();
                            }
                            break;
                        case "Grampanchayat":
                            {
                                dr = dt.NewRow();
                                dr["GRAMPANCHAYATCODE"] = "GRAMPANCHAYAT";
                                dr["GRAMPANCHAYATNAME"] = "ALL";
                                dt.Rows.InsertAt(dr, 0);
                                dt.AcceptChanges();
                            }
                            break;
                        case "Town":
                            {
                                dr = dt.NewRow();
                                dr["TOWNCODE"] = "TOWN";
                                dr["TOWNNAME"] = "ALL";
                                dt.Rows.InsertAt(dr, 0);
                                dt.AcceptChanges();
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr = null;
            }

            return dt;
        }

        private DataTable BindDropDownList(DataTable dt)
        {
            DataTable dtTempTable = null;

            try
            {
                cmbTaluka.SelectedIndexChanged -= cmbTaluka_SelectedIndexChanged;
                cmbGrampanchayat.SelectedIndexChanged -=cmbGrampanchayat_SelectedIndexChanged;
                cmbTown.SelectedIndexChanged -=cmbTown_SelectedIndexChanged;

                if (dt != null)
                {
                    switch (dt.TableName)
                    {
                        case "Gender":
                            {
                                cmbGender.DataSource = null;
                                dtTempTable = AddAllOption(dt.Copy());
                                cmbGender.DataSource = dtTempTable.Copy();
                                cmbGender.DisplayMember = "GENDERID";
                                cmbGender.ValueMember = "GENDERID";
                                cmbGender.Text = "ALL";
                            }
                            break;
                        case "Tehsil":
                            {

                                cmbTaluka.DataSource = null;
                                dtTempTable = dt.Copy(); //AddAllOption(dt.Copy());
                                cmbTaluka.DataSource = dtTempTable.Copy();
                                cmbTaluka.DisplayMember = "TEHSILNAME";
                                cmbTaluka.ValueMember = "TEHSILCODE";
                                cmbTaluka.SelectedValue = sDefaultTahsil;
                                cmbTaluka.Text = sDefaultTahsil;
                            }
                            break;
                        case "Grampanchayat":
                            {
                                cmbGrampanchayat.DataSource = null;
                                dtTempTable = AddAllOption(dt.Copy());
                                cmbGrampanchayat.DataSource = dtTempTable.Copy();
                                cmbGrampanchayat.DisplayMember = "GRAMPANCHAYATNAME";
                                cmbGrampanchayat.ValueMember = "GRAMPANCHAYATCODE";
                                cmbGrampanchayat.Text = "ALL";
                            }
                            break;
                        case "Town":
                            {
                                cmbTown.DataSource = null;
                                dtTempTable = AddAllOption(dt.Copy());
                                cmbTown.DataSource = dtTempTable.Copy();
                                cmbTown.DisplayMember = "TOWNNAME";
                                cmbTown.ValueMember = "TOWNCODE";
                                cmbTown.Text = "ALL";
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmbTaluka.SelectedIndexChanged += cmbTaluka_SelectedIndexChanged;
                cmbGrampanchayat.SelectedIndexChanged += cmbGrampanchayat_SelectedIndexChanged;
                cmbTown.SelectedIndexChanged += cmbTown_SelectedIndexChanged;

                if (dtTempTable != null) { dtTempTable.Dispose(); dtTempTable = null; }
                if (dt != null) { dt.Dispose(); dt = null; }
            }

            return dt;
        }

        private void PerformSearch()
        {
            DataTable dtResult = null;
            
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string selectedGender = string.Empty;
                string selectedTehsil = string.Empty;
                string selectedGrampanchayat = string.Empty;
                string selectedTown = string.Empty;
                string nameSearchText = string.Empty; 
                string nameSearchTextP2 = string.Empty; 
                string nameSearchTextP3 = string.Empty;
                string fatherNameSearchText = string.Empty;
                string motherNameSearchText = string.Empty;
                string ahlTinText = string.Empty;
                string nprTinTest = string.Empty;
                string searchWith = string.Empty;

                if (cmbGender.Text.Trim() != "" && cmbGender.Text.Trim() != "ALL")
                { selectedGender = cmbGender.Text; }
                else
                { selectedGender = null; }

                if (cmbTaluka.Text.Trim() != "ALL")
                { selectedTehsil = cmbTaluka.Text; }
                else
                { selectedTehsil = null; }

                if (cmbGrampanchayat.Text.Trim() != "ALL")
                { selectedGrampanchayat = cmbGrampanchayat.Text; }
                else
                { selectedGrampanchayat = null; }

                if (cmbTown.Text.Trim() != "ALL")
                { selectedTown = cmbTown.Text; }
                else
                { selectedTown = null; }

                if(txtNameSearch.Text.Trim().Length > 0)
                {nameSearchText = txtNameSearch.Text.Trim(); }
                else
                {nameSearchText = null; }

                if(txtNameSearch_P2.Text.Trim().Length > 0)
                {nameSearchTextP2 = txtNameSearch_P2.Text.Trim(); }
                else
                {nameSearchTextP2 = null; }

                if(txtNameSearch_P3.Text.Trim().Length > 0)
                {nameSearchTextP3 = txtNameSearch_P3.Text.Trim(); }
                else
                {nameSearchTextP3 = null; }

                if (txtMotherNameSearch.Text.Trim().Length > 0)
                { motherNameSearchText = txtMotherNameSearch.Text.Trim(); }
                else
                { motherNameSearchText = null; }

                if (txtFatherNameSearch.Text.Trim().Length > 0)
                { fatherNameSearchText = txtFatherNameSearch.Text.Trim(); }
                else
                { fatherNameSearchText = null; }

                if (txtAHL_TIN.Text.Trim().Length > 0)
                { ahlTinText = txtAHL_TIN.Text.Trim(); }
                else
                { ahlTinText = null; }

                //if (txtNPR_TIN.Text.Trim().Length > 0)
                //{ nprTinTest = txtNPR_TIN.Text.Trim(); }
                //else
                //{ nprTinTest = null; }

                if (rdInformation.Checked)
                { searchWith = Convert.ToString(rdInformation.Tag.ToString()); }
                else if(rdTINID.Checked)
                { searchWith = Convert.ToString(rdTINID.Tag.ToString()); }

                dtResult = dbAccessLayer.SearchPerson(selectedTehsil, selectedGrampanchayat, selectedTown, selectedGender, 
                                nameSearchText, nameSearchTextP2, nameSearchTextP3, fatherNameSearchText, motherNameSearchText,ahlTinText,searchWith);

                dtResult.Columns["NAME"].SetOrdinal(1);
                dtResult.Columns["FATHERNAME"].SetOrdinal(2);
                dtResult.Columns["MOTHERNAME"].SetOrdinal(3);

                dgvResult.DataSource = null;
                dgvResult.DataSource = dtResult.Copy();

                dgvResult.Columns["AHL_TIN"].Width = 250;
                dgvResult.Columns["NAME"].Width = 250;
                dgvResult.Columns["FATHERNAME"].Width = 250;
                dgvResult.Columns["MOTHERNAME"].Width = 250;

                dgvResult.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching data. Contact your application vendor."+ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                if (dtResult != null) { dtResult.Dispose(); dtResult = null; }
            }
        }

        private Boolean CheckApplication()
        {
            bool _result = false;
            try
            {
                DataTable dtTemp = dbAccessLayer.GetProductKey();
                if (dtTemp != null && dtTemp.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtTemp.Rows)
                    {
                        string sEncKey = Convert.ToString(dr["sKeyText"]);
                        string sDecriptedKey = Encryption.DecryptFromBase64String(sEncKey);
                        string sCurrentKey = System.Environment.MachineName.ToUpper() + "-admin123";
                        if (sDecriptedKey ==sCurrentKey)
                        {
                            _result = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form data: " + ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
            }
      
            
            return _result;
        }
        #endregion " Private methods "

        #region " Form button events " 

        private void btnClearSearchFields_Click(object sender, EventArgs e)
        {
            if (rdInformation.Checked)
            {
                txtNameSearch.Clear();
                txtNameSearch_P2.Clear();
                txtNameSearch_P3.Clear();
                txtMotherNameSearch.Clear();
                txtFatherNameSearch.Clear();
            }
            else if (rdTINID.Checked)
            {
                txtAHL_TIN.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        #endregion " Form button events "

        #region " Combo events "

        private void cmbTaluka_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtTemp = null;
            
            try
            {
                //Fill Grampanchayat dropdownlist
                dtTemp = dbAccessLayer.GetGrampanchayat(Convert.ToString(cmbTaluka.Text));
                BindDropDownList(dtTemp.Copy());
                dtTemp = null;

                //Fill Town dropdownlist
                dtTemp = dbAccessLayer.GetTown(Convert.ToString(cmbTaluka.Text), Convert.ToString(cmbGrampanchayat.Text));
                BindDropDownList(dtTemp.Copy());
                dtTemp = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Tehsil drop-down selection change event" + ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dtTemp != null) { dtTemp.Dispose(); dtTemp = null; }
            }
        }

        private void cmbGrampanchayat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtTemp = null;

            try
            {
                //Fill Town dropdownlist
                dtTemp = dbAccessLayer.GetTown(Convert.ToString(cmbTaluka.Text), Convert.ToString(cmbGrampanchayat.Text));
                BindDropDownList(dtTemp.Copy());
                dtTemp = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Grampanchayat drop-down selection change event" + ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dtTemp != null) { dtTemp.Dispose(); dtTemp = null; }
            }
        }

        private void cmbTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error at Town drop-down selection change event" + ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion " Combo events "

        #region "Radio Button events"
        private void rdInformation_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideSearchPanel();
        }

        private void ShowHideSearchPanel()
        {
            if (rdInformation.Checked)
            {
                pnlSearchInformation.Visible = true;
                pnlSearchTIN_ID.Visible = false;
                pnlTop.Height = 189;
            }
            else if (rdTINID.Checked)
            {
                pnlSearchInformation.Visible = false;
                pnlSearchTIN_ID.Visible = true;
                pnlTop.Height = 132;
                if (dgvResult.CurrentCell.ColumnIndex == 0)
                {
                    txtAHL_TIN.Text = dgvResult.CurrentCell.Value.ToString();
                }
            }
        }

        private void rdTINID_CheckedChanged(object sender, EventArgs e)
        {
            ShowHideSearchPanel();
        } 
        #endregion
        
    }
}
