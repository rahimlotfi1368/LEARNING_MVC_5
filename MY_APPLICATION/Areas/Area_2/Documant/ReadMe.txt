فرض کنیم در پروژه ای یک ایریا داریم که در آن یک کنترلر همنام با کنترلر روت پرژه یعنی
HomeControler
داریم در زمان اجرای پروژه ما به خطا خواهیم رفت
چون کامپایلر نمی تواند تشخیص دهد که کدام کنترلر را انتخاب کند
//-----------------steps for excuting a webApp-----------------------------------------------
step 0 )=> our app will not start as soon as uploading,it will start after first request
step 1 )=>as soon as first request,The event [APPLICATION_START] will be trigger
step 2 )=>After [APPLICATION_START] ,The event [SESION_START] will be trigger
step 3 )=>for the next requests only The event [SESION_START] will be trigger
step 4 )=>if there was no request for 20 min,The event [SESION_END] will be trigger
step 5 )=>After [SESION_END] ,The event [APPLICATION_END] will be trigger
step 6 )=>For [ALWAYS ON] systems ,The event [APPLICATION_END] will never trigger
//--------------------------------------------------------------------------------------------
چهار رویداد بالا در فایل
global.asax
تعریف می شوند.
به طور کلی در فایل بالا که یک فایل باشخصیت برای 
MVC
می باشد توابع زیر قابل تعریف می باشند
1 => [REQUEST_START]
2 => [REQUEST_END]
3 => [APPLICATION_START]
4 => [APPLICATION_END]
5 => [SESION_START]
6 => [SESION_END]
7 => [APPLICATION_ERROR]
***********************************************************************************************
در تابع 
APPLICATION_START
یک متد به نام
RegisterRoutes
وجود دارد که یک متد استاتیک کلاس
RouteConfig
می باشد
 در این متد که در آدرس زیر می شود دید
 [APP_START]=>CLASS RouteConfig
 می توان تنظیمات 
ROUTING 
را انجام داد.