using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje
{
    class DataBase
    {
       
            public static SqlConnection GetConnection()
            {
                string connectionString = @"Data Source=ALFA\\SQLEXPRESS;Initial Catalog=Sirket;Integrated Security=True";
                return new SqlConnection(connectionString);
            }
        
    }
}
