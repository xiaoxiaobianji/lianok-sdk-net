﻿using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopQueryZfbAuthorizeStateResponse : DockingResponseBase
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
        /// 支付宝子商户号
        /// </summary>
        [JsonProperty(PropertyName = "alipayMerchantNo")]
        public string AlipayMerchantNo;

        /// <summary>
        /// 授权状态
        /// AUTHORIZED：已授权
        /// UNAUTHORIZED：未授权
        /// </summary>
        [JsonProperty(PropertyName = "authorizeState")]
        public string AuthorizeState;
    }
}