using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TicToeWebsite;
using TicToeWebsite.DataBaseAcces;
using TicToeWebsite.Models;

namespace TicToeWbsite.DataBaseAcces
{
    public class SqlRepository
    {
        
        public int Search(User user)
        {
            string Email = user.Email;
            string no = "";
            SqlConnection connectionobject = new SqlConnection();
            connectionobject.ConnectionString = "data source=tavdesk004;initial catalog=UserDataBase;user id=sa;password=test123!@#";

            using (var cmd = connectionobject.CreateCommand())
            {
                connectionobject.Open();
                cmd.CommandText = "SELECT count(*) FROM Users WHERE Email = @Email";


                cmd.Parameters.AddWithValue("@Email", Email);
                no = cmd.ExecuteScalar().ToString();

            }
            if (no == "0")
            {
                return 0;

            }

            return 1;

        }
        public void Add(User user)
        {
            SqlConnect connect = new SqlConnect();
            SqlConnection connectionobject = connect.Connect();
           
            string query = "insert into Users values(@firstname,@lastname,@email,@accesstoken)";
            SqlCommand cmd = new SqlCommand(query, connectionobject);

            cmd.Parameters.Add(new SqlParameter("@firstname", user.FirstName));
            cmd.Parameters.Add(new SqlParameter("@lastname", user.LastName));
            cmd.Parameters.Add(new SqlParameter("@email", user.Email));
            cmd.Parameters.Add(new SqlParameter("@accesstoken", user.AccessToken));
            cmd.ExecuteNonQuery();
            connectionobject.Close();


        }
        public string GetById(int Id)
        {
            string apiKey = "";
            string AccessToken =
       "SELECT AccessToken from  Users where Id=@Id";
            using (SqlConnection connectionobject =
                       new SqlConnection())
            {
                connectionobject.ConnectionString = "Data Source=TAVDESK004;Initial Catalog=UserDataBase;User ID=sa;Password=test123!@#";
                connectionobject.Open();
                SqlCommand command =
                    new SqlCommand(AccessToken, connectionobject);

                command.Parameters.AddWithValue("@Id", Id);
                apiKey = command.ExecuteScalar().ToString();

            }
            return apiKey;

        }

        //Int32.Parse((reader["Id"].ToString())));
        //            Console.WriteLine(reader["FirstName"].ToString());
        //            Console.WriteLine(reader["LastName"].ToString());
        //            Console.WriteLine(reader["Email"].ToString());
        //            Console.WriteLine(reader["AccessToken"].ToString());
            
           public int AuthenticateUser(string AccessToken)
            {
           
                string no = "";
                SqlConnection connectionobject = new SqlConnection();
                connectionobject.ConnectionString = "data source=tavdesk004;initial catalog=UserDataBase;user id=sa;password=test123!@#";

                using (var cmd = connectionobject.CreateCommand())
                {
                    connectionobject.Open();
                    cmd.CommandText = "SELECT count(*) FROM Users WHERE AccessToken= @AccessToken";


                    cmd.Parameters.AddWithValue("@AccessToken", AccessToken);
                    no = cmd.ExecuteScalar().ToString();

                }
                if (no == "0")
                {
                    return 0;

                }
                return 1;

            }

        }
    }






