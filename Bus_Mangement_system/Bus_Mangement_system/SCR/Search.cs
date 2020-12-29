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

        #region prop
        public int ID { get; set; }
        public string path { get; set; }
        string strid ="";
        int id;
        #endregion

        public Search()
        {
            InitializeComponent();
            ID = 0;
        }

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextBox Watermark
        private void TxtStudentId_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtStudentId, lblStudentId);
        }

        #endregion

        #region TextBox Validation

        private void TxtStudentId_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtStudentId, "Please Enter ID", ref strid, e,errorProvider1);
        }

        #endregion

        #region Search Student Button
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
                            Student.EditStuent esObj = new Student.EditStuent();
                            esObj.ID = this.ID;
                            this.Close();
                            esObj.ShowDialog();
                        }
                        else if (path == "Renewed Booking")
                        {
                            Student.RenewedBooking rbObj = new Student.RenewedBooking();
                            rbObj.ID = this.ID;
                            this.Close();
                            rbObj.ShowDialog();
                            
                        }
                        else if(path == "Report Student")
                        {
                            Student.ReportStudent rsObj = new Student.ReportStudent();
                            rsObj.ID = this.ID;
                            this.Close();
                            rsObj.ShowDialog();
                        }
                    }

                }
                else 
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease enter number ", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

    }
}
