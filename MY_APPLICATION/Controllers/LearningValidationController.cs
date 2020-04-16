using System.Linq;
namespace MY_APPLICATION.Controllers
{
	public partial class LearningValidationController : Infrastracture.BaseController
	{
		public LearningValidationController() : base()
		{

		}
		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ActionResult Index()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn01()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn01(Models.Validation.Learn01 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn02()
		{
			
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn02(Models.Validation.Learn02 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn03()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn03(Models.Validation.Learn03 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn04()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn04(Models.Validation.Learn04 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn05()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn05(Models.Validation.Learn05 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn06()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn06(Models.Validation.Learn06 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn07()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn07(Models.Validation.Learn07 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn08()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn08(Models.Validation.Learn08 model)
		{
			if (ModelState.IsValid)
			{
				//Models.User newUser = new Models.User();

				//newUser.Username = viewModel.Username;
				//newUser.Password = viewModel.Password;
				//newUser.EmailAddress = viewModel.EmailAddress;

				//MyDatabaseContext.Users.Add(newUser);

				//MyDatabaseContext.SaveChanges();
				return RedirectToAction(actionName: "Index");
			}

			return View(model);
		}

		//********************************************************************************
		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.JsonResult CheckUsername(string username)
		//public System.Web.Mvc.ActionResult CheckUsername(string username)
		{
			//Request.ServerVariables["HTTP_REFERER"]

			bool result = true;

			if (string.Compare(username, "Dariush", ignoreCase: true) == 0)
			{
				result = false;
			}

			//Models.User user =
			//	MyDatabaseContext.Users
			//	.Where(current => current.Username == username)
			//	.FirstOrDefault();

			//Models.User user =
			//	MyDatabaseContext.Users
			//	.Where(current => string.Compare(current.Username, username, true) == 0)
			//	.FirstOrDefault();

			//if (user != null)
			//{
			//	result = false;
			//}

			return Json(data: result,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.JsonResult CheckEmailAddress(string emailAddress)
		//public System.Web.Mvc.ActionResult CheckEmail(string email)
		{
			bool result = true;

			if (string.Compare(emailAddress, "DariushT@GMail.com", ignoreCase: true) == 0)
			{
				result = false;
			}

			//Models.User user =
			//	MyDatabaseContext.Users
			//	.Where(current => string.Compare(current.EmailAddress, emailAddress, true) == 0)
			//	.FirstOrDefault();

			//if (user != null)
			//{
			//	result = false;
			//}

			return Json(data: result,
				behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
		}
		//***************************************************************************************************
		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn09()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn09(Models.Validation.learn09 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn10()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn10(Models.Validation.Learn10 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn11()
		{
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn11(Models.Validation.Learn11 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn12()
		{
			//Models.Validation.Learn12 learn12
			//			= new Models.Validation.Learn12
			//			{

			//			};
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn12(Models.Validation.Learn12 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			return View(model);
		}

		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Learn13()
		{
			
			return View();
		}

		[System.Web.Mvc.HttpPost]
		public virtual System.Web.Mvc.ActionResult Learn13(Models.Validation.Learn13 model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Index");
			}

			return View(model);
		}
	}
}