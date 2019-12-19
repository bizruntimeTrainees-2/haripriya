using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ViewResult Index()
        {
            return View();
        }
        public PartialViewResult Login()
        {
            return PartialView();
        }
    }
}