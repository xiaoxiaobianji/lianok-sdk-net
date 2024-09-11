using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Accredit
{
    /// <summary>
    /// 自动分账规则查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/my4snhk6ir8blk1g
    /// </summary>
    public class ApiHLBillRuleQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.bill.rule.query";
        }

        /// <summary>
        /// 分账方商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}