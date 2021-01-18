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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        string strFirstName,strLastName, strPhone,strAddress,strBookingFrom = DateTime.Now.ToShortDateString(),strBookingTo;
        int iAddressID = -1, iUniversityID, iBookingID,iStId, iPrice;
        int [] arrDuration = {0,0,1,4};
        DateTime date;

        #endregion

        #region Form

        public AddStuent()
        {
            InitializeComponent();
        }
        private void AddStuent_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            connection.Open();

            cmd= new SqlCommand("select bookingType_name from bookingType", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbBookingType.Items.Add(dr["bookingType_name"].ToString());
            }

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

            connection.Close();
        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
            Functions.validationTxt(txtFirstName, "Please Enter Valid First Name Without Any Numbers", ref strFirstName,e,errorProvider1);
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLastName, "Please Enter Valid Last Name Without Any Numbers", ref strLastName, e, errorProvider1);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Valid Phone Like (01*********)", ref strPhone, e, errorProvider1);
        }

        #endregion

        #region ComboBox Validation
        private void cmbAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbAddress, "Please Select Address",ref iAddressID, e, errorProvider1);
            if (iAddressID != -1)
                strAddress = cmbAddress.Items[iAddressID].ToString();
        }
        private void cmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbUniversity, "Please Select University", ref iUniversityID, e, errorProvider1);
        }

        private void cmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBookingType, "Please Select Type", ref iBookingID, e, errorProvider1);
        }

        #endregion

        #region Add Student Button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {strFirstName} {strLastName}\nphone:             {strPhone}\naddress:           {strAddress}\nUniversity:        {cmbUniversity.Items[iUniversityID]}\nBooking Type: {cmbBookingType.Items[iBookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {

                    //db
                    iUniversityID++;iAddressID++;iBookingID++;
                    connection = new SqlConnection(conString);
                    connection.Open();
                    // check student
                    da = new SqlDataAdapter("SELECT student_id from studentInformation where fName = '" + strFirstName + "' and lName = '" + strLastName + "' and student_phone = '" + strPhone + "' and address_id = '" + iAddressID + "' and university_id = '" + iUniversityID + "' ", connection);
                    try
                    {
                        ds = new DataSet();
                        da.Fill(ds, "studentSearch");
                        dr = ds.Tables["studentSearch"].Rows[0];
                        if (ds.Tables["studentSearch"].Rows.Count > 0)
                            MetroFramework.MetroMessageBox.Show(this, "\n\nYou have already added this student\nPlease go to Renew Booking or Edit", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception)
                    {
                        //insert into studentInformation
                        cmd = new SqlCommand("insert into studentInformation(fName,lName,student_phone,address_id,university_id)values('" + strFirstName + "','" + strLastName + "','" + strPhone + "','" + iAddressID + "','" + iUniversityID + "')", connection);
                        cmd.ExecuteNonQuery();

                        //get studentid
                        da = new SqlDataAdapter("SELECT student_id from studentInformation where fName = '" + strFirstName + "' and lName = '" + strLastName + "' and student_phone = '" + strPhone + "' and address_id = '" + iAddressID + "' and university_id = '" + iUniversityID + "' ", connection);
                        ds = new DataSet();
                        da.Fill(ds, "studentID");
                        dr = ds.Tables["studentID"].Rows[0];
                        iStId = (int)dr.ItemArray.GetValue(0);

                        //get booking price
                        da = new SqlDataAdapter("select price as pricebooking from bookingPrice bp  where bp.bookingType_id ='" + iBookingID + "'and bp.expiryDate is null", connection);
                        da.Fill(ds, "pricebooking");
                        dr = ds.Tables["pricebooking"].Rows[0];
                        iPrice = (int)dr.ItemArray.GetValue(0);

                        //get expireDate
                        da = new SqlDataAdapter("SELECT DATEADD(Month, " + arrDuration[iBookingID] + ", GETDATE()) AS expire", connection);
                        ds = new DataSet();
                        da.Fill(ds, "expire");
                        dr = ds.Tables["expire"].Rows[0];
                        date = (DateTime)dr.ItemArray.GetValue(0);
                        strBookingTo = date.ToShortDateString();

                        //insert into studentBooking
                        cmd = new SqlCommand("insert into studentBooking(student_id,bookingType_id,price,bookingFrom,bookingTo)values('" + iStId + "','" + iBookingID + "','" + iPrice + "','" + strBookingFrom + "','" + strBookingTo + "')", connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        //insert into profit
                        connection.Open();
                        SqlCommand cmdproce=new SqlCommand();
                        if (iBookingID==1)
                            cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + strBookingFrom + "'," + iPrice + "", connection);
                        else if (iBookingID==2)
                            cmdproce = new SqlCommand("exec monthlyBookingCheckExist '" + strBookingFrom + "'," + iPrice + "", connection);

                        else if (iBookingID==3)
                            cmdproce = new SqlCommand("exec termBookingCheckExist '" + strBookingFrom + "'," + iPrice + "", connection);

                        cmdproce.ExecuteNonQuery();
                        connection.Close();

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
