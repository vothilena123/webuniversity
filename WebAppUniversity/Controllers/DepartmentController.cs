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
//    public class DepartmentController : Controller
//    {
//        private SubmissionDBContext db = new SubmissionDBContext();

//        // GET: Admin/Department
//        public ActionResult Index()
//        {
//            return View(db.Department.ToList());
//        }

//        // GET: Admin/Department/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataDepartment dataDepartment = db.Department.Find(id);
//            if (dataDepartment == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataDepartment);
//        }

//        // GET: Admin/Department/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Admin/Department/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "ID,Name")] DataDepartment dataDepartment)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Department.Add(dataDepartment);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(dataDepartment);
//        }

//        // GET: Admin/Department/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataDepartment dataDepartment = db.Department.Find(id);
//            if (dataDepartment == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataDepartment);
//        }

//        // POST: Admin/Department/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "ID,Name")] DataDepartment dataDepartment)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(dataDepartment).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            return View(dataDepartment);
//        }

//        // GET: Admin/Department/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            DataDepartment dataDepartment = db.Department.Find(id);
//            if (dataDepartment == null)
//            {
//                return HttpNotFound();
//            }
//            return View(dataDepartment);
//        }

//        // POST: Admin/Department/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            DataDepartment dataDepartment = db.Department.Find(id);
//            db.Department.Remove(dataDepartment);
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
