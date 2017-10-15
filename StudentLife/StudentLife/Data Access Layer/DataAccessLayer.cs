using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Data_Access_Layer
{
    class DataAccessLayer
    {
        static void Test()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=localhost; Database=StudentLife; Integrated Security=true"))
                {
                    conn.Open();

                    //SqlCommand cmd = new SqlCommand("SELECT * FROM Organization;", conn);
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    Console.WriteLine(reader.GetString(0));
                    //}
                    //Console.ReadLine();
                    //conn.Close()

                    SqlCommand cmd = new SqlCommand("usp_GetAllOrganizations", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@name", "Helsingkrona"));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(4) + reader.GetString(1) + reader.GetString(2) + reader.GetString(3) + reader.GetString(4) + reader.GetString(5));
                    }
                    Console.ReadLine();
                }
            }
            catch(Exception exception)
            {
                //TO DO: Stuff to be handled
                //Perhaps throw custom exceptions, then handle them with an error handler at top level?
            }
        }
    }
}
