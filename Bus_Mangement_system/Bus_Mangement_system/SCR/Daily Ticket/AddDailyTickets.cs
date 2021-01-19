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

namespace Bus_Mangement_system.SCR.Daily_Ticket
{
    public partial class AddDailyTickets : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        DailyTicket dailyTicket = new DailyTicket();
        
        #endregion

        #region Form

        public AddDailyTickets()
        {
            InitializeComponent();
        }

        private void AddDailyTickets_Load(object sender, EventArgs e)
        {
            dataBase.connection = new SqlConnection(dataBase.conString);
        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
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

                errorProvider1.SetError(txtOneWay, "Enter Ticket Numbers Like 30");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtOneWay, null);
                dailyTicket.strOneWay = txtOneWay.Text;
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

                errorProvider1.SetError(txtRoundTrip, "Enter Ticket Numbers Like 60");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtRoundTrip, null);
                dailyTicket.strRoundTrip = txtRoundTrip.Text;
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

        #region Add Daily Tickets Button
        private void btnAddDailyTickets_Click(object sender, EventArgs e)
        {

            dailyTicket.iTotal = 0;
            int refIOneWay, refIRoundTrip, refIPrice;

            //Validition

            //validtxtOneWay();
            if (txtOneWay.Text!=""&&txtRoundTrip.Text=="")
            {
                if (validtxtOneWay())
                {
                    
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A one-way ticket: {dailyTicket.strOneWay}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        
                        int.TryParse(dailyTicket.strOneWay, out refIOneWay);
                        dailyTicket.iOneWay = refIOneWay;

                        //DB Commands
                        dataBase.cmd = new SqlCommand("select price from bookingPrice bp  where bp.bookingType_id ='1' and bp.expiryDate is null", dataBase.connection);
                        dataBase.connection.Open();
                        dataBase.cmd.ExecuteNonQuery();
                        dataBase.drr = dataBase.cmd.ExecuteReader();
                        while (dataBase.drr.Read())
                        {
                            dailyTicket.strPrice = (string)dataBase.drr["price"].ToString();
                            int.TryParse(dailyTicket.strPrice, out refIPrice);
                            dailyTicket.iPrice = refIPrice;
                        }
                        dailyTicket.iTotal = dailyTicket.iOneWay * (dailyTicket.iPrice /2);
                        dataBase.connection.Close();

                        dataBase.connection.Open();
                        SqlCommand cmdproce = new SqlCommand("exec dailyBookingCheckExist '"+ dailyTicket.strDate +"',"+ dailyTicket.iTotal +"", dataBase.connection);
                        cmdproce.ExecuteNonQuery();

                        dataBase.connection.Close();


                        //clear
                        txtOneWay.Clear();
                        txtRoundTrip.Clear();
                        MetroFramework.MetroMessageBox.Show(this, "\n\nDaily Tickets Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }

            //validtxtRoundTrip();
            else if (txtRoundTrip.Text != ""&& txtOneWay.Text == "")
            {
                if (validtxtRoundTrip())
                {
                    
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A Round Trip ticket: {dailyTicket.strRoundTrip}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(dailyTicket.strRoundTrip, out refIRoundTrip);
                        dailyTicket.iRoundTrip = refIRoundTrip;

                        //DB Commands
                        dataBase.cmd = new SqlCommand("select price from bookingPrice bp  where bp.bookingType_id ='1' and bp.expiryDate is null", dataBase.connection);
                        dataBase.connection.Open();
                        dataBase.cmd.ExecuteNonQuery();
                        dataBase.drr = dataBase.cmd.ExecuteReader();
                        while (dataBase.drr.Read())
                        {
                            dailyTicket.strPrice = (string)dataBase.drr["price"].ToString();
                            int.TryParse(dailyTicket.strPrice, out refIPrice);
                            dailyTicket.iPrice = refIPrice;
                        }
                        dailyTicket.iTotal = dailyTicket.iRoundTrip * dailyTicket.iPrice;
                        dataBase.connection.Close();

                        dataBase.connection.Open();
                        SqlCommand cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + dailyTicket.strDate + "'," + dailyTicket.iTotal + "", dataBase.connection);
                        cmdproce.ExecuteNonQuery();

                        dataBase.connection.Close();

                        //clear
                        txtOneWay.Clear();
                        txtRoundTrip.Clear();
                        MetroFramework.MetroMessageBox.Show(this, "\n\nDaily Tickets Added Successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }

            //validtxtOneWay() && validtxtRoundTrip();
            else if (txtRoundTrip.Text != "" && txtOneWay.Text != "")
            {
                if (validtxtRoundTrip()&&validtxtOneWay())
                {

                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A one-way ticket: {dailyTicket.strOneWay}\nA Round Trip ticket: {dailyTicket.strRoundTrip}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(dailyTicket.strOneWay, out refIOneWay);
                        int.TryParse(dailyTicket.strRoundTrip, out refIRoundTrip);
                        dailyTicket.iOneWay = refIOneWay;
                        dailyTicket.iRoundTrip = refIRoundTrip;

                        //DB Commands
                        dataBase.cmd = new SqlCommand("select price from bookingPrice bp  where bp.bookingType_id ='1' and bp.expiryDate is null", dataBase.connection);
                        dataBase.connection.Open();
                        dataBase.cmd.ExecuteNonQuery();
                        dataBase.drr = dataBase.cmd.ExecuteReader();
                        while (dataBase.drr.Read())
                        {
                            dailyTicket.strPrice = (string)dataBase.drr["price"].ToString();
                            int.TryParse(dailyTicket.strPrice, out refIPrice);
                            dailyTicket.iPrice = refIPrice;
                        }
                        dailyTicket.iTotal = (dailyTicket.iRoundTrip * dailyTicket.iPrice) + (dailyTicket.iOneWay * (dailyTicket.iPrice / 2));
                        dataBase.connection.Close();

                        dataBase.connection.Open();
                        SqlCommand cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + dailyTicket.strDate + "'," + dailyTicket.iTotal + "", dataBase.connection);
                        cmdproce.ExecuteNonQuery();

                        dataBase.connection.Close();


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
