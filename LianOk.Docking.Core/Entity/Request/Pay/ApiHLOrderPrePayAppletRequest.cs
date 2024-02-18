using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// 小程序托管下单支付
    ///
    /// https://www.yuque.com/youyun-8yqqt/vpbgq7/zmtd89sk31rwzpnm
    /// </summary>
    public class ApiHlOrderPrePayAppletRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pre.pay.applet";
        }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }

        /// <summary>
        /// 对接商系统订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 订单支付金额
        /// </summary>
        [JsonProperty(PropertyName = "payAmount")]
        public decimal PayAmount { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [JsonProperty(PropertyName = "payWay")]
        public string PayWay { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 异步通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单失效时间
        /// </summary>
        [JsonProperty(PropertyName = "payExpireTime")]
        public int? PayExpireTime { get; set; }

        /// <summary>
        /// 订单优惠标记
        /// </summary>
        [JsonProperty(PropertyName = "goodsTag")]
        public string GoodsTag { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [JsonProperty(PropertyName = "goodsInfo")]
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 订单分账标识
        /// </summary>
        [JsonProperty(PropertyName = "shareMarkFlag")]
        public string ShareMarkFlag { get; set; }

        /// <summary>
        /// 收银设备端真实IP
        /// </summary>
        [JsonProperty(PropertyName = "clientIp")]
        public string ClientIp { get; set; }
    }
}