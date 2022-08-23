using Newtonsoft.Json;

namespace LianOk.Docking.Core.Request
{
    public class ApiHLOrderPayBarcodeRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pay.barcode";
        }

        /// <summary>
        /// 对接商业务订单号
        /// </summary>
        [JsonProperty(PropertyName = "payBarcode")]
        public string PayBarcode { get; set; }

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
        /// 花呗分期数, 支持3、6、12期
        /// </summary>
        [JsonProperty(PropertyName = "stageNum")]
        public int? StageNum { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 限制卡类型, 默认值 0
        /// 0 全部支持 1 限定不能使用信用卡支付
        /// </summary>
        [JsonProperty(PropertyName = "limitPay")]
        public int? LimitPay { get; set; }

        /// <summary>
        /// 订单失效时间
        /// 失效时间范围60秒~600秒
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
        public string goodsInfo { get; set; }
    }
}