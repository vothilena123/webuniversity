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
//    public class CategoryController : Controller
//    {
//        private SubmissionDBContext db = new SubmissionDBContext();

//        // GET: Admin/Category
//        public ActionResult Index()
//        {
//            return View(db.Category.ToList());
//        }

//        // GET: Admin/Category/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataCategory dataCategory = db.Category.Find(id);
//            if (dataCategory == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataCategory);
//        }

//        // GET: Admin/Category/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Admin/Category/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "ID,Name")] DataCategory dataCategory)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Category.Add(dataCategory);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(dataCategory);
//        }

//        // GET: Admin/Category/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataCategory dataCategory = db.Category.Find(id);
//            if (dataCategory == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataCategory);
//        }

//        // POST: Admin/Category/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "ID,Name")] DataCategory dataCategory)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(dataCategory).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(dataCategory);
//        }

//        // GET: Admin/Category/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataCategory dataCategory = db.Category.Find(id);
//            if (dataCategory == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataCategory);
//        }

//        // POST: Admin/Category/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            DataCategory dataCategory = db.Category.Find(id);
//            db.Category.Remove(dataCategory);
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
