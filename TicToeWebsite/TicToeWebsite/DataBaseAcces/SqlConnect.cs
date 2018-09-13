using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TicToeWebsite.DataBaseAcces
{
    public class SqlConnect
    {
        SqlConnection connectionobject = new SqlConnection();
        public SqlConnection Connect()
        {
            connectionobject.ConnectionString = "Data Source=TAVDESK004;Initial Catalog=UserDataBase;User ID=Sa;Password=test123!@#";
            connectionobject.Open();
            return connectionobject;
        }

    }
}
