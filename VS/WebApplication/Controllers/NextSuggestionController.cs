using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class NextSuggestionController : Controller
    {
        // GET: NextSuggestion
        public ActionResult Index(String searchInpu)
        {
            return View();
        }
    }
}