using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdms.Utils;

namespace Tdms.Controllers
{
    public class FirstController : Controller
    {
        Logger logger = new Logger(typeof(FirstController));
        // GET: First
        public ActionResult Index()
        {
            base.ViewBag.user1 = "张三";
            base.ViewData["user2"] = "李四";
            base.TempData["user3"] = "王五";
            base.HttpContext.Session["user4"] = "赵六";

            base.ViewData["user2"] = "testuser2";
            object model = "qqchen123123";

            return View(model);

            //return Redirect("ToIndex");

        }

        public ActionResult ToIndex() {
            return View();
        }

        public ActionResult MyLogTest()
        {
            this.logger.Info("FirstController MyLogTest-info");
            this.logger.Warn("FirstController MyLogTest-warn");
            this.logger.Debug("FirstController MyLogTest-debug");
            this.logger.Error("FirstController MyLogTest-error");
            return View();
        }
    }
}