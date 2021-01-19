using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Mangement_system.SCR.Daily_Ticket
{
    class DailyTicket
    {
        public DailyTicket()
        {
            iTotal = 0;
            strDate = DateTime.Now.ToShortDateString();
        }
       
        public int iOneWay { get; set; }
        public int iRoundTrip { get; set; }
        public int iPrice { get; set; }
        public int iTotal { get; set; }

        public string strOneWay { get; set; }
        public string strRoundTrip { get; set; }
        public string strPrice { get; set; }
        public string strDate { get; set; }


    }
}
