using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdms.Models;

namespace Tdms.Utils.Filters
{
    public class MyAuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {

        private string _LoginUrl = null;
        public MyAuthorizationFilter(string loginUrl="~/Fifth/login") {
            this._LoginUrl = loginUrl;
        }


        public void OnAuthorization(AuthorizationContext filterContext)
        {
            //throw new NotImplementedException();

            var httpContext = filterContext.HttpContext;
            if (filterContext.ActionDescriptor.IsDefined(typeof(MyAllowAnonymousAttribute), true))
            {
                return;
            }
            else if (filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(MyAllowAnonymousAttribute), true))
            {
                return;
            }
            else

            if (httpContext.Session["CurrentUser"] == null || !(httpContext.Session["CurrentUser"] is User))
            {

                if (httpContext.Request.IsAjaxRequest())
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new
                        {
                            DebugMessage = "登录过期",
                            RetValue = ""
                        }
                    };
                }
                else
                {

                    httpContext.Session["CurrentUrl"] = httpContext.Request.Url.AbsoluteUri;
                    filterContext.Result = new RedirectResult(this._LoginUrl);
                }
            }
            else
            {

                User user = (User)httpContext.Session["CurrentUser"];
                return;
            }








        }
    }
}