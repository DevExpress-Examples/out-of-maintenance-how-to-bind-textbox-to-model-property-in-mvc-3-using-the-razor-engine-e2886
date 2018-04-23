using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorSupport.Models;
using DevExpress.Web.Mvc;

namespace RazorSupport.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Fill the form:";

            return TextBox();
        }
        public ActionResult TextBox() {
            return View("TextBox",
                new MyModel() { OrderDate = DateTime.Now, Name = "Test" });
        }

        [HttpPost]
        public ActionResult PostValues([ModelBinder(typeof(DevExpressEditorsBinder))] MyModel model) {
            ViewBag.Message = String.Format("Values from {0} were posted", model.Name);
            return View("TextBox", model);
        }
    }
}
