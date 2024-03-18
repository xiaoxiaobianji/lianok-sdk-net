using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillRuleInfo
    {
            /// <summary>
            /// 分账方商户编号
            /// </summary>
            [JsonProperty(PropertyName = "receiveMerchantNo")]
            public string ReceiveMerchantNo { get; set; }

            /// <summary>
            /// 分账规则生效日期
            /// </summary>
            [JsonProperty(PropertyName = "ruleEffectiveDate")]
            public DateTime RuleEffectiveDate { get; set; }

            /// <summary>
            /// 分账规则结束日期
            /// </summary>
            [JsonProperty(PropertyName = "ruleExpiredDate")]
            public DateTime RuleExpiredDate { get; set; }

            /// <summary>
            /// 分账比例
            /// </summary>
            [JsonProperty(PropertyName = "sharePercent")]
            public int SharePercent { get; set; }

            /// <summary>
            /// 累计分账金额上限
            /// </summary>
            [JsonProperty(PropertyName = "maxShareAmount")]
            public string MaxShareAmount { get; set; }

            /// <summary>
            /// 每月分账金额上限
            /// </summary>
            [JsonProperty(PropertyName = "maxMonthShareAmount")]
            public string MaxMonthShareAmount { get; set; }

            /// <summary>
            /// 分账规则状态0关闭 1启用
            /// </summary>
            [JsonProperty(PropertyName = "shareRuleStatus")]
            public string ShareRuleStatus { get; set; }
    }
}