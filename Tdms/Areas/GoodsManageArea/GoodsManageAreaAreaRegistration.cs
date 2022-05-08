using System.Web.Mvc;

namespace Tdms.Areas.GoodsManageArea
{
    public class GoodsManageAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GoodsManageArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GoodsManageArea_default",
                "GoodsManageArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}