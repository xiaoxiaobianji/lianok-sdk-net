using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 分时结算开通
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/si5devmm2yo4430s
    /// </summary>
    public class ApiHlShopSettlePeriodSetRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.settle.period.set";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 申请分时结算周期
        /// </summary>
        [JsonProperty(PropertyName = "applySettlePeriod")]
        public int ApplySettlePeriod { get; set; }

        /// <summary>
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetSignByJsonStringMethod()
        {
            return true;
        }
    }
}
