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
    public partial class RenewedBooking : Form
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
        public int ID { get; set; }
        string firstName, lastName, phone, bookingTo, bookingFrom = DateTime.Now.ToShortDateString();
        int bookingID=-1,price;
        int[] arr = { 0, 0, 1, 4 };
        DateTime d;

        #endregion

        #region Form

        public RenewedBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(294, 30);
        }
        private void RenewedBooking_Load(object sender, EventArgs e)
        {
            bool flag = false;
            DateTime sys = DateTime.Now;
            DateTime expire;

            connection = new SqlConnection(conString);
            connection.Open();
            cmd = new SqlCommand("select * from studentBooking where student_id = "+this.ID+" ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                expire= (DateTime)dr["bookingTo"];
                if (sys>expire)
                    flag = true;

            }
            if (!flag)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nThe student is already Booking", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                connection.Close();
                this.Close();
            }

            else
            {
                //-------------------------------------------------------------------
                cmd = new SqlCommand("select bookingType_name from bookingType", connection);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cmbBookingType.Items.Add(dr["bookingType_name"].ToString());
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
                    phone = txtPhone.Text = dr["student_phone"].ToString();
                }
                connection.Close();

            }



        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ComboBox Validation
        private void CmbBookingType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBookingType, "Please Select Type", ref bookingID, e, errorProvider1);

        }

        #endregion

        #region Renewed Booking Button

        private void BtnRenewedBooking_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"\nBooking Type: {cmbBookingType.Items[bookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bookingID = cmbBookingType.SelectedIndex+1;
                    connection.Open();
                    //DB Commands

                    //get price
                    da = new SqlDataAdapter("select price as pricebooking from bookingPrice bp  where bp.bookingType_id ='" + bookingID + "'and bp.expiryDate is null", connection);
                    ds = new DataSet();
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
                    cmd = new SqlCommand("insert into studentBooking(student_id,bookingType_id,price,bookingFrom,bookingTo)values(" + this.ID + ",'" + bookingID + "','" + price + "','" + bookingFrom + "','" + bookingTo + "')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //insert into profit
                    connection.Open();
                    SqlCommand cmdproce = new SqlCommand();
                    if (bookingID == 1)
                        cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + bookingFrom + "'," + price + "", connection);
                    else if (bookingID == 2)
                        cmdproce = new SqlCommand("exec monthlyBookingCheckExist '" + bookingFrom + "'," + price + "", connection);

                    else if (bookingID == 3)
                        cmdproce = new SqlCommand("exec termBookingCheckExist '" + bookingFrom + "'," + price + "", connection);

                    cmdproce.ExecuteNonQuery();
                    connection.Close();


                    //clear
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();
                    cmbBookingType.SelectedIndex = -1;
                    MetroFramework.MetroMessageBox.Show(this, "\n\nStudent has been RenewedBooking successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
            }

        }

        #endregion

    }
}
