using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controller
{
    public sealed class ADODBConnection
    {
        private static volatile SqlConnection instance;
        private ADODBConnection()
        {

        }
        public static SqlConnection Connection()
        {
            if (instance == null)
            {
                instance = new SqlConnection("Data Source=desktop-v72h0i5;Initial Catalog=dbcontrolemensagem;User ID=sa;Password=2015@c3f3t");
            }
            return instance;
        }

    }
}
