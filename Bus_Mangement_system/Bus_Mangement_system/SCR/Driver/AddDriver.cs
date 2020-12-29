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
    public partial class AddDriver : Form
    {

        #region Prop
        string name, phone, address,salary;
        int iSalary=0;

        #endregion

        public AddDriver()
        {
            InitializeComponent();
        }

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextBox Watermark
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtName, lblName);
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

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtName, "Please Enter Name", ref name, e, errorProvider1);
        }


        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Phone", ref phone, e, errorProvider1);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtAddress, "Please Enter Address", ref address, e, errorProvider1);
        }

        private void TxtSalary_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtSalary, "Please Enter Salary", ref salary, e, errorProvider1);

        }

        #endregion

        #region Add Driver Button

        private void btnAddDriver_Click(object sender, EventArgs e)
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
                        MetroFramework.MetroMessageBox.Show(this, "\n\nDriver Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease Enter a correct monthly salary ", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        #endregion

    }
}
