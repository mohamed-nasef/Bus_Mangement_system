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

namespace Bus_Mangement_system.SCR.Daily_Ticket
{
    public partial class AddDailyTickets : Form
    {

        #region Prop

        string oneWay ="", roundTrip="";
        int iOneWay, iRoundTrip;

        #endregion

        public AddDailyTickets()
        {
            InitializeComponent();
        }


        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Function
        protected bool validtxtOneWay()
        {
            bool flag = false;
            Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
            if (!(r.IsMatch(txtOneWay.Text)))
            {

                errorProvider1.SetError(txtOneWay, "Enter valid money like $ 500");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtOneWay, null);
                oneWay = txtOneWay.Text;
                flag = true;
            }
            return flag;
        }

        protected bool validtxtRoundTrip()
        {
            bool flag = false;
            Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
            if (!(r.IsMatch(txtRoundTrip.Text)))
            {

                errorProvider1.SetError(txtRoundTrip, "Enter valid money like $ 500");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtRoundTrip, null);
                roundTrip = txtRoundTrip.Text;
                flag = true;
            }
            return flag;
        }

        #endregion

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
        //private void txtOneWay_Validating(object sender, CancelEventArgs e)
        //{
        //    Functions.validationTxt(txtOneWay, "Please Enter Number Of Tickets", ref oneWay, e, errorProvider1);
        //}

        //private void txtRoundTrip_Validating(object sender, CancelEventArgs e)
        //{
        //    Functions.validationTxt(txtRoundTrip, "Please Enter Number Of Tickets", ref roundTrip, e, errorProvider1);
        //}

        #endregion

        #region Add Daily Tickets Button
        private void btnAddDailyTickets_Click(object sender, EventArgs e)
        {

            //validtxtOneWay();
            //validtxtRoundTrip();
            //Validition
            if (txtOneWay.Text!=""&&txtRoundTrip.Text=="")
            {
                if (validtxtOneWay())
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A one-way ticket: {oneWay}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(oneWay, out iOneWay);
                        //DB Commands

                        //clear
                        txtOneWay.Clear();
                        txtRoundTrip.Clear();
                        MetroFramework.MetroMessageBox.Show(this, "\n\nDaily Tickets Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            else if (txtRoundTrip.Text != ""&& txtOneWay.Text == "")
            {
                if (validtxtRoundTrip())
                {
                    
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A Round Trip ticket: {roundTrip}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(roundTrip, out iRoundTrip);
                        //DB Commands

                        //clear
                        txtOneWay.Clear();
                        txtRoundTrip.Clear();
                        MetroFramework.MetroMessageBox.Show(this, "\n\nDaily Tickets Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            else if(txtRoundTrip.Text != "" && txtOneWay.Text != "")
            {
                if (validtxtRoundTrip()&&validtxtOneWay())
                {

                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A one-way ticket: {oneWay}\nA Round Trip ticket: {roundTrip}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(roundTrip, out iRoundTrip);
                        int.TryParse(oneWay, out iOneWay);
                        //DB Commands

                        //clear
                        txtOneWay.Clear();
                        txtRoundTrip.Clear();
                        MetroFramework.MetroMessageBox.Show(this, "\n\nDaily Tickets Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }

        }

        #endregion

    }
}
