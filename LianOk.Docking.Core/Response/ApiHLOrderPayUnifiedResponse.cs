using Newtonsoft.Json;

namespace LianOk.Docking.Core.Response
{
    public class ApiHLOrderPayUnifiedResponse : DockingResponseBase
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