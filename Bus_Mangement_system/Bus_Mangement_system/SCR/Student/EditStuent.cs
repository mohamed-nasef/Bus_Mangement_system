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
    public partial class EditStuent : Form
    {
        public int ID { get; set; }
        string firstName, lastName, phone, address;
        int addressID = -1, universityID, bookingID;



        public EditStuent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(294, 30);
        }
        private void EditStuent_Load(object sender, EventArgs e)
        {
            //waterwark
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblPhone.Visible = false;

            lblID.Text = this.ID.ToString();

            //data from database

            firstName = txtFirstName.Text = "Moustafa";
            lastName = txtLastName.Text = "Ibrahem";
            phone = txtPhone.Text = "01067893079";
            addressID = 1;
            cmbAddress.SelectedIndex = addressID;
            address= cmbAddress.Items[addressID].ToString();
            universityID = 1;
            cmbUniversity.SelectedIndex = universityID;
            bookingID = 0;
            cmbBookingType.SelectedIndex = bookingID;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region TextBox Watermark
        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtLastName, lblLastName);

        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtPhone, lblPhone);

        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtFirstName, lblFirstName);

        }
        #endregion

        #region TextBox Validation
        private void TxtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtFirstName, "Please Enter First Name", ref firstName, e, errorProvider1);
        }
        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLastName, "Please Enter Last Name", ref lastName, e, errorProvider1);
        }
        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Phone Number", ref phone, e, errorProvider1);

        }
        #endregion

        #region ComboBox Validation
        private void CmbAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbAddress, "Please Select Address", ref addressID, e, errorProvider1);
            if (addressID != -1)
                address = cmbAddress.Items[addressID].ToString();
        }

        private void CmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbUniversity, "Please Select University", ref universityID, e, errorProvider1);

        }

        private void CmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBookingType, "Please Select University", ref bookingID, e, errorProvider1);

        }
        #endregion

        #region Edit Student Button
        private void BtnEditStudent_Click(object sender, EventArgs e)
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
                    MetroFramework.MetroMessageBox.Show(this, "\n\nStudent has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }

        }

        #endregion
    }
}
