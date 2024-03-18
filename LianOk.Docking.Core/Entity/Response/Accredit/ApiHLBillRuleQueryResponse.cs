using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillRuleQueryResponse : DockingResponseBase
    {
        /// <summary>
        /// 分账规则详情
        /// </summary>
        [JsonProperty(PropertyName = "ruleList")]
        public List<ApiHLBillRuleInfo> RuleList { get; set; }
    } 
}