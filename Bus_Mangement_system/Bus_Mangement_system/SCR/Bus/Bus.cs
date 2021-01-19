using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Mangement_system.SCR.Bus
{
    class Bus
    {

        public Bus()
        {
            iCapacityIndex = iBusindex = -1;
            iCapacity = 0;
        }
        public int iCapacityIndex { get; set; }
        public int iBusindex { get; set; }
        public int iBusID { get; set; }
        public int iCapacity { get; set; }

        public string strID { get; set; }
        public string strName { get; set; }
        public string strLicenseNumber { get; set; }
        public string strCapacity { get; set; }
        public string oldName { get; set; }
        public string oldLicenseNumber { get; set; }
        public string oldStrCapacity { get; set; }



    }
}
