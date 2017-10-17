using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient; //Provides data access specifically for Microsoft SQL Server.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Data_Access_Layer
{
    static class DataAccessLayer
    {

        public static Model.Organization GetOrganizationByName(string organizationName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Persist Security Info=false; Server=localhost; Database=StudentLife; Integrated Security=true"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_GetOrganizationByName", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@name", organizationName));
                    SqlDataReader reader = cmd.ExecuteReader();

                    Model.Organization org = new Model.Organization();

                    while (reader.Read())
                    {
                        org.Name = reader.GetString(0);
                        org.Adress = reader.GetString(1);
                        org.PhoneNumber = reader.GetString(2);
                        org.Email = reader.GetString(3);
                        org.Website = reader.GetString(4);
                        org.OrgDescription = reader.GetString(5);
                    }

                    return org;
                }
            }
            catch(Exception exception)
            {
                return null;
            }
        }

        static void Test()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Persist Security Info=false; Server=localhost; Database=StudentLife; Integrated Security=true"))
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
                    //hej hej
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
