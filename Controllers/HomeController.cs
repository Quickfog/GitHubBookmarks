using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GitHubBookmarks.Models;

namespace GitHubBookmarks.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Store(Repository data)
        {
            Session[data.Name] = data;
            return Json(data: "success");
        }
    }
}
