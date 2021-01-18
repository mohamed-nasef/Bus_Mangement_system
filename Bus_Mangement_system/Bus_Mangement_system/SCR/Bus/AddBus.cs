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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        string strName, strLicenseNumber , strCapacity="0";
        int iCapacity=0,iIndex=-1;

        #endregion

        #region Form

        public AddBus()
        {
            InitializeComponent();
        }

        private void AddBus_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);

        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
            Functions.validationTxt(txtBusName, "Please Enter Valid Bus Name Without any numbers", ref strName, e, errorProvider1);
        }

        private void txtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLicenseNumber, "Please Enter Valid License Number like 124KF or 8574UODK", ref strLicenseNumber, e, errorProvider1);
        }

        #endregion

        #region ComboBox Validation
        private void cmbCapacity_Validating(object sender, CancelEventArgs e)
        {

            Functions.validationcmb(cmbCapacity, "Please Select The Bus Capacity", ref iIndex, e, errorProvider1);
            if (iIndex != -1)
            {
                strCapacity = cmbCapacity.Items[iIndex].ToString();
                iCapacity = int.Parse(strCapacity);
            }
        }
        #endregion

        #region Add Bus Button
        private void btnAddBus_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:                  {strName}\nlicense Number: {strLicenseNumber}\ncapacity:              {iCapacity}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result==DialogResult.Yes)
                {
                    //DB Commands
                    connection = new SqlConnection(conString);
                    connection.Open();
                    da = new SqlDataAdapter("SELECT bus_id from busInformation where bus_name ='" + strName + "'", connection);
                    try
                    {
                        ds = new DataSet();
                        da.Fill(ds, "busid");
                        dr = ds.Tables["busid"].Rows[0];
                        if (ds.Tables["busid"].Rows.Count > 0)
                            MetroFramework.MetroMessageBox.Show(this, "\n\nYou have already added this Bus\nPlease go to Bus Fees or Edit", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception)
                    {
                        cmd = new SqlCommand("insert into busInformation (bus_name,bus_licenseNumber,bus_capacity)values('"+strName+ "','"+strLicenseNumber+"',"+iCapacity+")", connection);
                        cmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "\n\nBus Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    }
                    //clear
                    txtBusName.Clear();
                    txtLicenseNumber.Clear();
                    cmbCapacity.SelectedIndex = -1;
                    connection.Close();
                }
            }
        }
        #endregion

    }
}
