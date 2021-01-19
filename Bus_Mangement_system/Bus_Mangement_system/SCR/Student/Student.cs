using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Mangement_system.SCR.Student
{
    class Student
    {
        public Student()
        {
            iAddressID = -1;
            iBookingID = -1;
            strBookingFrom = DateTime.Now.ToShortDateString();
        }

        public int ID { get; set; }
        public int iStId { get; set; }
        public int iAddressID { get; set; }
        public int iUniversityID { get; set; }
        public int iBookingID { get; set; }
        public int iPrice { get; set; }
        public int iOldAddressID { get; set; }
        public int iOldUniversityID { get; set; }
        public int price { get; set; }


        public string strFirstName { get; set; }
        public string strLastName { get; set; }
        public string strPhone { get; set; }
        public string strAddress { get; set; }
        public string strBookingFrom { get; set; }
        public string strBookingTo { get; set; }
        public string strOldFirstName { get; set; }
        public string strOldLastName { get; set; }
        public string strOldPhone { get; set; }
        public string strOldAddress { get; set; }
        public string strUniversity { get; set; }
        public string strType { get; set; }

        public DateTime date { get; set; }
    }
}
