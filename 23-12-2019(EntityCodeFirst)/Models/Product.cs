using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityCodeFirst.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        //primary key that define in category,that is used in F.K in product
        public Category Category { get; set; }
    }
}