using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdms.Utils.Filters;

namespace Tdms.Controllers
{
    public class FourthController : Controller
    {
        // GET: Fourth
        //[MyActionFilterAttribute]
        [MyActionFilterAttributeBark]
        public ActionResult Index()
        {
            return View();
        }
    }
}