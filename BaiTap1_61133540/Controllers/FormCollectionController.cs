using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1_61133540.Controllers
{
    public class FormCollectionController : Controller
    {
        // GET: FormCollection
        public ActionResult UseFormCollection()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseFormCollection(FormCollection f)
        {
            double a = double.Parse(f["a"]);
            double b = double.Parse(f["b"]);
            string pt = f["pt"].ToString();
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }

    }
}