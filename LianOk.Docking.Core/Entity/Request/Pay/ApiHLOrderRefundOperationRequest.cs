using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// 退款
    ///
    /// 参考:https://www.yuque.com/youyun-8yqqt/vpbgq7/zhbb2ak9sihvuozo
    /// </summary>
    public class ApiHlOrderRefundOperationRequest : DockingRequestBase
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
        /// 渠道订单号，
        /// 如乐刷订单号、随行付订单号等
        /// 与火脸订单号、对接商系统订单号3选1
        /// </summary>
        [JsonProperty(PropertyName = "channelOrderNo")]
        public string ChannelOrderNo { get; set; }

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

        /// <summary>
        /// 退款出资模式，默认为0
        /// 0：使用待分账账户余额退款
        /// 1：使用待结算账户余额退款
        /// </summary>
        [JsonProperty(PropertyName = "shareRefundMode")]
        public int? ShareRefundMode { get; set; }

        /// <summary>
        /// 退款出资详情，list格式并且需要转化为string，一次请求不可超过50个分账接收方且分账接收方不可重复
        /// </summary>
        [JsonProperty(PropertyName = "refundDetails")]
        public string RefundDetails { get; set; }
    }
}