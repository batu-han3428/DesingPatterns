using System;
using System.Data.SqlClient;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Bir nesnenin bir kez instance alınıp defalarca farklı konumlarda kullanılmasını sağlarız 
            */

            var nesne = singleton1.Sinif;
            SqlConnection sqlcon = dbConnection.GetInstance();


        }
    }
}
