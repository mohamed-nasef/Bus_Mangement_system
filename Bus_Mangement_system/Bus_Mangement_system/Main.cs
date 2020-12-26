using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

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

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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
            //new form
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
            //new form
        }

        private void booking_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void reportStudent_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
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
            //new form
        }

        private void editBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void Fees_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void reportBus_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
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
            //new form
        }

        private void editDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void salary_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void reportDriver_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
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
            //new form
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
            //new form
        }

        private void dailyReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }

        private void universityReport_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form
        }
        #endregion

        #region Setting
        private void btnSetting_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form

        }

        private void btniconSetting_Click(object sender, EventArgs e)
        {
            customizeDesign();
            //new form

        }


        #endregion

    }
}