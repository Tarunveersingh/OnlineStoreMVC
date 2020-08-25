using OnlineStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStoreMVC.Controllers
{
    public class StockController : Controller
    {
        OnlineStoreEntityEntities Entities_MVC = new OnlineStoreEntityEntities();


        // GET: Stock
        public ActionResult AllStock()
        {
            return View(Entities_MVC.StockDetails.ToList());
        }

        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(StockDetail NewStock)
        {


            if (!ModelState.IsValid)
                return View();
            Entities_MVC.StockDetails.Add(NewStock);
            Entities_MVC.SaveChanges();
            //Response.Redirect("StudentAdmission",true);
            return RedirectToAction("AllStock");

        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            var IdToEdit = (from m in Entities_MVC.StockDetails where m.id == id select m).First();
            return View(IdToEdit);
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit(StockDetail IdToEdit)
        {
            var orignalRecord = (from m in Entities_MVC.StockDetails where m.id == IdToEdit.id select m).First();

            if (!ModelState.IsValid)
                return View(orignalRecord);
            Entities_MVC.Entry(orignalRecord).CurrentValues.SetValues(IdToEdit);

            Entities_MVC.SaveChanges();
            return RedirectToAction("AllStock");
        }

        // GET: Stock/Delete/5
        public ActionResult Delete(StockDetail IdToDel)
        {
            var d = Entities_MVC.StockDetails.Where(x => x.id == IdToDel.id).FirstOrDefault();
            Entities_MVC.StockDetails.Remove(d);
            Entities_MVC.SaveChanges();
            return RedirectToAction("AllStock");
        }

        // POST: Stock/Delete/5
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
