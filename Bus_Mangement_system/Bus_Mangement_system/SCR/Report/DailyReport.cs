using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Report
{
    public partial class DailyReport : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        string date;

        #endregion

        #region Form

        public DailyReport()
        {
            InitializeComponent();
        }
        private void DailyReport_Load(object sender, EventArgs e)
        {
            dataBase.connection = new SqlConnection(dataBase.conString);
            dgvDaily.Visible = false;
            date= dtpDaily.Value.ToShortDateString();
        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

        #region Select Date

        private void DtpDaily_ValueChanged(object sender, EventArgs e)
        {
            date = dtpDaily.Value.ToShortDateString();
        }

        #endregion

        #region Search Button

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dataBase.connection.Open();
            dataBase.da = new SqlDataAdapter("select p.profit_date as 'Date', p.driverTakenSalary as 'Driver Salary',p.busFees as 'Bus Fees',p.dailyBooking as 'Daily Booking',p.monthlyBooking as 'Monthly Booking',p.termBooking as 'Term Booking'  from profit p where profit_date='" + date + "'", dataBase.connection);
            dataBase.ds = new DataSet();
            dataBase.da.Fill(dataBase.ds, "daily");
            if (dataBase.ds.Tables["daily"].Rows.Count > 0)
            {
                dgvDaily.Visible = true;
                btnProfit.Visible = true;
                dgvDaily.DataSource = dataBase.ds.Tables["daily"];
                dataBase.da = new SqlDataAdapter("SELECT (sum(dailyBooking)+SUM(monthlyBooking)+SUM(termBooking))-(SUM(driverTakenSalary)+sum(busFees)) as profit FROM profit where profit_date='" + date + "'", dataBase.connection);
                dataBase.da.Fill(dataBase.ds, "profitDaily");
                dataBase.dr = dataBase.ds.Tables["profitDaily"].Rows[0];
                if ((int)dataBase.dr.ItemArray.GetValue(0) > 0)
                {
                    btnProfit.Text = $"Profit = {dataBase.dr.ItemArray.GetValue(0).ToString()}";
                    btnProfit.BaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnProfit.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnProfit.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");
                }
                else
                {
                    btnProfit.Text = $"losses = {dataBase.dr.ItemArray.GetValue(0).ToString()}";
                    btnProfit.BaseColor = ColorTranslator.FromHtml("#E1184D");
                    btnProfit.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    btnProfit.OnPressedColor = ColorTranslator.FromHtml("#E1184D");
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, $"There is no report for this date {date} ", "\nError ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvDaily.Visible = false;
                btnProfit.Visible = false;

            }
            dataBase.connection.Close();
        }

        #endregion

    }
}
