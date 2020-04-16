using System.Linq;
namespace MY_APPLICATION.Areas.LearningModelArea.Controllers
{
    public partial class RolesController : Infrastracture.BaseController
    {

        /// <summary>
        /// Index
        /// کارش لیست کردن ریکرد موجودیت نقش می باشد
        /// </summary>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Index()
        {
            var items =
                MyDatabaseContext.Roles
                .OrderBy(current => current.Name)
                .ToList()
                ;

            return View(model: items);
        }

        /// <summary>
        /// در این اکشن باید برحسب یک شناسگر یک ریکورد را نمایش می دهد
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Details(System.Guid? id)
        {
            if (id.HasValue == false)
            {
                //باید یک اکشن درست کنیم با ورودی زیر و آن را به یک اکشن که یک ویو ارور نشان می دهد
                return new System.Web.Mvc.HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var foundedItem =
                    MyDatabaseContext.Roles
                    .Where(current => current.Id == id.Value)
                    .FirstOrDefault()
                    ;
            if (foundedItem == null)
            {
                return HttpNotFound();
            }

            return View(model: foundedItem);
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ViewResult Create()
        {
            return View();
        }


        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]//برای هر اکشن با پوست این رو باید بزنیم
        public virtual System.Web.Mvc.ActionResult Create([System.Web.Mvc.Bind(Exclude = "Id")] Models.Role role)
        {
            //اول بررسی می کنیم که آیا رکوردی با مشخصات فرستاده شده از طریق فرم قبلا ایجاد نشده باشد!
            var foundedItem =
                    MyDatabaseContext.Roles
                    .Where(current => string.Compare(current.Name, role.Name, true) == 0)
                    .FirstOrDefault()
                    ;
            if (foundedItem != null)
            {
                ModelState.AddModelError
                            (key: "Name", errorMessage: "Name is exist! Please choose another one...");
            }

            if (ModelState.IsValid)
            {
                MyDatabaseContext.Roles.Add(role);
                MyDatabaseContext.SaveChanges();
                return RedirectToAction(actionName: "Index", controllerName: "Roles");
            }

            return View(model: role);
        }
        /// <summary>
        /// این اکشن درست مثل 
        /// Details
        /// چون در اینجا هم اطلاعات یک رکورد اول به نمایش گذاشته می شود
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Edit(System.Guid? id)
        {

            if (id.HasValue == false)
            {
                //باید یک اکشن درست کنیم با ورودی زیر و آن را به یک اکشن که یک ویو ارور نشان می دهد
                return new System.Web.Mvc.HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var foundedItem =
                    MyDatabaseContext.Roles
                    .Where(current => current.Id == id.Value)
                    .FirstOrDefault()
                    ;
            if (foundedItem == null)
            {
                return HttpNotFound();
            }

            return View(model: foundedItem);
        }

        /// <summary>
        /// اول رکورد اصلی را با استفاده از 
        /// id
        /// پیدا می کنیم
        /// سپس 
        /// مقادیر مشخص را با استفاده از مقادیر بدست آمده از فرم آپدیت می کنیم
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public virtual System.Web.Mvc.ActionResult Edit(Models.Role role)
        {
            var orginalItem =
                MyDatabaseContext.Roles
                .Where(current => current.Id == role.Id)
                .FirstOrDefault()
                ;

            if (orginalItem == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                orginalItem.Name = role.Name;
                orginalItem.IsActive = role.IsActive;
                MyDatabaseContext.SaveChanges();
                return RedirectToAction(actionName: "Index", controllerName: "Roles");
            }
            return View(model: role);
        }

        /// <summary>
        /// Delete=Ditailes=Edit[get]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Delete(System.Guid? id)
        {
            if (id.HasValue == false)
            {
                //باید یک اکشن درست کنیم با ورودی زیر و آن را به یک اکشن که یک ویو ارور نشان می دهد
                return new System.Web.Mvc.HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var foundedItem =
                    MyDatabaseContext.Roles
                    .Where(current => current.Id == id.Value)
                    .FirstOrDefault()
                    ;
            if (foundedItem == null)
            {
                return HttpNotFound();
            }

            return View(model: foundedItem);
        }

        /// <summary>
        /// دلیل اینکه چرا نام پست اکشن دیلیت یه چیز دیگه است این است که
        /// به دلیل داشتن ورودی یکسان به مشکل
        /// C# overloading
        /// بر می خوریم 
        /// به نام 
        /// overLoading
        /// ولی از آنجایی که با زدن دکمه سابمیت ویو  به تو خودکار کامپایلر به دنبال اکشن پوست تولید کننده اکشن می گردد
        /// Action name
        /// را ایجاد کرده
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ActionName("Delete")]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public virtual System.Web.Mvc.ActionResult DeleteConfirmed(System.Guid? id)
        {
            if (id.HasValue == false)
            {
                //باید یک اکشن درست کنیم با ورودی زیر و آن را به یک اکشن که یک ویو ارور نشان می دهد
                return new System.Web.Mvc.HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var foundedItem =
                    MyDatabaseContext.Roles
                    .Where(current => current.Id == id.Value)
                    .FirstOrDefault()
                    ;
            if (foundedItem == null)
            {
                return HttpNotFound();
            }
            MyDatabaseContext.Roles.Remove(foundedItem);
            MyDatabaseContext.SaveChanges();

            return RedirectToAction(actionName: "Index", controllerName: "Roles");
        }


    }
}
