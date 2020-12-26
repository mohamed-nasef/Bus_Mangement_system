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
    public partial class login : Form
    {
        string username, password;
        Main obj = new Main();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //select from DB
            username = "a";
            password = "1";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username == txtUserName.Text && password == txtPassword.Text)
            {
                obj.Show();
                this.Hide();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nIncorrect username Or password", "\nincorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

    }
}
