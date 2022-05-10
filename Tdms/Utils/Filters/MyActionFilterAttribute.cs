using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tdms.Utils.Filters
{
    public class MyActionFilterAttribute:ActionFilterAttribute
    {
        Logger logger = new Logger(typeof(MyActionFilterAttribute));
        //方法执行前
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            logger.Info("===OnActionExecuting==");
            //base.OnActionExecuting(filterContext);
        }
        // 方法执行后
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            logger.Info("===OnActionExecuted==");
            //base.OnActionExecuted(filterContext);
        }

        //结果执行前
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            logger.Info("===OnResultExecuting==");
            //base.OnResultExecuting(filterContext);
        }
        //结果执行后
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            logger.Info("===OnResultExecuted==");
            //base.OnResultExecuted(filterContext);
        }
    }

    //通过接口来完成：只有方法前，方法后
    public class MyActionFilterAttributeBark : FilterAttribute, IActionFilter
    {
        Logger logger = new Logger(typeof(MyActionFilterAttributeBark));

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            logger.Info("---OnActionExecuting---");
            //throw new NotImplementedException();
        }
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            logger.Info("---OnActionExecuted---");
            //throw new NotImplementedException();
        }

        
    }
}