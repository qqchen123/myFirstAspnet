using EFModel;
using Microsoft.Practices.Unity.Configuration;
using MyInterfaces;
using MyServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdms.Utils;
using Unity;

namespace Tdms.Controllers
{
    public class ThirdController : Controller
    {
        private IUserInfo _userInfo = null;
        //构造函数注入
        public ThirdController(IUserInfo userInfo) {
            this._userInfo = userInfo;
        }

        //属性注入
        [Dependency]
        public IUserInfo _userinfoprop { get; set; }

        public IUserInfo _userinfomethod { get; set; }

        //方法注入
        [InjectionMethod]
        public void setIUserInfoMethod(IUserInfo userInfo) {
            _userinfomethod = userInfo;
        }


        // GET: Third
        public ActionResult Index()
        {
            //IUnityContainer container = CustomDIFactory.getContainer();
            //IUserInfo userInfo = container.Resolve<IUserInfo>();
            //student us = userInfo.GetUserInfo(1);
            student us = _userInfo.GetUserInfo(1);
            return View(us);
        }
    }
}