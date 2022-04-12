using MVCvaja.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCvaja.Controllers
{
    public class StudentOceneController : Controller
    {
        // GET: StudentOcene
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VseOcene()
        {
            var x = from m in select m;
            return View();
        }
    }
}