using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONET_CA_
{
    class CreateDb
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "create database DB";
            //string query = "alter database DB modify name=SampleDatabase";
            //string query="Drop database SampleDatabase";
            SqlCommand cmd = new SqlCommand(query,conn);
            try
            {
                conn.Open();
                //executenonquery used for exe queries that does not return any data
                cmd.ExecuteNonQuery();
                Console.WriteLine("database created successfully");
            }
            catch(SqlException e)
            {
                Console.WriteLine("Error generated Details:"+e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
        }
    }
}