using Newtonsoft.Json;

namespace LianOk.Docking.Core.Request
{
    public class ApiHLOrderPayAppletRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.order.pay.applet";
        }

        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "operatorAccount")]
        public string OperatorAccount { get; set; }

        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        [JsonProperty(PropertyName = "payAmount")]
        public decimal PayAmount { get; set; }

        [JsonProperty(PropertyName = "payWay")]
        public string PayWay { get; set; }

        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        [JsonProperty(PropertyName = "openId")]
        public string OpenId { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "deviceNo")]
        public string DeviceNo { get; set; }

        [JsonProperty(PropertyName = "remark")]
        public string Remark { get; set; }

        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "payExpireTime")]
        public int? PayExpireTime { get; set; }

        [JsonProperty(PropertyName = "stageNum")]
        public int? StageNum { get; set; }

        [JsonProperty(PropertyName = "goodsTag")]
        public string GoodsTag { get; set; }

        [JsonProperty(PropertyName = "goods_info")]
        public object GoodsInfo { get; set; }
    }
}