using CareerPlatform.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CareerPlatform.Controllers
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
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ValidateLogin()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult EmployeeLanding()
        {
            return View();
        }
        public ActionResult EmployerLanding()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateUser(string firstname,string lastname,string age,string email,string password,string telephone,string address)
        {
            var existing = Server.MapPath("/Database/datas/user.txt");
            StringBuilder sb = new StringBuilder();
            sb.Append(firstname + "|" + lastname + "|" + age + "|" + email + "|" + password + "|" + telephone + "|" + address);

            if(System.IO.File.Exists(existing))
                using (StreamWriter sw=new StreamWriter(existing,true))
                {
                    sw.WriteLine(sb.ToString());
                }
            
            return RedirectToAction("Index");
        }
    }
}