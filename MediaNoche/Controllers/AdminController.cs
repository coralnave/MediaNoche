using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediaNoche.DAL;
using MediaNoche.Models;

namespace MediaNoche.Controllers
{
    [Authorize(Roles = "Admins")]
    public class AdminController : Controller
    {
        private MediaNocheContext db = new MediaNocheContext();

        public AdminController()
        {
            
        }
        //
        // GET: /Admin/
        public ActionResult Index()
        {
            return Content("Hello Admin") ;
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }


	}
}