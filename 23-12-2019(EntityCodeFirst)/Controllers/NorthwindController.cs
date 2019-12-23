using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityCodeFirst.Models;//through that we are going to access models

namespace EntityCodeFirst.Controllers
{
    public class NorthwindController : Controller
    {
        NorthwindContext db = new NorthwindContext();
        //db is responsible for comm with DB connection string(NorthwindContext)
        public ActionResult Index()
        {
            db.CategoriesTable.ToList();
            //return list of categories
            db.ProductTable.ToList();
            return View();
        }
    }
}
//Index action communicate with db and inter act with CategoriesTable,ProductTable