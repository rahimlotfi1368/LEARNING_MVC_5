// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace MY_APPLICATION.Controllers
{
    public partial class LearningHtmlHelperController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected LearningHtmlHelperController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LearningHtmlHelperController Actions { get { return MVC.LearningHtmlHelper; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "LearningHtmlHelper";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "LearningHtmlHelper";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string learn01 = "learn01";
            public readonly string CreateFormBaseOnAjax = "CreateFormBaseOnAjax";
            public readonly string learn03 = "learn03";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string learn01 = "learn01";
            public const string CreateFormBaseOnAjax = "CreateFormBaseOnAjax";
            public const string learn03 = "learn03";
        }


        static readonly ActionParamsClass_learn01 s_params_learn01 = new ActionParamsClass_learn01();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_learn01 learn01Params { get { return s_params_learn01; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_learn01
        {
            public readonly string viewModel = "viewModel";
        }
        static readonly ActionParamsClass_CreateFormBaseOnAjax s_params_CreateFormBaseOnAjax = new ActionParamsClass_CreateFormBaseOnAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateFormBaseOnAjax CreateFormBaseOnAjaxParams { get { return s_params_CreateFormBaseOnAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateFormBaseOnAjax
        {
            public readonly string viewModel = "viewModel";
        }
        static readonly ActionParamsClass_learn03 s_params_learn03 = new ActionParamsClass_learn03();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_learn03 learn03Params { get { return s_params_learn03; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_learn03
        {
            public readonly string viewModel = "viewModel";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string CreateFormBaseOnAjax = "CreateFormBaseOnAjax";
                public readonly string Index = "Index";
                public readonly string learn01 = "learn01";
                public readonly string learn03 = "learn03";
            }
            public readonly string CreateFormBaseOnAjax = "~/Views/LearningHtmlHelper/CreateFormBaseOnAjax.cshtml";
            public readonly string Index = "~/Views/LearningHtmlHelper/Index.cshtml";
            public readonly string learn01 = "~/Views/LearningHtmlHelper/learn01.cshtml";
            public readonly string learn03 = "~/Views/LearningHtmlHelper/learn03.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_LearningHtmlHelperController : MY_APPLICATION.Controllers.LearningHtmlHelperController
    {
        public T4MVC_LearningHtmlHelperController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void learn01Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult learn01()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.learn01);
            learn01Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void learn01Override(T4MVC_System_Web_Mvc_ActionResult callInfo, ViewModels.LearningHtmlHelper.Learn01ViewModel viewModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult learn01(ViewModels.LearningHtmlHelper.Learn01ViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.learn01);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            learn01Override(callInfo, viewModel);
            return callInfo;
        }

        [NonAction]
        partial void CreateFormBaseOnAjaxOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreateFormBaseOnAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateFormBaseOnAjax);
            CreateFormBaseOnAjaxOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void CreateFormBaseOnAjaxOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, ViewModels.LearningHtmlHelper.CreateFormBaseOnAjaxViewModel viewModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult CreateFormBaseOnAjax(ViewModels.LearningHtmlHelper.CreateFormBaseOnAjaxViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.CreateFormBaseOnAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            CreateFormBaseOnAjaxOverride(callInfo, viewModel);
            return callInfo;
        }

        [NonAction]
        partial void learn03Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult learn03()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.learn03);
            learn03Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void learn03Override(T4MVC_System_Web_Mvc_ActionResult callInfo, ViewModels.LearningHtmlHelper.Learn03ViewModel viewModel);

        [NonAction]
        public override System.Web.Mvc.ActionResult learn03(ViewModels.LearningHtmlHelper.Learn03ViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.learn03);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            learn03Override(callInfo, viewModel);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
