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

        string conString = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";//-------
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        string firstName,lastName, phone,address;
        int addressID = -1, universityID, bookingID;
        int stid, price;
        int [] arr = {0,0,1,4};
        string bookingFrom = DateTime.Now.ToShortDateString();
        string bookingTo;
        DateTime d;

        #endregion
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
            Functions.validationTxt(txtFirstName, "Please Enter First Name",ref firstName,e,errorProvider1);
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLastName, "Please Enter Last Name", ref lastName, e, errorProvider1);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtPhone, "Please Enter Phone Number", ref phone, e, errorProvider1);
        }

        #endregion

        #region ComboBox Validation
        private void cmbAddress_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbAddress, "Please Select Address",ref addressID, e, errorProvider1);
            if (addressID != -1)
                address = cmbAddress.Items[addressID].ToString();
        }
        private void cmbUniversity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbUniversity, "Please Select University", ref universityID, e, errorProvider1);
        }

        private void cmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBookingType, "Please Select Type", ref bookingID, e, errorProvider1);
        }

        #endregion

        #region Add Student Button
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:              {firstName} {lastName}\nphone:             {phone}\naddress:           {address}\nUniversity:        {cmbUniversity.Items[universityID]}\nBooking Type: {cmbBookingType.Items[bookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {

                    //db
                    universityID++;addressID++;bookingID++;
                    connection = new SqlConnection(conString);
                    connection.Open();
                    // check student
                    da = new SqlDataAdapter("SELECT student_id from studentInformation where fName = '" + firstName + "' and lName = '" + lastName + "' and student_phone = '" + phone + "' and address_id = '" + addressID + "' and university_id = '" + universityID + "' ", connection);
                    try
                    {
                        ds = new DataSet();
                        da.Fill(ds, "studentSearch");
                        dr = ds.Tables["studentSearch"].Rows[0];
                        if (ds.Tables["studentSearch"].Rows.Count > 0)
                            MetroFramework.MetroMessageBox.Show(this, "\n\nYou have already added this student\nPlease go to Renew Booking or Edit", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception)
                    {
                        //insert into studentInformation
                        cmd = new SqlCommand("insert into studentInformation(fName,lName,student_phone,address_id,university_id)values('" + firstName + "','" + lastName + "','" + phone + "','" + addressID + "','" + universityID + "')", connection);
                        cmd.ExecuteNonQuery();

                        //get studentid
                        da = new SqlDataAdapter("SELECT student_id from studentInformation where fName = '" + firstName + "' and lName = '" + lastName + "' and student_phone = '" + phone + "' and address_id = '" + addressID + "' and university_id = '" + universityID + "' ", connection);
                        ds = new DataSet();
                        da.Fill(ds, "studentID");
                        dr = ds.Tables["studentID"].Rows[0];
                        stid = (int)dr.ItemArray.GetValue(0);

                        //get booking price
                        da = new SqlDataAdapter("select price as pricebooking from bookingPrice bp  where bp.bookingType_id ='" + bookingID + "'and bp.expiryDate is null", connection);
                        da.Fill(ds, "pricebooking");
                        dr = ds.Tables["pricebooking"].Rows[0];
                        price = (int)dr.ItemArray.GetValue(0);

                        //get expireDate
                        da = new SqlDataAdapter("SELECT DATEADD(Month, " + arr[bookingID] + ", GETDATE()) AS expire", connection);
                        ds = new DataSet();
                        da.Fill(ds, "expire");
                        dr = ds.Tables["expire"].Rows[0];
                        d = (DateTime)dr.ItemArray.GetValue(0);
                        bookingTo = d.ToShortDateString();

                        //insert into studentBooking
                        cmd = new SqlCommand("insert into studentBooking(student_id,bookingType_id,price,bookingFrom,bookingTo)values('" + stid + "','" + bookingID + "','" + price + "','" + bookingFrom + "','" + bookingTo + "')", connection);
                        cmd.ExecuteNonQuery();

                        //msg
                        MetroFramework.MetroMessageBox.Show(this, "\n\nStudent Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    
                    //clear
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    cmbAddress.SelectedIndex = cmbBookingType.SelectedIndex = cmbUniversity.SelectedIndex = -1;
                    connection.Close();
                }
            }
            
            

        }
        #endregion

    }
}
