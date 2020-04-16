using System.Linq;
namespace Infrastracture
{
    public class BaseController : System.Web.Mvc.Controller
    {
        public BaseController():base()
        {

        }

		private Models.DatabaseContext myDatabaseContext;

		/// <summary>
		/// Lazy Loading = Lazy Initialization
		/// Best Practic
		/// 
		/// </summary>
		protected Models.DatabaseContext MyDatabaseContext
		{
			get
			{
				if (myDatabaseContext == null)
				{
					myDatabaseContext =
						new Models.DatabaseContext();
				}

				return (myDatabaseContext);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (myDatabaseContext != null)
				{
					myDatabaseContext.Dispose();
					myDatabaseContext = null;
					//MyDatabaseContext = null;مشکل فاجعه آمیز
				}
			}

			base.Dispose(disposing);
		}

		//*********************************************************************************************
		protected override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
		{
			// کد ذیل برای آن است که اول بسم الله سایت به چه زبانی دیده شود
			if (Session["Culture"] == null)
			{
				Session["Culture"] = "en-US";
				//Session["Culture"] = "fa-IR";
			}

			// دقت کنید که دستورات ذیل، در داخل شرط فوق قرار ندارند
			System.Globalization.CultureInfo cultureInfo =
				new System.Globalization.CultureInfo(Session["Culture"].ToString());

			System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
		}
	}
}