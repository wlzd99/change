using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using change;

namespace change.Controllers
{
    public class getEdiNo_sController : Controller
    {
        private changeEntities db = new changeEntities();

        // GET: getEdiNo_s
        public ActionResult Index()
        {
            return View(db.getEdiNo_s.ToList());
        }

        // GET: getEdiNo_s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            getEdiNo_s getEdiNo_s = db.getEdiNo_s.Find(id);
            if (getEdiNo_s == null)
            {
                return HttpNotFound();
            }
            return View(getEdiNo_s);
        }

        // GET: getEdiNo_s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: getEdiNo_s/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,customsCode,agentCode,entryType,userName")] getEdiNo_s getEdiNo_s)
        {
            if (ModelState.IsValid)
            {
                db.getEdiNo_s.Add(getEdiNo_s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(getEdiNo_s);
        }

        // GET: getEdiNo_s/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            getEdiNo_s getEdiNo_s = db.getEdiNo_s.Find(id);
            if (getEdiNo_s == null)
            {
                return HttpNotFound();
            }
            return View(getEdiNo_s);
        }

        // POST: getEdiNo_s/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,customsCode,agentCode,entryType,userName")] getEdiNo_s getEdiNo_s)
        {
            if (ModelState.IsValid)
            {
                db.Entry(getEdiNo_s).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(getEdiNo_s);
        }

        // GET: getEdiNo_s/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            getEdiNo_s getEdiNo_s = db.getEdiNo_s.Find(id);
            if (getEdiNo_s == null)
            {
                return HttpNotFound();
            }
            return View(getEdiNo_s);
        }

        // POST: getEdiNo_s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            getEdiNo_s getEdiNo_s = db.getEdiNo_s.Find(id);
            db.getEdiNo_s.Remove(getEdiNo_s);
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
