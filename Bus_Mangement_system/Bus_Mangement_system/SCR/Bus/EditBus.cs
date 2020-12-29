using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Bus
{
    public partial class EditBus : Form
    {

        #region Prop
        int busindex = -1;
        string name, LicenseNumber, strCapacity = "0";
        int capacity = 0, index = -1;

        #endregion

        public EditBus()
        {
            InitializeComponent();
        }
        private void EditBus_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            lblName.Visible = false;
            lblLicenseNumber.Visible = false;
            txtName.Visible = false;
            txtLicenseNumber.Visible = false;
            cmbCapacity.Visible = false;

            //db 3alashan ageb mn goah


        }


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
        private void TxtLicenseNumber_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtLicenseNumber, lblLicenseNumber);

        }
        #endregion

        #region TextBox Validation

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtName, "Please Enter Name", ref name, e, errorProvider1);

        }

        private void TxtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLicenseNumber, "Please Enter License Number", ref LicenseNumber, e, errorProvider1);

        }

        #endregion

        #region ComboBox Validation

        private void CmbBus_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBus, "Please Select Bus", ref busindex, e, errorProvider1);

        }


        private void CmbCapacity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbCapacity, "Please Select Number", ref index, e, errorProvider1);
            if (index != -1)
            {
                strCapacity = cmbCapacity.Items[index].ToString();
                capacity = int.Parse(strCapacity);
            }
        }

        #endregion

        #region Selected Bus
        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            lblName.Visible = true;
            lblLicenseNumber.Visible = true;
            txtName.Visible = true;
            txtLicenseNumber.Visible = true;
            cmbCapacity.Visible = true;


            //db 
            txtName.Text = "Bus 1";
            txtLicenseNumber.Text = "123KFC";
            cmbCapacity.SelectedIndex = 1;

        }

        #endregion

        #region Edit Bus Button

        private void BtnEditBus_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:                  {name}\nlicense Number: {LicenseNumber}\ncapacity:              {capacity}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB Commands

                    //clear
                    txtName.Clear();
                    txtLicenseNumber.Clear();
                    cmbCapacity.SelectedIndex = -1;
                    MetroFramework.MetroMessageBox.Show(this, "\n\nBus has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        #endregion



    }
}
