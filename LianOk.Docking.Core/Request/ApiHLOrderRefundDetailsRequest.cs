using Newtonsoft.Json;

namespace LianOk.Docking.Core.Request
{
    public class ApiHLOrderRefundDetailsRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.refund.details";
        }

        /// <summary>
        /// 火脸退单号
        /// </summary>
        [JsonProperty(PropertyName = "refundNo")]
        public string refundNo { get; set; }

        /// <summary>
        /// 渠道退单号
        /// </summary>
        [JsonProperty(PropertyName = "channelRefundNo")]
        public string channelRefundNo { get; set; }

        /// <summary>
        /// 对接商系统退单号
        /// </summary>
        [JsonProperty(PropertyName = "businessRefundNo")]
        public string businessRefundNo { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string merchantNo { get; set; }
    }
}