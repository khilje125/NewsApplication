using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsAppAdmin.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        // GET: /SignUp/

        public ActionResult SignUp()
        {
            return View();
        }

        // GET: /Category/

        public ActionResult Category()
        {
            return View();
        }

        // GET: /SearchCategory/

        public ActionResult SearchCategory()
        {
            return View();
        }

        // GET: /AddRssLink/

        public ActionResult AddRssLink()
        {
            return View();
        }
    }
}
