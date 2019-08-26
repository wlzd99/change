using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class downloadPDF_sJsonData
    {
        /// <summary>
        /// 
        /// </summary>
        public string ediNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fileType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string signunit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string icCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userName { get; set; }
    }

    public class downloadPDF_sJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public downloadPDF_sJsonData data { get; set; }
    }

}