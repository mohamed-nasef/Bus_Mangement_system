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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        public int ID { get; set; }
        string strFirstName, strLastName, strPhone, strAddress, strOldFirstName, strOldLastName, strOldPhone,strOldAddress;
        int iAddressID = -1, iUniversityID, iOldAddressID, iOldUniversityID;

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
            connection = new SqlConnection(conString);
            connection.Open();
            cmd = new SqlCommand("select university_name from university", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbUniversity.Items.Add(dr["university_name"].ToString());
            }

            cmd = new SqlCommand("select address_name from address", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbAddress.Items.Add(dr["address_name"].ToString());
            }

            cmd = new SqlCommand("select * from studentInformation where student_id =" + this.ID + " ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                strOldFirstName = strFirstName = txtFirstName.Text = dr["fName"].ToString();
                strOldLastName = strLastName = txtLastName.Text = dr["lName"].ToString();
                strOldPhone = strPhone = txtPhone.Text = dr["student_phone"].ToString();

                iOldAddressID = iAddressID = (int)dr["address_id"];
                cmbAddress.SelectedIndex = iAddressID-1;
                strOldAddress=strAddress = cmbAddress.Items[iAddressID-1].ToString();

                iOldUniversityID=iUniversityID = (int)dr["university_id"];
                cmbUniversity.SelectedIndex = iUniversityID-1;


            }

            

            connection.Close();

            
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
            Functions.validationTxt(txtFirstName, "Please Enter Valid First Name Without Any Numbers", ref strFirstName, e, errorProvider1);
        }
        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLastName, "Please Enter Valid Last Name Without Any Numbers", ref strLastName, e, errorProvider1);
        }
        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref strPhone, e, errorProvider1);

        }
        #endregion

        #region ComboBox Validation
        private void CmbAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbAddress, "Please Select Address", ref iAddressID, e, errorProvider1);
            if (iAddressID != -1)
                strAddress = cmbAddress.Items[iAddressID].ToString();
        }

        private void CmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbUniversity, "Please Select University", ref iUniversityID, e, errorProvider1);

        }

        #endregion

        #region Edit Student Button
        private void BtnEditStudent_Click(object sender, EventArgs e)
        {

            if (strOldFirstName==strFirstName&& strOldLastName==strLastName&& strOldPhone==strPhone&& iOldAddressID==iAddressID&& iOldUniversityID == iUniversityID)
                MetroFramework.MetroMessageBox.Show(this, "\n\nYou didn't make any change\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            else
            {
                //Validition
                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {strFirstName} {strLastName}\nphone:             {strPhone}\naddress:           {strAddress}\nUniversity:        {cmbUniversity.Items[iUniversityID]}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        connection.Open();
                        // check student   
                        bool flagIN = false;
                        if (!(strPhone == strOldPhone))
                        {
                            // check student   
                            cmd = new SqlCommand("select student_phone from studentInformation where student_phone ='" + strPhone + "'", connection);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            da = new SqlDataAdapter(cmd);
                            da.Fill(dt);

                            foreach (DataRow dr in dt.Rows)
                                flagIN = true;


                        }

                        if (flagIN)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\nThis phone already exists\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            connection.Close();
                        }

                        else
                        {
                            //DB Commands
                            iAddressID = cmbAddress.SelectedIndex;
                            iUniversityID = cmbUniversity.SelectedIndex;
                            iUniversityID++; iAddressID++;
                            cmd = new SqlCommand("update studentInformation set fName='" + strFirstName + "',lName='" + strLastName + "' ,student_phone='" + strPhone + "',address_id='" + iAddressID + "',university_id='" + iUniversityID + "' where student_id =" + this.ID + "", connection);
                            cmd.ExecuteNonQuery();

                            connection.Close();
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
