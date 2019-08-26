using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{

    public class downloadDocumentsAttachedByCheck_rJsonDocAttachedInfosItem
    {
    }

    public class downloadDocumentsAttachedByCheck_rJsonData
    {
        /// <summary>
        /// 
        /// </summary>
        public List<downloadDocumentsAttachedByCheck_rJsonDocAttachedInfosItem> DocAttachedInfos { get; set; }
    }

    public class downloadDocumentsAttachedByCheck_rJsonRoot
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
        public downloadDocumentsAttachedByCheck_rJsonData data { get; set; }
    }
}