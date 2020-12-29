using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Driver
{
    public partial class DriverReport : Form
    {
        #region Prop
        int driverindex = -1;
        string name, phone, address, salary;
        int iSalary = 0;

        #endregion
        public DriverReport()
        {
            InitializeComponent();
        }

        private void DriverReport_Load(object sender, EventArgs e)
        {
            visible();

            //db 3alashan ageb mn goah
        }

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
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
                label5.Visible = false;
                txtName.Visible = false;
                txtAddress.Visible = false;
                txtPhone.Visible = false;
                txtSalary.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtName.Visible = true;
                txtAddress.Visible = true;
                txtPhone.Visible = true;
                txtSalary.Visible = true;
            }

        }
        private void True()
        {
            if (label1.Visible == false)
            {
                label1.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                txtName.Visible = true;
                txtAddress.Visible = true;
                txtPhone.Visible = true;
                txtSalary.Visible = true;
            }
           

        }
        #endregion

        #region Selected Driver

        private void CmbDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            True();
            //db 
            txtName.Text = "Driver";
            txtPhone.Text = "01067893079";
            txtAddress.Text = "aga";
            txtSalary.Text = "5000";
        }

        #endregion
    }
}
