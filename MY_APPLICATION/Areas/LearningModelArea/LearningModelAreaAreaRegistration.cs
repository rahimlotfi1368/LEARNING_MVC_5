using System.Web.Mvc;

namespace MY_APPLICATION.Areas.LearningModelArea
{
    public class LearningModelAreaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LearningModelArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                              
                   name: "LearningModelArea_default",
                   url: "LearningModelArea/{controller}/{action}/{id}",
                   defaults: new { action = "Index", id = UrlParameter.Optional },
                   namespaces: new[] { "MY_APPLICATION.Areas.LearningModelArea.Controllers" }

            );
        }
    }
}