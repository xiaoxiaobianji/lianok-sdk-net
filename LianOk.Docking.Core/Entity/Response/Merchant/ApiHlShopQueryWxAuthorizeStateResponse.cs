using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopQueryWxAuthorizeStateResponse : DockingResponseBase
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;
        /// <summary>
        /// 上游商户号
        /// </summary>
        [JsonProperty(PropertyName = "channelMerchantNo")]
        public string ChannelMerchantNo;
        /// <summary>
        /// 微信子商户号
        /// </summary>
        [JsonProperty(PropertyName = "wechatMerchantNo")]
        public string WechatMerchantNo;
        /// <summary>
        /// 授权状态
        /// AUTHORIZED：已授权
        /// UNAUTHORIZED：未授权
        /// </summary>
        [JsonProperty(PropertyName = "authorizeState")]
        public string AuthorizeState;
    }
}
