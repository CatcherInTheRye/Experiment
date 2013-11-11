using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoGrid.Views.Home
{
    public class BaseController : Controller
    {

        protected JsonResult JSON(object obj)
        {
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}
