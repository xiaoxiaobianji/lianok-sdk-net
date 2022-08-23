using Newtonsoft.Json;

namespace LianOk.Docking.Core.Request
{
    public class ApiHLOrderPayDetailsRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pay.details";
        }

        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [JsonProperty(PropertyName = "channelOrderNo")]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// 对接商系统订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }
    }
}