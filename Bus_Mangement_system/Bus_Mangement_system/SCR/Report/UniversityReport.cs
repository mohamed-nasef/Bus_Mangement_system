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
    public partial class UniversityReport : Form
    {
        #region DB

        string conString = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";//-------
        SqlCommand cmd;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        int iUnuversityId;

        #endregion

        public UniversityReport()
        {
            InitializeComponent();
        }

        private void UniversityReport_Load(object sender, EventArgs e)
        {
            cmbUniversity.Items.Clear();
            connection = new SqlConnection(conString);
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select university_name from university";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbUniversity.Items.Add(dr["university_name"].ToString());
            }
            connection.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            iUnuversityId = cmbUniversity.SelectedIndex + 1;
            SqlDataAdapter da = new SqlDataAdapter("select s.fName ,s.lName ,s.student_phone,u.university_name,a.address_name from studentInformation s inner join university u on s.university_id=u.university_id inner join address a on s.address_id=a.address_id where s.university_id = '" + iUnuversityId + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            if (ds.Tables["Student"].Rows.Count > 0)
            {
                dgvStudent.Visible = true;
                btnStudentNumber.Visible = true;
                dgvStudent.DataSource = ds.Tables["Student"];
                da = new SqlDataAdapter("select COUNT(s.student_id) from studentInformation s where s.university_id = '" + iUnuversityId + "'", connection);
                da.Fill(ds, "countStudent");
                DataRow dr = ds.Tables["countStudent"].Rows[0];
                if ((int)dr.ItemArray.GetValue(0) > 0)
                {
                    btnStudentNumber.Text = $"{dr.ItemArray.GetValue(0).ToString()}";
                    btnStudentNumber.BaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnStudentNumber.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnStudentNumber.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");
                }
                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, $"There is no report for this university {cmbUniversity.SelectedText} ", "\nError ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvStudent.Visible = false;
                btnStudentNumber.Text = $"0";
                btnStudentNumber.BaseColor = ColorTranslator.FromHtml("#E1184D");
                btnStudentNumber.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                btnStudentNumber.OnPressedColor = ColorTranslator.FromHtml("#E1184D");

            }
        }
    }
}
