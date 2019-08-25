using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class getEdiNo_sJsonData
    {
        /// <summary>
        /// 申报口岸
        /// </summary>
        public string customsCode { get; set; }
        /// <summary>
        /// 申报企业海关代码
        /// </summary>
        public string agentCode { get; set; }
        /// <summary>
        /// 报关单类型
        /// </summary>
        public string entryType { get; set; }
        /// <summary>
        /// 海关账号
        /// </summary>
        public string userName { get; set; }
    }

    public class getEdiNo_sJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public getEdiNo_sJsonData data { get; set; }
    }
}