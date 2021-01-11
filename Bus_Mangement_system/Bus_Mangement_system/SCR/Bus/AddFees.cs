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

        string conString = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";//-------
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        int BusID, FeesTypeID;

        int iChangeOil=0, iOther=0, iLicenseRenewal=0, iBusWash=0, iPeriodicMaintenance=0, iSolar=0;

        int total = 0;

        string strChangeOil, strOther, strLicenseRenewal, strBusWash, strPeriodicMaintenance, strSolar;
       
        int year= DateTime.Now.Year , month= DateTime.Now.Month, day= DateTime.Now.Day;


        string money;

        #endregion

        #region Form

        public AddFees()
        {
            InitializeComponent();
        }
        private void AddFees_Load(object sender, EventArgs e)
        {
            visible();
            connection = new SqlConnection(conString);

            //db
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

            cmd = new SqlCommand("select feesType_name from feesType", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbFeesType.Items.Add(dr["feesType_name"].ToString());
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
            }

        }

        protected bool valid()
        {
            bool flag;
            Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
            if (!(r.IsMatch(txtMoney.Text)))
            {
                
                errorProvider1.SetError(txtMoney, "Enter valid money like $ 500");
                flag = false;
            }
            else
            {
                
                errorProvider1.SetError(txtMoney, null);
                money = txtMoney.Text;
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
            Functions.validationcmb(cmbBus, "Please choose Bus", ref BusID, e, errorProvider1);
        }

        private void CmbFeesType_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationcmb(cmbFeesType, "Please choose Fees Type", ref FeesTypeID, e, errorProvider1);
        }

        #endregion

        #region Select Bus

        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            show();
            BusID = cmbBus.SelectedIndex + 1;

        }

        #endregion

        #region Select Fees Type

        private void CmbFeesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select FeesType id 
            FeesTypeID = cmbFeesType.SelectedIndex + 1;//sdasdasdasdasdasdasdasdfdsafadf
            string selected = this.cmbFeesType.GetItemText(this.cmbFeesType.SelectedItem);
            if (selected == "Other")
                txtMoney.Text = iOther.ToString();
            else if (selected == "License Renewal")
                txtMoney.Text = iLicenseRenewal.ToString();
            else if (selected == "Bus Wash")
                txtMoney.Text = iBusWash.ToString();
            else if (selected == "Change Oil")
                txtMoney.Text = iChangeOil.ToString();
            else if (selected == "Solar")
                txtMoney.Text = iSolar.ToString();
            else if (selected == "Periodic Maintenance")
                txtMoney.Text = iPeriodicMaintenance.ToString();

        }

        #endregion

        #region Assign Button
        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                Buttons();
                string selected = this.cmbFeesType.GetItemText(this.cmbFeesType.SelectedItem);
                if (selected == "Other")
                {
                    if (iOther != 0)
                        total -= iOther;
                    strOther = money;
                    btnOther.Text = $"$ {strOther}";
                    int.TryParse(strOther, out iOther);
                    total += iOther;
                    btnOther.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnOther.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "License Renewal")
                {
                    if (iLicenseRenewal != 0)
                        total -= iLicenseRenewal;
                    strLicenseRenewal = money;
                    btnLicenseRenewal.Text = $"$ {strLicenseRenewal}";
                    int.TryParse(strLicenseRenewal, out iLicenseRenewal);
                    total += iLicenseRenewal;
                    btnLicenseRenewal.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnLicenseRenewal.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "Bus Wash")
                {
                    if (iBusWash != 0)
                        total -= iBusWash;
                    strBusWash = money;
                    btnBusWash.Text = $"$ {strBusWash}";
                    int.TryParse(strBusWash, out iBusWash);
                    total += iBusWash;
                    btnBusWash.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnBusWash.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");

                }
                else if (selected == "Change Oil")
                {
                    if (iChangeOil != 0)
                        total -= iChangeOil;
                    strChangeOil = money;
                    btnChangeOil.Text = $"$ {strChangeOil}";
                    int.TryParse(strChangeOil, out iChangeOil);
                    total += iChangeOil;
                    btnChangeOil.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnChangeOil.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "Solar")
                {
                    if (iSolar != 0)
                        total -= iSolar;
                    strSolar = money;
                    btnSolar.Text = $"$ {strSolar}";
                    int.TryParse(strSolar, out iSolar);
                    total += iSolar;
                    btnSolar.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnSolar.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }
                else if (selected == "Periodic Maintenance")
                {
                    if (iPeriodicMaintenance != 0)
                        total -= iPeriodicMaintenance;
                    strPeriodicMaintenance = money;
                    btnPeriodicMaintenance.Text = $"$ {strPeriodicMaintenance}";
                    int.TryParse(strPeriodicMaintenance, out iPeriodicMaintenance);
                    total += iPeriodicMaintenance;
                    btnPeriodicMaintenance.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnPeriodicMaintenance.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");


                }

                btnTotal.Text = $"$ {total}";
            }

        }

        #endregion

        #region Clear Button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            string selected = this.cmbFeesType.GetItemText(this.cmbFeesType.SelectedItem);

            if ((selected == "Other"&&iOther!=0)|| (selected == "License Renewal" && iLicenseRenewal != 0) || (selected == "Bus Wash" && iBusWash != 0) || (selected == "Change Oil" && iChangeOil != 0) || (selected == "Solar" && iSolar != 0) || (selected == "Periodic Maintenance" && iPeriodicMaintenance != 0))
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"You want to Clear {selected} ? ", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (selected == "Other")
                    {
                        btnOther.Text = $"$ 0";
                        total -= iOther;
                        iOther = 0;
                        btnOther.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");

                    }
                    else if (selected == "License Renewal")
                    {
                        btnLicenseRenewal.Text = $"$ 0";
                        total -= iLicenseRenewal;
                        iLicenseRenewal = 0;
                        btnLicenseRenewal.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");

                    }
                    else if (selected == "Bus Wash")
                    {
                        btnBusWash.Text = $"$ 0";
                        total -= iBusWash;
                        iBusWash = 0;
                        btnBusWash.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }
                    else if (selected == "Change Oil")
                    {
                        btnChangeOil.Text = $"$ 0";
                        total -= iChangeOil;
                        iChangeOil = 0;
                        btnChangeOil.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }
                    else if (selected == "Solar")
                    {
                        btnChangeOil.Text = $"$ 0";
                        total -= iSolar;
                        iSolar = 0;
                        btnSolar.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }
                    else if (selected == "Periodic Maintenance")
                    {
                        btnPeriodicMaintenance.Text = $"$ 0";
                        total -= iPeriodicMaintenance;
                        iPeriodicMaintenance = 0;
                        btnPeriodicMaintenance.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }

                    btnTotal.Text = $"$ {total}";
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

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"Total = {total}\n\nChange Oil = {iChangeOil}   \t\t Periodic Maintenance = {iPeriodicMaintenance}   \t\t License Renewal = {iLicenseRenewal}\nBus Wash = {iBusWash}        \t\t Solar = {iSolar}             \t\t Other = {iOther}", "Are you sure to add this ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    BusID = cmbBus.SelectedIndex + 1;
                    //db
                    //insert into table BusFees
                    connection.Open();
                    if (iPeriodicMaintenance != 0)
                    {
                        FeesTypeID= cmbFeesType.Items.IndexOf("Periodic Maintenance");
                        FeesTypeID++;
                        cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + BusID + "','" + FeesTypeID + "','" + iPeriodicMaintenance + "')", connection);
                        cmd.ExecuteNonQuery();
                    }
                    if (iSolar != 0)
                    {
                        FeesTypeID = cmbFeesType.Items.IndexOf("Solar");
                        FeesTypeID++;
                        cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + BusID + "','" + FeesTypeID + "','" + iSolar + "')", connection);
                        cmd.ExecuteNonQuery();
                    }
                    if (iChangeOil != 0)
                    {
                        FeesTypeID = cmbFeesType.Items.IndexOf("Change Oil");
                        FeesTypeID++;
                        cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + BusID + "','" + FeesTypeID + "','" + iChangeOil + "')", connection);
                        cmd.ExecuteNonQuery();
                    }
                    if (iBusWash != 0)
                    {
                        FeesTypeID = cmbFeesType.Items.IndexOf("Bus Wash");
                        FeesTypeID++;
                        cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + BusID + "','" + FeesTypeID + "','" + iBusWash + "')", connection);
                        cmd.ExecuteNonQuery();
                    }
                    if (iLicenseRenewal != 0)
                    {
                        FeesTypeID = cmbFeesType.Items.IndexOf("License Renewal");
                        FeesTypeID++;
                        cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + BusID + "','" + FeesTypeID + "','" + iLicenseRenewal + "')", connection);
                        cmd.ExecuteNonQuery();
                    }
                    if (iOther != 0)
                    {
                        FeesTypeID = cmbFeesType.Items.IndexOf("Other");
                        FeesTypeID++;
                        cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + BusID + "','" + FeesTypeID + "','" + iOther + "')", connection);
                        cmd.ExecuteNonQuery();
                    }

                    //update fees in businformation
                    cmd = new SqlCommand("update busInformation SET bus_fees = bus_fees +" + total + " where bus_id ='" + BusID + "'", connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //insert into profit
                    connection.Open();
                    SqlCommand cmdproce = new SqlCommand();
                    cmdproce = new SqlCommand("exec busFeesCheckExist '"+year+"-"+month+"-"+day+"',"+total+" ", connection);
                    cmdproce.ExecuteNonQuery();

                    connection.Close();


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
                    iOther = iLicenseRenewal = iBusWash = iChangeOil = iPeriodicMaintenance = total = 0;
                    money =strOther=strLicenseRenewal=strBusWash=strChangeOil=strPeriodicMaintenance= "";
                    BusID = FeesTypeID =- 1;

                    visible();
                    MetroFramework.MetroMessageBox.Show(this, "\n\nBus Fees Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

        }

        #endregion


    }
}
