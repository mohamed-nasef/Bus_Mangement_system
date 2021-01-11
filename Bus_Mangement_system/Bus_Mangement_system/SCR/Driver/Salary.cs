using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Driver
{
    public partial class Salary : Form
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
        int iDriverId, month, year;
        int iTakenSalary=0, iRestOfSalary=0, iSalary=0,iBasicSalary=0,total=0;

        string strSalary,strBasic,strTaken;
        DateTime date = DateTime.Now;
        #endregion

        public Salary()
        {
            InitializeComponent();
        }
        private void Salary_Load(object sender, EventArgs e)
        {

            visible();
            month = date.Month;
            year = date.Year;
            numMonth.Value = month;
            cmbDriver.SelectedIndex = -1;
            connection = new SqlConnection(conString);
            connection.Open();
            cmd = new SqlCommand("select driver_name from driverInformation", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbDriver.Items.Add(dr["driver_name"].ToString());
            }
            connection.Close();
        }

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Function

        private void visible()
        {
            if (label1.Visible==true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                lblSalary.Visible = false;
                numMonth.Visible = false;
                btnSearch.Visible = false;
                txtSalaryTaken.Visible = false;
                txtRestOfSalary.Visible = false;
                txtSalary.Visible = false;
                btnAddSalary.Visible = false;
            }
           
        }

        private void numMon()
        {
            if (label1.Visible==false)
            {
                label1.Visible = true;
                numMonth.Visible = true;
                btnSearch.Visible = true;
            }
        }

        private void show()
        {
            if (label2.Visible == false)
            {
                label2.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lblSalary.Visible = true;
                txtSalaryTaken.Visible = true;
                txtRestOfSalary.Visible = true;
                txtSalary.Visible = true;
                btnAddSalary.Visible = true;
            }
        }

        protected bool salaryValid()
        {
            bool flag ;
            Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
            if (!(r.IsMatch(txtSalary.Text)))
            {

                errorProvider1.SetError(txtSalary, "Enter valid money like $ 500");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtSalary, null);
                strSalary = txtSalary.Text;
                int.TryParse(strSalary, out iSalary);
                flag = true;
            }
            return flag;
        }

        #endregion

        #region Watermark

        private void TxtSalary_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtSalary, lblSalary);
        }

        #endregion

        #region Select Driver

        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDriverId = cmbDriver.SelectedIndex + 1;
            connection.Open();
            cmd = new SqlCommand("select * from driverInformation where driver_id ='" + iDriverId + "' ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                strBasic = dr["basicSalary"].ToString();
                int.TryParse(strBasic, out iBasicSalary);
            }
            connection.Close();
            numMon();
        }
        #endregion

        #region Select Month

        private void NumMonth_ValueChanged(object sender, EventArgs e)
        {
            month = (int)numMonth.Value;
        }
        #endregion

        #region Search Button

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            show();
            iDriverId = cmbDriver.SelectedIndex + 1;

            //db select by iddriver get all what happen in this month in taple salary and but in iTakenSalary iRestOfSalary
            connection = new SqlConnection(conString);
            connection.Open();

            //da = new SqlDataAdapter("SELECT * FROM driverSalary WHERE DATEPART(YEAR, monthSalary) = '" + year + "' AND DATEPART(MONTH, monthSalary) = '" + month + "'", connection);
            cmd = new SqlCommand("SELECT * FROM driverSalary WHERE DATEPART(YEAR, monthSalary) = '" + year + "' AND DATEPART(MONTH, monthSalary) = '" + month + "' and driver_id='"+ iDriverId + "' ", connection);
            cmd.ExecuteNonQuery();
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    strTaken= dr["takenSalary"].ToString();
                    int.TryParse(strTaken, out total);
                    iTakenSalary += total;
                    strBasic = dr["basicSalary"].ToString();
                    int.TryParse(strBasic, out iBasicSalary);
                }
                connection.Close();

                txtSalaryTaken.Text = iTakenSalary.ToString();
                txtRestOfSalary.Text = (iBasicSalary - iTakenSalary).ToString();
            }
            catch (Exception)
            {
                txtSalaryTaken.Text = "0";
                txtRestOfSalary.Text = iBasicSalary.ToString();
            }
            connection.Close();
        }
        #endregion

        #region Add Salary Button

        private void BtnAddSalary_Click(object sender, EventArgs e)
        {
            int.TryParse(txtRestOfSalary.Text, out iRestOfSalary);
            if (salaryValid()&&iSalary<=iRestOfSalary)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"To add $ {iSalary} to {cmbDriver.SelectedValue} ", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB
                    iDriverId = cmbDriver.SelectedIndex + 1;
                    connection.Open();
                    cmd = new SqlCommand("insert into driverSalary(driver_id,takenSalary,basicSalary,monthSalary)values ("+iDriverId+","+iSalary+","+iBasicSalary+",'"+year+"-"+month+"-1')", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //insert into profit
                    connection.Open();
                    SqlCommand cmdproce = new SqlCommand();
                    cmdproce = new SqlCommand("exec driverTakenSalaryCheckExist '" + date + "'," + iSalary + "", connection);
                    connection.Close();


                    //clear
                    MetroFramework.MetroMessageBox.Show(this, "\n\nDriver Salary Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    cmbDriver.SelectedIndex = -1;
                    iSalary = iRestOfSalary = iTakenSalary = 0;
                    iDriverId = -1;
                    visible();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, $"\n\nMake sure put right salary\nor you don't give this driver more than {iRestOfSalary}", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        #endregion


    }
}
