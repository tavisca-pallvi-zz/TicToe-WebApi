using System;

namespace DataAccessLayer
{
    public class Class1
    {
        public class SqlRepository : IRepository
        {

            public void Add(User user)
            {


                FileRepository.Instance.Add("Here in SqlRepository" + "Add function is called" + "To add product in SQL DataBase");

                Console.WriteLine("IN ADDD DATATBASE");
                IProduct prod = null;

                SqlConnection connectionobject = new SqlConnection();
                connectionobject.ConnectionString = "Data Source=TAVDESK004;Initial Catalog=Product;User ID=Sa;Password=test123!@#";
                //connectionobject.ConnectionString = "Data Source=TAVDESK004;Initial Catalog=Product;Integrated Security=True";
                connectionobject.Open();
                FileRepository.Instance.Add("Connection opened ");

                string typeProduct = product.GetTypeOf();
                FileRepository.Instance.Add("Insert function is called");
                string query = "insert into " + typeProduct + " values(@name,@id,@fare,@isbooked)";
                SqlCommand cmd = new SqlCommand(query, connectionobject);
                cmd.Parameters.Add(new SqlParameter("@name", product.itemName));

                cmd.Parameters.Add(new SqlParameter("@fare", fare));

                cmd.Parameters.Add(new SqlParameter("@isbooked", product.isBooked));
                cmd.Parameters.Add(new SqlParameter("@id", product.itemId));

                cmd.ExecuteNonQuery();
                connectionobject.Close();
            }
            public void Get(IProduct product)
            {
                IProduct RefProduct = null;
                string typeProduct = product.GetTypeOf();
                string queryString =
           "SELECT * from " + typeProduct;
                using (SqlConnection connectionobject =
                           new SqlConnection())
                {
                    connectionobject.ConnectionString = "Data Source=TAVDESK004;Initial Catalog=Product;User ID=Sa;Password=test123!@#";

                    connectionobject.Open();

                    SqlCommand command =
                        new SqlCommand(queryString, connectionobject);


                    SqlDataReader reader = command.ExecuteReader();

                    // Call Read before accessing data.
                    while (reader.Read())
                    {
                        Console.WriteLine((reader["ItemID"].ToString()));
                        Console.WriteLine(reader["ItemName"].ToString());
                        Console.WriteLine(Double.Parse(reader["Fare"].ToString()));
                        Console.WriteLine(Int32.Parse(reader["IsBooked"].ToString()));

                    }

                    // Call Close when done reading.
                    reader.Close();
                    connectionobject.Close();
                }


            }
        }

    }

