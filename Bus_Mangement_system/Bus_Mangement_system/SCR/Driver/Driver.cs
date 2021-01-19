using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Mangement_system.SCR.Driver
{
    class Driver
    {
        public Driver()
        {
            date = DateTime.Now;

            iYear = date.Year;
            iMonth = date.Month;
            iSalary = 0;
            iDriverIndex = -1;
            iTakenSalary = 0;
            iRestOfSalary = 0;
            iBasicSalary = 0;
            iTotal = 0;


        }

        public int iDriverId { get; set; }
        public int iSalary { get; set; }
        public int iDriverIndex { get; set; }
        public int iTakenSalary { get; set; }
        public int iRestOfSalary { get; set; }
        public int iBasicSalary { get; set; }
        public int iTotal { get; set; }
        public int iYear { get; set; }
        public int iMonth { get; set; }

        public string strName { get; set; }
        public string strPhone { get; set; }
        public string strAddress { get; set; }
        public string strSalary { get; set; }
        public string strID { get; set; }
        public string strOldName { get; set; }
        public string strOldPhone { get; set; }
        public string strOldAddress { get; set; }
        public string strOldSalary { get; set; }
        public string strBasic { get; set; }
        public string strTaken { get; set; }

        public DateTime date { get; set; }

    }
}
