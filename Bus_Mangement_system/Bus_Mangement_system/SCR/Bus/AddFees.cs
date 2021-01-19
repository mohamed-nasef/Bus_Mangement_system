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

namespace Bus_Mangement_system.SCR.Bus
{
    public partial class AddFees : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        Bus bus = new Bus();
        FeesType feesType = new FeesType();

        int refIBusID, refIFeesTypeID;

        #endregion

        #region Form

        public AddFees()
        {
            InitializeComponent();
        }
        private void AddFees_Load(object sender, EventArgs e)
        {
            visible();
            dataBase.connection = new SqlConnection(dataBase.conString);

            //db
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

            dataBase.cmd = new SqlCommand("select feesType_name from feesType", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbFeesType.Items.Add(dr["feesType_name"].ToString());
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
            if (label2.Visible==true)
            {
                label1.Visible = false;
                label2.Visible = false;
                lblMoney.Visible = false;
                cmbFeesType.Visible = false;
                txtMoney.Visible = false;
                btnClear.Visible = false;
                btnAssign.Visible = false;
                label4.Visible = false;
                btnTotal.Visible = false;
                btnPeriodicMaintenance.Visible = false;
                btnSolar.Visible = false;
                btnChangeOil.Visible = false;
                btnBusWash.Visible = false;
                btnLicenseRenewal.Visible = false;
                btnOther.Visible = false;
                btnAddBusFees.Visible = false;
                

            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                lblMoney.Visible = true;
                cmbFeesType.Visible = true;
                txtMoney.Visible = true;
                btnClear.Visible = true;
                btnAssign.Visible = true;
            }

        }

        private void show()
        {
            if (label2.Visible == false)
            {
                label1.Visible = true;
                label2.Visible = true;
                lblMoney.Visible = true;
                cmbFeesType.Visible = true;
                txtMoney.Visible = true;
                btnClear.Visible = true;
                btnAssign.Visible = true;
            }
          
        }

        private void Buttons()
        {

            if (label4.Visible == false)
            {
                label4.Visible = true;
                btnTotal.Visible = true;
                btnPeriodicMaintenance.Visible = true;
                btnSolar.Visible = true;
                btnChangeOil.Visible = true;
                btnBusWash.Visible = true;
                btnLicenseRenewal.Visible = true;
                btnOther.Visible = true;
                btnAddBusFees.Visible = true;
            }

        }

        protected bool valid()
        {
            bool flag;
            Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
            if (!(r.IsMatch(txtMoney.Text)))
            {
                
                errorProvider1.SetError(txtMoney, "Enter Valid Money Like $ 500 Not 0 or Character");
                flag = false;
            }
            else
            {
                
                errorProvider1.SetError(txtMoney, null);
                feesType.strMoney = txtMoney.Text;
                flag = true;
            }
            return flag;
        }

        #endregion

        #region Watermark
        private void TxtMoney_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtMoney, lblMoney);
        }

        #endregion

        #region ComboBox Validation

        private void CmbBus_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbBus, "Please choose Bus", ref refIBusID, e, errorProvider1);
            bus.iBusID = refIBusID;
        }

        private void CmbFeesType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbFeesType, "Please choose Fees Type", ref refIFeesTypeID, e, errorProvider1);
            feesType.iFeesTypeID = refIFeesTypeID;
        }

        #endregion

        #region Select Bus

        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
            bus.iBusID = cmbBus.SelectedIndex + 1;

        }

        #endregion

        #region Select Fees Type

        private void CmbFeesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select FeesType id 
            feesType.iFeesTypeID = cmbFeesType.SelectedIndex + 1;
            string selected = this.cmbFeesType.GetItemText(this.cmbFeesType.SelectedItem);
            if (selected == "Other")
                txtMoney.Text = feesType.iOther.ToString();
            else if (selected == "License Renewal")
                txtMoney.Text = feesType.iLicenseRenewal.ToString();
            else if (selected == "Bus Wash")
                txtMoney.Text = feesType.iBusWash.ToString();
            else if (selected == "Change Oil")
                txtMoney.Text = feesType.iChangeOil.ToString();
            else if (selected == "Solar")
                txtMoney.Text = feesType.iSolar.ToString();
            else if (selected == "Periodic Maintenance")
                txtMoney.Text = feesType.iPeriodicMaintenance.ToString();

        }

        #endregion

        #region Assign Button
        private void BtnAssign_Click(object sender, EventArgs e)
        {
           
            if (valid() && cmbFeesType.SelectedIndex != -1)
            {
                Buttons();
                string selected = this.cmbFeesType.GetItemText(this.cmbFeesType.SelectedItem);
                if (selected == "Other")
                {
                    if (feesType.iOther != 0)
                        feesType.iTotal -= feesType.iOther;
                    feesType.strOther = feesType.strMoney;
                    btnOther.Text = $"$ {feesType.strOther}";
                    int refIOther;
                    int.TryParse(feesType.strOther, out refIOther);
                    feesType.iOther = refIOther;
                    feesType.iTotal += feesType.iOther;
                    btnOther.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnOther.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "License Renewal")
                {
                    if (feesType.iLicenseRenewal != 0)
                        feesType.iTotal -= feesType.iLicenseRenewal;
                    feesType.strLicenseRenewal = feesType.strMoney;
                    btnLicenseRenewal.Text = $"$ {feesType.strLicenseRenewal}";
                    int refILicenseRenewal;
                    int.TryParse(feesType.strLicenseRenewal, out refILicenseRenewal);
                    feesType.iLicenseRenewal = refILicenseRenewal;
                    feesType.iTotal += feesType.iLicenseRenewal;
                    btnLicenseRenewal.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnLicenseRenewal.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "Bus Wash")
                {
                    if (feesType.iBusWash != 0)
                        feesType.iTotal -= feesType.iBusWash;
                    feesType.strBusWash = feesType.strMoney;
                    btnBusWash.Text = $"$ {feesType.strBusWash}";
                    int refIBusWash;
                    int.TryParse(feesType.strBusWash, out refIBusWash);
                    feesType.iBusWash = refIBusWash;

                    feesType.iTotal += feesType.iBusWash;
                    btnBusWash.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnBusWash.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");

                }
                else if (selected == "Change Oil")
                {
                    if (feesType.iChangeOil != 0)
                        feesType.iTotal -= feesType.iChangeOil;
                    feesType.strChangeOil = feesType.strMoney;
                    btnChangeOil.Text = $"$ {feesType.strChangeOil}";
                    int refIChangeOil;
                    int.TryParse(feesType.strChangeOil, out refIChangeOil);
                    feesType.iChangeOil = refIChangeOil;
                    feesType.iTotal += feesType.iChangeOil;
                    btnChangeOil.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnChangeOil.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "Solar")
                {
                    if (feesType.iSolar != 0)
                        feesType.iTotal -= feesType.iSolar;
                    feesType.strSolar = feesType.strMoney;
                    btnSolar.Text = $"$ {feesType.strSolar}";
                    int refISolar;
                    int.TryParse(feesType.strSolar, out refISolar);
                    feesType.iSolar = refISolar;
                    feesType.iTotal += feesType.iSolar;
                    btnSolar.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnSolar.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "Periodic Maintenance")
                {
                    if (feesType.iPeriodicMaintenance != 0)
                        feesType.iTotal -= feesType.iPeriodicMaintenance;
                    feesType.strPeriodicMaintenance = feesType.strMoney;
                    btnPeriodicMaintenance.Text = $"$ {feesType.strPeriodicMaintenance}";
                    int refIPeriodicMaintenance;
                    int.TryParse(feesType.strPeriodicMaintenance, out refIPeriodicMaintenance);
                    feesType.iPeriodicMaintenance = refIPeriodicMaintenance;
                    feesType.iTotal += feesType.iPeriodicMaintenance;
                    btnPeriodicMaintenance.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnPeriodicMaintenance.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }

                btnTotal.Text = $"$ {feesType.iTotal}";
            }
            if(cmbFeesType.SelectedIndex == -1)
                MetroFramework.MetroMessageBox.Show(this, "\n\nPlease select first", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        #endregion

        #region Clear Button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            string selected = this.cmbFeesType.GetItemText(this.cmbFeesType.SelectedItem);

            if ((selected == "Other"&& feesType.iOther !=0)|| (selected == "License Renewal" && feesType.iLicenseRenewal != 0) || (selected == "Bus Wash" && feesType.iBusWash != 0) || (selected == "Change Oil" && feesType.iChangeOil != 0) || (selected == "Solar" && feesType.iSolar != 0) || (selected == "Periodic Maintenance" && feesType.iPeriodicMaintenance != 0))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"You want to Clear {selected} ? ", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (selected == "Other")
                    {
                        btnOther.Text = $"$ 0";
                        feesType.iTotal -= feesType.iOther;
                        feesType.iOther = 0;
                        btnOther.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");

                    }
                    else if (selected == "License Renewal")
                    {
                        btnLicenseRenewal.Text = $"$ 0";
                        feesType.iTotal -= feesType.iLicenseRenewal;
                        feesType.iLicenseRenewal = 0;
                        btnLicenseRenewal.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");

                    }
                    else if (selected == "Bus Wash")
                    {
                        btnBusWash.Text = $"$ 0";
                        feesType.iTotal -= feesType.iBusWash;
                        feesType.iBusWash = 0;
                        btnBusWash.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }
                    else if (selected == "Change Oil")
                    {
                        btnChangeOil.Text = $"$ 0";
                        feesType.iTotal -= feesType.iChangeOil;
                        feesType.iChangeOil = 0;
                        btnChangeOil.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }
                    else if (selected == "Solar")
                    {
                        btnChangeOil.Text = $"$ 0";
                        feesType.iTotal -= feesType.iSolar;
                        feesType.iSolar = 0;
                        btnSolar.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }
                    else if (selected == "Periodic Maintenance")
                    {
                        btnPeriodicMaintenance.Text = $"$ 0";
                        feesType.iTotal -= feesType.iPeriodicMaintenance;
                        feesType.iPeriodicMaintenance = 0;
                        btnPeriodicMaintenance.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }

                    btnTotal.Text = $"$ {feesType.iTotal}";
                }
                txtMoney.Clear();

            }
            else
                MetroFramework.MetroMessageBox.Show(this, $"No money was assigned to {selected} to clear ", "\nError ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        #endregion

        #region Add Bus Fees Button

        private void BtnAddBusFees_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"Total = {feesType.iTotal}\n\nChange Oil = {feesType.iChangeOil}   \t\t Periodic Maintenance = {feesType.iPeriodicMaintenance}   \t\t License Renewal = {feesType.iLicenseRenewal}\nBus Wash = {feesType.iBusWash}        \t\t Solar = {feesType.iSolar}             \t\t Other = {feesType.iOther}", "Are you sure to add this ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bus.iBusID = cmbBus.SelectedIndex + 1;
                    //db
                    //insert into table BusFees
                    dataBase.connection.Open();
                    if (feesType.iPeriodicMaintenance != 0)
                    {
                        feesType.iFeesTypeID = cmbFeesType.Items.IndexOf("Periodic Maintenance");
                        feesType.iFeesTypeID++;
                        dataBase.cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + bus.iBusID + "','" + feesType.iFeesTypeID + "','" + feesType.iPeriodicMaintenance + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                    }
                    if (feesType.iSolar != 0)
                    {
                        feesType.iFeesTypeID = cmbFeesType.Items.IndexOf("Solar");
                        feesType.iFeesTypeID++;
                        dataBase.cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + bus.iBusID + "','" + feesType.iFeesTypeID + "','" + feesType.iSolar + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                    }
                    if (feesType.iChangeOil != 0)
                    {
                        feesType.iFeesTypeID = cmbFeesType.Items.IndexOf("Change Oil");
                        feesType.iFeesTypeID++;
                        dataBase.cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + bus.iBusID + "','" + feesType.iFeesTypeID + "','" + feesType.iChangeOil + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                    }
                    if (feesType.iBusWash != 0)
                    {
                        feesType.iFeesTypeID = cmbFeesType.Items.IndexOf("Bus Wash");
                        feesType.iFeesTypeID++;
                        dataBase.cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + bus.iBusID + "','" + feesType.iFeesTypeID + "','" + feesType.iBusWash + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                    }
                    if (feesType.iLicenseRenewal != 0)
                    {
                        feesType.iFeesTypeID = cmbFeesType.Items.IndexOf("License Renewal");
                        feesType.iFeesTypeID++;
                        dataBase.cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + bus.iBusID + "','" + feesType.iFeesTypeID + "','" + feesType.iLicenseRenewal + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                    }
                    if (feesType.iOther != 0)
                    {
                        feesType.iFeesTypeID = cmbFeesType.Items.IndexOf("Other");
                        feesType.iFeesTypeID++;
                        dataBase.cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + bus.iBusID + "','" + feesType.iFeesTypeID + "','" + feesType.iOther + "')", dataBase.connection);
                        dataBase.cmd.ExecuteNonQuery();
                    }

                    //update fees in businformation
                    dataBase.cmd = new SqlCommand("update busInformation SET bus_fees = bus_fees +" + feesType.iTotal + " where bus_id ='" + bus.iBusID + "'", dataBase.connection);
                    dataBase.cmd.ExecuteNonQuery();
                    dataBase.connection.Close();

                    //insert into profit
                    dataBase.connection.Open();
                    SqlCommand cmdproce = new SqlCommand();
                    cmdproce = new SqlCommand("exec busFeesCheckExist '"+ feesType.iYear +"-"+ feesType.iMonth +"-"+ feesType.iDay +"',"+ feesType.iTotal +" ", dataBase.connection);
                    cmdproce.ExecuteNonQuery();

                    dataBase.connection.Close();


                    //clear
                    visible();
                    cmbBus.SelectedIndex = -1;
                    cmbFeesType.SelectedIndex = -1;
                    btnOther.Text = $"$ 0";
                    btnLicenseRenewal.Text = $"$ 0";
                    btnBusWash.Text = $"$ 0";
                    btnChangeOil.Text = $"$ 0";
                    btnPeriodicMaintenance.Text = $"$ 0";
                    btnTotal.Text = $"$ 0";
                    txtMoney.Clear();
                    feesType.iOther = feesType.iLicenseRenewal = feesType.iBusWash = feesType.iChangeOil = feesType.iPeriodicMaintenance = feesType.iTotal = 0;
                    feesType.strMoney = feesType.strOther = feesType.strLicenseRenewal = feesType.strBusWash = feesType.strChangeOil = feesType.strPeriodicMaintenance = "";
                    bus.iBusID = feesType.iFeesTypeID =- 1;

                    visible();
                    MetroFramework.MetroMessageBox.Show(this, "\n\nBus Fees Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    this.Close();
                }
            }

        }

        #endregion


    }
}
