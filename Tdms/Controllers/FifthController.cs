using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdms.Models;
using Tdms.Utils.Filters;

namespace Tdms.Controllers
{
    public class FifthController : Controller
    {
        // GET: Fifth
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [MyAllowAnonymousAttribute]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [MyAllowAnonymousAttribute]
        public ActionResult Login(string username,string password,string verify)
        {
            //string formName = HttpContext.Request.Form["username"];
            if (username.Equals("qqchen") && password.Equals("123123"))
            {
                User user = new User()
                {
                    Id = 123,
                    UserName = username,
                    Account = "qqchen123",
                    Password = password,
                    LoginTime = DateTime.Now
                };
                HttpContext.Session["CurrentUser"] = user;
                
                return Redirect("/home/index");
            }
            else {
                ModelState.AddModelError("failed","用户名或密码错误！");
                return View();
            }
        }
    }
}