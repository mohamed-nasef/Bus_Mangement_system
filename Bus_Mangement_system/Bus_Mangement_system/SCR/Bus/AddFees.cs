using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        #region Prop

        int BusID, FeesTypeID;

        int iChangeOil=0, iOther=0, iLicenseRenewal=0, iBusWash=0, iPeriodicMaintenance=0, iSolar=0;

        int total = 0;

        string strChangeOil, strOther, strLicenseRenewal, strBusWash, strPeriodicMaintenance, strSolar;

        string money;

        #endregion

        public AddFees()
        {
            InitializeComponent();
        }
        private void AddFees_Load(object sender, EventArgs e)
        {
            visible();
            //db
            //cmbBus and cmbFeesType
        }


        #region Close Form
        private void BtnClose_Click(object sender, EventArgs e)
        {
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
                grbDetails.Visible = false;

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
                grbDetails.Visible = true;
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

        private void grbShow()
        {
            if (btnClear.Visible==true)
            {
                grbDetails.Visible = true;
            }
        }

        protected bool valid()
        {
            bool flag = false;
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

        #region TextBox Validation

        //private void TxtMoney_Validating(object sender, CancelEventArgs e)
        //{
        //    Functions.validationTxt(txtMoney, "Enter valid money like $ 500", ref money, e, errorProvider1);
        //}

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

            //select bus id from comboBox
            BusID = cmbBus.SelectedIndex + 1;//dfsdfsdfsdfsdfsdfsdfsdfsdfsdfsdfasdfasdf

        }

        #endregion

        #region Select Fees Type

        private void CmbFeesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //select FeesType id 
            FeesTypeID = cmbFeesType.SelectedIndex + 1;//sdasdasdasdasdasdasdasdfdsafadf

        }

        #endregion

        #region Assign Button
        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (valid())
            {
                grbShow();
                string selected = this.cmbFeesType.GetItemText(this.cmbFeesType.SelectedItem);
                if (selected == "Other")
                {
                    if (iOther != 0)
                        total -= iOther;
                    strOther = money;
                    lblOther.Text = $"Other= {strOther}";
                    int.TryParse(strOther, out iOther);
                    total += iOther;

                    //db go to db and insert BusId and  FeesType and money and date to table Fees
                }
                else if (selected == "License Renewal")
                {
                    if (iLicenseRenewal != 0)
                        total -= iLicenseRenewal;
                    strLicenseRenewal = money;
                    lblLicenseRenewal.Text = $"License Renewal= {strLicenseRenewal}";
                    int.TryParse(strLicenseRenewal, out iLicenseRenewal);
                    total += iLicenseRenewal;

                    //db go to db and insert BusId and  FeesType and money and date to table Fees
                }
                else if (selected == "Bus Wash")
                {
                    if (iBusWash != 0)
                        total -= iBusWash;
                    strBusWash = money;
                    lblBusWash.Text = $"Bus Wash= {strBusWash}";
                    int.TryParse(strBusWash, out iBusWash);
                    total += iBusWash;
                    //db go to db and insert BusId and  FeesType and money and date to table Fees
                }
                else if (selected == "Change Oil")
                {
                    if (iChangeOil != 0)
                        total -= iChangeOil;
                    strChangeOil = money;
                    lblChangeOil.Text = $"Change Oil= {strChangeOil}";
                    int.TryParse(strChangeOil, out iChangeOil);
                    total += iChangeOil;

                    //db go to db and insert BusId and  FeesType and money and date to table Fees
                }
                else if (selected == "Solar")
                {
                    if (iSolar != 0)
                        total -= iSolar;
                    strSolar = money;
                    lblSolar.Text = $"Solar= {strSolar}";
                    int.TryParse(strSolar, out iSolar);
                    total += iSolar;

                    //db go to db and insert BusId and  FeesType and money and date to table Fees
                }
                else if (selected == "Periodic Maintenance")
                {
                    if (iPeriodicMaintenance != 0)
                        total -= iPeriodicMaintenance;
                    strPeriodicMaintenance = money;
                    lblPeriodicMaintenance.Text = $"Periodic Maintenance= {strPeriodicMaintenance}";
                    int.TryParse(strPeriodicMaintenance, out iPeriodicMaintenance);
                    total += iPeriodicMaintenance;

                    //db go to db and insert BusId and  FeesType and money and date to table Fees
                }

                lblTotal.Text = $"Total = {total}";
                txtMoney.Clear();
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
                        lblOther.Text = $"Other=";
                        total -= iOther;
                        iOther = 0;

                        //db go to db and delet the row by the date and the BusId and  FeesType from table Fees
                    }
                    else if (selected == "License Renewal")
                    {
                        lblLicenseRenewal.Text = $"License Renewal=";
                        total -= iLicenseRenewal;
                        iLicenseRenewal = 0;

                        //db go to db and delet the row by the date and the BusId and  FeesType from table Fees

                    }
                    else if (selected == "Bus Wash")
                    {
                        lblBusWash.Text = $"Bus Wash=";
                        total -= iBusWash;
                        iBusWash = 0;

                        //db go to db and delet the row by the date and the BusId and  FeesType from table Fees
                    }
                    else if (selected == "Change Oil")
                    {
                        lblChangeOil.Text = $"Change Oil=";
                        total -= iChangeOil;
                        iChangeOil = 0;

                        //db go to db and delet the row by the date and the BusId and  FeesType from table Fees
                    }
                    else if (selected == "Solar")
                    {
                        lblSolar.Text = $"Solar=";
                        total -= iSolar;
                        iSolar = 0;

                        //db go to db and delet the row by the date and the BusId and  FeesType from table Fees
                    }
                    else if (selected == "Periodic Maintenance")
                    {
                        lblPeriodicMaintenance.Text = $"Periodic Maintenance=";
                        total -= iPeriodicMaintenance;
                        iPeriodicMaintenance = 0;

                        //db go to db and delet the row by the date and the BusId and  FeesType from table Fees
                    }

                    lblTotal.Text = $"Total = {total}";
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

                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $" ", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB Commands

                    //clear

                    MetroFramework.MetroMessageBox.Show(this, "\n\nBus Fees Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

        }

        #endregion


    }
}
