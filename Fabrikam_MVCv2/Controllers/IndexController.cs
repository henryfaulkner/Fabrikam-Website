using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fabrikam_MVCv2.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Computing_Digital_Music
        public ActionResult Computing_Digital_Music()
        {
            return View();
        }

        // GET: Education
        public ActionResult Education()
        {
            return View();
        }

        // GET: Law
        public ActionResult Law()
        {
            return View();
        }

        // GET: Music
        public ActionResult Music()
        {
            return View();
        }
    }
}