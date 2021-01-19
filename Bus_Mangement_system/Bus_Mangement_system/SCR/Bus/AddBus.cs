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
    public partial class AddBus : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Bus bus = new Bus();

        string refStrName, refStrLicenseNumber;
        int refICapacityIndex;

        #endregion

        #region Form

        public AddBus()
        {
            InitializeComponent();
        }

        private void AddBus_Load(object sender, EventArgs e)
        {
            dataBase.connection = new SqlConnection(dataBase.conString);

        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

        #region TextBox Watermark

        private void txtBusName_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtBusName, lblName);
        }
        private void txtLicenseNumber_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtLicenseNumber, lblLicenseNumber);
        }

        #endregion

        #region TextBox Validation

        private void txtBusName_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtBusName, "Please Enter Valid Bus Name Without any numbers", ref refStrName, e, errorProvider1);
            bus.strName = refStrName;
        }

        private void txtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLicenseNumber, "Please Enter Valid License Number like 124KF or 8574UODK", ref refStrLicenseNumber, e, errorProvider1);
            bus.strLicenseNumber = refStrLicenseNumber;
        }

        #endregion

        #region ComboBox Validation
        private void cmbCapacity_Validating(object sender, CancelEventArgs e)
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

        #region Add Bus Button
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:                  {bus.strName}\nlicense Number: {bus.strLicenseNumber}\ncapacity:              {bus.iCapacity}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result==DialogResult.Yes)
                {
                    //DB Commands
                    dataBase.connection = new SqlConnection(dataBase.conString);
                    dataBase.connection.Open();
                    dataBase.da = new SqlDataAdapter("SELECT bus_id from busInformation where bus_name ='" + bus.strName + "'", dataBase.connection);
                    try
                    {
                        dataBase.ds = new DataSet();
                        dataBase.da.Fill(dataBase.ds, "busid");
                        dataBase.dr = dataBase.ds.Tables["busid"].Rows[0];
                        if (dataBase.ds.Tables["busid"].Rows.Count > 0)
                            MetroFramework.MetroMessageBox.Show(this, "\n\nYou have already added this Bus\nPlease go to Bus Fees or Edit", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception)
                    {
                        dataBase.cmd = new SqlCommand("insert into busInformation (bus_name,bus_licenseNumber,bus_capacity)values('"+ bus.strName + "','"+ bus.strLicenseNumber +"',"+ bus.iCapacity +")", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "\n\nBus Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    }
                    //clear
                    txtBusName.Clear();
                    txtLicenseNumber.Clear();
                    cmbCapacity.SelectedIndex = -1;
                    dataBase.connection.Close();
                }
            }
        }
        #endregion

    }
}
