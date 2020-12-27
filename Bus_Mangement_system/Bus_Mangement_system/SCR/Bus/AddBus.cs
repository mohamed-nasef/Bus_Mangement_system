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
    public partial class AddBus : Form
    {
        string name, LicenseNumber , strCapacity="0";
        int capacity=0,index=-1;
        public AddBus()
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

        private void txtLicenseNumber_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtLicenseNumber, lblLicenseNumber);
        }

        #endregion

        #region TextBox Validation
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtName, "Please Enter Name", ref name, e);
        }

        private void txtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtLicenseNumber, "Please Enter License Number", ref LicenseNumber, e);
        }

        #endregion

        #region ComboBox Validation
        private void cmbCapacity_Validating(object sender, CancelEventArgs e)
        {

            validationcmb(cmbCapacity, "Please Select Number", ref index, e);
            if (index != -1)
            {
                strCapacity = cmbCapacity.Items[index].ToString();
                capacity = int.Parse(strCapacity);
            }
        }
        #endregion

        #region Add Bus Button
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //DB Commands
                MetroFramework.MetroMessageBox.Show(this, $"name is :{name}\n{LicenseNumber}\n{capacity}\n", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtName.Clear();
                txtLicenseNumber.Clear();
                cmbCapacity.SelectedIndex = -1;
                MetroFramework.MetroMessageBox.Show(this, "\n\nBus Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        #endregion
    }
}
