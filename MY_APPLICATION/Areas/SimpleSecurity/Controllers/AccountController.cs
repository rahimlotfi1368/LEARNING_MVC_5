﻿using System.Linq;
//using System.Web.Mvc;
namespace MY_APPLICATION.Areas.SimpleSecurity.Controllers
{
    public partial class AccountController : Infrastracture.BaseController
    {
        public AccountController() : base()
        {

        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Login()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public virtual System.Web.Mvc.ActionResult Login(ViewModels.Account.LoginViewModel viewModel)
        {
            try
            {
                //این کد لاگین می کند
                System.Web.Security.FormsAuthentication.SetAuthCookie
                    (userName: viewModel.Username, createPersistentCookie: false);

                //System.Web.Security.FormsAuthentication.SetAuthCookie
                //	(userName: user.Username, createPersistentCookie: viewModel.RememberMe);

                if (string.IsNullOrWhiteSpace(viewModel.ReturnUrl) == false)
                {
                    return Redirect(url: viewModel.ReturnUrl);
                }
                else
                {
                    //return RedirectToAction(MVC.Home.Index());
                    return Redirect(url: System.Web.Security.FormsAuthentication.DefaultUrl);
                }
            }
            catch (System.Exception ex)
            {
                //Dtx.Logger.LogError
                //	(type: GetType(), exception: ex);

                //return RedirectToAction
                //	(MVC.Error.UnexpectedError());
            }

            return View(model: viewModel);

        }

        #region Logout
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.AllowAnonymous]
        public virtual System.Web.Mvc.ActionResult Logout()
        {
            try
            {
                //این کد لاگ اوت می کند
                System.Web.Security.FormsAuthentication.SignOut();

                //string sessionID = Session.SessionID;

                //var userSiteLoginLogs =
                //	MyDatabaseContext.UserSiteLoginLogs
                //	.Where(current => current.LogoutDateTime.HasValue == false)
                //	.Where(current => string.Compare(current.SessionId, sessionID, true) == 0)
                //	.ToList()
                //	;

                //foreach (var item in userSiteLoginLogs)
                //{
                //	item.LogoutManually = true;
                //	item.LogoutDateTime = Models.Utility.GetNow();
                //}

                //MyDatabaseContext.SaveChanges();

                // TODO: تست شود
                //Session.Abandon();
            }
            catch (System.Exception ex)
            {
                //Dtx.Logger.LogError
                //	(type: GetType(), exception: ex);
            }

            return Redirect(url: System.Web.Security.FormsAuthentication.DefaultUrl);
        }
        #endregion /Logout
    }
}