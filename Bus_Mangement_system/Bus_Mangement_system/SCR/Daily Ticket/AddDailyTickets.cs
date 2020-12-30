using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Daily_Ticket
{
    public partial class AddDailyTickets : Form
    {
        string oneWay, roundTrip;
        int iOneWay, iRoundTrip;
        public AddDailyTickets()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region WaterMark
        private void txtOneWay_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtOneWay, lblOneWay);
        }

        private void txtRoundTrip_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtRoundTrip, lblRoundTrip);
        }

        #endregion

        #region TextBox Validation
        private void txtOneWay_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtOneWay, "Please Enter Number Of Tickets", ref oneWay, e, errorProvider1);
        }

        private void txtRoundTrip_Validating(object sender, CancelEventArgs e)
        {
            Functions.validationTxt(txtRoundTrip, "Please Enter Number Of Tickets", ref roundTrip, e, errorProvider1);
        }

        #endregion

        #region Add Daily Tickets Button
        private void btnAddDailyTickets_Click(object sender, EventArgs e)
        {
            //Validition
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A one-way ticket: {oneWay}\nRound Trip ticket: {roundTrip}", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB Commands

                    //clear
                    txtOneWay.Clear();
                    txtRoundTrip.Clear();
                    MetroFramework.MetroMessageBox.Show(this, "\n\nDaily Tickets Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        #endregion

    }
}
