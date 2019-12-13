using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace ADONET_CA_
{
    class TransactionsAndConcurrency
    {
        static void Main()
        {
            string cs = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
            using (SqlConnection con=new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from Accounts",con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    if(rdr["AccountNumber"].ToString()=="A1")
                    {
                        Console.WriteLine("{0},{1},{2}",rdr["AccountNumber"],rdr["CustomerName"],rdr["Balance"]);
                    }
                    else
                    {
                        Console.WriteLine("{0},{1},{2}", rdr["AccountNumber"], rdr["CustomerName"], rdr["Balance"]);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
