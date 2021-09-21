using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SingletonPattern
{
    public class dbConnection
    {
        private const string constr = "server=(localdb)\\MsSqlLocalDb;database=Singleton;Trusted_Connection=true;";

        private static SqlConnection _sqlcon = new SqlConnection(constr);

        private dbConnection() { 
        
        }

        public static SqlConnection GetInstance()
        {
            return _sqlcon;
        }
    }
}
