using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using change;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Zip;
using System.Text;
using System.IO;

namespace change.Controllers
{
    public class nc_getEdiNoController : Controller
    {
        private log4net.ILog log = log4net.LogManager.GetLogger("ValuesController");
        private changeEntities db = new changeEntities();

        // GET: nc_getEdiNo
        public ActionResult Index()
        {
            return View(db.nc_getEdiNo.ToList());
        }

        // GET: nc_getEdiNo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nc_getEdiNo nc_getEdiNo = db.nc_getEdiNo.Find(id);
            if (nc_getEdiNo == null)
            {
                return HttpNotFound();
            }
            return View(nc_getEdiNo);
        }

        // GET: nc_getEdiNo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nc_getEdiNo/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TextBox1,txtAdress,txtData,txtPassword,txtPrivateKey,txtPublicKey,txtSender,txtRecever,txtMiWen,txtMingWen")] nc_getEdiNo nc_getEdiNo)
        {
            if (ModelState.IsValid)
            {
                db.nc_getEdiNo.Add(nc_getEdiNo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nc_getEdiNo);
        }

        // GET: nc_getEdiNo/Edit/5
        public ActionResult Edit(int? id)
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nc_getEdiNo nc_getEdiNo = db.nc_getEdiNo.Find(id);
            if (nc_getEdiNo == null)
            {
                return HttpNotFound();
            }
            return View(nc_getEdiNo);
        }

        // POST: nc_getEdiNo/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TextBox1,txtAdress,txtData,txtPassword,txtPrivateKey,txtPublicKey,txtSender,txtRecever,txtMiWen,txtMingWen")] nc_getEdiNo nc_getEdiNo,string action)
        {
            log4net.Config.XmlConfigurator.Configure(new System.IO.FileInfo(Server.MapPath("~/Web.config")));
            if (action == "Save")
            {
                if (ModelState.IsValid)
                {
                    db.Entry(nc_getEdiNo).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nc_getEdiNo);
            }
            else if (action == "测试")
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(nc_getEdiNo.txtAdress.Trim());
                httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                httpWebRequest.Timeout = 300 * 1000;
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv 11.0) like Gecko";
                httpWebRequest.ContentType = "application/json;charset=utf8";
                httpWebRequest.Headers.Add("Accept-Encoding", "gzip,deflate");
                ServicePointManager.Expect100Continue = false;
                httpWebRequest.Headers.Add("X-SWGD-Sender", nc_getEdiNo.txtSender.Trim());
                httpWebRequest.Headers.Add("X-SWGD-Receiver", nc_getEdiNo.txtRecever.Trim());
                httpWebRequest.Headers.Add("X-SWGD-PublicKey", nc_getEdiNo.txtPublicKey.Trim());
                string txtSign = com.easipass.business.util.winx.SignUtil.getSign(nc_getEdiNo.txtPrivateKey.Trim(), nc_getEdiNo.txtData.Trim());
                string strData = "{\"data\":\"" + com.easipass.business.util.winx.AESUtil.encrypt(nc_getEdiNo.txtData.Trim(), nc_getEdiNo.txtPassword.Trim()) + "\"}";
                httpWebRequest.Headers.Add("X-SWGD-Sign", txtSign);
                httpWebRequest.Method = "POST";
                log.Info("发送头信息：：：" + httpWebRequest.Headers.ToString());
                log.Info("发送信息：：：" + strData);
                try
                {
                    byte[] dataBuff = Encoding.UTF8.GetBytes(strData);
                    httpWebRequest.ContentLength = dataBuff.Length;
                    using (Stream stream = httpWebRequest.GetRequestStream())
                    {
                        stream.Write(dataBuff, 0, dataBuff.Length);
                        stream.Close();
                    }

                    using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                    {
                        string responseContentEncoding = httpWebResponse.ContentEncoding.ToLower();
                        string response = string.Empty;
                        using (StreamReader sr = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            response = sr.ReadToEnd();
                            sr.Close();
                        }

                        httpWebResponse.Close();
                        nc_getEdiNo.TextBox1 = response;
                        log.Info("返回信息：：：" + nc_getEdiNo.TextBox1.Trim());

                    }
                    if (ModelState.IsValid)
                    {
                        db.Entry(nc_getEdiNo).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                finally
                {
                    httpWebRequest.Abort();
                }
                return RedirectToAction("edit");
            }
            else if (action == "解码")
            {
                nc_getEdiNo.txtMingWen = com.easipass.business.util.winx.AESUtil.decrypt(nc_getEdiNo.txtMiWen.Trim(), nc_getEdiNo.txtPassword.Trim());
                log.Error(nc_getEdiNo.txtMingWen.Trim());
                if (ModelState.IsValid)
                {
                    db.Entry(nc_getEdiNo).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("edit");
                //
            }
            else
            {
                return RedirectToAction("edit");
                //
            }

        }

        // GET: nc_getEdiNo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nc_getEdiNo nc_getEdiNo = db.nc_getEdiNo.Find(id);
            if (nc_getEdiNo == null)
            {
                return HttpNotFound();
            }
            return View(nc_getEdiNo);
        }

        // POST: nc_getEdiNo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nc_getEdiNo nc_getEdiNo = db.nc_getEdiNo.Find(id);
            db.nc_getEdiNo.Remove(nc_getEdiNo);
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
