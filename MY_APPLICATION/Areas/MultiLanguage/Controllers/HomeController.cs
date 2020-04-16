using System.Linq;
//using System.Web.Mvc;

namespace MY_APPLICATION.Areas.MultiLanguage.Controllers
{
    public partial class HomeController : Infrastracture.BaseController
    {

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ActionResult Index(bool? result)
        {
			ViewBag.Result = result;

			return View();
        }

		//***********************
		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Create()
		{
			return View();
		}

		//***********************
		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Create
				(ViewModels.MultiLanguageViewModels.FormInformationMultiLanguageViewModels viewModel)
		{
			var foundedItem =
					MyDatabaseContext.Information
					.Where(current => current.Username.ToLower() == viewModel.Username.ToLower())
					.FirstOrDefault()
					;

			if (foundedItem != null)
			{
				//اگر در کد زیر قرار دهیم 
				//key:string.Empty
				//در این صورت نگفتیم این اعتبار سنجی برای کدام  پراپرتی باید اعلان شود پس در قسمت
				//validation summery
				// اعلان و به نمایش قرار می گیرد

				ModelState.AddModelError
					(key: "Username", errorMessage: "Username is exist! Please choose another one...");
			}


			if (ModelState.IsValid)
			{
				var newInformation =
						new Models.FormInformationMultiLanguage
						{
							Username=viewModel.Username,
							Password=viewModel.Password,
							EmailAddress=viewModel.EmailAddress,
							Description=viewModel.Description,
						};
				MyDatabaseContext.Information.Add(newInformation);
				MyDatabaseContext.SaveChanges();
				return RedirectToAction
						(actionName:"Index",controllerName:"Home",routeValues:new { Area= "MultiLanguage", result=true });
			}

			return View(model: viewModel);
		}

		//*************************************************************************************
		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ActionResult ChangeCulture(string cultureName)
		{
			Session["Culture"] = cultureName;

			//return RedirectToAction(actionName: "Index", controllerName: "Home"));

			string referrerUrl =
				Request.UrlReferrer.AbsoluteUri;

			return Redirect(url: referrerUrl);
		}
	}
}