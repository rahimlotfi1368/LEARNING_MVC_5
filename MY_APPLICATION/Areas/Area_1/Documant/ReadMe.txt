//******************************Area**********************
برای انتقال از یک اکشن در یک کنترولر به یک اکشن دیگر در یک کنترولر دیگر از
@Html.ActionLink()
استفاده می کنیم
//********************************************************************************************
نوع اول) برای مثال می خواهیم از 
[Action=Action_1 , Controller=Controller_1 , Area=Root]
به
[Action=Action_2 , Controller=Controller_2 , Area=Area]
برویم باید به نحو زیر عمل کنیم

 @Html.ActionLink(linkText: "Go to Action_2 in Controller_2 in Area", actionName: "Action_2", controllerName: "Controller_2", routeValues: new { Area = "Area" }, htmlAttributes: new { @class = "navbar-brand" })
//*********************************************************************************************

//********************************************************************************************
نوع دوم) برای مثال می خواهیم از 
[Action=Action_2 , Controller=Controller_2 , Area=Area]
به
[Action=Action_1 , Controller=Controller_1 , Area=Root]
برویم باید به نحو زیر عمل کنیم

 @Html.ActionLink(linkText: "Go to Action_1 in Controller_1 in Root", actionName: "Action_1", controllerName: "Controller_1", routeValues: new { Area = "" }, htmlAttributes: new { @class = "navbar-brand" })
//*********************************************************************************************
