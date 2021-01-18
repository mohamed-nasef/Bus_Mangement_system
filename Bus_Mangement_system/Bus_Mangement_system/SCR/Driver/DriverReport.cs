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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        string strName, strPhone, strAddress, strSalary;
        int iSalary = 0, iDriverIndex = -1;

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

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
            iDriverIndex = cmbDriver.SelectedIndex + 1;
            strName = cmbDriver.SelectedText;
            connection.Open();
            cmd = new SqlCommand("select * from driverInformation where driver_id ='" + iDriverIndex + "' ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                txtName.Text = dr["driver_name"].ToString();
                strName = txtName.Text;
                txtPhone.Text = dr["driver_phone"].ToString();
                strPhone = txtPhone.Text;
                txtAddress.Text = dr["driver_address"].ToString();
                strAddress = txtAddress.Text;
                txtSalary.Text = dr["basicSalary"].ToString();
                strSalary = txtSalary.Text;
                int.TryParse(strSalary, out iSalary);

            }
            connection.Close();
        }

        #endregion
    }
}
