using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class SuggestionController : Controller
    {
        // GET: Suggestion
        public ActionResult Suggestion(String searchInput)
        {
            if (searchInput == null)
            {
                return new EmptyResult();
            }

            if (searchInput.Contains("ski"))
            {
                return RedirectToAction("Index", "NextSuggestion");
            }

            return View();
        }
    }
}