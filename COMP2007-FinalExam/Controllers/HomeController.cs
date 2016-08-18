/* Name: Yandong Wang 
 * Number: 200277628
 * Date: 8/18/2016
 * Version: 0.1
 * Description: Provide an Album List page,	an Artist list Page, and a Genre List page.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
    }
}