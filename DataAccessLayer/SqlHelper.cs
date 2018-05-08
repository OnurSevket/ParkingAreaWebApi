using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class SqlHelper
    {
        //SVN Commit GİTHUB isThisTrue
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);

        public static class ConnectionString
        {
            public static string Connection = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString;
        }

        public static class AppSettings
        {
            public static string appSettingVal = System.Configuration.ConfigurationManager.AppSettings["DebugOutlineActive"];
        }

    }
}
