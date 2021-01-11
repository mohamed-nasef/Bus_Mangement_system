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
    public partial class MonthlyReport : Form
    {

        #region DB

        int year, month;
        string conString = Program.GetConnectionStringByName();
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Form

        public MonthlyReport()
        {
            InitializeComponent();
        }
        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            //this.profitTableAdapter.Fill(this.testDataSet.profit);
            dgvMonthly.Visible = false;
            year = (int)numYear.Value;
            month = (int)numMonth.Value;
        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        #endregion

        #region Select Date

        private void NumYear_ValueChanged(object sender, EventArgs e)
        {
            year = (int)numYear.Value;
        }

        private void NumMonth_ValueChanged(object sender, EventArgs e)
        {
            month = (int)numMonth.Value;
        }

        #endregion

        #region Search Button

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT p.profit_date as 'Date', p.driverTakenSalary as 'Driver Salary',p.busFees as 'Bus Fees',p.dailyBooking as 'Daily Booking',p.monthlyBooking as 'Monthly Booking',p.termBooking as 'Term Booking' FROM profit p WHERE DATEPART(YEAR, profit_date) = '" + year + "' AND DATEPART(MONTH, profit_date) = '" + month + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "monthly");
            if (ds.Tables["monthly"].Rows.Count > 0)
            {
                dgvMonthly.Visible = true;
                btnProfit.Visible = true;
                dgvMonthly.DataSource = ds.Tables["monthly"];
                da = new SqlDataAdapter("SELECT (sum(dailyBooking)+SUM(monthlyBooking)+SUM(termBooking))-(SUM(driverTakenSalary)+sum(busFees)) as profit FROM profit WHERE DATEPART(YEAR, profit_date) = '" + year + "'  AND DATEPART(MONTH, profit_date) ='" + month + "'", connection);
                da.Fill(ds, "profit");
                DataRow dr = ds.Tables["profit"].Rows[0];
                if ((int)dr.ItemArray.GetValue(0) > 0)
                {
                    btnProfit.Text = $"Profit = {dr.ItemArray.GetValue(0).ToString()}";
                    btnProfit.BaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnProfit.OnHoverBaseColor = ColorTranslator.FromHtml("#4DE1AF");
                    btnProfit.OnPressedColor = ColorTranslator.FromHtml("#4DE1AF");
                }
                else
                {
                    btnProfit.Text = $"losses = {dr.ItemArray.GetValue(0).ToString()}";
                    btnProfit.BaseColor = ColorTranslator.FromHtml("#E1184D");
                    btnProfit.OnHoverBaseColor = ColorTranslator.FromHtml("#E1184D");
                    btnProfit.OnPressedColor = ColorTranslator.FromHtml("#E1184D");
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, $"There is no report for this date {year}-{month}-1 ", "\nError ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvMonthly.Visible = false;
                btnProfit.Visible = false;

            }
            connection.Close();
        }

        #endregion

    }
}
