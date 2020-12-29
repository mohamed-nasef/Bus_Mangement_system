using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR
{
    public partial class Search : Form
    {
        public int ID { get; set; }
        public string path { get; set; }
        string strid ="";
        int id;
        public Search()
        {
            InitializeComponent();
            ID = 0;
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
        #endregion


        #endregion

        #region TextBox Watermark
        private void TxtStudentId_TextChanged(object sender, EventArgs e)
        {
            waterMark(txtStudentId, lblStudentId);
        }

        #endregion

        #region TextBox Validation

        private void TxtStudentId_Validating(object sender, CancelEventArgs e)
        {
            validationTxt(txtStudentId, "Please Enter ID", ref strid, e);
        }

        #endregion



        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                bool isNumber = int.TryParse(strid, out id);
                if (isNumber&&id!=0)
                {
                   
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"ID: {id}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.ID = id;
                        if (path == "Edit")
                        {
                            //Student.TestEdit esObj = new Student.TestEdit();
                            Student.EditStuent esObj = new Student.EditStuent();
                            esObj.ID = this.ID;
                            this.Hide();
                            esObj.Show();
                        }
                    }

                }
                    else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease enter number ", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
    }
}
