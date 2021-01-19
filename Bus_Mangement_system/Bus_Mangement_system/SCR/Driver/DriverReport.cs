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

namespace Bus_Mangement_system.SCR.Driver
{
    public partial class DriverReport : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Driver driver = new Driver();

        #endregion

        #region Form

        public DriverReport()
        {
            InitializeComponent();
        }

        private void DriverReport_Load(object sender, EventArgs e)
        {
            visible();
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

        #region Funcation
        private void visible()
        {
            if (label1.Visible == true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                txtName.Visible = false;
                txtAddress.Visible = false;
                txtPhone.Visible = false;
                txtSalary.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtName.Visible = true;
                txtAddress.Visible = true;
                txtPhone.Visible = true;
                txtSalary.Visible = true;
            }

        }
        private void True()
        {
            if (label1.Visible == false)
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtName.Visible = true;
                txtAddress.Visible = true;
                txtPhone.Visible = true;
                txtSalary.Visible = true;
            }
           

        }
        #endregion

        #region Selected Driver

        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            True();
            driver.iDriverIndex = cmbDriver.SelectedIndex + 1;
            driver.strName = cmbDriver.SelectedText;
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select * from driverInformation where driver_id ='" + driver.iDriverIndex + "' ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                
                txtName.Text = dr["driver_name"].ToString();
                driver.strName = txtName.Text;
                txtPhone.Text = dr["driver_phone"].ToString();
                driver.strPhone = txtPhone.Text;
                txtAddress.Text = dr["driver_address"].ToString();
                driver.strAddress = txtAddress.Text;
                txtSalary.Text = dr["basicSalary"].ToString();
                driver.strSalary = txtSalary.Text;
                int refISalary;
                int.TryParse(driver.strSalary, out refISalary);
                driver.iSalary = refISalary;
            }
            dataBase.connection.Close();
        }

        #endregion
    }
}
