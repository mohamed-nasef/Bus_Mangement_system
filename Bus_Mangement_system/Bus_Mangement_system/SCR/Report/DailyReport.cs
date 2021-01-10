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
        string date;
        //dasdl;as,l;d,asld,as;ld,asdl;,asl;d,asdl;,asdlas,dlasd
        string constr = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        public DailyReport()
        {
            InitializeComponent();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            //this.profitTableAdapter.Fill(this.testDataSet.profit);
            dgvDaily.Visible = false;
            date= dtpDaily.Value.ToShortDateString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtpDaily_ValueChanged(object sender, EventArgs e)
        {
            date = dtpDaily.Value.ToShortDateString();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select p.profit_date as 'Date', p.driverTakenSalary as 'Driver Salary',p.busFees as 'Bus Fees',p.dailyBooking as 'Daily Booking',p.monthlyBooking as 'Monthly Booking',p.termBooking as 'Term Booking'  from profit p where profit_date='" + date + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "daily");
            if (ds.Tables["daily"].Rows.Count > 0)
            {
                dgvDaily.Visible = true;
                btnProfit.Visible = true;
                dgvDaily.DataSource = ds.Tables["daily"];
                da = new SqlDataAdapter("SELECT (sum(dailyBooking)+SUM(monthlyBooking)+SUM(termBooking))-(SUM(driverTakenSalary)+sum(busFees)) as profit FROM profit where profit_date='" + date + "'", con);
                da.Fill(ds, "profitDaily");
                DataRow dr = ds.Tables["profitDaily"].Rows[0];
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
                MetroFramework.MetroMessageBox.Show(this, $"There is no report for this date {date} ", "\nError ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvDaily.Visible = false;
                btnProfit.Visible = false;

            }
        }

    }
}
