using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 自动分账规则修改
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/pgl8f6028657x6ii
    /// </summary>
    public class ApiHLBillRuleUpdateRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.rule.update";
        }

        /// <summary>
        /// 分账规则编号 新增自动分账规则成功时返回
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <summary>
        /// 分账方商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 分账接收方商户ID，火脸商户ID，在火脸服务商后台-商户列表或商家后台-门店列表，可查看该字段
        /// </summary>
        [JsonProperty(PropertyName = "receiveMerchantNo")]
        public string ReceiveMerchantNo { get; set; }
        

        /// <summary>
        /// 分账规则生效日期，精确到秒
        /// </summary>
        [JsonProperty(PropertyName = "ruleEffectiveDate")]
        public DateTime RuleEffectiveDate { get; set; }
        
        /// <summary>
        /// 分账规则结束日期，精确到秒
        /// </summary>
        [JsonProperty(PropertyName = "ruleExpiredDate")]
        public int RuleExpiredDate { get; set; }

        /// <summary>
        /// 分账比例，万分位，如10000=100%
        /// </summary>
        [JsonProperty(PropertyName = "sharePercent")]
        public int SharePercent { get; set; }

        /// <summary>
        /// 累计分账金额上限，单位元，精确到0.01
        /// </summary>
        [JsonProperty(PropertyName = "maxShareAmount")]
        public string MaxShareAmount { get; set; }
        
        /// <summary>
        /// 每月分账金额上限 单位元，精确到0.01
        /// </summary>
        [JsonProperty(PropertyName = "maxMonthShareAmount")]
        public string MaxMonthShareAmount { get; set; }

        /// <summary>
        /// 分账规则状态 0关闭 1启用 分账规则关闭，当天立即停止分账
        /// </summary>
        [JsonProperty(PropertyName = "shareRuleStatus")]
        public int ShareRuleStatus { get; set; }
    }
}