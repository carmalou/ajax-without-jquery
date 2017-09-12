using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWordTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RespondToAjax()
        {
            return Json("Hello World!", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PostFromAjax(TestModel postParams)
        {
            // do something with data, probably create db record
            return Json("Success!");
        }

        public class TestModel
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string FavoriteColor { get; set; }
        }
    }
}