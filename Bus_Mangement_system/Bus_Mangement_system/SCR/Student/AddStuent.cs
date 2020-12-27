using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Student
{
    public partial class AddStuent : Form
    {
        string firstName,lastName, phone,address;
        int addressID = -1, universityID, bookingID;
        public AddStuent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ValidationFun
        private void validationTxt(Guna.UI.WinForms.GunaTextBox txt ,string errorMessage,ref string str ,CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, errorMessage);
            }        
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, null);
                str = txt.Text;
            }
        }
        private void validationcmb(Guna.UI.WinForms.GunaComboBox cmb, string errorMessage, ref int index, CancelEventArgs e)
        {
            if(cmb.SelectedItem==null)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmb, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmb, null);
                index = cmb.SelectedIndex;
            }
        }
        #endregion

        #region CmbValidation
        private void cmbAddress_Validating(object sender, CancelEventArgs e)
        {
            validationcmb(cmbAddress, "Please Select Address",ref addressID, e);
            if (addressID != -1)
                address = cmbAddress.Items[addressID].ToString();
        }
        private void cmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            validationcmb(cmbUniversity, "Please Select University", ref universityID, e);
        }

        private void cmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            validationcmb(cmbUniversity, "Please Select University", ref bookingID, e);
        }

        #endregion

        #region TextValidation
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtFirstName, "Please Enter First Name",ref firstName,e);
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtLastName, "Please Enter Last Name", ref lastName, e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtPhone, "Please Enter Phone Number", ref phone, e);
        }

        #endregion

        #region AddButton
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //DB Commands
                MetroFramework.MetroMessageBox.Show(this, $"name is :{firstName} {lastName}\n{phone}\n{address}\n{cmbUniversity.Items[universityID]}\n{cmbBookingType.Items[bookingID]}", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtFirstName.Clear();
                txtLastName.Clear();
                txtPhone.Clear();
                cmbAddress.SelectedIndex = cmbBookingType.SelectedIndex = cmbUniversity.SelectedIndex = -1;
                MetroFramework.MetroMessageBox.Show(this, "\n\nStudent Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            
            

        }
        #endregion

    }
}
