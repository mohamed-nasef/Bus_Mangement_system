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

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        int iUnuversityId;

        #endregion

        #region Form

        public UniversityReport()
        {
            InitializeComponent();
        }

        private void UniversityReport_Load(object sender, EventArgs e)
        {
            cmbUniversity.Items.Clear();
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = dataBase.connection.CreateCommand();
            dataBase.cmd.CommandType = CommandType.Text;
            dataBase.cmd.CommandText = "select university_name from university";
            dataBase.cmd.ExecuteNonQuery();

            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbUniversity.Items.Add(dr["university_name"].ToString());
            }
            dataBase.connection.Close();
        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

        #region Select University
        private void CmbUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            iUnuversityId = cmbUniversity.SelectedIndex + 1;
            dataBase.da = new SqlDataAdapter("select  s.fName as 'First Name' ,s.lName as 'Last Name' ,s.student_phone as 'Phone',u.university_name as 'University',a.address_name as 'Address' from studentInformation s inner join university u on s.university_id=u.university_id inner join address a on s.address_id=a.address_id where s.university_id = '" + iUnuversityId + "'", dataBase.connection);
            dataBase.ds = new DataSet();
            dataBase.da.Fill(dataBase.ds, "Student");
            if (dataBase.ds.Tables["Student"].Rows.Count > 0)
            {
                dgvStudent.Visible = true;
                btnStudentNumber.Visible = true;
                dgvStudent.DataSource = dataBase.ds.Tables["Student"];


                dataBase.da = new SqlDataAdapter("select COUNT(s.student_id) from studentInformation s where s.university_id = '" + iUnuversityId + "'", dataBase.connection);
                dataBase.da.Fill(dataBase.ds, "countStudent");
                dataBase.dr = dataBase.ds.Tables["countStudent"].Rows[0];
                if ((int)dataBase.dr.ItemArray.GetValue(0) > 0)
                {
                    btnStudentNumber.Text = $"{dataBase.dr.ItemArray.GetValue(0).ToString()}";
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

        #endregion

    }
}
