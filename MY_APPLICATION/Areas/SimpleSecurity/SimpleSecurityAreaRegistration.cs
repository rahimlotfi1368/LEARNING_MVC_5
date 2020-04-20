using System.Web.Mvc;

namespace MY_APPLICATION.Areas.SimpleSecurity
{
    public class SimpleSecurityAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SimpleSecurity";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(

                    name: "SimpleSecurity_default",
                   url: "SimpleSecurity/{controller}/{action}/{id}",
                   defaults: new { action = "Index", id = UrlParameter.Optional },
                   namespaces: new[] { "MY_APPLICATION.Areas.SimpleSecurity.Controllers" }
              
            );
        }
    }
}