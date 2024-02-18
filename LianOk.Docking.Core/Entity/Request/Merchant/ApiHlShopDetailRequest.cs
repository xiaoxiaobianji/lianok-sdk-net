using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Merchant
{
    /// <summary>
    /// 商户资料查询
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/tl0g2h100dgveshg
    /// </summary>
    public class ApiHlShopDetailRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.detail";
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
    }
}
