using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Driver
{
    public partial class EditDriver : Form
    {
        #region Prop
        int driverindex = -1;
        string name, phone, address, salary;
        int iSalary = 0;

        #endregion
        public EditDriver()
        {
            InitializeComponent();
        }
        private void EditDriver_Load(object sender, EventArgs e)
        {
            visible();

            //db 3alashan ageb mn goah

        }

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
                txtName.Visible = false;
                txtAddress.Visible = false;
                txtPhone.Visible = false;
                txtSalary.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                lblName.Visible = true;
                lblAddress.Visible = true;
                lblPhone.Visible = true;
                lblSalary.Visible = true;
                txtName.Visible = true;
                txtAddress.Visible = true;
                txtPhone.Visible = true;
                txtSalary.Visible = true;
            }
           
        }
        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextBox Watermark

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtName, lblName);

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

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtName, "Please Enter Name", ref name, e, errorProvider1);

        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Phone", ref phone, e, errorProvider1);

        }

        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtAddress, "Please Enter Address", ref address, e, errorProvider1);

        }

        private void TxtSalary_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtSalary, "Please Enter Salary", ref salary, e, errorProvider1);

        }

        #endregion

        #region ComboBox Validation

        private void CmbDriver_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbDriver, "Please Select Driver", ref driverindex, e, errorProvider1);

        }

        #endregion

        #region Selected Bus

        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

            visible();

            //db 
            txtName.Text = "Driver";
            txtPhone.Text = "01067893079";
            txtAddress.Text = "aga";
            txtSalary.Text = "5000";


        }

        #endregion

        #region Edit Driver Button

        private void BtnEditDriver_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                bool isNumber = int.TryParse(salary, out iSalary);
                if (isNumber && iSalary != 0)
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:    {name}\nsalary:    {iSalary}\nphone:   {phone}\naddress: {address}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //DB Commands

                        //clear
                        txtName.Clear();
                        txtPhone.Clear();
                        txtAddress.Clear();
                        txtSalary.Clear();
                        cmbDriver.SelectedIndex = -1;
                        MetroFramework.MetroMessageBox.Show(this, "\n\nDriver has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease Enter a correct monthly salary ", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }
    }
}
