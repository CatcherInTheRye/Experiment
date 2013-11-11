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

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
