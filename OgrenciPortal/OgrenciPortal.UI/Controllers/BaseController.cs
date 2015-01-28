using OgrenciPortal.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciPortal.UI.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/

        public ActionResult Index()
        {
            if (Session["Kullanici"] != null)
            {
                ViewModelSession kul = Session["Kullanici"] as ViewModelSession;
                return View(kul);
            }
            else
                return View();
        }

    }
}
