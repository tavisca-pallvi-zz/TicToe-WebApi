using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.Models;

namespace TicToeWebsite.DataBaseAcces
{
    public class LogDatabase
    {
        private static LogDatabase inst = null;
        public void Add()
        {
            SqlConnect connOb = new SqlConnect();
            SqlConnection connection = connOb.Connect();

            string query = "insert into Users values(@response,@request,@exception)";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.Add(new SqlParameter("@response", Logger.Response));
            cmd.Parameters.Add(new SqlParameter("@request", Logger.Request));
            cmd.Parameters.Add(new SqlParameter("@exception", Logger.Exception));

            cmd.ExecuteNonQuery();
            connection.Close();


        }
    }
}
