using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR
{
    public partial class TestSearchcs : Form
    {
        public int id;
        public TestSearchcs()
        {
            InitializeComponent();
        }

        private void GunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
            bool isNumber = int.TryParse(txtStudentId.Text, out id);
            this.Close();
        }
    }
}
