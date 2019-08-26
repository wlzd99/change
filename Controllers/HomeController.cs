using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Spire.Xls;
using System.Data;

namespace change.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "首页";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// 上传excel文件
        /// </summary>
        [HttpPost]
        public ActionResult UploadFiles()
        {
            bool b = false;
            var statuses = new List<ViewDataUploadFilesResult>();
            var headers = Request.Headers;
            if (string.IsNullOrEmpty(headers["X-File-Name"]))
            {
                b = UploadWholeFile(Request, statuses);//上传文件
            }
            if (b)//上传成功
            {
                JsonResult result = Json(statuses);
                result.ContentType = "text/plain";
                return result;
            }
            var r = new List<ViewDataUploadFilesResult>();
            return Json(r);//上传失败
        }
        private string StorageRoot
        {
            get { return Path.Combine(Server.MapPath("~/File")); }//文件上传的路径：根目录下的/Files 文件夹
        }
        private bool UploadWholeFile(HttpRequestBase request, List<ViewDataUploadFilesResult> statuses)
        {
            try
            {
                var file = request.Files[0];//文件源
                var fullPath = Path.Combine(StorageRoot, Path.GetFileName(file.FileName));//服务器文件完整路径
                file.SaveAs(fullPath);//复制文件

                Workbook workbook = new Workbook();
                workbook.LoadFromFile(fullPath);
                //读取第一个sheet
                Worksheet worksheet = workbook.Worksheets[0];
                var dt = worksheet.ExportDataTable();

                //至此：已经获取上传的Excel文件中的内容并转成DataTable，即可进行写入(导入)数据库的操作(略)     
                Session["Upload"] = dt;//存到Session,用于展示上传的excel文件中的内容

                statuses.Add(new ViewDataUploadFilesResult()
                {
                    name = file.FileName,
                    size = file.ContentLength,
                    type = file.ContentType,
                });

                return true;
            }
            catch
            {
                return false;
            }
        }
        public class ViewDataUploadFilesResult
        {
            public string name { get; set; }
            public int size { get; set; }
            public string type { get; set; }
            public string url { get; set; }
            public string delete_url { get; set; }
            public string thumbnail_url { get; set; }
            public string delete_type { get; set; }
        }
        /// <summary>
        /// 展示上传的excel文件中的内容
        /// </summary>
        public ActionResult ReadFile()
        {
            DataTable dt = Session["Upload"] as DataTable;
            string json = "";
            json += "[";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                json += "{";
                json += "\"no\":" + "\"" + dt.Rows[i]["no"].ToString() + "\"" + ",";
                json += "\"title\":" + "\"" + dt.Rows[i]["title"].ToString() + "\"" + ",";
                json += "\"note\":" + "\"" + dt.Rows[i]["note"].ToString() + "\"";
                json += "}";
                json += ",";
            }
            json = json.Substring(0, json.Length - 1);
            json += "]";
            return Content(json);
        }
    }
}