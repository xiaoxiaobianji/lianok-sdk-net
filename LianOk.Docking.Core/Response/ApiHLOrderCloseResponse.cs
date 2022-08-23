using Newtonsoft.Json;

namespace LianOk.Docking.Core.Response
{
    public class ApiHLOrderCloseResponse : DockingResponseBase
    {
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
        /// 对接商系统订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// 3关单成功
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public int? State { get; set; }
    }
}