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
        /// ��վ��ʼ������
        /// 
        /// Ϊ����վ�����е�ʱ�򣬰���Ҫ�ĸ����������װ�������
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();  //ע������
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);  //ע��filter
            RouteConfig.RegisterRoutes(RouteTable.Routes);  //ע��·��
            BundleConfig.RegisterBundles(BundleTable.Bundles); //ע��bundles --����js/css��Ҫ�����

            //�����Լ��Ŀ���������
            ControllerBuilder.Current.SetControllerFactory(new MyControllerFactory());
        }
    }
}
