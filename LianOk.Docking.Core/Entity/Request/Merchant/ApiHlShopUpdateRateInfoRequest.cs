using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 修改费率信息
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/dchgeqhxq49qf50k
    /// </summary>
    public class ApiHlShopUpdateRateInfoRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.update.rateInfo";
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
        /// 异步通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }
        /// <summary>
        /// 支付宝费率 万分之一 : 0.0001
        /// </summary>
        [JsonProperty(PropertyName = "alipayRate")]
        public decimal AlipayRate { get; set; }
        /// <summary>
        /// 微信费率 万分之一 : 0.0001
        /// </summary>
        [JsonProperty(PropertyName = "wechatPayRate")]
        public decimal WechatPayRate { get; set; }
        /// <summary>
        /// 云闪付费率1000以下 万分之一 : 0.0001
        /// </summary>
        [JsonProperty(PropertyName = "cloudPayLe1000Rate")]
        public decimal CloudPayLe1000Rate { get; set; }
        /// <summary>
        /// 云闪付费率1000以上 万分之一 : 0.0001
        /// </summary>
        [JsonProperty(PropertyName = "cloudPayGt1000Rate")]
        public decimal CloudPayGt1000Rate { get; set; }

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
