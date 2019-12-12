using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace ADONET_CA_
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString;
            //grab the connection string from app.Config
            connString = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
            //create sql Connection obj
            //pass in the conn string into the constructor
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            Console.WriteLine("Connection to database is succ ");
            sqlConnection.Close();
        }
    }
}
