using System.Linq;
namespace MY_APPLICATION.Controllers
{
    public partial class OtherController : Infrastracture.BaseController
    {
        public OtherController() : base()
        {

        }
        // GET: Other
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return View();
        }
        public virtual System.Web.Mvc.ContentResult Action2()
        {
            return Content($"{nameof(Action2)} from OtherController");
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ContentResult Login()
        {
            return Content("Login...");
        }
    }
}