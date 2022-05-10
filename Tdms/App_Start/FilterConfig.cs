using System.Web;
using System.Web.Mvc;
using Tdms.Utils.Filters;

namespace Tdms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            // 全局注册，对项目中的所有方法都生效
            //filters.Add(new MyActionFilterAttribute());

            //注册--- 全局异常处理
            filters.Add(new MyExceptionFilterAttribute());
            // 登录验证
            filters.Add(new MyAuthorizationFilter());
        }
    }
}
