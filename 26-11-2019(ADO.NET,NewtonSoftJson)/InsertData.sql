using System;  
using System.Data.SqlClient;  
namespace AdoNetConsoleApplication  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            new Program().CreateTable();  
        }  
        public void CreateTable()  
        {  
            SqlConnection con = null;  
            try  
            {  
                // Creating Connection  
                con = new SqlConnection(@"data source=DESKTOP-V58GDEQ\SERVER; database=student; integrated security=SSPI"); 
				
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('101','raj','abc@gmail.com','26/11/2019')", con);  

                // Opening Connection  
                con.Open();  

                // Executing the SQL query  
                cm.ExecuteNonQuery();  

                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");  
            }  
            catch (Exception e)  
            {  
                Console.WriteLine("something went wrong."+e);  
            }  
            // Closing the connection  
            finally  
            {  
                con.Close();  
            }  
        }  
    }  
}  