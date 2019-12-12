using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_CA_
{
    class SQLDATAREADERex
    {
        static void Main()
        {
            SQLDATAREADERex sqr = new SQLDATAREADERex();
            sqr.SimpleRead();
        }
        public void SimpleRead()
        {
            SqlDataReader rdr = null;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("select * from tblProduct",conn);
            try
            {
                conn.Open();
                rdr = cmd.ExecuteReader();
                Console.WriteLine("ProductId              Name");
                Console.WriteLine("------                -------");
                while(rdr.Read())
                {
                    int ProductId = (int)rdr["ProductId"];
                    string Name = (string)rdr["Name"];
                    Console.Write("{0,-25}", ProductId);
                    Console.Write("{0,-25}", Name);
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
