using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Bus
{
    public partial class BusReport : Form
    {

        #region Prop
        int busindex = -1;
        string name, LicenseNumber, strCapacity = "0";
        int capacity = 0, index = -1;

        #endregion

        public BusReport()
        {
            InitializeComponent();
        }

        private void BusReport_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            txtName.Visible = false;
            txtLicenseNumber.Visible = false;
            txtCapacity.Visible = false;

            //db 3alashan ageb mn goah
        }

        #region Close Form
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Selected Bus
        private void CmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            txtName.Visible = true;
            txtLicenseNumber.Visible = true;
            txtCapacity.Visible = true;

            //db 
            txtName.Text = "Bus 1";
            txtLicenseNumber.Text = "123KFC";
            txtCapacity.Text="32";
        }
        #endregion

    }
}
