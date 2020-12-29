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
    public partial class RenewedBooking : Form
    {

        #region Prop
        public int ID { get; set; }
        string firstName, lastName, phone, address, university;
        int addressID = -1, universityID, bookingID;

        #endregion

        public RenewedBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(294, 30);
        }
        private void RenewedBooking_Load(object sender, EventArgs e)
        {
          
            lblID.Text = this.ID.ToString();

            //data from database

            firstName = txtFirstName.Text = "Moustafa";
            lastName = txtLastName.Text = "Ibrahem";
            phone = txtPhone.Text = "01067893079";

            addressID = 1;
            address = txtAddress.Text = "Menyet El-Nasr";
            //cmbAddress.SelectedIndex = addressID;
            //address = cmbAddress.Items[addressID].ToString();

            universityID = 1;
            university = txtUniversity.Text = "MET";
            //cmbUniversity.SelectedIndex = universityID;

        }

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ComboBox Validation
        private void CmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBookingType, "Please Select Type", ref bookingID, e, errorProvider1);

        }

        #endregion

        #region Renewed Booking Button

        private void BtnRenewedBooking_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"\nBooking Type: {cmbBookingType.Items[bookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB Commands

                    //clear
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    txtUniversity.Clear();
                    cmbBookingType.SelectedIndex = -1;
                    MetroFramework.MetroMessageBox.Show(this, "\n\nStudent has been RenewedBooking successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
            }

        }

        #endregion

    }
}
