using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 同步凭证核销状态
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/gaw8p9f89e6fhvm1
    /// </summary>
    public class ApiHlAlipayCertRefundRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.cert.refund";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string merchantNo { get; set; }

        [JsonProperty(PropertyName = "bizDt")]
        public DateTime BizDt { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "openId")]
        public string OpenId { get; set; }

        [JsonProperty(PropertyName = "orderId")]
        public string OrderId { get; set; }

        [JsonProperty(PropertyName = "outBizNo")]
        public string OutBizNo { get; set; }

        [JsonProperty(PropertyName = "useOrderNoList")]
        public List<string> UseOrderNoList { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}