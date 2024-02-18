using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Pay
{
    [Serializable]
    public class ApiHlOrderPayUnifiedResponse : DockingResponseBase
    {
        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 跳转支付地址
        /// </summary>
        [JsonProperty(PropertyName = "payUrl")]
        public string PayUrl { get; set; }
    }
}