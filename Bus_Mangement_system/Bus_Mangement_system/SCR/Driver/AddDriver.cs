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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop
        string strName, strPhone, strAddress,strSalary;
        int iSalary=0;

        #endregion

        #region Form

        public AddDriver()
        {
            InitializeComponent();
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
            Functions.validationTxt(txtDriverName, "Please Enter Valid Driver Name Without Any Numbers", ref strName, e, errorProvider1);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref strPhone, e, errorProvider1);
        }


        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtAddress, "Please Enter Valid Address Without Any Numbers", ref strAddress, e, errorProvider1);
        }

        private void TxtSalary_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtSalary, "Please Enter Valid Salary Like $ 5000 Not 0 or Character", ref strSalary, e, errorProvider1);

        }

        #endregion

        #region Add Driver Button

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                bool isNumber = int.TryParse(strSalary, out iSalary);
                if (isNumber && iSalary != 0)
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:    {strName}\nsalary:    {iSalary}\nphone:   {strPhone}\naddress: {strAddress}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //DB Commands
                        connection = new SqlConnection(conString);
                        connection.Open();
                        da = new SqlDataAdapter("SELECT driver_id from driverInformation where driver_name ='" + strName + "'", connection);
                        try
                        {
                            ds = new DataSet();
                            da.Fill(ds, "driverid");
                            dr = ds.Tables["driverid"].Rows[0];
                            if (ds.Tables["driverid"].Rows.Count > 0)
                                MetroFramework.MetroMessageBox.Show(this, "\n\nYou have already added this Driver\nPlease go to Add Salary or Edit", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        catch (Exception)
                        {
                            cmd = new SqlCommand("insert into driverInformation (driver_name,driver_phone,driver_address,basicSalary)values('" + strName + "','" + strPhone + "','" + strAddress + "',"+ iSalary + ")", connection);
                            cmd.ExecuteNonQuery();
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
