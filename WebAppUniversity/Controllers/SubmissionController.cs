//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using WebApplication1.Areas.Admin.Models;

//namespace WebApplication1.Areas.Admin.Controllers
//{
//    public class SubmissionController : Controller
//    {
//        private SubmissionDBContext db = new SubmissionDBContext();

//        // GET: Admin/Submission
//        public ActionResult Index()
//        {
//            return View(db.Submission.ToList());
//        }

//        // GET: Admin/Submission/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataSubmission dataSubmission = db.Submission.Find(id);
//            if (dataSubmission == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataSubmission);
//        }

//        // GET: Admin/Submission/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Admin/Submission/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "ID,Name,Deadline_1,Deadline_2")] DataSubmission dataSubmission)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Submission.Add(dataSubmission);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(dataSubmission);
//        }

//        // GET: Admin/Submission/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataSubmission dataSubmission = db.Submission.Find(id);
//            if (dataSubmission == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataSubmission);
//        }

//        // POST: Admin/Submission/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "ID,Name,Deadline_1,Deadline_2")] DataSubmission dataSubmission)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(dataSubmission).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(dataSubmission);
//        }

//        // GET: Admin/Submission/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataSubmission dataSubmission = db.Submission.Find(id);
//            if (dataSubmission == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataSubmission);
//        }

//        // POST: Admin/Submission/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            DataSubmission dataSubmission = db.Submission.Find(id);
//            db.Submission.Remove(dataSubmission);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
