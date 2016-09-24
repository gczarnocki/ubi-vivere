using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonServer.Migrations;
using HackathonServer.Models;

namespace HackathonServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            using (var context = new HackathonContext())
            {
                DatabaseInitializer.EducationFacilitiesSeed(context);
            }

            return View();
        }
    }
}
