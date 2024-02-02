using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// 银行卡支付
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/tcb85rigyan22qwb
    /// </summary>
    public class ApiHlOrderPayBankRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pay.bank";
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
        /// 商品名称
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 支付方式,默认支持所有支付方式
        /// alipay(支付宝)，wechat(微信)，cloud(云闪付)
        /// </summary>
        [JsonProperty(PropertyName = "payWay")]
        public string PayWay { get; set; }

        /// <summary>
        /// 银行卡绑定的手机号
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 订单失效时间
        /// 失效时间范围60秒~600秒
        /// </summary>
        [JsonProperty(PropertyName = "payExpireTime")]
        public int? PayExpireTime { get; set; }

        /// <summary>
        /// 支付成功页面跳转地址
        /// </summary>
        [JsonProperty(PropertyName = "pageNotifyUrl")]
        public string pageNotifyUrl { get; set; }

        /// <summary>
        /// 银行卡信息
        /// </summary>
        [JsonProperty(PropertyName = "bankCard")]
        public string BankCard { get; set; }

        /// <summary>
        /// 银行卡类型(非必填):
        /// DEBIT: 借记卡
        /// CREDIT: 信用卡
        /// 不限制支付卡种值可不传
        /// </summary>
        [JsonProperty(PropertyName = "cardType")]
        public string CardType { get; set; }
    }
}