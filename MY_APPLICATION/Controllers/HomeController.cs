using System.Linq;
namespace MY_APPLICATION.Controllers
{
    public partial class HomeController : Infrastracture.BaseController
    {
        public HomeController() : base()
        {

        }
        // GET: Home
        public virtual System.Web.Mvc.ViewResult Index()
        {
            return View();
        }
        public string learn01()
        {
            string result = $"rahim lotfi";
            return result;
        }

        /// <summary>
		/// http://localhost:30847/Home/Learn1010 -> Error!
		/// http://localhost:30847/Home/Learn1010?id=15
		/// http://localhost:30847/Home/Learn1010/15 // شیک تر است
		/// http://localhost:30847/Home/Learn1010/Something -> Error!
		/// </summary>
        public string learn02(int id)
        {
            string result = $"rahim lotfi {id}";
            return result;
        }

        /// <summary>
		/// http://localhost:30847/Home/Learn1020 -> Error!
		/// http://localhost:30847/Home/Learn1020/15 -> Error!
		/// http://localhost:30847/Home/Learn1020?number=15
		/// http://localhost:30847/Home/Learn1020?number=Something -> Error!
		/// http://LOCALHOST:30847/HOME/LEARN1020?NUMBER=15 -> Note: Url (Domain and Controller and Action name) and the input parameter(s) name are not Case Sensitive!
		/// </summary>
        public string learn03(int number)
        {
            string result = $"rahim lotfi {number}";
            return result;
        }

        /// <summary>
		/// http://localhost:30847/Home/Learn1030 -> Error!
		/// http://localhost:30847/Home/Learn1030/15 -> Error!
		/// http://localhost:30847/Home/Learn1030?firstNumber=15 -> Error!
		/// http://localhost:30847/Home/Learn1030?firstNumber=15&secondNumber=20
		/// http://localhost:30847/Home/Learn1030?secondNumber=20&firstNumber=15 -> Note: The parameters ordering is not important!
		/// </summary>
        public string learn04(int m, int n)
        {
            string result = $"rahim lotfi {n} , {m}";
            return result;
        }

        /// <summary>
		/// http://localhost:30847/Home/Learn1040 -> Error!
		/// http://localhost:30847/Home/Learn1040/15 -> Error!
		/// http://localhost:30847/Home/Learn1040?id=15&number=20
		/// http://localhost:30847/Home/Learn1040?number=20&id=15
		/// http://localhost:30847/Home/Learn1040/15?number=20 // شیک تر است
		/// </summary>
        public string learn05(int id, int m)
        {
            string result = $"rahim lotfi id={id},{m}";
            return result;
        }
        public string learn06(int id, string name)
        {
            string result = $"{name} and {id}";
            return result;
        }

        /// <summary>
		/// http://localhost:30847/Home/Learn1080 -> id = null
		/// http://localhost:30847/Home/Learn1080?id=Something -> id = "Something"
		/// http://localhost:30847/Home/Learn1080/Something -> id = "Something" شيک تر است
		/// </summary>
        public string learn07(string id)
        {
            string result = $"rahim lotfi {id}";
            return result;
        }
        /// <summary>
        /// این ویژ گی باعث می شود متد در حالی که عمومی است یک اکشن محسوب نشود
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        [System.Web.Mvc.NonAction]
        public string print(string message)
        {
            string result = $"{message}";
            return result;
        }
        [System.Web.Mvc.ActionName("نمایش")]
        public string learn08(string information)
        {
            return print(information);
        }
        public virtual System.Web.Mvc.ContentResult learn09(string name)
        {
            string result1 = Server.HtmlEncode($"<b>Hello World,Mr.{name}</b>");//این کد تگ ها را بی اثر می کند
            string result2 = $"<b>Hello World,Mr.{name}</b>";
            return Content(result1);
        }
        //******************************RedirectToAction in home controler*****************************************
        public virtual System.Web.Mvc.ContentResult Action1()
        {
            string result = $"Action(1)";
            return Content(result);
        }
        public virtual System.Web.Mvc.ContentResult Action2()
        {
            string result = $"Action(2)";
            return Content(result);
        }

