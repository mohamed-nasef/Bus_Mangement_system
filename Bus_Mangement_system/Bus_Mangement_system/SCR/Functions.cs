﻿using System;
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
                if (txt.Name== "txtPhone")
                {
                    Regex r = new Regex(@"^[0]{1}[1]{1}[0-9]{9}$");
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
                //Driver name and bus
                else if (txt.Name == "txtDriverName"|| txt.Name == "txtBusName")
                {
                    Regex r = new Regex(@"^[a-zA-Z\x20]{3,25}$");
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
                //LicenseNumber
                else if (txt.Name== "txtLicenseNumber")
                {
                    Regex r = new Regex(@"^[0-9]{1,4}[a-zA-Z]{1,4}$");
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

                //StudentId
                else if (txt.Name== "txtStudentId" || txt.Name== "txtOneWay" || txt.Name== "txtRoundTrip")
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

                //Money
                else if (txt.Name == "txtMoney")
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