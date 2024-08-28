using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PegPayKYC.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult ClientIndex()
        {
            return View("ClientIndex");
        }

        public ActionResult AddBusiness()
        {
            return View("AddBusiness");
        }

        public ActionResult ViewStatus()
        {
            return View("ViewStatus");
        }

        public ActionResult ClientNotifications()
        {
            return View("ClientNotifications");
        }

        public ActionResult Help()
        {
            return View("Help");
        }
    }
}