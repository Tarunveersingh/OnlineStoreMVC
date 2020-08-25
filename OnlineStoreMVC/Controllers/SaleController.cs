using OnlineStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStoreMVC.Controllers
{
    public class SaleController : Controller
    {
        OnlineStoreEntityEntities Entities_MVC = new OnlineStoreEntityEntities();

        // GET: Sale
        public ActionResult AllSale()
        {
            return View(Entities_MVC.SaleDetails.ToList());
        }

        // GET: Sale/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sale/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sale/Create
        [HttpPost]
        public ActionResult Create(SaleDetail newSale)
        {
            if (!ModelState.IsValid)
                return View();
            Entities_MVC.SaleDetails.Add(newSale);
            Entities_MVC.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("AllSale");

        }

        // GET: Sale/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in Entities_MVC.SaleDetails where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Sale/Edit/5
        [HttpPost]
        public ActionResult Edit(SaleDetail IdToEdit)
        {
            var orignalRecord = (from m in Entities_MVC.SaleDetails where m.id == IdToEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            Entities_MVC.Entry(orignalRecord).CurrentValues.SetValues(IdToEdit);

            Entities_MVC.SaveChanges();
            return RedirectToAction("AllSale");


        }

        // GET: Sale/Delete/5
        public ActionResult Delete(SaleDetail IdtoDel)
        {
            var d = Entities_MVC.SaleDetails.Where(x => x.id == IdtoDel.id).FirstOrDefault();
            Entities_MVC.SaleDetails.Remove(d);
            Entities_MVC.SaveChanges();
            return RedirectToAction("AllSale");
        }

        // POST: Sale/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
