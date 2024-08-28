using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PegPayKYC.Helpers;

namespace PegPayKYC.Controllers
{
    public class BusinessController : Controller
    {
        private IStorage _storage = new DBStorage();
        
        // GET: Business
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewClients()
        {
            // Fetch records from the database and map to ViewModel
            List<object> cards = _storage.ExecuteSelectQuery("Select * from ClientBusiness");
            

            return View("ViewClients",cards);
        }

        public ActionResult ViewStatus()
        {
            return View("ViewStatus");
        }
    }
}