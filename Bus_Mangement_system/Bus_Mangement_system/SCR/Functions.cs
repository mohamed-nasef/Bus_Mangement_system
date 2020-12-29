using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                //Phone
                if (txt.Name == "txtPhone"&& txt.Text.Length == 11)
                {
                    bool isnumber = false;
                    char[] arrnumber = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    for (int i = 0; i < txt.Text.Length; i++)
                    {
                        isnumber = false;
                        for (int y = 0; y < 10; y++)
                        {
                            if (txt.Text[i] == arrnumber[y])
                            {
                                isnumber = true;
                                break;
                            }
                        }
                        if (!isnumber)
                            break;
                    }
                    if (isnumber)
                    {
                        e.Cancel = false;
                        isnumber = false;
                        errorProvider.SetError(txt, null);
                        str = txt.Text;
                    }
                    else
                    {
                        e.Cancel = true;
                        //txt.Focus();
                        errorProvider.SetError(txt, errorMessage);
                    }



                }
                else if (txt.Name == "txtPhone" && txt.Text.Length != 11)
                {
                    e.Cancel = true;
                    //txt.Focus();
                    errorProvider.SetError(txt, errorMessage);
                }

                //LicenseNumber
                else if (txt.Name== "txtLicenseNumber")
                {
                    Regex r = new Regex(@"^[0-9]{1,4}[a-z]{1,4}$");
                    if (!(r.IsMatch(txt.Text)))
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

                //StudentId SalaryDriver
                else if (txt.Name== "txtStudentId")
                {
                    Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
                    if (!(r.IsMatch(txt.Text)))
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

                //SalaryDriver
                else if (txt.Name == "txtSalary")
                {
                    Regex r = new Regex(@"^[1-9]{1}[0-9]{3}[0-9]*$");
                    if (!(r.IsMatch(txt.Text)))
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

                //Name
                else
                {
                    Regex r = new Regex(@"^[a-zA-Z]{3,25}$");
                    if (!(r.IsMatch(txt.Text)))
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
