using System.Linq;
using System.Web.Mvc.Html;
namespace Infrastracture
{
    public static class HtmlHelper
    {
         static HtmlHelper()
        {

        }

        public static System.Web.IHtmlString RlxLable
                        (this System.Web.Mvc.HtmlHelper htmlHelper,string expression,string labelText)
        {
            //soloution (1)
            //string result =
            //      $"<label for='{ expression }'>{ labelText }</label>";
            //*************

            //soloution (2)
            //System.Web.Mvc.TagBuilder lable = new System.Web.Mvc.TagBuilder("label");
            //lable.SetInnerText(labelText);
            //lable.Attributes.Add("for", expression);
            //***************

            //soloution (3)
            string lable = htmlHelper.Label(expression: expression, labelText: labelText).ToHtmlString();
            System.Web.Mvc.TagBuilder div = new System.Web.Mvc.TagBuilder("div");
            div.AddCssClass("caption");
            div.InnerHtml = lable.ToString();
            return htmlHelper.Raw(div.ToString());
            //***************
        }

        public static System.Web.IHtmlString RlxTextBox
                        (this System.Web.Mvc.HtmlHelper htmlHelper, string name,string placeholder, object value=null)
        {
            //soloution (1)
            //string textBox = htmlHelper.TextBox(name: name, value: value).ToHtmlString();
            //System.Web.Mvc.TagBuilder div = new System.Web.Mvc.TagBuilder("div");
            //div.AddCssClass("caption");
            //div.InnerHtml = textBox.ToString();
            //return htmlHelper.Raw(div.ToString());
            //************************

            System.Web.Mvc.TagBuilder input = new System.Web.Mvc.TagBuilder("input");
            input.Attributes.Add("id", name);
            input.Attributes.Add("name", name);
            input.Attributes.Add("type", "text");
            input.Attributes.Add("placeholder", placeholder);
            if (value!=null)
            {
                input.Attributes.Add("value", value.ToString());
            }
            return htmlHelper.Raw(input.ToString());
                      
        }

        public static System.Web.IHtmlString RlxButton
                        (this System.Web.Mvc.HtmlHelper htmlHelper, string caption, Rlx.Enums.ButtonType buttonType,Rlx.Enums.ButtonStyle buttonStyle, Rlx.Enums.ButtonSize buttonSize)
        {
            
            System.Web.Mvc.TagBuilder button = new System.Web.Mvc.TagBuilder("button");
            button.Attributes.Add("type", $"{buttonType}");
            button.AddCssClass($"btn btn-{buttonStyle.ToString().ToLower()} btn-{Rlx.Utility.ToBootstrapSize(buttonSize)}");
            button.SetInnerText(caption);
            return htmlHelper.Raw(button.ToString());

        }
    }
}