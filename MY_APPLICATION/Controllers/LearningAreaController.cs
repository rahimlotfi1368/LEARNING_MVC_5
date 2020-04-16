using System.Linq;
namespace MY_APPLICATION.Controllers
{
    public partial class LearningAreaController : Infrastracture.BaseController
    {
        public LearningAreaController() : base()
        {

        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Help()
        {
            return View();
        }
    }
}