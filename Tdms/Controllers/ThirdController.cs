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
        // GET: Third
        public ActionResult Index()
        {
            //IUserInfo userInfo = new UserInfoService();
            //student stu = userInfo.GetUserInfo(1);
            //return View(stu);

            //ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            //fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "ConfigFiles\\unity.config");
            //Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            //UnityConfigurationSection section = (UnityConfigurationSection)configuration.GetSection(UnityConfigurationSection.SectionName);
            //IUnityContainer container = new UnityContainer();
            //section.Configure(container, "IQueryContainer");

            //IUserInfo userInfo = container.Resolve<IUserInfo>();

            //student us = userInfo.GetUserInfo(1);
            //-------------------------------------------
            IUnityContainer container = CustomDIFactory.getContainer();
            IUserInfo userInfo = container.Resolve<IUserInfo>();
            student us = userInfo.GetUserInfo(1);
            return View(us);
        }
    }
}