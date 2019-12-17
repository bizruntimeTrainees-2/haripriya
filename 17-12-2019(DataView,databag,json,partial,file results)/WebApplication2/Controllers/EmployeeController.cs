using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name ="John",
                Gender="Male",
                City="London"
            };
            return View(employee);
        }
    }
}
//the controller responds to url request,gets data from model
//and hands it over to the view.the view then renders the data


//Controller responds to URL Request,
