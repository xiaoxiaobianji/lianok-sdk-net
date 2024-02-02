using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// 退款详情
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/kn3py57ohwhdgyc4
    /// </summary>
    public class ApiHlOrderRefundDetailsRequest : DockingRequestBase
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