using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class queryFormResult_rJsonListItem
    {
        /// <summary>
        /// EDI单据编号
        /// </summary>
        public string ediNo { get; set; }
        /// <summary>
        /// 预录入编号
        /// </summary>
        public string preEntryId { get; set; }
        /// <summary>
        /// 海关帐号
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// 录入企业代码
        /// </summary>
        public string loginTradecode { get; set; }
        /// <summary>
        /// 数据中心统一编号
        /// </summary>
        public string seqNo { get; set; }
        /// <summary>
        /// 通知时间
        /// </summary>
        public string noticeDate { get; set; }
        /// <summary>
        /// 处理结果
        /// </summary>
        public string channel { get; set; }
        /// <summary>
        /// 审核备注
        /// </summary>
        public string note { get; set; }
        /// <summary>
        /// 申报口岸
        /// </summary>
        public string declPort { get; set; }
        /// <summary>
        /// 进出口日期
        /// </summary>
        public string iEDate { get; set; }
        /// <summary>
        /// 申报日期
        /// </summary>
        public string dDate { get; set; }
        /// <summary>
        /// 回执文件名
        /// </summary>
        public string fileName { get; set; }
        /// <summary>
        /// 关检关联号
        /// </summary>
        public string cusCiqNo { get; set; }
    }

    public class queryFormResult_rJsonDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<queryFormResult_rJsonListItem> List { get; set; }
    }

    public class queryFormResult_rJsonRoot
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
        public List<queryFormResult_rJsonDataItem> data { get; set; }
    }
}