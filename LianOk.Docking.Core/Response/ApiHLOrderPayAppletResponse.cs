using Newtonsoft.Json;

namespace LianOk.Docking.Core.Response
{
    public class ApiHLOrderPayAppletResponse : DockingResponseBase
    {
        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 对接商系统订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 微信支付5要素或支付宝TradeNO,
        /// 用于唤起微信、支付宝小程序的支付组件
        /// </summary>
        [JsonProperty(PropertyName = "jsPayInfo")]
        public string JsPayInfo { get; set; }
    }
}