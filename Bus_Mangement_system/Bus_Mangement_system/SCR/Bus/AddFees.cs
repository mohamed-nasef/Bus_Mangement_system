using Guna.UI.WinForms;
using System;
using System.Collections;
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

            //db
            dataBase.connection = new SqlConnection(dataBase.conString);
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
                feesType.strName.Add(dr["feesType_name"].ToString());
                feesType.iPrice.Add(0);
            }

            dataBase.connection.Close();

            feesType.GunaButton.Add(btnChangeOil);
            feesType.GunaButton.Add(btnPeriodicMaintenance);
            feesType.GunaButton.Add(btnLicenseRenewal);
            feesType.GunaButton.Add(btnBusWash);
            feesType.GunaButton.Add(btnSolar);
            feesType.GunaButton.Add(btnOther);


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
            txtMoney.Text = feesType.iPrice[cmbFeesType.SelectedIndex].ToString();

        }

        #endregion

        #region Assign Button
        private void BtnAssign_Click(object sender, EventArgs e)
        {
           
            if (valid() && cmbFeesType.SelectedIndex != -1)
            {
                Buttons();
                int index = cmbFeesType.SelectedIndex;
                if (feesType.iPrice[index] != 0)
                    feesType.iTotal -= feesType.iPrice[index];
                int refInt;
                int.TryParse(feesType.strMoney, out refInt);
                feesType.iPrice[index] = refInt;
                feesType.iTotal += feesType.iPrice[index];
                feesType.GunaButton[index].Text= $"$ {feesType.iPrice[index]}";
                feesType.GunaButton[index].OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                feesType.GunaButton[index].OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");

                btnTotal.Text = $"$ {feesType.iTotal}";
            }
            if(cmbFeesType.SelectedIndex == -1)
                MetroFramework.MetroMessageBox.Show(this, "\n\nPlease select first", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        #endregion

        #region Clear Button
        private void BtnClear_Click(object sender, EventArgs e)
        {
            
            int index = cmbFeesType.SelectedIndex;

            if (feesType.iPrice[index]!=0)
            {

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"You want to Clear {feesType.strName[index]} ? ", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    feesType.iTotal -= feesType.iPrice[index];
                    feesType.iPrice[index] = 0;
                    feesType.GunaButton[index].Text = $"$ 0";
                    feesType.GunaButton[index].OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    btnTotal.Text = $"$ {feesType.iTotal}";
                }
                txtMoney.Clear();

            }
            else
                MetroFramework.MetroMessageBox.Show(this, $"No money was assigned to {feesType.strName[index]} to clear ", "\nError ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        #endregion

        #region Add Bus Fees Button

        private void BtnAddBusFees_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string msg = $"Total = {feesType.iTotal}\n\n";
                for (int i = 0; i < feesType.iPrice.Count; i++)
                {
                    if (feesType.iPrice[i]!=0)
                        msg += $"{feesType.strName[i]} = {feesType.iPrice[i]}        ";

                    if (i==2)
                        msg += "\n";
                }
                
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, msg, "Are you sure to add this ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bus.iBusID = cmbBus.SelectedIndex + 1;
                    //db
                    //insert into table BusFees
                    dataBase.connection.Open();
                    for (int i = 0; i < feesType.iPrice.Count; i++)
                    {
                        if (feesType.iPrice[i]!=0)
                        {
                            feesType.iFeesTypeID = cmbFeesType.Items.IndexOf(feesType.strName[i]);
                            feesType.iFeesTypeID++;
                            dataBase.cmd = new SqlCommand("insert into busFees(bus_id,feesType_id,feesPrice)values('" + bus.iBusID + "','" + feesType.iFeesTypeID + "','" + feesType.iPrice[i] + "')", dataBase.connection);
                            dataBase.cmd.ExecuteNonQuery();
                        }
                       
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
                    txtMoney.Clear();
                    cmbFeesType.SelectedIndex = 0;
                    bus.iBusID = feesType.iFeesTypeID =- 1;
                    foreach (var item in feesType.GunaButton)
                    {
                        item.Text= "$ 0";
                        item.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    }
                    MetroFramework.MetroMessageBox.Show(this, "\n\nBus Fees Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
            }

        }
        #endregion
    }
}
