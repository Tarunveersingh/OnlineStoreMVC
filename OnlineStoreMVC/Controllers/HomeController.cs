using OnlineStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        Sql_Connection obj = new Sql_Connection();

        OnlineStoreEntityEntities Entities_MVC = new OnlineStoreEntityEntities();

        public ActionResult ContactDetails()
        {


            return View(Entities_MVC.ContactDetails.ToList());
        }


        public ActionResult Index()
        {
            return View();
        }


        // GET: Order/Delete/5
        public ActionResult Delete(ContactDetail IdToDelete)
        {

            var d = Entities_MVC.ContactDetails.Where(x => x.id == IdToDelete.id).FirstOrDefault();
            Entities_MVC.ContactDetails.Remove(d);
            Entities_MVC.SaveChanges();
            return RedirectToAction("ContactDetails");
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // method to generate the layout for the login page 
        public ActionResult AdminLogin()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AdminDashboard()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult InvalidDetails()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        [HttpPost]
        public ActionResult LoginVerification(Login data)
        {


           // String query = "select * from AdminDetails where AdminName='" + data.txt_Name + "' ";
            String query = "select * from AdminDetails where AdminName='" + data.txt_Name + "' And AdminPassword='" + data.txt_Password + "'";
            DataTable tbl = new DataTable();
            tbl = obj.SrchLogin(query);
            
            if (tbl.Rows.Count > 0)
            {
                return View("AdminDashboard");
            }
            else
            {
                return View("InvalidDetails");
            }

        }


        public ActionResult Confirmation()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        [HttpPost]
        public ActionResult send_Message(Contact data)
        {

            //get the value from the user to pass in the database 


            String query = "insert into ContactDetails(Name,Email,Contact,Message) values('" + data.txt_Name + "','" + data.txt_Email + "','" + data.txt_Contact + "','" + data.txt_Msg + "')";

            obj.sendfeedback(query);

            return View("Confirmation");


        }

    }
}