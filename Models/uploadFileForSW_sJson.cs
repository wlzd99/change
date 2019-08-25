using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class uploadFileForSW_sJsonData
    {
        /// <summary>
        /// 
        /// </summary>
        public string ediNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string edoccode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tradeFileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fileDigest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string declCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string declName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string signunit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> datas { get; set; }
    }

    public class uploadFileForSW_sJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public uploadFileForSW_sJsonData uploadFileForSW_sJsondata { get; set; }
    }
}