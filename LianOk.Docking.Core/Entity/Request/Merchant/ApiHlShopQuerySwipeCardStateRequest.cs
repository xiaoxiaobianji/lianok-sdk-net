using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 查询刷卡信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/kwfu5v838re57zqo
    /// </summary>
    public class ApiHlShopQuerySwipeCardStateRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.querySwipeCardStatus";
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
        /// 刷卡费率类型 目前只能传1
        /// </summary>
        [JsonProperty(PropertyName = "swipeType")]
        public int SwipeType { get; set; }

        /// <summary>
        /// 签名规则
        /// </summary>
        /// <returns></returns>
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}