using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR
{
    public partial class Search : Form
    {

        #region DB

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region prop
        public int ID { get; set; }
        public string path { get; set; }
        string strid ="";
        int id;
        #endregion

        #region Form

        public Search()
        {
            InitializeComponent();
            ID = 0;
        }
        private void Search_Load(object sender, EventArgs e)
        {
            if (path == "Renew Booking")
            {
                grbSearch.Text = $"Search to {path}";
            }
            else if (path== "Report")
            {
                grbSearch.Text = $"Search to Student {path}";
            }
            else
                grbSearch.Text = $"Search to {path} Student";
        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
                        connection = new SqlConnection(conString);
                        connection.Open();
                        // check student
                        da = new SqlDataAdapter("SELECT student_id from studentInformation where student_id = "+id+"", connection);
                        try
                        {
                            ds = new DataSet();
                            da.Fill(ds, "studentSearch");
                            dr = ds.Tables["studentSearch"].Rows[0];

                            this.ID = id;
                            if (path == "Edit")
                            {
                                Student.EditStuent esObj = new Student.EditStuent();
                                esObj.ID = this.ID;
                                this.Close();
                                esObj.ShowDialog();
                            }
                            else if (path == "Renew Booking")
                            {
                                Student.RenewedBooking rbObj = new Student.RenewedBooking();
                                rbObj.ID = this.ID;
                                this.Close();
                                rbObj.ShowDialog();

                            }
                            else if (path == "Report")
                            {
                                Student.ReportStudent rsObj = new Student.ReportStudent();
                                rsObj.ID = this.ID;
                                this.Close();
                                rsObj.ShowDialog();
                            }
                        }
                        catch (Exception)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\nThis ID not found ", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else 
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease enter number ", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

       
    }
}
