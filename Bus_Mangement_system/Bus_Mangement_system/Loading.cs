﻿using System;
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
    public partial class Loading : Form
    {

        #region Prop

        login obj = new login();

        #endregion

        #region Form

        public Loading()
        {
            InitializeComponent();
        }

        #endregion

        #region Loading Timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();
                obj.Show();
                this.Hide();
            }
        }

        #endregion

    }
}