        public virtual System.Web.Mvc.ActionResult learn10(int id)
        {
            switch (id)
            {
                case 1:
                    {
                        return RedirectToAction(actionName: nameof(Action1));
                    }
                case 2:
                    {
                        return RedirectToAction(actionName: nameof(Action2), controllerName: "Other");
                    }
                default:
                    {
                        //string message = $"id is not valid :)";
                        //return Content(message);
                        return Redirect(url: "www.google.com");
                    }

            }
        }
        //*********************************redirect to action with input parameters************************************************
        public virtual System.Web.Mvc.ContentResult Action3(string firstName, string lastName)
        {
            string fullName = $"my name is {firstName} {lastName}";
            return Content(fullName);
        }

        public virtual System.Web.Mvc.ActionResult learn11()
        {
            return RedirectToAction(actionName: nameof(Action3), routeValues: new { firstName = "Rahim", lastName = "lotfi" });
        }
        //***********************************using tempdata**************************************************
        public virtual System.Web.Mvc.ContentResult Action4()
        {
            string result = string.Empty;
            if (TempData["myName"] != null)
            {
                result = $"My Name is {TempData["myName"].ToString()}";
                return Content(result);
            }
            else
            {
                result = $"there is any passed parameters";
                return Content(result);
            }
        }

        public virtual System.Web.Mvc.ContentResult Action5()
        {
            string result = string.Empty;
            if (TempData["myNumber"] == null)
            {
                TempData["myNumber"] = 10;
                TempData.Keep("myNumber");
            }
            else
            {
                TempData["myNumber"] = (int)TempData["myNumber"] + 1;
                TempData.Keep("myNumber");

            }
            result = $"my number is {TempData["myNumber"]} and my name is {TempData["myName"]}";
            return Content(result);
        }
        public virtual System.Web.Mvc.ActionResult learn12()
        {
            TempData["myName"] = "Rahim lotfe";
            TempData["myNumber"] = 10;
            //return RedirectToAction(nameof(Action4));
            return RedirectToAction(nameof(Action5));
        }
        //*********************************useing RedirectPermanent*****************************************
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.RedirectResult Aboutus()
        {
            return RedirectPermanent(url: nameof(About));
        }

        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ContentResult About()
        {
            return Content("I Am Rahim Lotfi in new page about");
        }
        //***********************************caching***************************************
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.ContentResult Learn13()
        {
            string result = System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");
            return Content(result);
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.OutputCache(Duration = 10)]
        public virtual System.Web.Mvc.ContentResult Learn14()
        {
            string result = System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");
            return Content(result);
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.OutputCache(Duration = 300)]
        public virtual System.Web.Mvc.ContentResult Learn15(int id)
        {
            switch (id)
            {
                case 1:
                    {
                        return Content($"{System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss")}");
                    }
                case 2:
                    {
                        return Content(System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss"));
                    }
                default:
                    {
                        return Content(System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss"));
                    }
            }
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.OutputCache(Duration = 300)]
        public virtual System.Web.Mvc.ContentResult Learn16()
        {
            string result = System.DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss");
            return Content(result);
        }

        [System.Web.Mvc.HttpGet]
        public void Learn17()
        {
            string url = Url.Action(actionName: nameof(Learn16));
            Response.RemoveOutputCacheItem(url);
        }
        //*********************************security*****************************************
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Authorize]
        public virtual System.Web.Mvc.ContentResult Learn1370()
        {
            return Content("Hello, World!");
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Authorize(Roles = "Supervisor,Manager")]
        public virtual System.Web.Mvc.ContentResult learn18()
        {
            return Content("hello world");
        }
        //***********************************json result**************************
        [System.Web.Mvc.HttpGet]
        public virtual System.Web.Mvc.JsonResult learn19()
        {
            var result = new System.Collections.ArrayList();
            for (int index = 0; index < 10; index++)
            {
                var entity= new { fullName = $"Rahim Lotfi({index+1})", age = 31+index };
                result.Add(entity); 
            }
                
            return Json(data: result, behavior: System.Web.Mvc.JsonRequestBehavior.AllowGet);
        }
        //************************************downloading*********************
        public virtual System.Web.Mvc.FileResult learn20()
        {
            string rootRelativePathName = "~/App_Data/images/r.jpg";
            string pathName = Server.MapPath(rootRelativePathName);//ایجاد آدرس فیزیکی فایل
            //return File(fileName: pathName, contentType: "text/html");در این حالت عکس به صورت دری وری نمایش داده می شود
            //return File(fileName: pathName, contentType: "image/.jpeg"); فایل دانلود می شود بدون آمدن پنجره ذخیره
            // return File(fileName: pathName, contentType: "gogol/magol");// فایل دانلود می شود بدون آمدن پنجره ذخیره
            return File(fileName: pathName, contentType: "gogol/magol", fileDownloadName: "Rahim.jpg");//برای ذخیره فایل با نام دلخواه 
        }

