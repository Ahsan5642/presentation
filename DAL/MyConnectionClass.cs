using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class MyConnection  
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        public static SqlConnection Connection = new SqlConnection(ConnectionString);

        public static string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
