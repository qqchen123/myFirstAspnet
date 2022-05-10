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





    }
}