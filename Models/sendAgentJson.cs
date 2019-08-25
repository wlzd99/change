using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class T_SWGD_AGENT_LIST
    {
        /// <summary>
        /// 
        /// </summary>
        public string ediNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string copCusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string gname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string codeTS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string declTotal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string iEDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string listNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tradeMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string curr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string oriCountry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string otherNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consignIcCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consignIcName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consignPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consignDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string entryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cusCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string decEntryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string receiveDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string edocCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string otherRecInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string declarePrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string promiseNote { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string declIcCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string declIcName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string declTele { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string note { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string payerCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tradeCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string agentCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string userName { get; set; }
    }

    public class sendAgentJsonData
    {
        /// <summary>
        /// 
        /// </summary>
        public T_SWGD_AGENT_LIST T_SWGD_AGENT_LIST { get; set; }
    }

    public class sendAgentJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public sendAgentJsonData sendAgentJsondata { get; set; }
    }
}