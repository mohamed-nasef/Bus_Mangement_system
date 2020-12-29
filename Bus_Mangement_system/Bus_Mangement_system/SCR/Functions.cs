using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR
{
    class Functions
    {
        #region WaterMark

        public static void waterMark(Guna.UI.WinForms.GunaTextBox txt, Label lbl)
        {
            if (txt.Text == "")
                lbl.Visible = true;
            else
                lbl.Visible = false;
        }

        #endregion

        #region Validation
        public static void validationTxt(Guna.UI.WinForms.GunaTextBox txt, string errorMessage, ref string str, CancelEventArgs e, ErrorProvider errorProvider)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {

                e.Cancel = true;
                //txt.Focus();
                errorProvider.SetError(txt, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt, null);
                str = txt.Text;
            }
        }
        public static void validationcmb(Guna.UI.WinForms.GunaComboBox cmb, string errorMessage, ref int index, CancelEventArgs e,ErrorProvider errorProvider)
        {
            if (cmb.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cmb, errorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmb, null);
                index = cmb.SelectedIndex;
            }
        }
        #endregion
    }
}
