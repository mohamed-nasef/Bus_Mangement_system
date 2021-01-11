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

        string conString = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";//-------
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop
        int busindex = -1;
        string name, LicenseNumber, strCapacity = "0", strID;
        int capacity = 0, index = -1;

        #endregion

        #region Form

        public EditBus()
        {
            InitializeComponent();
        }
        private void EditBus_Load(object sender, EventArgs e)
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
            Functions.validationTxt(txtBusName, "Please Enter Name", ref name, e, errorProvider1);
        }
        
        private void TxtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLicenseNumber, "Please Enter License Number", ref LicenseNumber, e, errorProvider1);

        }

        #endregion

        #region ComboBox Validation

        private void CmbBus_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBus, "Please Select Bus", ref busindex, e, errorProvider1);

        }


        private void CmbCapacity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbCapacity, "Please Select Number", ref index, e, errorProvider1);
            if (index != -1)
            {
                strCapacity = cmbCapacity.Items[index].ToString();
                capacity = int.Parse(strCapacity);
            }
        }

        #endregion

        #region Selected Bus
        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busindex==-1)
                visible();

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
                txtBusName.Text = dr["bus_name"].ToString();
                name = txtBusName.Text;
                txtLicenseNumber.Text = dr["bus_licenseNumber"].ToString();
                LicenseNumber = txtLicenseNumber.Text;
                strCapacity= dr["bus_capacity"].ToString();
                if (strCapacity=="14")
                    cmbCapacity.SelectedIndex = 0;
                else if (strCapacity == "32")
                    cmbCapacity.SelectedIndex = 1;
                else
                    cmbCapacity.SelectedIndex = 2;
            }
            connection.Close();

        }

        #endregion

        #region Edit Bus Button

        private void BtnEditBus_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:                  {name}\nlicense Number: {LicenseNumber}\ncapacity:              {capacity}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    busindex = cmbBus.SelectedIndex + 1;
                    //DB Commands
                    cmd = new SqlCommand("update busInformation SET bus_name ='" + name + "',bus_licenseNumber ='" + LicenseNumber + "', bus_capacity ='" + capacity + "' where bus_id ='" + strID + "'", connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //clear
                    txtBusName.Clear();
                    txtLicenseNumber.Clear();
                    cmbCapacity.SelectedIndex = cmbBus.SelectedIndex = -1;
                    MetroFramework.MetroMessageBox.Show(this, "\n\nBus has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    this.Close();
                }
            }
        }

        #endregion



    }
}
