using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HgWorkflow.Models;
using HgWorkflow.DAL;

namespace HgWorkflow.Controllers
{
    public class UserAccountController : Controller
    {
        // GET: UserAccount
        public ActionResult Index()
        {
            using (OurDbContext db = new OurDbContext())
            {
                return View(db.userAccounts.ToList());
            }
                
        }

        public ActionResult Register()
        {
            return View();
                    }


        [HttpPost]
        public ActionResult Register(UserAccount account)
        {

            using (OurDbContext db = new OurDbContext())
            {

                var UserStatus = db.userAccounts.FirstOrDefault(u => u.Anummer == account.Anummer);

                if(UserStatus != null)

                {

                    ViewBag.message = account.Anummer + " " + "already exists, Contact Administrator. ";
                }
                else if (ModelState.IsValid)
                {
                    //using (OurDbContext db = new OurDbContext())
                    {
                        db.userAccounts.Add(account);
                        db.SaveChanges();
                    }
                    ModelState.Clear();
                    ViewBag.Message = account.FullName + " " + "has been successfully registered";

                }
                
                return View();
            }
            
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            using (OurDbContext db = new OurDbContext())
            {

                var UserLoggingIn = db.userAccounts.FirstOrDefault(u => u.Anummer == user.Anummer && u.Password == user.Password);
                if (UserLoggingIn != null)
                {
                    Session["UserId"] = user.UserId.ToString();
                    //Session["FullName"] = user.FullName.ToString();
                    Session["Anummer"] = user.Anummer.ToString();
                    //Session["ButikId"] = user.ButikId.ToString();

                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "AnstallaningNummer or Password incorrcet");
                    
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View("~/Views/WorkOrders/Index.cshtml");
            }
            else
            {
                return RedirectToAction("Login");

            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            
            return RedirectToAction("Login");
        }
    }


}