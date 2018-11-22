using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "GET OUT!";

            return View();
        }

        public JsonResult GetSearchValue(string search)
        {
            List<String> places = new List<string>(new String[] { "windsor", "milton", "mississauga", "toronto", "thornhill", "oakville", "vaughn" });
            IEnumerable<String> p = places.Where(x => x.StartsWith(search) || search == null).ToList();
            List<PlaceModel> allsearch = p.Select(x => new PlaceModel
            {
                Name = x
            }).ToList();
            return Json(allsearch, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}