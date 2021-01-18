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
        string firstName, lastName, phone, address, oldPhone;
        int addressID = -1, universityID;

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


                firstName = txtFirstName.Text = dr["fName"].ToString();
                lastName = txtLastName.Text = dr["lName"].ToString();
                oldPhone = phone = txtPhone.Text = dr["student_phone"].ToString();

                addressID = (int)dr["address_id"];
                cmbAddress.SelectedIndex = addressID-1;
                address = cmbAddress.Items[addressID-1].ToString();

                universityID = (int)dr["university_id"];
                cmbUniversity.SelectedIndex = universityID-1;


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
            Functions.validationTxt(txtFirstName, "Please Enter First Name", ref firstName, e, errorProvider1);
        }
        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLastName, "Please Enter Last Name", ref lastName, e, errorProvider1);
        }
        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Phone Number", ref phone, e, errorProvider1);

        }
        #endregion

        #region ComboBox Validation
        private void CmbAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbAddress, "Please Select Address", ref addressID, e, errorProvider1);
            if (addressID != -1)
                address = cmbAddress.Items[addressID].ToString();
        }

        private void CmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbUniversity, "Please Select University", ref universityID, e, errorProvider1);

        }

        #endregion

        #region Edit Student Button
        private void BtnEditStudent_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {firstName} {lastName}\nphone:             {phone}\naddress:           {address}\nUniversity:        {cmbUniversity.Items[universityID]}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {

                    connection.Open();
                    // check student   
                    bool flagPhone = false, flagIN = false;
                    if (!(phone == oldPhone))
                    {
                        // check student   
                        cmd = new SqlCommand("select student_phone from studentInformation where student_phone ='" + phone + "'", connection);
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
                        addressID = cmbAddress.SelectedIndex;
                        universityID = cmbUniversity.SelectedIndex;
                        universityID++; addressID++;
                        cmd = new SqlCommand("update studentInformation set fName='" + firstName + "',lName='" + lastName + "' ,student_phone='" + phone + "',address_id='" + addressID + "',university_id='" + universityID + "' where student_id =" + this.ID + "", connection);
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

        #endregion

    }
}
