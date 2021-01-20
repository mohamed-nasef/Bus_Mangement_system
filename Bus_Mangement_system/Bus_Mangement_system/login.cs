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
using System.Configuration;

namespace Bus_Mangement_system
{
    public partial class login : Form
    {

        #region DB

        SCR.DataBase dataBase = new SCR.DataBase();

        #endregion

        #region Prop

        string strUserName, strPassword;
        Main mObj = new Main();

        #endregion

        #region Form

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = new SqlCommand("select * from userLogin ", dataBase.connection);
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                strUserName = dr["userName"].ToString();
                strPassword  = dr["password"].ToString();

            }
            dataBase.connection.Close();
           
        }

        #endregion

        #region Close Form

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            Application.Exit();
        }

        #endregion

        #region Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (strUserName == txtUserName.Text && strPassword == txtPassword.Text)
            {
                mObj.Show();
                this.Hide();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nIncorrect username or password", "\nincorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

    }
}
