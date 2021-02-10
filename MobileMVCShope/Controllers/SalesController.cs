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
        [HttpPost]
        public ActionResult Addsales(sale sale)
        {
            var data=dotnetEntities.sales.Add(sale);
            dotnetEntities.SaveChanges();
            return View(data);
        }
        public ActionResult Edit(int id)
        {
            var salesentity=dotnetEntities.sales.Find(id);
            return View(salesentity);
        }
        [HttpPost]
        public ActionResult Edit(int id,sale sale)
        {
            var salesentity=dotnetEntities.sales.Find(id);
            dotnetEntities.Entry(sale).State=System.Data.Entity.EntityState.Modified;
            dotnetEntities.SaveChanges();
            return View(salesentity);
        }
    }
}