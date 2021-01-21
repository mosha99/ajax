using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.filter;
using WebApplication6.Models;
using System.Web.Security;
using WebApplication6.database;

namespace WebApplication6.Controllers
{
    public class accontController : Controller
    {
        // GET: accont
        Connector filter = new Connector();
        public ActionResult singin()
        {
            singin user=new singin();
           
            return View(user);
        }

        [HttpPost]
        public ActionResult singin(singin user)
        {
            user = filter.connector(user);

            return View(user);
        }
        public ActionResult Ajax()
        {


            return View("singin");
        }

        [HttpPost]
        public ActionResult Ajax(ajax b)
            {

            F_ajax filter = new F_ajax();
            b = filter.f_ajax(b);
            return Json(b);
        }

    }
} 