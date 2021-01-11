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

        string conString = Program.GetConnectionStringByName();
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
        int bookingID;

        #endregion

        #region Form

        public ReportStudent()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(294, 30);
        }
        private void ReportStudent_Load(object sender, EventArgs e)
        {
            bool flag = false;
            DateTime sys = DateTime.Now;
            DateTime expire;

            connection = new SqlConnection(conString);
            connection.Open();

            cmd = new SqlCommand("select * from studentBooking where student_id = " + this.ID + " ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                expire = (DateTime)dr["bookingTo"];
                if (sys <= expire)
                    flag = true;
                bookingID = (int)dr["bookingType_id"];
            }

            if (flag)
            {
                btnStudentActive.Text = "Active";
                btnStudentActive.BaseColor = ColorTranslator.FromHtml("#4DE1AF");
                btnStudentActive.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                btnStudentActive.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");
            }
            else
            {
                btnStudentActive.Text = "Deactivated";
                btnStudentActive.BaseColor = ColorTranslator.FromHtml("#E1184D");
                btnStudentActive.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                btnStudentActive.OnPressedColor = ColorTranslator.FromHtml("#E1184D");
            }


            //------------------------------------------
            cmd = new SqlCommand("select  s.fName ,s.lName ,s.student_phone ,u.university_name ,a.address_name  from studentInformation s inner join university u on s.university_id=u.university_id inner join address a on s.address_id=a.address_id where s.student_id = " + this.ID + "", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                firstName = txtFirstName.Text = dr["fName"].ToString();
                lastName = txtLastName.Text = dr["lName"].ToString();
                phone = txtPhone.Text = dr["student_phone"].ToString();
                address = txtAddress.Text = dr["address_name"].ToString();
                university = txtUniversity.Text = dr["university_name"].ToString();

            }
            connection.Close();

            //--------------------------------------------------------------------
            if (bookingID==1)
                type = txtBookingType.Text = "Daily";
            else if (bookingID == 2)
                type = txtBookingType.Text = "Monthly";
            else
                type = txtBookingType.Text = "Term";

        }

        #endregion

        #region Clode Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
