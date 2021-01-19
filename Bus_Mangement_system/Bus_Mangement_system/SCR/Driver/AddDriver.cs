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
    public partial class AddDriver : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Driver driver = new Driver();

        #endregion

        #region Form

        public AddDriver()
        {
            InitializeComponent();
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {
            dataBase.connection = new SqlConnection(dataBase.conString);
        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

        #region TextBox Watermark
        private void TxtDriverName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtDriverName, lblName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtPhone, lblPhone);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
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
            string refStrName = "";
            Functions.validationTxt(txtDriverName, "Please Enter Valid Driver Name Without Any Numbers", ref refStrName, e, errorProvider1);
            driver.strName = refStrName;
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string refStrPhone = "";
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref refStrPhone, e, errorProvider1);
            driver.strPhone = refStrPhone;
        }


        private void txtAddress_Validating(object sender, CancelEventArgs e)
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

        #region Add Driver Button

        private void btnAddDriver_Click(object sender, EventArgs e)
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
                        //DB Commands
                        dataBase.connection = new SqlConnection(dataBase.conString);
                        dataBase.connection.Open();
                        dataBase.da = new SqlDataAdapter("SELECT driver_id from driverInformation where driver_name ='" + driver.strName + "'", dataBase.connection);
                        try
                        {
                            dataBase.ds = new DataSet();
                            dataBase.da.Fill(dataBase.ds, "driverid");
                            dataBase.dr = dataBase.ds.Tables["driverid"].Rows[0];
                            if (dataBase.ds.Tables["driverid"].Rows.Count > 0)
                                MetroFramework.MetroMessageBox.Show(this, "\n\nYou have already added this Driver\nPlease go to Add Salary or Edit", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        catch (Exception)
                        {
                            dataBase.cmd = new SqlCommand("insert into driverInformation (driver_name,driver_phone,driver_address,basicSalary)values('" + driver.strName + "','" + driver.strPhone + "','" + driver.strAddress + "',"+ driver.iSalary + ")", dataBase.connection);
                            dataBase.cmd.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "\n\nDriver Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        }

                        //clear
                        txtDriverName.Clear();
                        txtPhone.Clear();
                        txtAddress.Clear();
                        txtSalary.Clear();
                    }

                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease Enter a correct monthly salary ", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        #endregion

    }
}
