using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult GotoHome()
        //{
           

        //    ViewData["CurrentTime"] = DateTime.Now.ToString();
        //    return View("MyHomePage");
        //}

        public ActionResult MyHomePage()
        {
            Items ob = new Items();
            ob.id = 1;
            ob.name = "Jack";

            ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View(ob);
        }

       public ActionResult FillCostumer()
        {
           

            return View();
        }

        public ActionResult DisplayCostumer()
        {
            MyCostumer obj = new MyCostumer();
            obj.name = Request.Form["CustName"].ToString();
            obj.RollNo = Request.Form["CustRno"].ToString();
            obj.Class = Request.Form["CustClass"].ToString();
            obj.Address = Request.Form["CustAddress"].ToString();

            return View(obj);
        }
       

    }
}