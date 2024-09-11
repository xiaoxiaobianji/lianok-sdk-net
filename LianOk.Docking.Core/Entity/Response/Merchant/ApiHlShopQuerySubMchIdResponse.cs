using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopQuerySubMchIdResponse : DockingResponseBase
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode;

        /// <summary>
        /// 支付宝子商户号
        /// </summary>
        [JsonProperty(PropertyName = "alipayMerchantNo")]
        public string AlipayMerchantNo;

        /// <summary>
        /// 微信子商户号
        /// </summary>
        [JsonProperty(PropertyName = "wechatMerchantNo")]
        public string WechatMerchantNo;
    }
}