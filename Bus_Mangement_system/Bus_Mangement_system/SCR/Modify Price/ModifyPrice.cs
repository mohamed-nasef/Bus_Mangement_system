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
using System.Data.SqlClient;

namespace Bus_Mangement_system.SCR.Modify_Price
{
    public partial class ModifyPrice : Form
    {

        #region DB

        DataBase dataBase = new DataBase();

        #endregion

        #region Prop

        BookingPrice bookingPrice = new BookingPrice();

        #endregion

        #region Form

        public ModifyPrice()
        {
            InitializeComponent();
        }
        private void ModifyPrice_Load(object sender, EventArgs e)
        {
            visible();
            cmbBookingType.Items.Clear();
            dataBase.connection = new SqlConnection(dataBase.conString);
            dataBase.connection.Open();
            dataBase.cmd = dataBase.connection.CreateCommand();
            dataBase.cmd.CommandType = CommandType.Text;
            dataBase.cmd.CommandText = "select bookingType_name from bookingType";
            dataBase.cmd.ExecuteNonQuery();
            dataBase.dt = new DataTable();
            dataBase.da = new SqlDataAdapter(dataBase.cmd);
            dataBase.da.Fill(dataBase.dt);
            foreach (DataRow dr in dataBase.dt.Rows)
            {
                cmbBookingType.Items.Add(dr["bookingType_name"].ToString());
            }
            dataBase.connection.Close();
        }

        #endregion

        #region Close Form

        private void BtnClose_Click(object sender, EventArgs e)
        {
            dataBase.connection.Close();
            this.Close();
        }

        #endregion

        #region Function

        private void visible()
        {
            if (label4.Visible==true)
            {
                label1.Visible = false;
                label5.Visible = false;
                lblNewPrice.Visible = false;
                txtOldPrice.Visible = false;
                txtNewPrice.Visible = false;
                btnModifyPrice.Visible = false;
            }
           
        }
        private void show()
        {
            if (label1.Visible==false)
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

                errorProvider1.SetError(txtNewPrice, "Enter Valid Money Like $ 500");
                flag = false;
            }
            else
            {

                errorProvider1.SetError(txtNewPrice, null);
                bookingPrice.strNewPrice = txtNewPrice.Text;
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
            show();
            bookingPrice.iBookingTypeId = cmbBookingType.SelectedIndex + 1;

            dataBase.cmd = new SqlCommand("select price from bookingPrice bp  where bp.bookingType_id ='" + bookingPrice.iBookingTypeId + "'and bp.expiryDate is null", dataBase.connection);
            dataBase.connection.Open();
            dataBase.cmd.ExecuteNonQuery();
            dataBase.drr = dataBase.cmd.ExecuteReader();//--------------------
            while (dataBase.drr.Read())
            {
                bookingPrice.strOldPrice = (string)dataBase.drr["price"].ToString();
                txtOldPrice.Text = bookingPrice.strOldPrice;
                int refIOldPrice;
                int.TryParse(bookingPrice.strOldPrice, out refIOldPrice);
                bookingPrice.iOldPrice = refIOldPrice;
            }

            dataBase.connection.Close();
        }

        #endregion

        #region Modify Price Button
        private void BtnModifyPrice_Click(object sender, EventArgs e)
        {

            if (valid())
            {
                int refINewPrice;
                int.TryParse(bookingPrice.strNewPrice, out refINewPrice);
                bookingPrice.iNewPrice = refINewPrice;
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, $"Modify New Price to {bookingPrice.iNewPrice}\n", "\nAre you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //DB Commands

                    dataBase.cmd = new SqlCommand("update bookingPrice SET expiryDate='" + DateTime.Now + "' where bookingType_id = '" + bookingPrice.iBookingTypeId + "' and price = "+ bookingPrice.iOldPrice + "", dataBase.connection);
                    dataBase.connection.Open();
                    dataBase.cmd.ExecuteNonQuery();
                    dataBase.cmd = new SqlCommand("insert into bookingPrice (bookingType_id,price)values('" + bookingPrice.iBookingTypeId + "','" + bookingPrice.iNewPrice + "')", dataBase.connection);
                    dataBase.cmd.ExecuteNonQuery();
                    dataBase.connection.Close();


                    //clear
                    txtOldPrice.Clear();
                    txtNewPrice.Clear();
                    cmbBookingType.SelectedIndex = -1;
                    bookingPrice.strOldPrice = "";
                    bookingPrice.iNewPrice = bookingPrice.iBookingTypeId = -1;
                    bookingPrice.strNewPrice = "";
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPrice has been modified successfully", "\nDone", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            
        }

        #endregion

    }
}
