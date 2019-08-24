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
    public class 代理委托Controller : Controller
    {
        private changeEntities db = new changeEntities();

        // GET: 代理委托
        public ActionResult Index()
        {
            return View(db.代理委托.ToList());
        }

        // GET: 代理委托/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            代理委托 代理委托 = db.代理委托.Find(id);
            if (代理委托 == null)
            {
                return HttpNotFound();
            }
            return View(代理委托);
        }

        // GET: 代理委托/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 代理委托/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,oid,ediNo,userName,copCusCode,gname,codeTS,declTotal,iEDate,listNo,tradeMode,curr,oriCountry,otherNote,consignIcCode,consignIcName,consignPhone,consignDate,entryId,cusCode,decEntryId,receiveDate,edocCode,otherRecInfo,declarePrice,promiseNote,declIcCode,declIcName,declTele,note,payerCode,tradeCode,agentCode")] 代理委托 代理委托)
        {
            if (ModelState.IsValid)
            {
                db.代理委托.Add(代理委托);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(代理委托);
        }

        // GET: 代理委托/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            代理委托 代理委托 = db.代理委托.Find(id);
            if (代理委托 == null)
            {
                return HttpNotFound();
            }
            return View(代理委托);
        }

        // POST: 代理委托/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,oid,ediNo,userName,copCusCode,gname,codeTS,declTotal,iEDate,listNo,tradeMode,curr,oriCountry,otherNote,consignIcCode,consignIcName,consignPhone,consignDate,entryId,cusCode,decEntryId,receiveDate,edocCode,otherRecInfo,declarePrice,promiseNote,declIcCode,declIcName,declTele,note,payerCode,tradeCode,agentCode")] 代理委托 代理委托)
        {
            if (ModelState.IsValid)
            {
                db.Entry(代理委托).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(代理委托);
        }

        // GET: 代理委托/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            代理委托 代理委托 = db.代理委托.Find(id);
            if (代理委托 == null)
            {
                return HttpNotFound();
            }
            return View(代理委托);
        }

        // POST: 代理委托/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            代理委托 代理委托 = db.代理委托.Find(id);
            db.代理委托.Remove(代理委托);
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
