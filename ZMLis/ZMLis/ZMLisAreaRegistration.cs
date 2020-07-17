using System.Web.Mvc;

namespace ZMCMSv2.Areas.ZMLis
{
    public class ZMLisAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ZMLis";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ZMLis_default",
                "ZMLis/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}