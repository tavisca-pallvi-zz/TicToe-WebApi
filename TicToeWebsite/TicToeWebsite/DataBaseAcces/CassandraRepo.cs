using Cassandra;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite.Models;
using static System.Collections.Specialized.BitVector32;
using ISession = Cassandra.ISession;

namespace TicToeWebsite.DataBaseAcces
{
    public class CassandraRepo
    {
        public int Search(User user)
        {
            CassandraConnect obj = new CassandraConnect();
            ISession session = obj.Connect();
           
            string Email = user.Email;
            string no = "";
            string query = "SELECT count(*) FROM UserPlayer WHERE Email =? ALLOW FILTERING";
            PreparedStatement preparedStatement = session.Prepare(query);
            BoundStatement boundStatement = preparedStatement.Bind(Email);
            Row row = session.Execute(boundStatement).First();
             int v=int.Parse(row["count"].ToString());
            return v;
        }

        public void Add(User user)
        {
            bool created = false;
            int value = 0;
            PreparedStatement preparedStatement;
            BoundStatement boundStatement;
            CassandraConnect obj = new CassandraConnect();
            ISession session = obj.Connect();
            string token = Guid.NewGuid().ToString();
            user.AccessToken = token;
            
            string search = "SELECT MAX(Id) FROM UserPlayer";
            var res = session.Execute(search);
            foreach (var row in res)
            {
                value = row.GetValue<int>("system.max(id)");

            }
            user.Id = value+1;
            string query = "insert into UserPlayer (FirstName, LastName, Email,Id,AccessToken) values (?,?,?,?,?)";
            preparedStatement = session.Prepare(query);
             boundStatement = preparedStatement.Bind(user.FirstName, user.LastName, user.Email, user.Id, user.AccessToken);
            session.Execute(boundStatement);
            
        }
        public string GetById(int id)
        {
            CassandraConnect obj = new CassandraConnect();
            ISession session = obj.Connect();
            
            string apikey = "";
        
            string query = "select AccessToken from  UserPlayer where id=?";
            PreparedStatement preparedStatement = session.Prepare(query);
            BoundStatement boundStatement = preparedStatement.Bind(id);
           
            var res = session.Execute(boundStatement);
            foreach (var row in res)
            {
                apikey = row.GetValue<string>("accesstoken");

            }


            return apikey;
        }

    }
}
