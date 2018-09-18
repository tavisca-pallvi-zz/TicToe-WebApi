using System;
using Cassandra;
using static System.Collections.Specialized.BitVector32;
using System.Linq;

namespace Instaclustr.Cassandra.ConnectionSample
    {
        class MainClass
        {
        static void Main(string[] args)
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            //ISession session = cluster.Connect("UserDataBase");
            //session.Execute("insert into UserPlayer (FirstName, LastName, Email,Id,AccessToken) values ('Anushka', 'Goel', 'pgoel@example.com',1,'')");
            ////Row result = session.Execute("select * from UserPlayer where LastName='Goel'").First();
            //RowSet result = session.Execute("select * from UserPlayer");

            //var rows = result.GetRows();

            //if (rows.Count() != 1)
            //    throw new Exception("Result count is incorrect");

            //foreach (var row in rows)
            //{
            //    return CreateObjectFromRow(result.Columns,row);
            //}

            //var rows = result.GetRows();

            //if (rows.Count() != 1)
            //    throw new Exception("Result count is incorrect");

            //foreach (var row in rows)
            //{
            //    return CreateObjectFromRow(rowSet.Columns, row);
            //}

            //foreach (var row in result)
            //{
            //    var value = row.GetValue<string>("FirstName");
            //    Console.WriteLine(value);
            //    // Do something with the value
            //}
        
      //  Console.WriteLine("{0} {1}", result["FirstName"], result["LasName"]);


                Console.ReadLine();



        }




            //public static void Main(string[] args)
            //{
            //    Console.WriteLine("Hello Cassandra!");

            //    var cluster = Cluster.Builder()
            //                         .AddContactPoints(< PUBLIC IP1 >, < PUBLIC IP2 >, < PUBLIC IP3 >,..)
            //                         .WithPort(9042)
            //                         .WithLoadBalancingPolicy(new DCAwareRoundRobinPolicy("AWS_VPC_AP_SOUTHEAST_2"))
            //                         .WithAuthProvider(new PlainTextAuthProvider(< Username >, < Password >))
            //                         .Build();

            //    // Connect to the nodes using a keyspace
            //    var session = cluster.Connect("system_distributed");

            //    // Get name of a Cluster
            //    Console.WriteLine("The cluster's name is: " + cluster.Metadata.ClusterName);

            //    // Execute a query on a connection synchronously
            //    var rs = session.Execute("SELECT * FROM repair_history");

            //    // Iterate through the RowSet
            //    foreach (var row in rs)
            //    {
            //        var value = row.GetValue<string>("keyspace_name");
            //        Console.WriteLine(value);
            //        // Do something with the value
            //    }
            //}
        }
    
}
