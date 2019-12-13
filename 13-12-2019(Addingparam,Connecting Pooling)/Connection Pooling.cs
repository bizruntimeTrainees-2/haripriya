using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/* instead of creating new connections,reuse existing ado.net connections */
namespace ADONET_CA_
{
    class Connection_Pooling
    {
        static void Main()
        {
            string sqlConnectString = "Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            for (int i = 0; i < 100; i++)
            {
                SqlConnection connection = new SqlConnection(sqlConnectString);
                //setting the connection string with pooling option
                connection.Open();
                Thread.Sleep(100);
                Console.WriteLine("Connection opended:"+i);
                connection.Close();
            }
        }
    }
}
//Before connection obj it will check:1)socket,2)Hand shake,3)connection string parsed,4)auth,5)database
