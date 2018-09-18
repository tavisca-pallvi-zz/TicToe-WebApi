using Cassandra;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.Models;
using Logger = TicToeWebsite.Models.Logger;

namespace TicToeWebsite.DataBaseAcces
{
    public class LogDatabase

    {
        public static void Add()
        {
            CassandraConnect obj = new CassandraConnect();
            ISession session = obj.Connect();
      
            string query = "insert into \"LoggerT\" (\"id\", \"Response\",\"Request\",\"Exception\") values(?,?,?,?)";

          
            PreparedStatement preparedStatement = session.Prepare(query);
            BoundStatement boundStatement = preparedStatement.Bind(Logger.LogId,Logger.Response, Logger.Request, Logger.Exception);
            session.Execute(boundStatement);


            

        }
    }
}
