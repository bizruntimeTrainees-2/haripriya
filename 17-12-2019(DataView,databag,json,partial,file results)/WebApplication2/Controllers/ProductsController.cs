using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ProductsController:Controller
    {
        public ViewResult Index()
        {
            ViewBag.name = "David";
            ViewBag.categories = new List<string>()
            {
                "Electronics",
                "shoes"
            };
            ViewData.Add("nameData","john");
            //ViewData["name"]="John";
            ViewData["Products"] = new List<string>()
            {
                "Samsung Tv",
                "Nike Casuals"
            };
            string name = "ABC";
            return View();
        }
    }
}
//pass the controller to view are:
//1.ViewData,2.ViewBag,3.TempData,4.Session
//communicate with model and retrive data from model pass that data to view




//1)we specify the controller because to perform actions for
//what ever request receiving from http request 
//2)Action Method,Non Action method
//3)request process by action methods
//4)Action Methods:Controller methods that respond to 
//various http verbs like get,post,put,delete

//1.Controller action method must be public in access.
//2.can't static() 
//3.must return a value
//4.it must be defined with a return value,it can't be void
//5.it can be overload,it can't override
//it can't be any method of controller base class
//it can't be marked with "NonAction" attribute
//[NonAction]
//Controller is responsible for request by communicating with 
//a)model b)View
//MVC handle can identify a controller class
