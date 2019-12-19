using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

/*
1)user interacts with view
2)view alerts controller of particular event
3)controller updates model.
4)model alerts view that it has changed.
5)view grabs model data and updates itself.
*/
