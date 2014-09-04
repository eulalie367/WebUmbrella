using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUmbrella_MVC4.Controllers
{
    public class HomeController : ControllerBase
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
