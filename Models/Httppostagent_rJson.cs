using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class Httppostagent_rJsonData
    {
        /// <summary>
        /// EDI单据编号
        /// </summary>
        public string ediNo { get; set; }
        /// <summary>
        /// 委托协议号
        /// </summary>
        public string conSignNo { get; set; }
        /// <summary>
        /// 响应代码
        /// </summary>
        public string responseCode { get; set; }
        /// <summary>
        /// 响应信息
        /// </summary>
        public string responseNotes { get; set; }
        /// <summary>
        /// 通知时间
        /// </summary>
        public string dataResult { get; set; }
    }

    public class Httppostagent_rJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public string msgType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Httppostagent_rJsonData Httppostagent_rJsondata { get; set; }
    }
}