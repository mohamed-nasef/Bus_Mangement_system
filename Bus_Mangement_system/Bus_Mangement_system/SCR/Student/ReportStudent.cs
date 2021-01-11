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
    public partial class ReportStudent : Form
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
        string firstName, lastName, phone, address, university,type;
        int addressID = -1, universityID, bookingID;

        #endregion

        public ReportStudent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(294, 30);
        }
        private void ReportStudent_Load(object sender, EventArgs e)
        {
            

            //data from database

            firstName = txtFirstName.Text = "Moustafa";
            lastName = txtLastName.Text = "Ibrahem";
            phone = txtPhone.Text = "01067893079";

            addressID = 1;
            address = txtAddress.Text = "Menyet El-Nasr";
            //cmbAddress.SelectedIndex = addressID;
            //address = cmbAddress.Items[addressID].ToString();

            universityID = 1;
            university = txtUniversity.Text = "MET";
            //cmbUniversity.SelectedIndex = universityID;

            bookingID = 0;
            type = txtBookingType.Text = "Monthly";
            //cmbBookingType.SelectedIndex = bookingID;
        }

        #region Clode Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion



    }
}
