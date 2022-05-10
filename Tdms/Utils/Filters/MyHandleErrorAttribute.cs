using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tdms.Utils.Filters
{
    public class MyHandleErrorAttribute:HandleErrorAttribute
    {
        // 如果有异常发生，就执行
        public override void OnException(ExceptionContext filterContext)
        {
            var httpContext = filterContext.HttpContext;
            if (!filterContext.ExceptionHandled) {
                if (httpContext.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new
                        {
                            DebugMessage = filterContext.Exception.Message,
                            RetValue = "",
                            PromptMsg = "发生错误，请联系管理员"
                        }
                    };
                }
                else {
                    filterContext.Result = new ViewResult()
                    {
                        ViewName = "~/Views/Shared/Error.cshtml",
                        ViewData = new ViewDataDictionary<string>(filterContext.Exception.Message)
                    };
                    filterContext.ExceptionHandled = true;
                }
            }
        }
    }
}