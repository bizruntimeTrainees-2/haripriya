using System;
using System.Data.SqlClient;

class CreateSP1
{
    static void Main(string[] args)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        string query =
          @"
          CREATE PROCEDURE Retrieve_Record_Proc
          (
          @Name VARCHAR(50)
          )
          AS
          SELECT * FROM Products where Name=@Name
          ";
        SqlCommand cmd = new SqlCommand(query, con);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Store Procedure Created Successfully");
        }
        catch (SqlException e)
        {
            Console.WriteLine("Error Generated. Details: " + e.ToString());
        }
        finally
        {
            con.Close();
            Console.ReadKey();
        }
    }
}