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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        string strName, strLicenseNumber, strCapacity = "0", strID, oldName, oldLicenseNumber, oldStrCapacity;
        int iCapacity = 0, iIndex = -1, iBusindex = -1;

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
            Functions.validationTxt(txtBusName, "Please Enter Valid Bus Name Without any numbers", ref strName, e, errorProvider1);
        }
        
        private void TxtLicenseNumber_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtLicenseNumber, "Please Enter Valid License Number like 124KF or 8574UODK", ref strLicenseNumber, e, errorProvider1);

        }

        #endregion

        #region ComboBox Validation

        private void CmbBus_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBus, "Please Select Bus", ref iBusindex, e, errorProvider1);

        }


        private void CmbCapacity_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbCapacity, "Please Select The Bus Capacity", ref iIndex, e, errorProvider1);
            if (iIndex != -1)
            {
                strCapacity = cmbCapacity.Items[iIndex].ToString();
                iCapacity = int.Parse(strCapacity);
            }
        }

        #endregion

        #region Selected Bus
        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (iBusindex==-1)
                visible();

            iBusindex = cmbBus.SelectedIndex + 1;
            strName = cmbBus.SelectedText;
            connection.Open();
            cmd = new SqlCommand("select * from busInformation where bus_id ='" + iBusindex + "' ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                strID = dr["bus_id"].ToString();
                txtBusName.Text = dr["bus_name"].ToString();
                oldName = strName = txtBusName.Text;
                txtLicenseNumber.Text = dr["bus_licenseNumber"].ToString();
                oldLicenseNumber = strLicenseNumber = txtLicenseNumber.Text;
                oldStrCapacity = strCapacity = dr["bus_capacity"].ToString();
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

            if (oldName==strName&&oldLicenseNumber==strLicenseNumber&&oldStrCapacity==strCapacity)
                MetroFramework.MetroMessageBox.Show(this, "\n\nYou didn't make any change\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            else
            {
                //Validition
                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"name:                  {strName}\nlicense Number: {strLicenseNumber}\ncapacity:              {iCapacity}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        bool flagName = true;
                        bool flagLicenseNumber = true;
                        if (!(strName == oldName) || !(strLicenseNumber == oldLicenseNumber))
                        {
                            // check bus   
                            cmd = new SqlCommand("select bus_name from busInformation where bus_name ='" + strName + "'", connection);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (dr["bus_name"].ToString() == oldName)
                                    flagName = true;

                                else
                                    flagName = false;
                            }


                            cmd = new SqlCommand("select bus_licenseNumber from busInformation where bus_licenseNumber ='" + strLicenseNumber + "'", connection);
                            cmd.ExecuteNonQuery();
                            dt = new DataTable();
                            da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (dr["bus_licenseNumber"].ToString() == oldLicenseNumber)
                                    flagLicenseNumber = true;

                                else
                                    flagLicenseNumber = false;
                            }
                        }

                        if (!flagName || !flagLicenseNumber)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\nThis Bus already exists\nPlease be careful", "\nWarning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            connection.Close();
                        }

                        else
                        {
                            iBusindex = cmbBus.SelectedIndex + 1;
                            //DB Commands
                            cmd = new SqlCommand("update busInformation SET bus_name ='" + strName + "',bus_licenseNumber ='" + strLicenseNumber + "', bus_capacity ='" + iCapacity + "' where bus_id ='" + strID + "'", connection);
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
            }
          
        }

        #endregion



    }
}
