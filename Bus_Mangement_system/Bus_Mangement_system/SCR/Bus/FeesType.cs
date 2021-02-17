using Guna.UI.WinForms;
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
            iTotal = 0;
        }

        public List<int> iPrice = new List<int>();
        public List<string> strName = new List<string>();
        public List<GunaButton> GunaButton = new List<GunaButton>();

        public int iFeesTypeID { get; set; }
        public int iTotal { get; set; }
        public int iYear { get; set; }
        public int iMonth { get; set; }
        public int iDay { get; set; }

        public string strMoney { get; set; }


    }
}
