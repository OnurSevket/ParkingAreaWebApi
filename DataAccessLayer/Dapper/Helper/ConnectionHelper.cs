using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dapper.Helper
{
    public class ConnectionHelper
    {
        //Test Push
        public static SqlConnection SqlServerConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["OnlineStoreContext"].ConnectionString);
        }


    }
}