        /// <summary>
		/// Download Large Files! For example more than 100MB!
		/// </summary>
        [System.Web.Mvc.HttpGet]
        public void Download(int id)
        {
            // **************************************************
            string fileName =
                string.Format("{0}.zip", id);

            string rootRelativePathName =
                string.Format("~/App_Data/Files/{0}", fileName);

            string pathName =
                Server.MapPath(path: rootRelativePathName);

            if (System.IO.File.Exists(pathName) == false)
            {
                return;
            }
            // **************************************************

            System.IO.Stream stream = null;

            try
            {
                // Open the file
                stream =
                    new System.IO.FileStream
                        (path: pathName,
                        mode: System.IO.FileMode.Open,
                        share: System.IO.FileShare.Read,
                        access: System.IO.FileAccess.Read);

                // **************************************************
                Response.Buffer = false;

                // Setting the unknown [ContentType]
                // will display the saving dialog for the user
                Response.ContentType = "application/octet-stream";

                // With setting the file name,
                // in the saving dialog, user will see
                // the [fileName] name instead of [download]!
                Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);

                long fileLength = stream.Length;

                // Notify user (client) the total file length
                Response.AddHeader("Content-Length", fileLength.ToString());
                // **************************************************

                // Total bytes that should be read
                long dataToRead = fileLength;

                // Read the bytes of file
                while (dataToRead > 0)
                {
                    // The below code is just for testing! So we commented it!
                    //System.Threading.Thread.Sleep(1000);

                    // Verify that the client is connected or not?
                    if (Response.IsClientConnected)
                    {
                        // 8KB
                        int bufferSize = 8 * 1024;

                        // Create buffer for reading [intBufferSize] bytes from file
                        byte[] buffers =
                            new System.Byte[bufferSize];

                        // Read the data and put it in the buffer.
                        int theBytesThatReallyHasBeenReadFromTheStream =
                            stream.Read(buffer: buffers, offset: 0, count: bufferSize);

                        // Write the data from buffer to the current output stream.
                        Response.OutputStream.Write
                            (buffer: buffers, offset: 0,
                            count: theBytesThatReallyHasBeenReadFromTheStream);

                        // Flush (Send) the data to output
                        // (Don't buffer in server's RAM!)
                        Response.Flush();

                        dataToRead =
                            dataToRead - theBytesThatReallyHasBeenReadFromTheStream;
                    }
                    else
                    {
                        // Prevent infinite loop if user disconnected!
                        dataToRead = -1;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (stream != null)
                {
                    //oStream.Close();
                    stream.Dispose();
                    stream = null;
                }

                Response.Close();
            }
        }

        //*********************************************************************

    }
}