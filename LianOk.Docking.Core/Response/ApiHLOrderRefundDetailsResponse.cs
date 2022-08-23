using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Core.Response
{
    public class ApiHLOrderRefundDetailsResponse : DockingResponseBase
    {
        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款订单号
        /// </summary>
        [JsonProperty(PropertyName = "refundNo")]
        public string RefundNo { get; set; }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 对接商业务退单号
        /// </summary>
        [JsonProperty(PropertyName = "businessRefundNo")]
        public string BusinessRefundNo { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty(PropertyName = "refundAmount")]
        public decimal? RefundAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonProperty(PropertyName = "refundTime")]
        public DateTime? RefundTime { get; set; }

        /// <summary>
        /// 订单状态
        /// 0:待支付, 1:支付中, 2:支付成功, 3:交易关闭, 4:部分退款, 5:全部退款
        /// </summary>
        [JsonProperty(PropertyName = "refundStatus")]
        public int RefundStatus { get; set; }

        /// <summary>
        /// 退款方式
        /// alipay(支付宝)，wechat(微信)，cloud(云闪付)
        /// </summary>
        [JsonProperty(PropertyName = "payWay")]
        public string PayWay { get; set; }

        /// <summary>
        /// 退单备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 收银员编号
        /// </summary>
        [JsonProperty(PropertyName = "cashierNo")]
        public string CashierNo { get; set; }

        /// <summary>
        /// 收银设备
        /// </summary>
        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 渠道退单号
        /// </summary>
        [JsonProperty(PropertyName = "channelRefundNo")]
        public string ChannelRefundNo { get; set; }

        /// <summary>
        /// 退款手续费金额
        /// </summary>
        [JsonProperty(PropertyName = "serviceFee")]
        public decimal? ServiceFee { get; set; }

        /// <summary>
        /// 商家优惠退款金额
        /// </summary>
        [JsonProperty(PropertyName = "benefitAmount")]
        public decimal? BenefitAmount { get; set; }
    }
}