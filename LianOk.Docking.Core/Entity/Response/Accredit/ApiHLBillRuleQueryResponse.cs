using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillRuleQueryResponse : DockingResponseBase
    {
        /// <summary>
        /// 分账规则详情
        /// </summary>
        [JsonProperty(PropertyName = "ruleList")]
        public List<HlBillRuleInfo> RuleList { get; set; }
    } 
}