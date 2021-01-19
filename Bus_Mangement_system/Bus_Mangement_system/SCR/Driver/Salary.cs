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

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Driver driver = new Driver();
        int refIBasicSalary;

        #endregion

        #region Form

        public Salary()
        {
            InitializeComponent();
        }
        private void Salary_Load(object sender, EventArgs e)
        {

            visible();
            
            numMonth.Value = driver.iMonth;
            cmbDriver.SelectedIndex = -1;
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select driver_name from driverInformation", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbDriver.Items.Add(dr["driver_name"].ToString());
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

                errorProvider1.SetError(txtSalary, "Please Enter Valid Salary Like $ 1000 Not 0 or Character");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtSalary, null);
                driver.strSalary = txtSalary.Text;
                int refISalary;
                int.TryParse(driver.strSalary, out refISalary);
                driver.iSalary = refISalary;
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

        #region Select Month

        private void NumMonth_ValueChanged(object sender, EventArgs e)
        {
            driver.iMonth = (int)numMonth.Value;
        }
        #endregion

        #region Select Driver

        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txtSalaryTaken.Visible == true)
            {
                txtSalaryTaken.Visible = false;
                txtRestOfSalary.Visible = false;
                txtSalary.Visible = false;
                btnAddSalary.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                lblSalary.Visible = false;
            }
            
            driver.iDriverId = cmbDriver.SelectedIndex + 1;
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select * from driverInformation where driver_id ='" + driver.iDriverId + "' ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                driver.strBasic = dr["basicSalary"].ToString();
                
                int.TryParse(driver.strBasic, out refIBasicSalary);
                driver.iBasicSalary = refIBasicSalary;
            }
            dataBase.connection.Close();
            numMon();
        }
        #endregion

        #region Search Button

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            show();
            driver = new Driver();
            driver.iDriverId = cmbDriver.SelectedIndex + 1;
            driver.iMonth = (int)numMonth.Value;

            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();

            //get all Taken money in this month and the reset salary
            dataBase.cmd = new SqlCommand("SELECT * FROM driverSalary WHERE DATEPART(YEAR, monthSalary) = '" + driver.iYear + "' AND DATEPART(MONTH, monthSalary) = '" + driver.iMonth + "' and driver_id='"+ driver.iDriverId + "' ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            try
            {
                dataBase.dt = new DataTable();
                dataBase.da = new SqlDataAdapter(dataBase.cmd);
                dataBase.da.Fill(dataBase.dt);
                bool flagIn = false;
                foreach (DataRow dr in dataBase.dt.Rows)
                {
                    flagIn = true;
                    driver.strTaken = dr["takenSalary"].ToString();
                    int refITotal;
                    int.TryParse(driver.strTaken, out refITotal);
                    driver.iTotal = refITotal;
                    driver.iTakenSalary += driver.iTotal;


                    driver.strBasic = dr["basicSalary"].ToString();
                    int refIBasicSalary;
                    int.TryParse(driver.strBasic, out refIBasicSalary);
                    driver.iBasicSalary = refIBasicSalary;
                }
                dataBase.connection.Close();
                if (!flagIn)
                {
                    txtSalaryTaken.Text = "0";
                    driver.iBasicSalary = refIBasicSalary;
                    txtRestOfSalary.Text = driver.iBasicSalary.ToString();
                }
                else
                {
                    txtSalaryTaken.Text = driver.iTakenSalary.ToString();
                    txtRestOfSalary.Text = (driver.iBasicSalary - driver.iTakenSalary).ToString();
                }

            }
            catch (Exception)
            {
                txtSalaryTaken.Text = "0";
                driver.iBasicSalary = refIBasicSalary;
                txtRestOfSalary.Text = driver.iBasicSalary.ToString();
            }
            dataBase.connection.Close();
        }
        #endregion

        #region Add Salary Button

        private void BtnAddSalary_Click(object sender, EventArgs e)
        {
            int refIRestOfSalary;
            int.TryParse(txtRestOfSalary.Text, out refIRestOfSalary);
            driver.iRestOfSalary = refIRestOfSalary;

            //Validation
            if (salaryValid()&& driver.iSalary <= driver.iRestOfSalary)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"To add $ {driver.iSalary} to {cmbDriver.SelectedValue} ", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB
                    driver.iDriverId = cmbDriver.SelectedIndex + 1;
                    dataBase.connection.Open();
                    dataBase.cmd = new SqlCommand("insert into driverSalary(driver_id,takenSalary,basicSalary,monthSalary)values ("+ driver.iDriverId +","+ driver.iSalary +","+ driver.iBasicSalary +",'"+ driver.iYear +"-"+ driver.iMonth +"-1')", dataBase.connection);
                    dataBase.cmd.ExecuteNonQuery();
                    dataBase.connection.Close();

                    //insert into profit
                    dataBase.connection.Open();
                    SqlCommand cmdproce = new SqlCommand();
                    cmdproce = new SqlCommand("exec driverTakenSalaryCheckExist '" + driver.date + "'," + driver.iSalary + "", dataBase.connection);
                    cmdproce.ExecuteNonQuery();
                    dataBase.connection.Close();


                    //clear
                    MetroFramework.MetroMessageBox.Show(this, "\n\nDriver Salary Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    cmbDriver.SelectedIndex = -1;
                    driver.iSalary = driver.iRestOfSalary = driver.iTakenSalary = 0;
                    driver.iDriverId = -1;
                    txtSalary.Clear();
                    visible();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, $"\n\nMake sure put right salary\nor you don't give this driver more than {driver.iRestOfSalary}", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        #endregion

    }
}
