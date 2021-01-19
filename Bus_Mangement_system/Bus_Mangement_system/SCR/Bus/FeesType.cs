using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Mangement_system.SCR.Bus
{
    class FeesType
    {
        public FeesType()
        {
            iYear = DateTime.Now.Year;
            iMonth = DateTime.Now.Month;
            iDay = DateTime.Now.Day;
            iChangeOil = 0;
            iOther = 0;
            iLicenseRenewal = 0;
            iBusWash = 0;
            iPeriodicMaintenance = 0;
            iSolar = 0;
            iTotal = 0;
        }

        public int iFeesTypeID { get; set; }
        public int iChangeOil { get; set; }
        public int iOther { get; set; }
        public int iLicenseRenewal { get; set; }
        public int iBusWash { get; set; }
        public int iPeriodicMaintenance { get; set; }
        public int iSolar { get; set; }
        public int iTotal { get; set; }
        public int iYear { get; set; }
        public int iMonth { get; set; }
        public int iDay { get; set; }

        public string strChangeOil { get; set; }
        public string strOther { get; set; }
        public string strLicenseRenewal { get; set; }
        public string strBusWash { get; set; }
        public string strPeriodicMaintenance { get; set; }
        public string strSolar { get; set; }
        public string strMoney { get; set; }


    }
}
