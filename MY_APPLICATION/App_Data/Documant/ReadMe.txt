Install-Package bootstrap -Version 4.4.1
Install-Package bootstrap4rtl -Version 4.3.1
Install-Package jQuery -Version 3.4.1
Install-Package jQuery.Validation -Version 1.19.1
Install-Package jQuery.Validation.Unobtrusive -Version 2.0.20710
Install-Package vue -Version 2.6.11
Install-Package T4MVC -Version 4.2.3

Install-Package EntityFramework -Version 6.4.0

execute [Update-Package -Id <package_name> –reinstall] or [Update-Package  –reinstall] command whene you download it from GitHub

Relationships:
Rlx
Models
Resources
ViewModels

----------------------------------------داستان امنیت----------------------
فرض کنیم یک اکشن به شرطی قابل دسترسی است 
 اگر لاگین کرده باشیم و 
اگر لاگین نکرده باشیم به صفحه لاگین آن ریدایرکت می کند

Authentication => نحوه شناسایی کاربر
Authorization => سطح دسترسی کاربر
Authening => پیشینه کارهایی که کاربر بعد از ورود کرده 

فرض کنیم شخصی قصد ورود به سازمانی را دارد
روال به این صورت است که اف اف (نحوه شناسایی کاربر)را میزند
یک نام کاربری و رمز ورود می دهد و در صورت درست بودن وارد می شود
پس از ورود به شما اجازه رفتن(سطح دسترسی کاربر) به کلاس 8 در ساعت 9 را می دهند
حال  در این بین به کلاس 5 هم سر زده اید( پیشینه کارهایی که کاربر بعد از ورود کرده 
 و سپس به کلاس 8 رفته و حضور غیاب کرده اید.

 فرض کنیم که در
 OtherController ->Login (Action)
 و
 HomeController -> learn1370(Action)
 وجود دارد و 
 learn1370
 یک اکشن است که برای دسترسی به آن باید لاگین کرده باشیم
 سوال اینجاست که آیا اگر لاگین نکرده باشیم به صورت اتماتیک به صفحه لاگین برویم یا خیر؟
  OtherController ->Login (Action)
  جواب خیر است برای اینکار باید در
  web.config
  اصلی برنامه نه مربوط به
  view
  کد زیر را اضافه کنیم

  <authentication mode="Forms">
      <forms loginUrl="~/Other/Login"/>
  </authentication>

*******************************************lمراحل یک درخواست کاربر از ابتدا تا جواب*********************
زمانی که یک کاربر  یک درخواست را اعلام می کند مراحل زیر طی می شود
Step 1 => Default Constructor controller
Step 2 => Action
Step 3 => _ViewStart in Views's Shared Folder
Step 4 => _ViewStart in controller's Views Folder
Step 5 => Action's View
Step 6 => Layout initilized in [_ViewStart in controller's Views Folder] if it is not initilized in this folder,
                it will use the layout which is initilized in [_ViewStart in Views's Shared Folder]
Step 7 =>Client.

****************************************داستان مهم***************************

فرض کنید 1000 کاربر هر کدام 100 ریکوست بدهند
در این حالت به ازای هر ریکوست هر کاربر یک کنترولر ایجاد می شود 
در این کنترلر ها اگر به دیتا بیس نیاز باشد یک 
database context
ایجاد می شود
که اینکه به ازای نیاز دیتابیس فراخوانی شود حاصل تعریف آن به سبک
Lazy Loading
می باشد
**********************************Validation********************************
اعتبار سنجی بر سه نوع است:
1) Server Side
2) Client Side
3) Server-Client Side
که بهتر است نوع سوم را به کار ببریم
چون فرض کنیم یک کاربر بیاید و یک فرم را پر کند دکمه را بزند 
در حین پردازش درخواست وی  اگر کاربر به طور مکرر دکمه را بزند 
بار زیادی به سمت سرور منتقل می شود تا در آنجا اعتبار سنجی شود
برای جلوگیری از این حالت بهتر است اعتبار سنجی سمت کلاینت را هم فعال کنیم
برای اینکار دو نوگت زیر رانصب می کنیم
1) Install-Package jQuery.Validation -Version 1.19.1
2) Install-Package Microsoft.jQuery.Unobtrusive.Validation -Version 3.2.11
و کد های زیر را بر لایوت پروژه نصب می کنیم

 <script src="~/Scripts/jquery-3.4.1.min.js"></script>
    <script src="~/Scripts/jquery.validate.min.js"></script>
    <script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>
    <style>
        body {
            padding: 10px;
        }

        /* Set padding to keep content from hitting the edges */
        .body-content {
            padding-left: 15px;
            padding-right: 15px;
        }

        /* Set width on the form input elements since they're 100% wide by default */
        input,
        select,
        textarea {
            max-width: 280px;
        }

        /* Styles for validation helpers */
        .field-validation-error {
            color: #b94a48;
        }

        .field-validation-valid {
            display: none;
        }

        input.input-validation-error {
            border: 1px solid #b94a48;
        }

        input[type="checkbox"].input-validation-error {
            border: 0 none;
        }

        .validation-summary-errors {
            color: #b94a48;
        }

        .validation-summary-valid {
            display: none;
        }
        /* /Styles for validation helpers */

    </style>
************************************************************************************
String => Class => Refrence Type => Nullable => not Required
Int => Type => Primary Type =>not Nullable => Required