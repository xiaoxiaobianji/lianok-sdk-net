using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Period
{
    /// <summary>
    /// 分时结算开通
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/si5devmm2yo4430s
    /// </summary>
    public class ApiHLBillSettlePeriodSetRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.settle.period.set";
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

        /// <summary>
        /// 申请分时结算周期每个通道支持设置的分时结算周期不相同,可传值范围说明见下方说明
        /// </summary>
        [JsonProperty(PropertyName = "applySettlePeriod")]
        public String ApplySettlePeriod { get; set; }
    }
}