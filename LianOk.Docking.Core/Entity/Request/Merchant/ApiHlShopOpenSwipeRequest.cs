using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 开通刷卡费率
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/grcbd6qlokbu4i6d
    /// </summary>
    public class ApiHlShopOpenSwipeRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.openSwipe";
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
        /// 刷卡费率类型 目前只能传1
        /// </summary>
        [JsonProperty(PropertyName = "swipeType")]
        public int SwipeType { get; set; }
        /// <summary>
        /// 借记卡费率 例：万分之一 : 0.0001
        /// </summary>
        [JsonProperty(PropertyName = "unionDebitRate")]
        public decimal UnionDebitRate { get; set; }
        /// <summary>
        /// 贷记卡费率 例：万分之一 : 0.0001
        /// </summary>
        [JsonProperty(PropertyName = "unionCreditRate")]
        public decimal UnionCreditRate { get; set; }
    }
}
