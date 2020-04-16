using System.Web.Mvc;

namespace MY_APPLICATION.Areas.Area_2
{
    public class Area_2AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Area_2";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                  //"Area_2_default",
                  //"Area_2/{controller}/{action}/{id}",
                  //new { action = "Index", id = UrlParameter.Optional }

                   name: "Area_2_default",
                   url: "Area_2/{controller}/{action}/{id}",
                   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                   namespaces: new[] { "MY_APPLICATION.Areas.Area_2.Controllers" }
            );
        }
    }
}