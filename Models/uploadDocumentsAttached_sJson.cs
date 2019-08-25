using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class uploadDocumentsAttached_sJsonDataItem
    {
        /// <summary>
        /// 预录入编号
        /// </summary>
        public string preEntryId { get; set; }
        /// <summary>
        /// 随附单据名称
        /// </summary>
        public string fileName { get; set; }
        /// <summary>
        /// 上传人员名称
        /// </summary>
        public string declName { get; set; }
        /// <summary>
        /// 证书名称
        /// </summary>
        public string signCert { get; set; }
        /// <summary>
        /// 随附单据格式类型
        /// </summary>
        public string formatType { get; set; }
        /// <summary>
        /// 签名单位代码
        /// </summary>
        public string signUnit { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public string operFlag { get; set; }
        /// <summary>
        /// 回执文件名
        /// </summary>
        public string edocOwnerCode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string opNote { get; set; }
        /// <summary>
        /// 关区
        /// </summary>
        public string customsCode { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string edocOwnerName { get; set; }
        /// <summary>
        /// 随附单据类型
        /// </summary>
        public string fileType { get; set; }
        /// <summary>
        /// 海关账号
        /// </summary>
        public string loginName { get; set; }
        /// <summary>
        /// 数据中心统一编号
        /// </summary>
        public string declType { get; set; }
        /// <summary>
        /// 报关员号
        /// </summary>
        public string declCode { get; set; }
        /// <summary>
        /// 上传时间
        /// </summary>
        public string declTime { get; set; }
        /// <summary>
        /// 预录入编号
        /// </summary>
        public string entryId { get; set; }
        /// <summary>
        /// 经营单位代码
        /// </summary>
        public string tradeCode { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string dataSource { get; set; }
    }

    public class uploadDocumentsAttached_sJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public List<uploadDocumentsAttached_sJsonDataItem> uploadDocumentsAttached_sJsondata { get; set; }
    }
}