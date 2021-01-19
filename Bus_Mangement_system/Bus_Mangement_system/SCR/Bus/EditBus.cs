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
    public partial class EditBus : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Bus bus = new Bus();
        string refStrName, refStrLicenseNumber;
        int refIBusindex, refICapacityIndex;


        #endregion

        #region Form

        public EditBus()
        {
            InitializeComponent();
        }
        private void EditBus_Load(object sender, EventArgs e)
        {
            visible();
            
            
            //get Buses form DB but in comboBox
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
                lblName.Visible = false;
                lblLicenseNumber.Visible = false;
                txtBusName.Visible = false;
                txtLicenseNumber.Visible = false;
                cmbCapacity.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                lblName.Visible = true;
                lblLicenseNumber.Visible = true;
                txtBusName.Visible = true;
                txtLicenseNumber.Visible = true;
                cmbCapacity.Visible = true;
            }

        }
        #endregion

        #region TextBox Watermark
        private void TxtBusName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtBusName, lblName);
        }

        private void TxtLicenseNumber_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtLicenseNumber, lblLicenseNumber);

        }
        #endregion

        #region TextBox Validation
   
        private void TxtBusName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtBusName, "Please Enter Valid Bus Name Without any numbers", ref refStrName, e, errorProvider1);
            bus.strName = refStrName;
        }
        
        private void TxtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLicenseNumber, "Please Enter Valid License Number like 124KF or 8574UODK", ref refStrLicenseNumber, e, errorProvider1);
            bus.strLicenseNumber = refStrLicenseNumber;
        }

        #endregion

        #region ComboBox Validation

        private void CmbBus_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBus, "Please Select Bus", ref refIBusindex, e, errorProvider1);
            bus.iBusindex = refIBusindex;
        }


        private void CmbCapacity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbCapacity, "Please Select The Bus Capacity", ref refICapacityIndex, e, errorProvider1);
            bus.iCapacityIndex = refICapacityIndex;
            if (bus.iCapacityIndex != -1)
            {
                bus.strCapacity = cmbCapacity.Items[bus.iCapacityIndex].ToString();
                bus.iCapacity = int.Parse(bus.strCapacity);
            }
        }

        #endregion

        #region Selected Bus
        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bus.iBusindex==-1)
                visible();

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
                txtBusName.Text = dr["bus_name"].ToString();
                bus.oldName = bus.strName = txtBusName.Text;
                txtLicenseNumber.Text = dr["bus_licenseNumber"].ToString();
                bus.oldLicenseNumber = bus.strLicenseNumber = txtLicenseNumber.Text;
                bus.oldStrCapacity = bus.strCapacity = dr["bus_capacity"].ToString();
                if (bus.strCapacity =="14")
                    cmbCapacity.SelectedIndex = 0;
                else if (bus.strCapacity == "32")
                    cmbCapacity.SelectedIndex = 1;
                else
                    cmbCapacity.SelectedIndex = 2;
            }
            dataBase.connection.Close();

        }

        #endregion

        #region Edit Bus Button

        private void BtnEditBus_Click(object sender, EventArgs e)
        {

            if (bus.oldName == bus.strName && bus.oldLicenseNumber == bus.strLicenseNumber && bus.oldStrCapacity == bus.strCapacity)
                MetroFramework.MetroMessageBox.Show(this, "\n\nYou didn't make any change\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else
            {
                //Validition
                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:                  {bus.strName}\nlicense Number: {bus.strLicenseNumber}\ncapacity:              {bus.iCapacity}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dataBase.connection.Open();
                        bool flagName = true;
                        bool flagLicenseNumber = true;
                        if (!(bus.strName == bus.oldName) || !(bus.strLicenseNumber == bus.oldLicenseNumber))
                        {
                            // check bus   
                            dataBase.cmd = new SqlCommand("select bus_name from busInformation where bus_name ='" + bus.strName + "'", dataBase.connection);
                            dataBase.cmd.ExecuteNonQuery();
                            dataBase.dt = new DataTable();
                            dataBase.da = new SqlDataAdapter(dataBase.cmd);
                            dataBase.da.Fill(dataBase.dt);
                            foreach (DataRow dr in dataBase.dt.Rows)
                            {
                                if (dr["bus_name"].ToString() == bus.oldName)
                                    flagName = true;

                                else
                                    flagName = false;
                            }


                            dataBase.cmd = new SqlCommand("select bus_licenseNumber from busInformation where bus_licenseNumber ='" + bus.strLicenseNumber + "'", dataBase.connection);
                            dataBase.cmd.ExecuteNonQuery();
                            dataBase.dt = new DataTable();
                            dataBase.da = new SqlDataAdapter(dataBase.cmd);
                            dataBase.da.Fill(dataBase.dt);
                            foreach (DataRow dr in dataBase.dt.Rows)
                            {
                                if (dr["bus_licenseNumber"].ToString() == bus.oldLicenseNumber)
                                    flagLicenseNumber = true;

                                else
                                    flagLicenseNumber = false;
                            }
                        }

                        if (!flagName || !flagLicenseNumber)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\nThis Bus already exists\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dataBase.connection.Close();
                        }

                        else
                        {
                            bus.iBusindex = cmbBus.SelectedIndex + 1;
                            //DB Commands
                            dataBase.cmd = new SqlCommand("update busInformation SET bus_name ='" + bus.strName + "',bus_licenseNumber ='" + bus.strLicenseNumber + "', bus_capacity ='" + bus.iCapacity + "' where bus_id ='" + bus.strID + "'", dataBase.connection);
                            dataBase.cmd.ExecuteNonQuery();
                            dataBase.connection.Close();

                            //clear
                            txtBusName.Clear();
                            txtLicenseNumber.Clear();
                            cmbCapacity.SelectedIndex = cmbBus.SelectedIndex = -1;
                            MetroFramework.MetroMessageBox.Show(this, "\n\nBus has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            this.Close();
                        }

                    }
                }
            }
          
        }

        #endregion



    }
}
