using Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/
        DemoContext context = new DemoContext();
        public ActionResult Index()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Create(Demo demo)
        {
            //if(ModelState.IsValid)
            //{
                context.Demos.Add(demo);
                context.SaveChanges();
            //}
            string message = "SUCCESS";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        public JsonResult GetDemos(string id)
        {
            List<Demo>demos = new List<Demo>();
            demos = context.Demos.ToList();
            return Json(demos, JsonRequestBehavior.AllowGet);
        }


	}
}