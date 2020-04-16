//using System.Linq;
//using System.Web.Mvc;

namespace MY_APPLICATION.Controllers
{
    public partial class LearningHtmlHelperController : Infrastracture.BaseController
    {
        public LearningHtmlHelperController() : base()
        {

        }
        // GET: LearningHtmlHelper
        public virtual System.Web.Mvc.ActionResult Index()
        {

            return View();
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult learn01()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public virtual System.Web.Mvc.ActionResult learn01(ViewModels.LearningHtmlHelper.Learn01ViewModel viewModel)
        {
            if (viewModel.FirstName=="Rahim" && viewModel.LastName=="Lotfi")
            {
                ViewData["Message"] = "ok!";
            }
            else
            {
                ViewData["Message"] = "oops,sorry!";
            }
            return View();
        }
        //****************************************Creating a form base on Ajax************
        /// <summary>
        /// Asynchronous AJAX form is a very magical way to submit data to the controller without happening page load. 
        /// Asynchronous AJAX Forms simply post back the data to the controllers and update the only that part of the page,
        /// which has to display output.
        /// https://www.completecsharptutorial.com/asp-net-mvc5/4-ways-to-create-form-in-asp-net-mvc.php
        /// </summary>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult CreateFormBaseOnAjax()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public virtual System.Web.Mvc.ActionResult CreateFormBaseOnAjax(ViewModels.LearningHtmlHelper.CreateFormBaseOnAjaxViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                System.Text.StringBuilder result = new System.Text.StringBuilder();
                result.Append($"<b> My Name : {viewModel.Name} </b><br/>");
                result.Append($"<b> My Age : {viewModel.Age} </b><br/>");
                result.Append($"<b>and I am  : {(viewModel.Ismarid?"Marid":"Not Marid")} </b>");
                return Content(result.ToString());
            }
            else
            {
                return View();
            }
            
        }
        //*****************************************Using My Html Helpers**********************
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult learn03()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public virtual System.Web.Mvc.ActionResult learn03(ViewModels.LearningHtmlHelper.Learn03ViewModel viewModel)
        {
            ViewData["UserName"] = viewModel.UserName;
            ViewData["Password"] = viewModel.Password;
            ViewData["Email"] = viewModel.Email;
             return View();
        }
    }
}