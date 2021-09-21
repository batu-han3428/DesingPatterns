using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SingletonPattern
{
    public class dbConnection2
    {
        private const string constr = "server=(localdb)\\MsSqlLocalDb;database=Singleton;Trusted_Connection=true;";

        private static SqlConnection _sqlcon; 

        private dbConnection2() { 
            
        }

        public static SqlConnection GetInstance()
        {
            if(_sqlcon == null)
            {
                _sqlcon = new SqlConnection(constr);
            }

            return _sqlcon;
        }
    }
}
