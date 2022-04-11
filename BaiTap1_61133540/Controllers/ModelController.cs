using BaiTap1_61133540.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1_61133540.Controllers
{
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalModel cal)
        {
            switch (cal.pt)
            {
                case "+": ViewBag.KQ = cal.a + cal.b; break;
                case "-": ViewBag.KQ = cal.a - cal.b; break;
                case "*": ViewBag.KQ = cal.a * cal.b; break;
                case "/":
                    if (cal.b == 0) ViewBag.KQ = "Khong chia duoc cho 0";
                    else ViewBag.KQ = cal.a / cal.b; break;

            }
            return View();
        }

    }
}