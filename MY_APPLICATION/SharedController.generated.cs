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
namespace T4MVC
{
    public class SharedController
    {

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
            }
            static readonly _LayoutsClass s_Layouts = new _LayoutsClass();
            public _LayoutsClass Layouts { get { return s_Layouts; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _LayoutsClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string _DefaultLayout = "_DefaultLayout";
                    public readonly string _Layout_Afternoon = "_Layout_Afternoon";
                    public readonly string _Layout_Morning = "_Layout_Morning";
                    public readonly string _Layout_Night = "_Layout_Night";
                    public readonly string _Layout_Noon = "_Layout_Noon";
                    public readonly string _Layout01 = "_Layout01";
                    public readonly string _Layout02 = "_Layout02";
                    public readonly string _LayoutValidation = "_LayoutValidation";
                }
                public readonly string _DefaultLayout = "~/Views/Shared/Layouts/_DefaultLayout.cshtml";
                public readonly string _Layout_Afternoon = "~/Views/Shared/Layouts/_Layout_Afternoon.cshtml";
                public readonly string _Layout_Morning = "~/Views/Shared/Layouts/_Layout_Morning.cshtml";
                public readonly string _Layout_Night = "~/Views/Shared/Layouts/_Layout_Night.cshtml";
                public readonly string _Layout_Noon = "~/Views/Shared/Layouts/_Layout_Noon.cshtml";
                public readonly string _Layout01 = "~/Views/Shared/Layouts/_Layout01.cshtml";
                public readonly string _Layout02 = "~/Views/Shared/Layouts/_Layout02.cshtml";
                public readonly string _LayoutValidation = "~/Views/Shared/Layouts/_LayoutValidation.cshtml";
            }
            static readonly _PartialViewsClass s_PartialViews = new _PartialViewsClass();
            public _PartialViewsClass PartialViews { get { return s_PartialViews; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _PartialViewsClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string _Partial_PersianCalender = "_Partial_PersianCalender";
                    public readonly string _Partial_PersonInformation = "_Partial_PersonInformation";
                    public readonly string _Partial_PersonInformation_template = "_Partial_PersonInformation_template";
                }
                public readonly string _Partial_PersianCalender = "~/Views/Shared/PartialViews/_Partial_PersianCalender.cshtml";
                public readonly string _Partial_PersonInformation = "~/Views/Shared/PartialViews/_Partial_PersonInformation.cshtml";
                public readonly string _Partial_PersonInformation_template = "~/Views/Shared/PartialViews/_Partial_PersonInformation_template.cshtml";
            }
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
