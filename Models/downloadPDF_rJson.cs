using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class downloadPDF_rJsonData
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> ret { get; set; }
    }

    public class downloadPDF_rJsonRoot
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
        public downloadPDF_rJsonData data { get; set; }
    }
}