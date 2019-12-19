using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        List<Product1> products = new List<Product1>()
        {
            new Product1 {ProductId=1,Name="Samsung Tv",Price=3400,Photo="E:/Pictures/tv.png" },
            new Product1 {ProductId=2,Name="mobile",Price=3200,Photo="E:/Pictures/mobile.png" },
        };
        public PartialViewResult ProtoType()
        {
            return PartialView();
        }
        public ActionResult Index()
        {
            return View(products);
        }
    }
}