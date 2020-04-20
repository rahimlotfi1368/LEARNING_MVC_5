using System.Linq;
//using System.Web.Mvc;

namespace MY_APPLICATION.Areas.SimpleSecurity.Controllers
{
    public partial class HomeController : Infrastracture.BaseController
    {
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Index()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Action1()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Authorize]
        public virtual System.Web.Mvc.ViewResult Action2()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Authorize(Roles = "Administrator")]
        public virtual System.Web.Mvc.ViewResult Action3()
        {
            return View();
        }
    }
}