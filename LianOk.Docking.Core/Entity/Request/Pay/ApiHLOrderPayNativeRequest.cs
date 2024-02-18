using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.Pay
{
    /// <summary>
    /// 预下单
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/euo6xgekbgo64ws0
    /// </summary>
    public class ApiHlOrderPayNativeRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pay.native";
        }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo;

        /// <summary>
        /// 订单支付金额
        /// </summary>
        [JsonProperty(PropertyName = "payAmount")]
        public decimal PayAmount;

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty(PropertyName = "remark")]
        public string Remark;

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        /// <summary>
        /// 操作者账号
        /// </summary>
        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount;

        /// <summary>
        /// 收银设备号
        /// </summary>
        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo;

        /// <summary>
        /// 异步通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl;

        /// <summary>
        /// 花呗分期数, 支持3、6、12期
        /// </summary>
        [JsonProperty(PropertyName = "stageNum")]
        public int? StageNum;

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject;

        /// <summary>
        /// 支付方式,默认支持所有支付方式
        /// alipay(支付宝)，wechat(微信)，cloud(云闪付)
        /// </summary>
        [JsonProperty(PropertyName = "payWay")]
        public string PayWay;

        /// <summary>
        /// 订单失效时间
        /// 失效时间范围60秒~600秒
        /// </summary>
        [JsonProperty(PropertyName = "payExpireTime")]
        public int? PayExpireTime;

        /// <summary>
        /// 商品详情
        /// </summary>
        [JsonProperty(PropertyName = "goodsInfo")]
        public string GoodsInfo;

        /// <summary>
        /// 收银设备端真实IP
        /// </summary>
        [JsonProperty(PropertyName = "clientIp")]
        public string ClientIp;
    }
}