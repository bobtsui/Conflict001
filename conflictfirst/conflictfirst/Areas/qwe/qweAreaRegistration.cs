using System.Web.Mvc;

namespace conflictfirst.Areas.qwe
{
    public class qweAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "qwe";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "qwe_default",
                "qwe/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}