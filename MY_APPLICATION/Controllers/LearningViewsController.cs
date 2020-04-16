using System.Linq;
namespace MY_APPLICATION.Controllers
{
    public partial class LearningViewsController : Infrastracture.BaseController
    {
        /// <summary>
        /// Step (1)
        /// </summary>
        public LearningViewsController() : base()
        {

        }
        // GET: LearningViews
        public virtual System.Web.Mvc.ViewResult Index()
        {
            return View();
        }
        //**********************************View Fundemental**************************************
        public virtual System.Web.Mvc.ViewResult learn01()
        {
            return View(viewName: nameof(Index));
        }

        public virtual System.Web.Mvc.ViewResult learn02()
        {
            return View();
        }

        public virtual System.Web.Mvc.ViewResult learn03()
        {
            return View();
        }
        //*********************************viewData and viewBag**************************************
        public virtual System.Web.Mvc.ViewResult learn04()
        {
            ViewData["ViewDataMessage"] = "ViewDataText";
            ViewBag.ViewBagMessage = "viewBagText";
            return View();
        }
        //****************************************Best practic for sending a collection to data***************************************************

        public virtual System.Web.Mvc.ViewResult learn05()
        {
            var person = new
            {

                name = "Rahim",
                age = 25,
                car = "mazda",
            };

            System.DateTime birthDate = System.DateTime.Now;

            //------------------------Creating ViewModels----------
            ViewModels.Learn05ViewModel learn05ViewModel =
                                  new ViewModels.Learn05ViewModel
                                  {
                                      Name = person.name,
                                      Age = person.age,
                                      CarModel = person.car,
                                      BirthDate = birthDate,
                                  };

            return View(model: learn05ViewModel);
        }

        public virtual System.Web.Mvc.ViewResult learn06()
        {
            System.Collections.Generic.List<ViewModels.Learn06ViewModel> people =
                                                new System.Collections.Generic.List<ViewModels.Learn06ViewModel>();

            for (int index = 0; index < 10; index++)
            {
                ViewModels.Learn06ViewModel learn06ViewModel =
                                    new ViewModels.Learn06ViewModel
                                    {
                                        Name = $"name ({index + 1})",
                                        Age = 25 + index,
                                        CarModel = $"model#{index + 1}",
                                        BirthDate = System.DateTime.Now,
                                    };
                people.Add(learn06ViewModel);
            }
            return View(model: people);
        }
        //*************************************************_PartialView and _layouts************************
        public virtual System.Web.Mvc.ViewResult learn07()
        {
            System.Collections.Generic.List<ViewModels.Learn07ViewModel> people =
                                                new System.Collections.Generic.List<ViewModels.Learn07ViewModel>();

            for (int index = 0; index < 10; index++)
            {
                ViewModels.Learn07ViewModel learn06ViewModel =
                                    new ViewModels.Learn07ViewModel
                                    {
                                        Name = $"<b>name ({index + 1})</b>",//این فیلد چون دارای تگ اچ تی ام ال می باشد در ویو برای امنیت تگهایش اعمال نمی شود
                                        Age = 25 + index,
                                        CarModel = $"model#{index + 1}",
                                        BirthDate = System.DateTime.Now,
                                    };
                people.Add(learn06ViewModel);
            }
            return View(model: people);
        }

        public virtual System.Web.Mvc.ViewResult learn08()
        {
            return View();
        }

        /// <summary>
        /// Step (2)
        /// </summary>
        /// <returns></returns>
        public virtual System.Web.Mvc.ViewResult learn09()
        {
            ViewBag.SomeVariable1 = "Some Variable 1";
            return View();
        }

    }
}