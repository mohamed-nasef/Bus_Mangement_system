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

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Bus bus = new Bus();

        #endregion

        #region Form

        public BusReport()
        {
            InitializeComponent();
        }

        private void BusReport_Load(object sender, EventArgs e)
        {
            visible();

            cmbBus.SelectedIndex = -1;
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select bus_name from busInformation", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbBus.Items.Add(dr["bus_name"].ToString());
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
            bus.iBusindex = cmbBus.SelectedIndex + 1;
            bus.strName = cmbBus.SelectedText;
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select * from busInformation where bus_id ='" + bus.iBusindex + "' ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                bus.strID = dr["bus_id"].ToString();
                txtName.Text = dr["bus_name"].ToString();
                bus.strName = txtName.Text;
                txtLicenseNumber.Text = dr["bus_licenseNumber"].ToString();
                bus.strLicenseNumber = txtLicenseNumber.Text;
                txtCapacity.Text = dr["bus_capacity"].ToString();
                bus.strCapacity = txtCapacity.Text;
                txtTotalFees.Text= dr["bus_fees"].ToString();

            }
            dataBase.connection.Close();
        }
        #endregion

    }
}
