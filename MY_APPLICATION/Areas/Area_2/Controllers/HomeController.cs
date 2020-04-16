namespace MY_APPLICATION.Areas.Area_2.Controllers
{
    public partial class HomeController : Infrastracture.BaseController
    {
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult List()
        {
            return View();
        }
    }
}