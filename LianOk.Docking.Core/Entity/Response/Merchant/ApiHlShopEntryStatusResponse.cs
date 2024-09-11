using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopEntryStatusResponse : DockingResponseBase
    {
        /// <summary>
        /// 渠道商户号
        /// </summary>
        [JsonProperty(PropertyName = "channelMerchantNo")]
        public string ChannelMerchantNo;

        /// <summary>
        /// 微信子商户号
        /// </summary>
        [JsonProperty(PropertyName = "wechatMerchantNo")]
        public string WechatMerchantNo;

        /// <summary>
        /// 支付宝子商户号
        /// </summary>
        [JsonProperty(PropertyName = "alipayMerchantNo")]
        public string AlipayMerchantNo;

        /// <summary>
        /// 进件状态
        /// -1 未开通
        /// 0 预审核中
        /// 1 平台驳回
        /// 2 通道审核中
        /// 3 通道驳回
        /// 4 通过
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status;

        /// <summary>
        /// 驳回原因
        /// </summary>
        [JsonProperty(PropertyName = "rejectReason")]
        public string RejectReason;

        /// <summary>
        /// 渠道认证二维码 审核通过后返回
        /// </summary>
        [JsonProperty(PropertyName = "qrcodeData")]
        public string QrcodeData;

        /// <summary>
        /// 商户管理密码
        /// </summary>
        [JsonProperty(PropertyName = "refundPassword")]
        public string RefundPassword;
    }
}