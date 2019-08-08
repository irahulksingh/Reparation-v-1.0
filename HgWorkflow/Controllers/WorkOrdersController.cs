using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HgWorkflow.DAL;
using HgWorkflow.Models;

namespace HgWorkflow.Controllers
{
    public class WorkOrdersController : Controller
    {
        private OurDbContext db = new OurDbContext();

        // GET: WorkOrders
        public ActionResult Index()
        {
            if (Session["UserId"] != null)
            {
                return View(db.workOrders.ToList());
            }
            else
            {
                return RedirectToAction("Login", "UserAccount");
            }
            
        }

        // GET: WorkOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.workOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // GET: WorkOrders/Create
        public ActionResult Create()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login","UserAccount");
            }
            
        }

        // POST: WorkOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,WorkOrderId,GoldSmithName,CustomerName,CustomerMobileNumber,CustomerEmail,JewelleryDescription1,JewelleryDescription2,JewelleryDescription3,WorkToBeDone,WorkToBeDone2,WorkToBeDone3,AgentName,ProductGivenOn,DateProposed,DateAcceptedOrRejected,ProductToBeReturnedOn,AmountToBeCollected,AmountEstimate,Status")] WorkOrder workOrder)
        {

               if (ModelState.IsValid)
                {
                    db.workOrders.Add(workOrder);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            
            return View(workOrder);

        }

        // GET: WorkOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.workOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // POST: WorkOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,WorkOrderId,GoldSmithName,CustomerName,CustomerMobileNumber,CustomerEmail,JewelleryDescription1,JewelleryDescription2,JewelleryDescription3,WorkToBeDone,WorkToBeDone2,WorkToBeDone3,AgentName,ProductGivenOn,DateProposed,DateAcceptedOrRejected,ProductToBeReturnedOn,AmountToBeCollected,AmountEstimate,Status")] WorkOrder workOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workOrder);
        }

        // GET: WorkOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkOrder workOrder = db.workOrders.Find(id);
            if (workOrder == null)
            {
                return HttpNotFound();
            }
            return View(workOrder);
        }

        // POST: WorkOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkOrder workOrder = db.workOrders.Find(id);
            db.workOrders.Remove(workOrder);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
