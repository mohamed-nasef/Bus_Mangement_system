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
    public partial class AddStuent : Form
    {

        #region DB

        DataBase dataBase = new DataBase();


        #endregion

        #region Prop

        Student student = new Student();
        int [] arrDuration = {0,0,1,4};

        #endregion

        #region Form

        public AddStuent()
        {
            InitializeComponent();
        }
        private void AddStuent_Load(object sender, EventArgs e)
        {
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();

            dataBase.cmd = new SqlCommand("select bookingType_name from bookingType", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbBookingType.Items.Add(dr["bookingType_name"].ToString());
            }

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

            dataBase.connection.Close();
        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

        #region TextBox Watermark
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtFirstName, lblFirstName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtLastName, lblLastName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtPhone, lblPhone);
        }

        #endregion

        #region TextBox Validation

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string refStrFirstName = "";
            Functions.validationTxt(txtFirstName, "Please Enter Valid First Name Without Any Numbers", ref refStrFirstName, e, errorProvider1);
            student.strFirstName = refStrFirstName;
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string refStrLastName = "";
            Functions.validationTxt(txtLastName, "Please Enter Valid Last Name Without Any Numbers", ref refStrLastName, e, errorProvider1);
            student.strLastName = refStrLastName;
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            string refPhone = "";
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref refPhone, e, errorProvider1);
            student.strPhone = refPhone;
        }

        #endregion

        #region ComboBox Validation

        private void cmbAddress_Validating(object sender, CancelEventArgs e)
        {

            int refIAddressID = -1;
            Functions.validationcmb(cmbAddress, "Please Select Address", ref refIAddressID, e, errorProvider1);
            student.iAddressID = refIAddressID;

            if (student.iAddressID != -1)
                student.strAddress = cmbAddress.Items[student.iAddressID].ToString();

        }
        private void cmbUniversity_Validating(object sender, CancelEventArgs e)
        {

            int refIUniversityID = -1;
            Functions.validationcmb(cmbUniversity, "Please Select University", ref refIUniversityID, e, errorProvider1);
            student.iUniversityID = refIUniversityID;

        }

        private void cmbBookingType_Validating(object sender, CancelEventArgs e)
        {

            int refIBookingID = -1;
            Functions.validationcmb(cmbBookingType, "Please Select Type", ref refIBookingID, e, errorProvider1);
            student.iBookingID = refIBookingID;

        }

        #endregion

        #region Add Student Button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {student.strFirstName} {student.strLastName}\nphone:             {student.strPhone}\naddress:           {student.strAddress}\nUniversity:        {cmbUniversity.Items[student.iUniversityID]}\nBooking Type: {cmbBookingType.Items[student.iBookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {

                    //db
                    student.iUniversityID++; student.iAddressID++; student.iBookingID++;
                    dataBase.connection = new SqlConnection(dataBase.conString);
                    dataBase.connection.Open();
                    // check student
                    dataBase.da = new SqlDataAdapter("SELECT student_id from studentInformation where fName = '" + student.strFirstName + "' and lName = '" + student.strLastName + "' and student_phone = '" + student.strPhone + "' and address_id = '" + student.iAddressID + "' and university_id = '" + student.iUniversityID + "' ", dataBase.connection);
                    try
                    {
                        dataBase.ds = new DataSet();
                        dataBase.da.Fill(dataBase.ds, "studentSearch");
                        dataBase.dr = dataBase.ds.Tables["studentSearch"].Rows[0];
                        if (dataBase.ds.Tables["studentSearch"].Rows.Count > 0)
                            MetroFramework.MetroMessageBox.Show(this, "\n\nYou have already added this student\nPlease go to Renew Booking or Edit", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception)
                    {
                        //insert into studentInformation
                        dataBase.cmd = new SqlCommand("insert into studentInformation(fName,lName,student_phone,address_id,university_id)values('" + student.strFirstName + "','" + student.strLastName + "','" + student.strPhone + "','" + student.iAddressID + "','" + student.iUniversityID + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();

                        //get studentid
                        dataBase.da = new SqlDataAdapter("SELECT student_id from studentInformation where fName = '" + student.strFirstName + "' and lName = '" + student.strLastName + "' and student_phone = '" + student.strPhone + "' and address_id = '" + student.iAddressID + "' and university_id = '" + student.iUniversityID + "' ", dataBase.connection);
                        dataBase.ds = new DataSet();
                        dataBase.da.Fill(dataBase.ds, "studentID");
                        dataBase.dr = dataBase.ds.Tables["studentID"].Rows[0];
                        student.iStId = (int)dataBase.dr.ItemArray.GetValue(0);

                        //get booking price
                        dataBase.da = new SqlDataAdapter("select price as pricebooking from bookingPrice bp  where bp.bookingType_id ='" + student.iBookingID + "'and bp.expiryDate is null", dataBase.connection);
                        dataBase.da.Fill(dataBase.ds, "pricebooking");
                        dataBase.dr = dataBase.ds.Tables["pricebooking"].Rows[0];
                        student.iPrice = (int)dataBase.dr.ItemArray.GetValue(0);

                        //get expireDate
                        dataBase.da = new SqlDataAdapter("SELECT DATEADD(Month, " + arrDuration[student.iBookingID] + ", GETDATE()) AS expire", dataBase.connection);
                        dataBase.ds = new DataSet();
                        dataBase.da.Fill(dataBase.ds, "expire");
                        dataBase.dr = dataBase.ds.Tables["expire"].Rows[0];
                        student.date = (DateTime)dataBase.dr.ItemArray.GetValue(0);
                        student.strBookingTo = student.date.ToShortDateString();

                        //insert into studentBooking
                        dataBase.cmd = new SqlCommand("insert into studentBooking(student_id,bookingType_id,price,bookingFrom,bookingTo)values('" + student.iStId + "','" + student.iBookingID + "','" + student.iPrice + "','" + student.strBookingFrom + "','" + student.strBookingTo + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                        dataBase.connection.Close();

                        //insert into profit
                        dataBase.connection.Open();
                        SqlCommand cmdproce=new SqlCommand();
                        if (student.iBookingID ==1)
                            cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + student.strBookingFrom + "'," + student.iPrice + "", dataBase.connection);
                        else if (student.iBookingID ==2)
                            cmdproce = new SqlCommand("exec monthlyBookingCheckExist '" + student.strBookingFrom + "'," + student.iPrice + "", dataBase.connection);

                        else if (student.iBookingID ==3)
                            cmdproce = new SqlCommand("exec termBookingCheckExist '" + student.strBookingFrom + "'," + student.iPrice + "", dataBase.connection);

                        cmdproce.ExecuteNonQuery();
                        dataBase.connection.Close();

                        //msg
                        MetroFramework.MetroMessageBox.Show(this, "\n\nStudent Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    
                    //clear
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    cmbAddress.SelectedIndex = cmbBookingType.SelectedIndex = cmbUniversity.SelectedIndex = -1;
                }
            }
            
            

        }
        #endregion

    }
}
