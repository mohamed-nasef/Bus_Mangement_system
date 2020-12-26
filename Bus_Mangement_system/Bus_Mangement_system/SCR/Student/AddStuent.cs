using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Student
{
    public partial class AddStuent : Form
    {
        public AddStuent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Validition
            //DB Commands
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            cmbAddress.SelectedIndex = cmbBookingType.SelectedIndex = cmbUniversity.SelectedIndex = -1;
            MetroFramework.MetroMessageBox.Show(this, "\n\nStudent Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
