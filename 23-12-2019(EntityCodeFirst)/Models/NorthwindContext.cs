using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//provides DBcontext,database,DBset

namespace EntityCodeFirst.Models
{
    //accessing Dbcontext,passing name of connection string,which we want to connect
    public class NorthwindContext:DbContext
    {
        public NorthwindContext()
            :base("name=NorthwindConnection")
        {

        }
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductTable { get; set; }
    }
}
//when we created NorthwindContext of this,that is responsible for communicate
//with Connection string