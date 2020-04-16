namespace MY_APPLICATION.Areas.Area_1.Controllers
{
    public partial class UserController : Infrastracture.BaseController
    {
        // GET: Area_1/User
        public virtual System.Web.Mvc.ActionResult List()
        {
            return View();
        }
    }
}