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
        string name, phone, address;
        public AddDriver()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
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

        # region Validation
        private void validationTxt(Guna.UI.WinForms.GunaTextBox txt, string errorMessage, ref string str, CancelEventArgs e)
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
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtName, lblName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtPhone, lblPhone);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtAddress, lblAddress);
        }

        #endregion

        #region TextBox Validation

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtName, "Please Enter Name", ref name, e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtPhone, "Please Enter Phone", ref phone, e);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtAddress, "Please Enter Address", ref address, e);
        }

        #endregion

        #region Add Driver Button

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:    {name}\nphone:   {phone}\naddress: {address}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {
                    //DB Commands

                    //clear
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    MetroFramework.MetroMessageBox.Show(this, "\n\nDriver Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        #endregion

    }
}
