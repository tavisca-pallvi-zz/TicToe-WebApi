using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cassandra;
namespace TicToeWebsite.DataBaseAcces
{
    public class CassandraConnect
    {
        public ISession  Connect()
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            ISession session = cluster.Connect("UserDataBase");
            return session;
        }
    }
}
