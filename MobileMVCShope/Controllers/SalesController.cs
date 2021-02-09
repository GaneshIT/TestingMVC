using MobileMVCShope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileMVCShope.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        dotnetEntities dotnetEntities = new dotnetEntities();
        public ActionResult Addsales()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var salesentity=dotnetEntities.sales.Find(id);
            return View(salesentity);
        }
    }
}