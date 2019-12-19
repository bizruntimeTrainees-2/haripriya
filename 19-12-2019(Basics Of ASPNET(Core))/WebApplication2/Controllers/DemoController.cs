using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DemoController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product{ProductId=1,Name="Samsung Tv",Price=30000},
            new Product{ProductId=2,Name="Nike Shoe",Price=5000}
        };

        public JsonResult ProductsData()
        {
            return Json(products,JsonRequestBehavior.AllowGet);
        }
    }
}
/* Json Result:
 It represents a base class that returns JSON formatted content to response
 JsonRequestBehavior-It specifies http request allowed or not,in order to serialize JSON data to responce
 */
