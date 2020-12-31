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

namespace Bus_Mangement_system.SCR.Driver
{
    public partial class Salary : Form
    {

        #region Prop
        int iDriverId, month;
        int iTakenSalary, iRestOfSalary,iSalary;
        string strSalary;
        #endregion

        public Salary()
        {
            InitializeComponent();
        }
        private void Salary_Load(object sender, EventArgs e)
        {
            //db select driver but in cmbDriver
            visible();
            DateTime iDate = DateTime.Now;
            month = iDate.Month;
            numMonth.Value = month;
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
            if (label1.Visible==true)
            {
                label1.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                lblSalary.Visible = false;
                numMonth.Visible = false;
                btnSearch.Visible = false;
                txtSalaryTaken.Visible = false;
                txtRestOfSalary.Visible = false;
                txtSalary.Visible = false;
                btnAddSalary.Visible = false;
            }
           
        }

        private void numMon()
        {
            if (label1.Visible==false)
            {
                label1.Visible = true;
                numMonth.Visible = true;
                btnSearch.Visible = true;
            }
        }

        private void show()
        {
            if (label2.Visible == false)
            {
                label2.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                lblSalary.Visible = true;
                txtSalaryTaken.Visible = true;
                txtRestOfSalary.Visible = true;
                txtSalary.Visible = true;
                btnAddSalary.Visible = true;
            }
        }

        protected bool salaryValid()
        {
            bool flag ;
            Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
            if (!(r.IsMatch(txtSalary.Text)))
            {

                errorProvider1.SetError(txtSalary, "Enter valid money like $ 500");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtSalary, null);
                strSalary = txtSalary.Text;
                int.TryParse(strSalary, out iSalary);
                flag = true;
            }
            return flag;
        }

        #endregion

        #region Watermark

        private void TxtSalary_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtSalary, lblSalary);
        }

        #endregion

        #region Select Driver

        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDriverId = cmbDriver.SelectedIndex + 1;
            numMon();
        }
        #endregion

        #region Select Month

        private void NumMonth_ValueChanged(object sender, EventArgs e)
        {
            month = (int)numMonth.Value;
        }
        #endregion

        #region Search Button

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            show();
            //db select by iddriver get all what happen in this month in taple salary and but in iTakenSalary iRestOfSalary
            iTakenSalary = 1900;
            iRestOfSalary = 2100;
            txtSalaryTaken.Text = iTakenSalary.ToString();
            txtRestOfSalary.Text = iRestOfSalary.ToString();
        }
        #endregion

        #region Add Salary Button

        private void BtnAddSalary_Click(object sender, EventArgs e)
        {
            
            if (salaryValid()&&iSalary<=iRestOfSalary)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"To add $ {iSalary} to {cmbDriver.SelectedValue} ", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB Commands insert into table Bus Fees with BusId and type fees in multible row with date



                    //clear
                    MetroFramework.MetroMessageBox.Show(this, "\n\nDriver Salary Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    cmbDriver.SelectedIndex = -1;
                    iSalary = iRestOfSalary = iTakenSalary = 0;
                    iDriverId = -1;
                    visible();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, $"\n\nMake sure put right salary\nor you don't give this driver more than {iRestOfSalary}", "\nError", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        #endregion


    }
}
