using Microsoft.Data.SqlClient;
using System.Data;

namespace Testing2.DBContext
{
   public class DBContext
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionstring;
        public DBContext(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionstring = configuration.GetConnectionString("ConnectionSql");
        }

        public IDbConnection createconnectionstring() => new SqlConnection("connectionstring");
    }
}
