using Newtonsoft.Json;

namespace LianOk.Docking.Core.Request
{
    public class ApiHLOrderRefundOperationRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.refund.operation";
        }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string orderNo { get; set; }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessRefundNo")]
        public string BusinessRefundNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty(PropertyName = "refundAmount")]
        public decimal RefundAmount { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 退款密码（管理密码）
        /// </summary>
        [JsonProperty(PropertyName = "refundPassword")]
        public string RefundPassword { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// 收银设备号
        /// </summary>
        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 异步通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }
    }
}