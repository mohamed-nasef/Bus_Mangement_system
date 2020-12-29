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
    public partial class TestEdit : Form
    {
        public int ID { get; set; }
        string firstName, lastName, phone, address;
        int addressID = -1, universityID, bookingID;

        private void TestEdit_Load(object sender, EventArgs e)
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
            address = cmbAddress.Items[addressID].ToString();
            universityID = 1;
            cmbUniversity.SelectedIndex = universityID;
            bookingID = 0;
            cmbBookingType.SelectedIndex = bookingID;
        }

        public TestEdit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(294, 30);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Function

        #region WaterMark

        private void waterMark(Guna.UI.WinForms.GunaTextBox txt, Label lbl)
        {
            if (txt.Text == "")
                lbl.Visible = true;
            else
                lbl.Visible = false;
        }

        #endregion

        #region Validation
        private void validationTxt(Guna.UI.WinForms.GunaTextBox txt, string errorMessage, Label lbl, ref string str, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {

                e.Cancel = true;
                //txt.Focus();
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
            if (cmb.SelectedItem == null)
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

        #endregion

        #region TextBox Watermark
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtFirstName, lblFirstName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtLastName, lblLastName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtPhone, lblPhone);
        }

        #endregion

        #region TextBox Validation
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtFirstName, "Please Enter First Name", lblFirstName, ref firstName, e);
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtLastName, "Please Enter Last Name", lblLastName, ref lastName, e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtPhone, "Please Enter Phone Number", lblPhone, ref phone, e);
        }

        #endregion

        #region ComboBox Validation
        private void cmbAddress_Validating(object sender, CancelEventArgs e)
        {
            validationcmb(cmbAddress, "Please Select Address", ref addressID, e);
            if (addressID != -1)
                address = cmbAddress.Items[addressID].ToString();
        }
        private void cmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            validationcmb(cmbUniversity, "Please Select University", ref universityID, e);
        }

        private void cmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            validationcmb(cmbBookingType, "Please Select University", ref bookingID, e);
        }

        #endregion

        #region Edit Student Button
        private void BtnEditStudent_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {firstName} {lastName}\nphone:             {phone}\naddress:           {address}\nUniversity:        {cmbUniversity.Items[universityID]}\nBooking Type: {cmbBookingType.Items[bookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
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
