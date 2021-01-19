using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Driver
{
    public partial class EditDriver : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Driver driver = new Driver();
        
        #endregion

        #region Form
        public EditDriver()
        {
            InitializeComponent();
        }
        private void EditDriver_Load(object sender, EventArgs e)
        {
            visible();
            cmbDriver.SelectedIndex = -1;
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select driver_name from driverInformation", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbDriver.Items.Add(dr["driver_name"].ToString());
            }
            dataBase.connection.Close();
        }
        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

        #region Funcation
        private void visible()
        {
            if (label1.Visible==true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                lblName.Visible = false;
                lblAddress.Visible = false;
                lblPhone.Visible = false;
                lblSalary.Visible = false;
                txtDriverName.Visible = false;
                txtAddress.Visible = false;
                txtPhone.Visible = false;
                txtSalary.Visible = false;
            }
           
        }
        private void show()
        {
            if (label1.Visible==false)
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                lblName.Visible = true;
                lblAddress.Visible = true;
                lblPhone.Visible = true;
                lblSalary.Visible = true;
                txtDriverName.Visible = true;
                txtAddress.Visible = true;
                txtPhone.Visible = true;
                txtSalary.Visible = true;
            }
        }
        #endregion

        #region TextBox Watermark
        private void TxtDriverName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtDriverName, lblName);
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtPhone, lblPhone);

        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtAddress, lblAddress);

        }

        private void TxtSalary_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtSalary, lblSalary);

        }

        #endregion

        #region TextBox Validation

       
        private void TxtDriverName_Validating(object sender, CancelEventArgs e)
        {
            string refStrName="";
            Functions.validationTxt(txtDriverName, "Please Enter Valid Driver Name Without Any Numbers", ref refStrName, e, errorProvider1);
            driver.strName = refStrName;
        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            string refStrPhone = "";
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref refStrPhone, e, errorProvider1);
            driver.strPhone = refStrPhone;
        }

        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
            string refStrAddress = "";
            Functions.validationTxt(txtAddress, "Please Enter Valid Address Without Any Numbers", ref refStrAddress, e, errorProvider1);
            driver.strAddress = refStrAddress;
        }

        private void TxtSalary_Validating(object sender, CancelEventArgs e)
        {
            string refStrSalary = "";
            Functions.validationTxt(txtSalary, "Please Enter Valid Salary Like $ 5000 Not 0 or Character", ref refStrSalary, e, errorProvider1);
            driver.strSalary = refStrSalary;
        }

       

        #endregion

        #region ComboBox Validation

        private void CmbDriver_Validating(object sender, CancelEventArgs e)
        {
            int refIDriverIndex=0;
            Functions.validationcmb(cmbDriver, "Please Select Driver", ref refIDriverIndex, e, errorProvider1);
            driver.iDriverIndex = refIDriverIndex;
        }

        #endregion

        #region Selected Driver
        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
            driver.iDriverIndex = cmbDriver.SelectedIndex + 1;

            driver.strName = cmbDriver.SelectedText;
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select * from driverInformation where driver_id ='"+ driver.iDriverIndex +"' ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                driver.strID = dr["driver_id"].ToString();
                txtDriverName.Text = dr["driver_name"].ToString();
                driver.strName = driver.strOldName = txtDriverName.Text;
                txtPhone.Text = dr["driver_phone"].ToString();
                driver.strPhone = driver.strOldPhone = txtPhone.Text;
                txtAddress.Text = dr["driver_address"].ToString();
                driver.strOldAddress = driver.strAddress = txtAddress.Text;
                txtSalary.Text = dr["basicSalary"].ToString();
                driver.strOldSalary = driver.strSalary = txtSalary.Text;
                int refISalary;
                int.TryParse(driver.strSalary, out refISalary);
                driver.iSalary = refISalary;
            }
            dataBase.connection.Close();

           
        }

        #endregion

        #region Edit Driver Button

        private void BtnEditDriver_Click(object sender, EventArgs e)
        {
            if (driver.strOldName == driver.strName && driver.strOldPhone == driver.strPhone && driver.strOldAddress == driver.strAddress && driver.strOldSalary == driver.strSalary)
                MetroFramework.MetroMessageBox.Show(this, "\n\nYou didn't make any change\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                //Validition
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    int refISalary;
                    bool isNumber = int.TryParse(driver.strSalary, out refISalary);
                    driver.iSalary = refISalary;

                    if (isNumber && driver.iSalary != 0)
                    {
                        DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:    {driver.strName}\nsalary:    {driver.iSalary}\nphone:   {driver.strPhone}\naddress: {driver.strAddress}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            dataBase.connection.Open();
                            // check driver   
                            bool flagName = true;
                            bool flagPhone = true;
                            if (!(driver.strName == driver.strOldName) || !(driver.strPhone == driver.strOldPhone))
                            {
                                // check driver   
                                dataBase.cmd = new SqlCommand("select driver_name from driverInformation where driver_name ='" + driver.strName + "'", dataBase.connection);
                                dataBase.cmd.ExecuteNonQuery();
                                dataBase.dt = new DataTable();
                                dataBase.da = new SqlDataAdapter(dataBase.cmd);
                                dataBase.da.Fill(dataBase.dt);
                                foreach (DataRow dr in dataBase.dt.Rows)
                                {
                                    if (dr["driver_name"].ToString() == driver.strOldName)
                                        flagName = true;

                                    else
                                        flagName = false;
                                }


                                dataBase.cmd = new SqlCommand("select driver_phone from driverInformation where driver_phone ='" + driver.strPhone + "'", dataBase.connection);
                                dataBase.cmd.ExecuteNonQuery();
                                dataBase.dt = new DataTable();
                                dataBase.da = new SqlDataAdapter(dataBase.cmd);
                                dataBase.da.Fill(dataBase.dt);
                                foreach (DataRow dr in dataBase.dt.Rows)
                                {
                                    if (dr["driver_phone"].ToString() == driver.strOldPhone)
                                        flagPhone = true;

                                    else
                                        flagPhone = false;
                                }
                            }

                            if (!flagName || !flagPhone)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "\n\nThis driver already exists\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dataBase.connection.Close();
                            }

                            else
                            {
                                driver.iDriverIndex = cmbDriver.SelectedIndex + 1;
                                //DB Commands
                                dataBase.cmd = new SqlCommand("update driverInformation SET driver_name ='" + driver.strName + "',driver_phone ='" + driver.strPhone + "', driver_address ='" + driver.strAddress + "',basicSalary ='" + driver.iSalary + "' where driver_id ='" + driver.strID + "'", dataBase.connection);
                                dataBase.cmd.ExecuteNonQuery();
                                dataBase.connection.Close();

                                //clear
                                txtDriverName.Clear();
                                txtPhone.Clear();
                                txtAddress.Clear();
                                txtSalary.Clear();
                                cmbDriver.SelectedIndex = -1;

                                MetroFramework.MetroMessageBox.Show(this, "\n\nDriver has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                this.Close();
                            }

                        }
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "\n\nPlease Enter a correct monthly salary ", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

            #endregion

        }
    }
}
