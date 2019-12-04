using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebScrapingSite.Models;

namespace WebScrapingSite.Controllers
{
    public class HomeController : Controller
    {
        SampleData _data;
        public HomeController()
        {
            SampleData data = new SampleData();
            _data = data;
        }
        public ActionResult Index()
        {
            return View(_data);
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

        public ActionResult ViewDetail(int id)
        {
            SampleData SD = new SampleData();
            var model = SD.People.Where(x => x.ID == id).FirstOrDefault();
            return View(model);
        }

        public ActionResult PostSuccess()
        {
            var FD = Request.Form;
            ViewBag.Name = FD.GetValues("UserName").First();
            ViewBag.Gender = FD.GetValues("Gender").First();
            return View();
        }
    }
}