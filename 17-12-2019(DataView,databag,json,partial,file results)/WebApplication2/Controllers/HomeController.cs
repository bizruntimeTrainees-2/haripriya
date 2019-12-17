using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        //Index() Function
        public string Index2(string id)
        {
            return "Id="+id;
        }
        public string Index1(string id,string name)
        {
            return "Id=" + id + "Name="+Request.QueryString["name"];
        }
        public string GetDetails()
        {
            return "Getdetails invoked";
        }
        public ViewResult Index()
        {
            ViewData["countries"]=new List<string>()
            //ViewBag.Countries=new List<string>()
            {
                "India",
                 "UK"
            };
            return View();
        }
    }
}