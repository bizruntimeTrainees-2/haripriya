using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class FileController : Controller
    {
       public FileResult Resumepdf()
        {
            return File("E:/Resume/Resume.pdf", "Application/pdf");
        }
        public FileResult Resumedoc()
        {
            return File("E:/Resume/HARIPRIYA.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
    }
}