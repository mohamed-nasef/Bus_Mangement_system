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

namespace Bus_Mangement_system.SCR.Bus
{
    public partial class BusReport : Form
    {

        #region DB

        string conString = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";//-------
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop
        int busindex = -1;
        string name, LicenseNumber, strCapacity = "0",strID;
       

        #endregion

        public BusReport()
        {
            InitializeComponent();
        }

        private void BusReport_Load(object sender, EventArgs e)
        {
            visible();

            cmbBus.SelectedIndex = -1;
            connection = new SqlConnection(conString);
            connection.Open();
            cmd = new SqlCommand("select bus_name from busInformation", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbBus.Items.Add(dr["bus_name"].ToString());
            }
            connection.Close();
        }

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
                txtLicenseNumber.Visible = false;
                txtCapacity.Visible = false;
                txtTotalFees.Visible = false;
              
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtName.Visible = true;
                txtLicenseNumber.Visible = true;
                txtCapacity.Visible = true;
                txtTotalFees.Visible = true;

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
                txtLicenseNumber.Visible = true;
                txtCapacity.Visible = true;
                txtTotalFees.Visible = true;

            }
           

        }

        #endregion

        #region Selected Bus
        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            True();
            busindex = cmbBus.SelectedIndex + 1;
            name = cmbBus.SelectedText;
            connection.Open();
            cmd = new SqlCommand("select * from busInformation where bus_id ='" + busindex + "' ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                strID = dr["bus_id"].ToString();
                txtName.Text = dr["bus_name"].ToString();
                name = txtName.Text;
                txtLicenseNumber.Text = dr["bus_licenseNumber"].ToString();
                LicenseNumber = txtLicenseNumber.Text;
                txtCapacity.Text = dr["bus_capacity"].ToString();
                strCapacity = txtCapacity.Text;
                txtTotalFees.Text= dr["bus_fees"].ToString();

            }
            connection.Close();
        }
        #endregion

    }
}
