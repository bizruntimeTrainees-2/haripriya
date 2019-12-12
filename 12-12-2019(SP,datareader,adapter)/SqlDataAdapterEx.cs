
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace ADONET_CA_
{
    class SqlDataAdapterEx
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string querystring="select * from tblProduct";
            SqlDataAdapter adapter= new SqlDataAdapter(querystring, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"tblProduct");
            Console.WriteLine(ds.GetXml());
            Console.ReadLine();
        }
    }
}