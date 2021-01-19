using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Mangement_system.SCR
{
    class DataBase
    {
        public DataBase ()
        {
            conString = Program.GetConnectionStringByName();
            connection = new SqlConnection(conString);
        }
       
        public string conString { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataAdapter da { get; set; }
        public DataSet ds { get; set; }
        public DataRow dr { get; set; }
        public SqlDataReader drr { get; set; }
        public DataTable dt { get; set; }
        public SqlConnection connection { get; set; }




    }
}
