using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Mangement_system.SCR.Modify_Price
{
    public partial class ModifyPrice : Form
    {
        #region Prop

        string strNewPrice;
        int iBookingTypeId,iNewPrice,iOldPrice;

        #endregion
        public ModifyPrice()
        {
            InitializeComponent();
        }
        private void ModifyPrice_Load(object sender, EventArgs e)
        {
            visible();
        }

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Function

        private void visible()
        {
            if (label1.Visible==true)
            {
                label1.Visible = false;
                label5.Visible = false;
                lblNewPrice.Visible = false;
                txtOldPrice.Visible = false;
                txtNewPrice.Visible = false;
                btnModifyPrice.Visible = false;
            }
            else
            {
                label1.Visible = true;
                label5.Visible = true;
                lblNewPrice.Visible = true;
                txtOldPrice.Visible = true;
                txtNewPrice.Visible = true;
                btnModifyPrice.Visible = true;
            }
        }

        protected bool valid()
        {
            bool flag;
            Regex r = new Regex(@"^[1-9]{1}[0-9]*$");
            if (!(r.IsMatch(txtNewPrice.Text)))
            {

                errorProvider1.SetError(txtNewPrice, "Enter valid money like $ 500");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtNewPrice, null);
                strNewPrice = txtNewPrice.Text;
                flag = true;
            }
            return flag;
        }


        #endregion

        #region Watermark

        private void TxtNewPrice_TextChanged(object sender, EventArgs e)
        {
            Functions.waterMark(txtNewPrice, lblNewPrice);
        }

        #endregion

        #region Select Booking Type

        private void CmbBookingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            visible();
            iBookingTypeId = cmbBookingType.SelectedIndex + 1;
            //DB select booking type price from table where notnull
            iOldPrice = 350;
            txtOldPrice.Text = iOldPrice.ToString();
        }

        #endregion

        private void BtnModifyPrice_Click(object sender, EventArgs e)
        {

            if (valid())
            {
                int.TryParse(strNewPrice, out iNewPrice);
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"Modify New Price to {iNewPrice}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB Commands


                    //clear
                    txtOldPrice.Clear();
                    txtNewPrice.Clear();
                    cmbBookingType.SelectedIndex = -1;
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPrice has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            
        }
    }
}
