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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlConnection connection = new SqlConnection();
        #endregion

        #region Prop

        string strOneWay ="", strRoundTrip="",strPrice,strDate=DateTime.Now.ToShortDateString();
        int iOneWay, iRoundTrip,iPrice,iTotal=0;

        #endregion

        #region Form

        public AddDailyTickets()
        {
            InitializeComponent();
        }

        private void AddDailyTickets_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
        }

        #endregion

        #region Close Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
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
                strOneWay = txtOneWay.Text;
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
                strRoundTrip = txtRoundTrip.Text;
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
            iTotal = 0;
            //validtxtOneWay();
            //validtxtRoundTrip();
            //Validition

            if (txtOneWay.Text!=""&&txtRoundTrip.Text=="")
            {
                if (validtxtOneWay())
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A one-way ticket: {strOneWay}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(strOneWay, out iOneWay);

                        //DB Commands
                        cmd = new SqlCommand("select price from bookingPrice bp  where bp.bookingType_id ='1' and bp.expiryDate is null", connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            strPrice = (string)dr["price"].ToString();
                            int.TryParse(strPrice, out iPrice);
                        }
                        iTotal = iOneWay * (iPrice/2);
                        connection.Close();

                        connection.Open();
                        SqlCommand cmdproce = new SqlCommand("exec dailyBookingCheckExist '"+strDate+"',"+iTotal+"", connection);
                        cmdproce.ExecuteNonQuery();

                        connection.Close();


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
                    
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A Round Trip ticket: {strRoundTrip}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(strRoundTrip, out iRoundTrip);

                        //DB Commands
                        cmd = new SqlCommand("select price from bookingPrice bp  where bp.bookingType_id ='1' and bp.expiryDate is null", connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            strPrice = (string)dr["price"].ToString();
                            int.TryParse(strPrice, out iPrice);
                        }
                        iTotal = iRoundTrip * iPrice;
                        connection.Close();

                        connection.Open();
                        SqlCommand cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + strDate + "'," + iTotal + "", connection);
                        cmdproce.ExecuteNonQuery();

                        connection.Close();

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

                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"A one-way ticket: {strOneWay}\nA Round Trip ticket: {strRoundTrip}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        int.TryParse(strRoundTrip, out iRoundTrip);
                        int.TryParse(strOneWay, out iOneWay);

                        //DB Commands
                        cmd = new SqlCommand("select price from bookingPrice bp  where bp.bookingType_id ='1' and bp.expiryDate is null", connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            strPrice = (string)dr["price"].ToString();
                            int.TryParse(strPrice, out iPrice);
                        }
                        iTotal = (iRoundTrip * iPrice) + (iOneWay * (iPrice / 2));
                        connection.Close();

                        connection.Open();
                        SqlCommand cmdproce = new SqlCommand("exec dailyBookingCheckExist '" + strDate + "'," + iTotal + "", connection);
                        cmdproce.ExecuteNonQuery();

                        connection.Close();


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
