using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class LoginhomeController : Controller
    {
        // GET: Loginhome
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult secimlerbelediye()
        {
            return View();
        }
        public ActionResult secimlermillet()
        {
            return View();
        }
        public ActionResult profil()
        {
            return View();
        }
        public ActionResult oymillet()
        {
            return View();
        }
        public ActionResult oybelediye()
        {
            return View();
        }
        public ActionResult oyverildi()
        {
            return View();
        }
    }
}