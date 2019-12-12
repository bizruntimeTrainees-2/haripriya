using System;
using System.Data;
using System.Data.SqlClient;

class SqlCommandDemo
{
    SqlConnection conn;
    public SqlCommandDemo()
    {
        // Instantiate the connection
        conn = new SqlConnection("Data Source=DESKTOP-V58GDEQ\\SERVER;Initial Catalog=ADONET;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
    // call methods that demo SqlCommand capabilities
    static void Main()
    {
        SqlCommandDemo scd = new SqlCommandDemo();

        Console.WriteLine();
        Console.WriteLine(" Before Insert");
        Console.WriteLine("------------------------");

        // use ExecuteReader method
        scd.ReadData();

        // use ExecuteNonQuery method for Insert
        scd.Insertdata();
        Console.WriteLine();
        Console.WriteLine("Categories After Insert");
        Console.WriteLine("------------------------------");

        scd.ReadData();

        // use ExecuteNonQuery method for Update
        scd.UpdateData();

        Console.WriteLine();
        Console.WriteLine("Categories After Update");
        Console.WriteLine("------------------------------");

        scd.ReadData();

        // use ExecuteNonQuery method for Delete
        scd.DeleteData();

        Console.WriteLine();
        Console.WriteLine("Categories After Delete");
        Console.WriteLine("------------------------------");

        scd.ReadData();

        // use ExecuteScalar method
        int numberOfRecords = scd.GetNumberOfRecords();

        Console.WriteLine();
        Console.WriteLine("Number of Records: {0}", numberOfRecords);

        Console.ReadLine();
    }

    public void ReadData()
    {
        SqlDataReader rdr = null;

        try
        {
            // Open the connection
            conn.Open();

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand("select * from tblProduct", conn);

            // 2. Call Execute reader to get query results
            rdr = cmd.ExecuteReader();

            // print the CategoryName of each record
            Console.WriteLine("ProductId\tName\tunitPrice\tQtyAvailable");
            while (rdr.Read())
            {
                Console.Write(rdr[0]);
                Console.Write("\t\t"+rdr[1]);
                Console.Write("\t\t"+rdr[2]);
                Console.Write("\t\t"+rdr[3]);
                Console.WriteLine();
            }
        }
        finally
        {
            // close the reader
            if (rdr != null)
            {
                rdr.Close();
            }

            // Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
       
    }

    public void Insertdata()
    {
        try
        {
            // Open the connection
            conn.Open();
            // prepare command string
            string insertString = @"
                 insert into tblProduct
                 (ProductId,Name,UnitPrice,QtyAvailable)
                 values (1,'minilaptop',1200,45)";

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(insertString,conn);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();
        }
        finally
        {
            // Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }

    public void UpdateData()
    {
        try
        {
            // Open the connection
            conn.Open();

            // prepare command string
            string updateString = @"
                update tblProduct
                set Name = 'laps'
                where UnitPrice=2340";

            // 1. Instantiate a new command with command text only
            SqlCommand cmd = new SqlCommand(updateString);

            // 2. Set the Connection property
            cmd.Connection = conn;

            // 3. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();
        }
        finally
        {
            // Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }

    /// <summary>
    /// use ExecuteNonQuery method for Delete
    /// </summary>
    public void DeleteData()
    {
        try
        {
            // Open the connection
            conn.Open();

            // prepare command string
            string deleteString = @"
                 delete from tblProduct 
                 where Name = 'Servers'";

            // 1. Instantiate a new command
            SqlCommand cmd = new SqlCommand();

            // 2. Set the CommandText property
            cmd.CommandText = deleteString;

            // 3. Set the Connection property
            cmd.Connection = conn;

            // 4. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();
        }
        finally
        {
            // Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }

    public int GetNumberOfRecords()
    {
        int count = -1;

        try
        {
            // Open the connection
            conn.Open();

            // 1. Instantiate a new command
            SqlCommand cmd = new SqlCommand("select count(*) from tblProduct", conn);

            // 2. Call ExecuteScalar to send command
            count = (int)cmd.ExecuteScalar();
        }
        finally
        {
            // Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
        return count;
    }
}