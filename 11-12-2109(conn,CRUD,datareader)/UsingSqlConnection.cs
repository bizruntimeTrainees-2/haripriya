using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


class SqlConnectionDemo
{
    static void Main()
    {
        //Instantiate the connection
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataReader rdr = null;
        try
        {
            conn.Open();
            //passing connection to command object
            SqlCommand cmd = new SqlCommand("select * from tblProduct",conn);
            rdr = cmd.ExecuteReader();
            Console.WriteLine("ProductId  Name  unitPrice  QtyAvailable");
            while (rdr.Read())
            {
                Console.Write(rdr[0]);
                Console.Write("        "+rdr[1]);
                Console.Write("    "+rdr[2]);
                Console.Write("    "+rdr[3]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        finally
        {
            //close the reader
            if (rdr != null)
            {
                rdr.Close();
            }
            //close the connection
            if (conn !=null)
            {
                conn.Close();
            }
        }

    }
}