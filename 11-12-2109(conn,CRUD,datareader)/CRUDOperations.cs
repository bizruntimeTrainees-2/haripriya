using System;
using System.Data.SqlClient;

class CRUDOperations
{
    static void Main(string[] args)
    {
        string conn = ("Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        using (SqlConnection con = new SqlConnection(conn))
        {
            SqlCommand cmd = new SqlCommand("select * from tblProduct");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "delete from tblProduct where UnitPrice= 1200";
            int Exquery = cmd.ExecuteNonQuery();
            Console.WriteLine("Total rows deleted: " + Exquery);



            cmd.CommandText = "insert into tblProduct values(3,'servers',5000,1200),(4,'desktops',6000,00)";
            Exquery = cmd.ExecuteNonQuery();
            Console.WriteLine("Total rows Inserted: " + Exquery);

            cmd.CommandText = "update tblProduct Set  QtyAvailable=25 where ProductId =1";
            Exquery = cmd.ExecuteNonQuery();
            Console.WriteLine("Total rows updated: " + Exquery);

            Console.WriteLine("query executed successfully!");
        }
    }
}
        
    
     