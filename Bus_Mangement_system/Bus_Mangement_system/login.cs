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

        string conString = Program.GetConnectionStringByName();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection connection = new SqlConnection();

        #endregion

        #region Prop

        string username, password;
        Main obj = new Main();

        #endregion

        #region Form

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            connection.Open();
            cmd = new SqlCommand("select * from userLogin ", connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                username = dr["userName"].ToString();
                password  = dr["password"].ToString();

            }
            connection.Close();
           
        }

        #endregion

        #region Close Form

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            connection.Close();
            Application.Exit();
        }

        #endregion

        #region Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username == txtUserName.Text && password == txtPassword.Text)
            {
                obj.Show();
                this.Hide();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nIncorrect username or password", "\nincorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

    }
}
