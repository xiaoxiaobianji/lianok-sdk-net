using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Pay
{
    [Serializable]
    public class ApiHlOrderPayBarcodeResponse : DockingResponseBase
    {
        /// <summary>
        /// 火脸订单号
        /// </summary>
        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 通道订单号
        /// 微信订单号、支付宝订单号等，当支付成功时返回
        /// </summary>
        [JsonProperty(PropertyName = "topChannelOrderNo")]
        public string TopChannelOrderNo { get; set; }

        /// <summary>
        /// 渠道订单号
        /// 如乐刷订单号、随行付订单号等
        /// 当支付成功后返回
        /// </summary>
        [JsonProperty(PropertyName = "channelOrderNo")]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 订单支付金额
        /// </summary>
        [JsonProperty(PropertyName = "payAmount")]
        public decimal? PayAmount { get; set; }

        /// <summary>
        /// 商家实收金额，单位为元
        /// </summary>
        [JsonProperty(PropertyName = "actualAmount")]
        public decimal? ActualAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonProperty(PropertyName = "payTime")]
        public DateTime? PayTime { get; set; }

        /// <summary>
        /// 订单状态
        /// 0:待支付, 1:支付中, 2:支付成功, 3:交易关闭, 4:部分退款, 5:全部退款
        /// </summary>
        [JsonProperty(PropertyName = "orderStatus")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 收银员编号
        /// </summary>
        [JsonProperty(PropertyName = "cashierNo")]
        public string CashierNo { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 付款用户id，“微信openid”、“支付宝账户”等，当支付成功时返回
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// 商家优惠金额，
        /// 消费者使用商家免充值代金券优惠部分金额
        /// </summary>
        [JsonProperty(PropertyName = "benefitAmount")]
        public decimal? BenefitAmount { get; set; }

        /// <summary>
        /// 官方优惠金额，
        /// 消费者使用商家预充值代金券优惠部分金额
        /// </summary>
        [JsonProperty(PropertyName = "officialCouponAmount")]
        public decimal? OfficialCouponAmount { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [JsonProperty(PropertyName = "promotions")]
        public List<HlOrderPromotions> Promotions { get; set; }
    }
}