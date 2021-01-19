using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Mangement_system.SCR.Modify_Price
{
    class BookingPrice
    {
        public BookingPrice()
        {

        }

       
        public int iBookingTypeId { get; set; }
        public int iNewPrice { get; set; }
        public int iOldPrice { get; set; }

        public string strNewPrice { get; set; }
        public string strOldPrice { get; set; }

    }
}
