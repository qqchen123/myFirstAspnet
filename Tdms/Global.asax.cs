using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Tdms.Utils;

namespace Tdms
{
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 网站初始化动作
        /// 
        /// 为了网站在运行的时候，把需要的各种组件都先装配进来；
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();  //注册区域
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);  //注册filter
            RouteConfig.RegisterRoutes(RouteTable.Routes);  //注册路由
            BundleConfig.RegisterBundles(BundleTable.Bundles); //注册bundles --引用js/css需要的组件

            //定义自己的控制器工厂
            ControllerBuilder.Current.SetControllerFactory(new MyControllerFactory());
        }
    }
}
