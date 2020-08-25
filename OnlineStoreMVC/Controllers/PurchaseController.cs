using OnlineStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStoreMVC.Controllers
{
    public class PurchaseController : Controller
    {
        OnlineStoreEntityEntities Entities_MVC = new OnlineStoreEntityEntities();

        // GET: Purchase
        public ActionResult AllPurchase()
        {
            return View(Entities_MVC.PurchaseDetails.ToList());
        }

        // GET: Purchase/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Purchase/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Purchase/Create
        [HttpPost]
        public ActionResult Create(PurchaseDetail newPurchase)
        {
            if (!ModelState.IsValid)
                return View();
            Entities_MVC.PurchaseDetails.Add(newPurchase);
            Entities_MVC.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("AllPurchase");


        }

        // GET: Purchase/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in Entities_MVC.PurchaseDetails where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Purchase/Edit/5
        [HttpPost]
        public ActionResult Edit(PurchaseDetail IdToEdit)
        {
            var orignalRecord = (from m in Entities_MVC.PurchaseDetails where m.id == IdToEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            Entities_MVC.Entry(orignalRecord).CurrentValues.SetValues(IdToEdit);

            Entities_MVC.SaveChanges();
            return RedirectToAction("AllPurhcase");
        }

        // GET: Purchase/Delete/5
        public ActionResult Delete(PurchaseDetail IdtoDel)
        {
            var d = Entities_MVC.PurchaseDetails.Where(x => x.id == IdtoDel.id).FirstOrDefault();
            Entities_MVC.PurchaseDetails.Remove(d);
            Entities_MVC.SaveChanges();
            return RedirectToAction("AllPurchase");
        }

        // POST: Purchase/Delete/5
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
