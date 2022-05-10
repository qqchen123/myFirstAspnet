using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdms.Utils.Filters;

namespace Tdms.Controllers
{
    //[MyActionFilterAttributeBark] //让控制器下的所有action都生效
    public class FourthController : Controller
    {
        // GET: Fourth
        //[MyActionFilterAttribute]
        //[MyActionFilterAttributeBark]
        public ActionResult Index()
        {
            return View();
        }

        [MyCompressionActionFilterAttribute]
        public ActionResult About()
        {
            return View();
        }


        public ActionResult Home()
        {
            return View();
        }

        [MyHandleErrorAttribute]
        public ActionResult ExpIndex()
        {
            int i = 1;
            int o = 0;
            int x = i / o;
            return View();
        }

    }
}