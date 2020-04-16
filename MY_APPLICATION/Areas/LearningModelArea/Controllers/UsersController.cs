using System.Linq;
//using System.Web.Mvc;
namespace MY_APPLICATION.Areas.LearningModelArea.Controllers
{
    public partial class UsersController : Infrastracture.BaseController
    {
        /// <summary>
        /// Index
        /// کارش لیست کردن ریکرد موجودیت نقش می باشد
        /// </summary>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Index()
        {
            var items =
               MyDatabaseContext.Users
               .OrderBy(current => current.Username)
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
                return (new System.Web.Mvc.HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest));
            }

            var foundedItem =
                MyDatabaseContext.Users
                .Where(current => current.Id == id.Value)
                .FirstOrDefault()
                ;
            if (foundedItem == null)
            {
                return (HttpNotFound());
            }

            return View(model: foundedItem);
        }

        /// <summary>
        /// در این جا ما یک کامبو باکس داریم  که باید برحسب 
        /// RolId
        /// با
        /// Role.Name
        /// پر شودتا ازاین قسمت فیلد 
        /// RoleId ,Role.name 
        /// کاربر مقدار دهی شود
        /// </summary>
        /// <returns></returns>
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Create()
        {
            // **************************************************
            Models.User defaultItem = new Models.User();
                       
            defaultItem.IsActive = true;
            // **************************************************
            //رول هایی که فعال هستند
            var roles =
                MyDatabaseContext.Roles
                .Where(current => current.IsActive)
                .OrderBy(current => current.Name)
                .ToList()
                ;
            //نحوه پرکردن کامبو باکس برحسب 
            //Id
            //با مقادیر فیلد
            //Name
            ViewBag.RoleId =
                new System.Web.Mvc.SelectList
                    (items: roles, dataValueField: "Id", dataTextField: "Name", selectedValue: null);

            return View(model:defaultItem);
        }


        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public virtual System.Web.Mvc.ActionResult Create(/*[System.Web.Mvc.Bind(Exclude = "Id")]*/ Models.User user)
        {
            var foundedItem =
                MyDatabaseContext.Users
                .Where(current => string.Compare(current.Username, user.Username, true) == 0)
                .FirstOrDefault()
                ;

            //it is better in .net core
            //var foundedItem =
            //    MyDatabaseContext.Users
            //    .Where(current => current.Username.ToLower() == user.Username.ToLower() )
            //    .FirstOrDefault()
            //    ;

            if (foundedItem != null)
            {
                //اگر در کد زیر قرار دهیم 
                //key:string.Empty
                //در این صورت نگفتیم این اعتبار سنجی برای کدام  پراپرتی باید اعلان شود پس در قسمت
                //validation summery
                // اعلان و به نمایش قرار می گیرد

                ModelState.AddModelError
                    (key: "Username", errorMessage: "Username is exist! Please choose another one...");
            }

                     

            if (ModelState.IsValid)
            {
               
                MyDatabaseContext.Users.Add(user);
                MyDatabaseContext.SaveChanges();

                return RedirectToAction(actionName: "Index", controllerName: "Users");
            }

            var roles =
                MyDatabaseContext.Roles
                .Where(current => current.IsActive)
                .OrderBy(current => current.Name)
                .ToList()
                ;

            ViewBag.RoleId =
                 new System.Web.Mvc.SelectList
                     (items: roles, dataValueField: "Id", dataTextField: "Name", selectedValue: user.RoleId);

            return View(model: user);
        }

        //هرجا کامبو باکس داشتیم باید در اکشن گیت آن پرشود
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Edit(System.Guid? id)
        {
            if (id.HasValue == false)
            {
                return (new System.Web.Mvc.HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest));
            }

            var foundedItem =
                MyDatabaseContext.Users
                .Where(current => current.Id == id.Value)
                .FirstOrDefault()
                ;

            if (foundedItem == null)
            {
                return (HttpNotFound());
            }


            var roles =
                MyDatabaseContext.Roles
                .Where(current => current.IsActive)
                .OrderBy(current => current.Name)
                .ToList()
                ;

            ViewBag.RoleId =
                 new System.Web.Mvc.SelectList
                     (items: roles, dataValueField: "Id", dataTextField: "Name", selectedValue: foundedItem.RoleId);

            return View(model: foundedItem);
        }


        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public virtual System.Web.Mvc.ActionResult Edit(Models.User user)
        {
            var orginalItem =
                MyDatabaseContext.Users
                .Where(current => current.Id == user.Id)
                .FirstOrDefault()
                ;

            if (orginalItem == null)
            {
                return HttpNotFound();
            }

            // ***********************در قسمت ویرایش اگه نام کاربری تکراری کاربر خواست بگذارد چون این فیلد  یکتا باید باشد جلویش را با یک پیقام خطا میگیرد***************************
            var foundedItem =
                MyDatabaseContext.Users
                .Where(current => current.Id != user.Id)
                .Where(current => string.Compare(current.Username, user.Username, true) == 0)
                .FirstOrDefault();

            if (foundedItem != null)
            {
                ModelState.AddModelError
                    (key: "Username", errorMessage: "Username is exist! Please choose another one...");
            }
            // **************************************************

            if (ModelState.IsValid)
            {
                orginalItem.RoleId = user.RoleId;
                orginalItem.IsActive = user.IsActive;
                orginalItem.Username = user.Username;
                orginalItem.Password = user.Password;
                orginalItem.FullName = user.FullName;
                MyDatabaseContext.SaveChanges();
                return RedirectToAction(actionName: "Index", controllerName: "Users");
            }

            var roles =
                MyDatabaseContext.Roles
                .Where(current => current.IsActive)
                .OrderBy(current => current.Name)
                .ToList()
                ;

            ViewBag.RoleId =
                new System.Web.Mvc.SelectList
                    (items: roles, dataValueField: "Id", dataTextField: "Name", selectedValue: user.RoleId);

            return View(user);
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ActionResult Delete(System.Guid? id)
        {
            if (id.HasValue == false)
            {
                //باید یک اکشن درست کنیم با ورودی زیر و آن را به یک اکشن که یک ویو ارور نشان می دهد
                return new System.Web.Mvc.HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var foundedItem =
                    MyDatabaseContext.Users
                    .Where(current => current.Id == id.Value)
                    .FirstOrDefault()
                    ;
            if (foundedItem == null)
            {
                return HttpNotFound();
            }

            return View(model: foundedItem);
        }

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
                    MyDatabaseContext.Users
                    .Where(current => current.Id == id.Value)
                    .FirstOrDefault()
                    ;
            if (foundedItem == null)
            {
                return HttpNotFound();
            }
            MyDatabaseContext.Users.Remove(foundedItem);
            MyDatabaseContext.SaveChanges();

            return RedirectToAction(actionName: "Index", controllerName: "Users");
        }


    }
}
