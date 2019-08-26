using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace change.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "首页";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(Models.BlogModel bModel)
        {
            if (ModelState.IsValid)
            {
                var fileName = bModel.BlogPhoto.FileName;
                var filePath = Server.MapPath(string.Format("~/{0}", "File"));
                bModel.BlogPhoto.SaveAs(Path.Combine(filePath, fileName));
                ModelState.Clear();
            }
            return View();
        }

    }
}