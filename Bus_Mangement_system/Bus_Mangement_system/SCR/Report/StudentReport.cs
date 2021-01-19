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

namespace Bus_Mangement_system.SCR.Report
{
    public partial class StudentReport : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Form

        public StudentReport()
        {
            InitializeComponent();
        }
        private void StudentReport_Load(object sender, EventArgs e)
        {
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.da = new SqlDataAdapter("select s.student_id as 'ID',s.fName as 'First Name' ,s.lName as 'Last Name' ,s.student_phone as 'Phone',u.university_name as 'University',a.address_name as 'Address' from studentInformation s inner join university u on s.university_id=u.university_id inner join address a on s.address_id=a.address_id", dataBase.connection);
            dataBase.ds = new DataSet();
            dataBase.da.Fill(dataBase.ds, "AllStudent");
            dgvAllStudent.DataSource = dataBase.ds.Tables["AllStudent"];
        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

    }
}
