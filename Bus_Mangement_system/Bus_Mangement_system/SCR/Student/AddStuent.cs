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
        //
        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextBox Watermark
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtFirstName, lblFirstName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtLastName, lblLastName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtPhone, lblPhone);
        }

        #endregion

        #region TextBox Validation
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtFirstName, "Please Enter First Name",ref firstName,e,errorProvider1);
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLastName, "Please Enter Last Name", ref lastName, e, errorProvider1);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Phone Number", ref phone, e, errorProvider1);
        }

        #endregion

        #region ComboBox Validation
        private void cmbAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbAddress, "Please Select Address",ref addressID, e, errorProvider1);
            if (addressID != -1)
                address = cmbAddress.Items[addressID].ToString();
        }
        private void cmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbUniversity, "Please Select University", ref universityID, e, errorProvider1);
        }

        private void cmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBookingType, "Please Select Type", ref bookingID, e, errorProvider1);
        }

        #endregion

        #region Add Student Button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {firstName} {lastName}\nphone:             {phone}\naddress:           {address}\nUniversity:        {cmbUniversity.Items[universityID]}\nBooking Type: {cmbBookingType.Items[bookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {
                    //DB Commands

                    //clear
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    cmbAddress.SelectedIndex = cmbBookingType.SelectedIndex = cmbUniversity.SelectedIndex = -1;
                    MetroFramework.MetroMessageBox.Show(this, "\n\nStudent Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            
            

        }
        #endregion

    }
}
