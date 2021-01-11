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

namespace Bus_Mangement_system
{
    public partial class Main : Form
    {

        #region DB

        string conString = @"Data Source=DESKTOP-7521PNM\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";//-------
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataRow dr;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop
        int year = DateTime.Now.Year,month=DateTime.Now.Month,day=DateTime.Now.Day;

        #endregion

        #region Form

        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void Main_Load(object sender, EventArgs e)
        {

            //------------------------------------
            //label
            labelMonthlyDetailsIncome.Text = labelMonthlyDetailsPayments.Text = labelMonthlyDetailsProfits.Text = $"Details of Last {day} Days";
            labelDateDailyTicket.Text = $"Details of {DateTime.Now.ToShortDateString()}";
            //------------------------------------



            //------------------------------------
            //db
            connection = new SqlConnection(conString);
            connection.Open();


            //select income ,payments and profit
            cmd = new SqlCommand("SELECT (sum(dailyBooking)+SUM(monthlyBooking)+SUM(termBooking)) as 'income' ,(SUM(driverTakenSalary)+sum(busFees)) as 'payments' FROM profit WHERE DATEPART(YEAR, profit_date) = '" + year + "'  AND DATEPART(MONTH, profit_date) ='" + month + "'", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                labelIncome.Text = $"$ {dr["income"].ToString()}";
                labelPayments.Text = $"$ {dr["payments"].ToString()}";
                labelProfits.Text = $"$ {((int)dr["income"] -(int)dr["payments"]).ToString()}";
            }

            //count Daily Tickets
            cmd = new SqlCommand("select count(bookingType_id) as count from studentBooking where bookingFrom='"+DateTime.Now.ToShortDateString()+"' and bookingType_id=1", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                labelDailyTickets.Text = $"{dr["count"].ToString()}";
            }



            //select student id ,count valid students and count expired students
            List<int> arrStudentID = new List<int>();
            int valid=0, expired=0;
            bool flag = false;
            DateTime sys = DateTime.Now;
            DateTime expire;


            cmd = new SqlCommand("select student_id as id from studentInformation", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                arrStudentID.Add ((int)dr["id"]);
            }

            for (int i = 0; i < arrStudentID.Count; i++)
            {
                flag = false;
                cmd = new SqlCommand("select * from studentBooking where student_id = " + arrStudentID[i] + " ", connection);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    expire = (DateTime)dr["bookingTo"];
                    if (sys <= expire)
                        flag = true;

                }
                if (flag)
                {
                    valid++;
                }
                else
                {
                    expired++;
                }
            }
            labelValidStudents.Text = $"{valid}";
            labelExpiredStudents.Text = expired.ToString();



            //count bus
            cmd = new SqlCommand("select count(bus_id) as count from busInformation", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                labelBuses.Text = $"{dr["count"].ToString()}";
            }

            //count driver
            cmd = new SqlCommand("select count(driver_id) as count from driverInformation", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                labelDrivers.Text = $"{dr["count"].ToString()}";
            }
            connection.Close();
            //------------------------------------
        }
        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {
            Main_Load(null, EventArgs.Empty);

        }
        private void PanelChildForm_Enter(object sender, EventArgs e)
        {
            Main_Load(null, EventArgs.Empty);
        }

        private void PanelChildForm_MouseEnter(object sender, EventArgs e)
        {
            Main_Load(null, EventArgs.Empty);
        }


        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Main_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        #endregion

