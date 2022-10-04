using MvcCourseITM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCourseITM.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Register(Register stud)
        {
            using (var db= new forgithubEntities())
            {
                var newstudent = db.Registers.Create();
                newstudent.NAME = stud.NAME;
                newstudent.SURNAME = stud.SURNAME;
                newstudent.EMAIL = stud.EMAIL;
                newstudent.PASSWORD = stud.PASSWORD;
                newstudent.GENDER = stud.GENDER;

                db.Registers.Add(newstudent);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");

            }

           

        }
       
    }
}