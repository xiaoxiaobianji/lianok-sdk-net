using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// H5预下单
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/hd33nkqkl9w7ooys
    /// </summary>
    public class ApiHlOrderPayH5Request : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pay.h5";
        }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        /// <summary>
        /// 订单支付金额
        /// </summary>
        [JsonProperty(PropertyName = "payAmount")]
        public decimal PayAmount { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

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
        /// 异步通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 支付方式
        /// wechat 微信
        /// alipay 支付宝
        /// </summary>
        [JsonProperty(PropertyName = "payWay")]
        public string PayWay { get; set; }

        /// <summary>
        /// 支付成功页面跳转地址
        /// </summary>
        [JsonProperty(PropertyName = "pageNotifyUrl")]
        public string PageNotifyUrl { get; set; }

        /// <summary>
        /// 收银设备端真实IP
        /// </summary>
        [JsonProperty(PropertyName = "clientIp")]
        public string ClientIp { get; set; }

        /// <summary>
        /// 商品金额
        /// </summary>
        [JsonProperty(PropertyName = "itemAmount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonProperty(PropertyName = "itemQuantity")]
        public string ItemQuantity { get; set; }
    }
}