        #region Close Form

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region function
        private void customizeDesign()
        {
            if (panelMenu.Visible == false)
            {
                panelMenu.Visible = true;
            }
            else
            {
                panelMenu.Visible = false;
            }
            studentSubPanel.Visible = false;
            paneliconStudent.Visible = false;
            busSubPanel.Visible = false;
            paneliconBus.Visible = false;
            driverSubPanel.Visible = false;
            paneliconDriver.Visible = false;
            reportSubPanel.Visible = false;
            paneliconReport.Visible = false;
            dailyticketSubPanel.Visible = false;
            paneliconDailyTicket.Visible = false;
        }
        private void hideSubMenu()
        {
            if (studentSubPanel.Visible == true)
            {
                studentSubPanel.Visible = false;
                paneliconStudent.Visible = false;
            }
            if (busSubPanel.Visible == true)
            {
                busSubPanel.Visible = false;
                paneliconBus.Visible = false;
            }
            if (driverSubPanel.Visible == true)
            {
                driverSubPanel.Visible = false;
                paneliconDriver.Visible = false;
            }
            if (reportSubPanel.Visible == true)
            {
                reportSubPanel.Visible = false;
                paneliconReport.Visible = false;
            }
            if (dailyticketSubPanel.Visible == true)
            {
                dailyticketSubPanel.Visible = false;
                paneliconDailyTicket.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu, Panel iconPanel/*, int height = 243*/)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
                iconPanel.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
                iconPanel.Visible = false;

            }
        }

        private  Form activeForm = null;
        public  void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        #region Drawer
        private void btnDrawer_Click(object sender, EventArgs e)
        {
            customizeDesign();
        }



        #endregion

        #region Student


        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(studentSubPanel, paneliconStudent);
        }

        private void btniconStudent_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(studentSubPanel, paneliconStudent);
           
        }
        private void addStudent_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Student.AddStuent asObj = new SCR.Student.AddStuent();
            openChildForm(asObj);
        }

        private void editStudent_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Search sObj = new SCR.Search();
            sObj.path = "Edit";
            openChildForm(sObj);

        }

        private void booking_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Search sObj = new SCR.Search();
            sObj.path = "Renew Booking";
            openChildForm(sObj);
            
        }

        private void reportStudent_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Search sObj = new SCR.Search();
            sObj.path = "Report";
            openChildForm(sObj);
        }

        #endregion

        #region Bus
        private void btnBus_Click(object sender, EventArgs e)
        {
            showSubMenu(busSubPanel, paneliconBus);
        }

        private void btniconBus_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(busSubPanel, paneliconBus);
        }

        private void addBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //btniconBus.BackColor = ColorTranslator.FromHtml("#5487BE");
            SCR.Bus.AddBus abObj = new SCR.Bus.AddBus();
            openChildForm(abObj);

        }

        private void editBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Bus.EditBus ebObj = new SCR.Bus.EditBus();
            openChildForm(ebObj);

        }

        private void Fees_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Bus.AddFees afObj = new SCR.Bus.AddFees();
            openChildForm(afObj);
        }

        private void reportBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Bus.BusReport rbObj = new SCR.Bus.BusReport();
            openChildForm(rbObj);
        }

        #endregion

        #region Driver
        private void btnDriver_Click(object sender, EventArgs e)
        {
            showSubMenu(driverSubPanel, paneliconDriver);
        }
        private void btniconDriver_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(driverSubPanel, paneliconDriver);
        }
        private void addDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Driver.AddDriver adObj = new SCR.Driver.AddDriver();
            openChildForm(adObj);
            
        }

        private void editDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Driver.EditDriver edObj = new SCR.Driver.EditDriver();
            openChildForm(edObj);
           
        }

        private void salary_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Driver.Salary sObj = new SCR.Driver.Salary();
            openChildForm(sObj);

        }

        private void reportDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Driver.DriverReport drObj = new SCR.Driver.DriverReport();
            openChildForm(drObj);
        }
        #endregion

        #region DailyTickets
        private void btnDailyTickets_Click(object sender, EventArgs e)
        {
            showSubMenu(dailyticketSubPanel, paneliconDailyTicket/*, dailyticketPanelHeight*/);
        }

        private void btniconDailyTicket_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(dailyticketSubPanel, paneliconDailyTicket/*, dailyticketPanelHeight*/);
        }

        private void addDailyTicket_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Daily_Ticket.AddDailyTickets adtObj = new SCR.Daily_Ticket.AddDailyTickets();
            openChildForm(adtObj);
        }
        #endregion

        #region Report
        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(reportSubPanel, paneliconReport/*, reportPanelHeight*/);
        }
        private void btniconReport_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            showSubMenu(reportSubPanel, paneliconReport/*, reportPanelHeight*/);
        }
        private void monthlyReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Report.MonthlyReport mrObj = new SCR.Report.MonthlyReport();
            openChildForm(mrObj);
        }

        private void dailyReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Report.DailyReport drObj = new SCR.Report.DailyReport();
            openChildForm(drObj);
        }

        private void universityReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Report.UniversityReport urObj = new SCR.Report.UniversityReport();
            openChildForm(urObj);
        }
        private void StudentReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Report.StudentReport srObj = new SCR.Report.StudentReport();
            openChildForm(srObj);
        }

        #endregion

        #region Modify Price

        private void BtnModifyPrice_Click(object sender, EventArgs e)
        {
            customizeDesign();
            SCR.Modify_Price.ModifyPrice mpObj = new SCR.Modify_Price.ModifyPrice();
            openChildForm(mpObj);
        }

        private void BtniconModifyPrice_Click(object sender, EventArgs e)
        {
            customizeDesign();
            panelMenu.Visible = false;
           
            SCR.Modify_Price.ModifyPrice mpObj = new SCR.Modify_Price.ModifyPrice();
            openChildForm(mpObj);
        }

        #endregion

    }
}