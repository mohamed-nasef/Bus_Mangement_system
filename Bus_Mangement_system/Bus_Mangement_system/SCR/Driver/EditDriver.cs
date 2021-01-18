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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        string strName, strPhone, strAddress, strSalary,strID,strOldName,strOldPhone, strOldAddress, strOldSalary;
        int iSalary = 0,iDriverIndex = -1;

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
            connection = new SqlConnection(conString);
            connection.Open();
            cmd = new SqlCommand("select driver_name from driverInformation", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbDriver.Items.Add(dr["driver_name"].ToString());
            }
            connection.Close();
        }
        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
            Functions.validationTxt(txtDriverName, "Please Enter Valid Driver Name Without Any Numbers", ref strName, e, errorProvider1);

        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref strPhone, e, errorProvider1);

        }

        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtAddress, "Please Enter Valid Address Without Any Numbers", ref strAddress, e, errorProvider1);

        }

        private void TxtSalary_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtSalary, "Please Enter Valid Salary Like $ 5000 Not 0 or Character", ref strSalary, e, errorProvider1);

        }

       

        #endregion

        #region ComboBox Validation

        private void CmbDriver_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbDriver, "Please Select Driver", ref iDriverIndex, e, errorProvider1);

        }

        #endregion

        #region Selected Driver
        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
            iDriverIndex = cmbDriver.SelectedIndex + 1;

            strName = cmbDriver.SelectedText;
            connection.Open();
            cmd = new SqlCommand("select * from driverInformation where driver_id ='"+iDriverIndex+"' ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                strID = dr["driver_id"].ToString();
                txtDriverName.Text = dr["driver_name"].ToString();
                strName=strOldName = txtDriverName.Text;
                txtPhone.Text = dr["driver_phone"].ToString();
                strPhone=strOldPhone = txtPhone.Text;
                txtAddress.Text = dr["driver_address"].ToString();
                strOldAddress = strAddress = txtAddress.Text;
                txtSalary.Text = dr["basicSalary"].ToString();
                strOldSalary = strSalary = txtSalary.Text;
                int.TryParse(strSalary, out iSalary);

            }
            connection.Close();

           
        }

        #endregion

        #region Edit Driver Button

        private void BtnEditDriver_Click(object sender, EventArgs e)
        {
            if (strOldName==strName&&strOldPhone==strPhone&&strOldAddress==strAddress&&strOldSalary==strSalary)
                MetroFramework.MetroMessageBox.Show(this, "\n\nYou didn't make any change\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
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
                            connection.Open();
                            // check driver   
                            bool flagName = true;
                            bool flagPhone = true;
                            if (!(strName == strOldName) || !(strPhone == strOldPhone))
                            {
                                // check driver   
                                cmd = new SqlCommand("select driver_name from driverInformation where driver_name ='" + strName + "'", connection);
                                cmd.ExecuteNonQuery();
                                dt = new DataTable();
                                da = new SqlDataAdapter(cmd);
                                da.Fill(dt);
                                foreach (DataRow dr in dt.Rows)
                                {
                                    if (dr["driver_name"].ToString() == strOldName)
                                        flagName = true;

                                    else
                                        flagName = false;
                                }


                                cmd = new SqlCommand("select driver_phone from driverInformation where driver_phone ='" + strPhone + "'", connection);
                                cmd.ExecuteNonQuery();
                                dt = new DataTable();
                                da = new SqlDataAdapter(cmd);
                                da.Fill(dt);
                                foreach (DataRow dr in dt.Rows)
                                {
                                    if (dr["driver_phone"].ToString() == strOldPhone)
                                        flagPhone = true;

                                    else
                                        flagPhone = false;
                                }
                            }

                            if (!flagName || !flagPhone)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "\n\nThis driver already exists\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                connection.Close();
                            }

                            else
                            {
                                iDriverIndex = cmbDriver.SelectedIndex + 1;
                                //DB Commands
                                cmd = new SqlCommand("update driverInformation SET driver_name ='" + strName + "',driver_phone ='" + strPhone + "', driver_address ='" + strAddress + "',basicSalary ='" + iSalary + "' where driver_id ='" + strID + "'", connection);
                                cmd.ExecuteNonQuery();
                                connection.Close();

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
