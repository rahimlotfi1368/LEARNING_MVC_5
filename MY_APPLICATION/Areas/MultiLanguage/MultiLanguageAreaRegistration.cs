using System.Web.Mvc;

namespace MY_APPLICATION.Areas.MultiLanguage
{
    public class MultiLanguageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MultiLanguage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "MultiLanguage_default",
                   url: "MultiLanguage/{controller}/{action}/{id}",
                   defaults: new { action = "Index", id = UrlParameter.Optional },
                   namespaces: new[] { "MY_APPLICATION.Areas.MultiLanguage.Controllers" }
                                 
                                
            );
        }
    }
}