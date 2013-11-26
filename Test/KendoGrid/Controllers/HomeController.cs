using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoGrid.Views.Home;

namespace KendoGrid.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        [HttpGet]
        public JsonResult SelectOptionsGet()
        {
            List<IdTitle> selectOptions = new List<IdTitle>
                                              {new IdTitle {Id = 1, Title = "111"}, new IdTitle {Id = 2, Title = "222"}};
            return JSON(selectOptions);
        }

        [HttpGet]
        public JsonResult CurrentTimeGet()
        {
            return JSON(new object[] { DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(IdTitle model)
        {
            ViewBag.Message = "Your contact page.";
            bool validationOK = false;

            if (validationOK)
            {
                return View("Index");
            }
            else
            {
                return View();
            }
        }

        #region Strong Typed View

        [HttpGet]
        public ActionResult StrongTypedView()
        {
            IdTitleDescription idTitleDescription = new IdTitleDescription
                                                        {
                                                            Id = 1,
                                                            Title = "Strong typed description",
                                                            Description = "desc"
                                                        };
            return View(idTitleDescription);
        }

        [HttpPost]
        public ActionResult StrongTypedViewSave(int id, string title, string description, string shortDescription)
        {
            IdTitleDescription form = new IdTitleDescription
                                          {
                                              Id = id,
                                              Title = title,
                                              Description = description,
                                              ShortDescription = shortDescription
                                          };
            form.ShortDescription = "Сохранено. УРА!";
            form.Title = "Fucking saved.";
            return View("StrongTypedView", form);
        }

        #endregion Strong Typed View
    }
}
