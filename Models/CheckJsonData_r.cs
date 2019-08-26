using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class CheckJsonData_rErrorListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string ErrorCode { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMsg { get; set; }
        /// <summary>
        /// 错误的节点名
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Line { get; set; }
        /// <summary>
        /// 错误的字段名称
        /// </summary>
        public string ClientId { get; set; }
    }

    public class CheckJsonData_rData
    {
        /// <summary>
        /// 
        /// </summary>
        public List<CheckJsonData_rErrorListItem> ErrorList { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CheckSucc { get; set; }
    }

    public class CheckJsonData_rRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public string flag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string errorCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string errorInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CheckJsonData_rData data { get; set; }
    }
}