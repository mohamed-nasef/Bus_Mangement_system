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

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Student student = new Student();
        public int ID { get; set; }
        int[] arrDuration = { 0, 0, 1, 4 };
       
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

            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select * from studentBooking where student_id = "+this.ID+" ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                expire= (DateTime)dr["bookingTo"];
                if (sys <= expire)
                    flag = true;

            }

            if (flag)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\nThe student is already Booking", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                dataBase.connection.Close();
                this.Close();
            }

            else
            {
                //-------------------------------------------------------------------
                dataBase.cmd = new SqlCommand("select bookingType_name from bookingType", dataBase.connection);
                dataBase.cmd.ExecuteNonQuery();
                dataBase.dt = new DataTable();
                dataBase.da = new SqlDataAdapter(dataBase.cmd);
                dataBase.da.Fill(dataBase.dt);
                foreach (DataRow dr in dataBase.dt.Rows)
                {
                    cmbBookingType.Items.Add(dr["bookingType_name"].ToString());
                }

                dataBase.cmd = new SqlCommand("select * from studentInformation where student_id =" + this.ID + " ", dataBase.connection);
                dataBase.cmd.ExecuteNonQuery();
                dataBase.dt = new DataTable();
                dataBase.da = new SqlDataAdapter(dataBase.cmd);
                dataBase.da.Fill(dataBase.dt);
                foreach (DataRow dr in dataBase.dt.Rows)
                {

                    student.strFirstName = txtFirstName.Text = dr["fName"].ToString();
                    student.strLastName = txtLastName.Text = dr["lName"].ToString();
                    student.strPhone = txtPhone.Text = dr["student_phone"].ToString();
                }
                dataBase.connection.Close();

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
            int refIBookingID=-1;
            Functions.validationcmb(cmbBookingType, "Please Select Type", ref refIBookingID, e, errorProvider1);
            student.iBookingID = refIBookingID;
        }

        #endregion

        #region Renewed Booking Button

        private void BtnRenewedBooking_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"\nBooking Type: {cmbBookingType.Items[student.iBookingID]}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    student.iBookingID = cmbBookingType.SelectedIndex+1;
                    dataBase.connection.Open();
                    //DB Commands

                    //get price
                    dataBase.da = new SqlDataAdapter("select price as pricebooking from bookingPrice bp  where bp.bookingType_id ='" + student.iBookingID + "'and bp.expiryDate is null", dataBase.connection);
                    dataBase.ds = new DataSet();
                    dataBase.da.Fill(dataBase.ds, "pricebooking");
                    dataBase.dr = dataBase.ds.Tables["pricebooking"].Rows[0];
                    student.price = (int)dataBase.dr.ItemArray.GetValue(0);


                    //get expireDate
                    dataBase.da = new SqlDataAdapter("SELECT DATEADD(Month, " + arrDuration[student.iBookingID] + ", GETDATE()) AS expire", dataBase.connection);
                    dataBase.ds = new DataSet();
                    dataBase.da.Fill(dataBase.ds, "expire");
                    dataBase.dr = dataBase.ds.Tables["expire"].Rows[0];
                    student.date = (DateTime)dataBase.dr.ItemArray.GetValue(0);
                    student.strBookingTo = student.date.ToShortDateString();

                    //insert into studentBooking
                    dataBase.cmd = new SqlCommand("insert into studentBooking(student_id,bookingType_id,price,bookingFrom,bookingTo)values(" + this.ID + ",'" + student.iBookingID + "','" + student.price + "','" + student.strBookingFrom + "','" + student.strBookingTo + "')", dataBase.connection);
                    dataBase.cmd.ExecuteNonQuery();
                    dataBase.connection.Close();

                    //insert into profit
                    dataBase.connection.Open();
                    SqlCommand cmdproce = new SqlCommand();
                    if (student.iBookingID == 1)
                        cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + student.strBookingFrom + "'," + student.price + "", dataBase.connection);
                    else if (student.iBookingID == 2)
                        cmdproce = new SqlCommand("exec monthlyBookingCheckExist '" + student.strBookingFrom + "'," + student.price + "", dataBase.connection);

                    else if (student.iBookingID == 3)
                        cmdproce = new SqlCommand("exec termBookingCheckExist '" + student.strBookingFrom + "'," + student.price + "", dataBase.connection);

                    cmdproce.ExecuteNonQuery();
                    dataBase.connection.Close();


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
