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

        DataBase dataBase = new DataBase();
        
        #endregion

        #region Prop

        Student student = new Student();
        public int ID { get; set; }

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

            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();

            dataBase.cmd = new SqlCommand("select * from studentBooking where student_id = " + this.ID + " ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                expire = (DateTime)dr["bookingTo"];
                if (sys <= expire)
                    flag = true;
                student.iBookingID = (int)dr["bookingType_id"];
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
            dataBase.cmd = new SqlCommand("select  s.fName ,s.lName ,s.student_phone ,u.university_name ,a.address_name  from studentInformation s inner join university u on s.university_id=u.university_id inner join address a on s.address_id=a.address_id where s.student_id = " + this.ID + "", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {

                student.strFirstName = txtFirstName.Text = dr["fName"].ToString();
                student.strLastName = txtLastName.Text = dr["lName"].ToString();
                student.strPhone = txtPhone.Text = dr["student_phone"].ToString();
                student.strAddress = txtAddress.Text = dr["address_name"].ToString();
                student.strUniversity = txtUniversity.Text = dr["university_name"].ToString();

            }
            dataBase.connection.Close();

            //--------------------------------------------------------------------
            if (student.iBookingID ==1)
                student.strType = txtBookingType.Text = "Daily";
            else if (student.iBookingID == 2)
                student.strType = txtBookingType.Text = "Monthly";
            else
                student.strType = txtBookingType.Text = "Term";

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
