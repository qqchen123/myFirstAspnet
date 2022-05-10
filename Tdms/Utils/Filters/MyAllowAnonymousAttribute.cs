using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tdms.Utils.Filters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MyAllowAnonymousAttribute:Attribute
    {
    }
}