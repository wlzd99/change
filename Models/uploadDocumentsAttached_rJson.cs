using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class uploadDocumentsAttached_rJsonRoot
    {
        /// <summary>
        /// 状态T：成功F：失败
        /// </summary>
        public string flag { get; set; }
        /// <summary>
        /// 响应代码
        /// </summary>
        public string errorCode { get; set; }
        /// <summary>
        /// 响应信息  
        /// </summary>
        public string errorInfo { get; set; }
    }
}