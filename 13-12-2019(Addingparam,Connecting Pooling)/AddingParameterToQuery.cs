using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_CA_
{
    class AddingParameterToQuery
    {
        static void Main()
        {
            SqlConnection conn= null;
            SqlDataReader reader= null;
            string inputName = "laps";
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from tblProduct ", conn);
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Name";
                parameter.Value = inputName;
                cmd.Parameters.Add(parameter);
                reader = cmd.ExecuteReader();
                Console.WriteLine("ProductId and Name:");
                while (reader.Read())
                {
                    Console.WriteLine("{0},{1}", reader["ProductId"],reader["Name"]);
                }
                Console.ReadLine();
            }
            finally
            {
                if(reader!=null)
                {
                    reader.Close();
                }
                if(reader!=null)
                {
                    conn.Close();
                }
            }

        }
    }
}