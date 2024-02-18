using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Pay
{
    [Serializable]
    public class ApiHlOrderPayNativeResponse : DockingResponseBase
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
        [JsonProperty(PropertyName = "qrCodeUrl")]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }
    }
}