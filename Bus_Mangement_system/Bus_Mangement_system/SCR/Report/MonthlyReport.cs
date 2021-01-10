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
        int year, month;
        //dasdl;as,l;d,asld,as;ld,asdl;,asl;d,asdl;,asdlas,dlasd
        string constr = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            //this.profitTableAdapter.Fill(this.testDataSet.profit);
            dgvMonthly.Visible = false;
            year = (int)numYear.Value;
            month = (int)numMonth.Value;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void NumYear_ValueChanged(object sender, EventArgs e)
        {
            year = (int)numYear.Value;
        }

        private void NumMonth_ValueChanged(object sender, EventArgs e)
        {
            month = (int)numMonth.Value;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM profit WHERE DATEPART(YEAR, profit_date) = '" + year + "' AND DATEPART(MONTH, profit_date) = '" + month + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "monthly");
            if (ds.Tables["monthly"].Rows.Count > 0)
            {
                dgvMonthly.Visible = true;
                btnProfit.Visible = true;
                dgvMonthly.DataSource = ds.Tables["monthly"];
                da = new SqlDataAdapter("SELECT (sum(dailyBooking)+SUM(monthlyBooking)+SUM(termBooking))-(SUM(driverTakenSalary)+sum(busFees)) as profit FROM profit WHERE DATEPART(YEAR, profit_date) = '" + year + "'  AND DATEPART(MONTH, profit_date) ='" + month + "'", con);
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
                    btnProfit.Text = $"Financial losses = {dr.ItemArray.GetValue(0).ToString()}";
                    btnProfit.BaseColor = ColorTranslator.FromHtml("#E1184D");
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, $"There is no report for this date {year}-{month}-1 ", "\nError ?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvMonthly.Visible = false;
                btnProfit.Visible = false;

            }
        }

    }
}
