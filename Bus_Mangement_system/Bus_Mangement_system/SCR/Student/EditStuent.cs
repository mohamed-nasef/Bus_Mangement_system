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

namespace Bus_Mangement_system.SCR.Student
{
    public partial class EditStuent : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Student student = new Student();
        public int ID { get; set; }

        #endregion

        #region Form

        public EditStuent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(294, 30);
        }
        private void EditStuent_Load(object sender, EventArgs e)
        {
            //waterwark
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblPhone.Visible = false;

            //db
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select university_name from university", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbUniversity.Items.Add(dr["university_name"].ToString());
            }

            dataBase.cmd = new SqlCommand("select address_name from address", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbAddress.Items.Add(dr["address_name"].ToString());
            }

            dataBase.cmd = new SqlCommand("select * from studentInformation where student_id =" + this.ID + " ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {


                student.strOldFirstName = student.strFirstName = txtFirstName.Text = dr["fName"].ToString();
                student.strOldLastName = student.strLastName = txtLastName.Text = dr["lName"].ToString();
                student.strOldPhone = student.strPhone = txtPhone.Text = dr["student_phone"].ToString();

                student.iOldAddressID = student.iAddressID = (int)dr["address_id"];
                cmbAddress.SelectedIndex = student.iAddressID -1;
                student.strOldAddress = student.strAddress = cmbAddress.Items[student.iAddressID -1].ToString();

                student.iOldUniversityID = student.iUniversityID = (int)dr["university_id"];
                cmbUniversity.SelectedIndex = student.iUniversityID -1;


            }



            dataBase.connection.Close();

            
        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextBox Watermark
        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtLastName, lblLastName);

        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtPhone, lblPhone);

        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtFirstName, lblFirstName);

        }
        #endregion

        #region TextBox Validation
        private void TxtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string refStrFirstName = "";
            Functions.validationTxt(txtFirstName, "Please Enter Valid First Name Without Any Numbers", ref refStrFirstName, e, errorProvider1);
            student.strFirstName = refStrFirstName;
        }
        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            string refStrLastName = "";
            Functions.validationTxt(txtLastName, "Please Enter Valid Last Name Without Any Numbers", ref refStrLastName, e, errorProvider1);
            student.strLastName = refStrLastName;
        }
        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            string refPhone = "";
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref refPhone, e, errorProvider1);
            student.strPhone = refPhone;
        }
        #endregion

        #region ComboBox Validation
        private void CmbAddress_Validating(object sender, CancelEventArgs e)
        {
            int refIAddressID = -1;
            Functions.validationcmb(cmbAddress, "Please Select Address", ref refIAddressID, e, errorProvider1);
            student.iAddressID = refIAddressID;

            if (student.iAddressID != -1)
                student.strAddress = cmbAddress.Items[student.iAddressID].ToString();
        }

        private void CmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            int refIUniversityID = -1;
            Functions.validationcmb(cmbUniversity, "Please Select University", ref refIUniversityID, e, errorProvider1);
            student.iUniversityID = refIUniversityID;
        }

        #endregion

        #region Edit Student Button
        private void BtnEditStudent_Click(object sender, EventArgs e)
        {

            if (student.strOldFirstName == student.strFirstName && student.strOldLastName == student.strLastName && student.strOldPhone == student.strPhone && student.iOldAddressID == student.iAddressID && student.iOldUniversityID == student.iUniversityID)
                MetroFramework.MetroMessageBox.Show(this, "\n\nYou didn't make any change\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else
            {
                //Validition
                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {student.strFirstName} {student.strLastName}\nphone:             {student.strPhone}\naddress:           {student.strAddress}\nUniversity:        {cmbUniversity.Items[student.iUniversityID]}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        dataBase.connection.Open();
                        // check student   
                        bool flagIN = false;
                        if (!(student.strPhone == student.strOldPhone))
                        {
                            // check student   
                            dataBase.cmd = new SqlCommand("select student_phone from studentInformation where student_phone ='" + student.strPhone + "'", dataBase.connection);
                            dataBase.cmd.ExecuteNonQuery();
                            dataBase.dt = new DataTable();
                            dataBase.da = new SqlDataAdapter(dataBase.cmd);
                            dataBase.da.Fill(dataBase.dt);

                            foreach (DataRow dr in dataBase.dt.Rows)
                                flagIN = true;


                        }

                        if (flagIN)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\nThis phone already exists\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataBase.connection.Close();
                        }

                        else
                        {
                            //DB Commands
                            student.iAddressID = cmbAddress.SelectedIndex;
                            student.iUniversityID = cmbUniversity.SelectedIndex;
                            student.iUniversityID++; student.iAddressID++;
                            dataBase.cmd = new SqlCommand("update studentInformation set fName='" + student.strFirstName + "',lName='" + student.strLastName + "' ,student_phone='" + student.strPhone + "',address_id='" + student.iAddressID + "',university_id='" + student.iUniversityID + "' where student_id =" + this.ID + "", dataBase.connection);
                            dataBase.cmd.ExecuteNonQuery();

                            dataBase.connection.Close();
                            //clear
                            txtFirstName.Clear();
                            txtLastName.Clear();
                            txtPhone.Clear();
                            cmbAddress.SelectedIndex = cmbUniversity.SelectedIndex = -1;
                            MetroFramework.MetroMessageBox.Show(this, "\n\nStudent has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Close();
                        }


                    }

                }
            }
           

        }

        #endregion

    }
}
