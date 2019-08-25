using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class downloadDocumentsAttachedByCheck_sData
    {
        /// <summary>
        /// 
        /// </summary>
        public string ediNo { get; set; }
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

    public class downloadDocumentsAttachedByCheck_sRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public downloadDocumentsAttachedByCheck_sData downloadDocumentsAttachedByCheck_sdata { get; set; }
    }
}