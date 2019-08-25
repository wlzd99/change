using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace change.Models
{
    public class queryFormResultJsonData
    {
        /// <summary>
        /// 
        /// </summary>
        public string ediNo { get; set; }
    }

    public class queryFormResultJsonRoot
    {
        /// <summary>
        /// 
        /// </summary>
        public queryFormResultJsonData queryFormResultJsondata { get; set; }
    }
}