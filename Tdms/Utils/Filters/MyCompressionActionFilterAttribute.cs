using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tdms.Utils.Filters
{
    public class MyCompressionActionFilterAttribute : FilterAttribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // 判断浏览器/服务器是否同时支持压缩规则
            var request = filterContext.HttpContext.Request;
            var response = filterContext.HttpContext.Response;
            string acceptEncoding = request.Headers["Accept-Encoding"];
            if (!string.IsNullOrWhiteSpace(acceptEncoding) && acceptEncoding.ToUpper().Contains("GZIP")) {
                response.AddHeader("Content-Encoding","gzip");
                response.Filter = new GZipStream(response.Filter,CompressionMode.Compress);
            }
        }
    }
}