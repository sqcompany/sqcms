using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Areas.BackGround.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /BackGround/Account/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

    }
}
