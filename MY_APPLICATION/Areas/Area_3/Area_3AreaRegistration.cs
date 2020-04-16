using System.Web.Mvc;

namespace MY_APPLICATION.Areas.Area_3
{
    public class Area_3AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Area_3";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                   name:"Some Name" , //"Area_3_default",
                   url: "Area_3/A/B", //{controller}/{action}/{id}",
                   defaults: new { controller = "M", action = "N", id = UrlParameter.Optional },
                   namespaces: new[] { "MY_APPLICATION.Areas.Area_3.Controllers" }
            );
        }
    }
}