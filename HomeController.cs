using Lab_Exam_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_Exam_2.Controllers
{
    public class HomeController : Controller
    {

        // GET: /Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // POST: /Home/Calculate
        [HttpPost]
        public ActionResult Calculate(double speed)
        {
            double speedKmPerHour = speed * 3.6; // Convert meter/second to kilometer/hour

            ViewBag.SpeedKmPerHour = speedKmPerHour;

            return View("Result");
        }
    }
}



