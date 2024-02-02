using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// 小程序支付
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/yzixvetryt0lkkwt
    /// </summary>
    public class ApiHlOrderPayAppletRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pay.applet";
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
        /// 微信小程序AppId
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// 微信用户标识
        /// </summary>
        [JsonProperty(PropertyName = "openId")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户标识
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// 收银设备ID
        /// </summary>
        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo { get; set; }

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
        /// 订单失效时间，单位为秒，精确到个位
        /// 火脸默认订单失效时间为10分钟
        /// 失效时间需大于60秒
        /// </summary>
        [JsonProperty(PropertyName = "payExpireTime")]
        public int? PayExpireTime { get; set; }

        /// <summary>
        /// 花呗分期数
        /// </summary>
        [JsonProperty(PropertyName = "stageNum")]
        public int? StageNum { get; set; }

        /// <summary>
        /// 订单优惠标记
        /// </summary>
        [JsonProperty(PropertyName = "goodsTag")]
        public string GoodsTag { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [JsonProperty(PropertyName = "goods_info")]
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 订单分账标识
        /// </summary>
        [JsonProperty(PropertyName = "shareMarkFlag")]
        public int? ShareMarkFlag { get; set; }

        /// <summary>
        /// 收银设备端真实IP
        /// </summary>
        [JsonProperty(PropertyName = "clientIp")]
        public string ClientIp { get; set; }
    }
}