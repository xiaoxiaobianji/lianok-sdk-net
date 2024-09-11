using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 同步凭证核销状态
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/fvqlrggs1345isv5
    /// </summary>
    public class ApiHlAlipayCertUseRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.cert.use";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "bizDt")]
        public DateTime BizDt { get; set; }

        [JsonProperty(PropertyName = "certificateUseInfoList")]
        public List<CertificateUseInfo> CertificateUseInfoList { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "openId")]
        public string OpenId { get; set; }

        [JsonProperty(PropertyName = "orderId")]
        public string OrderId { get; set; }

        [JsonProperty(PropertyName = "outBizNo")]
        public string OutBizNo { get; set; }

        [JsonProperty(PropertyName = "outOrderId")]
        public string OutOrderId { get; set; }

        [JsonProperty(PropertyName = "shopId")]
        public string ShopId { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}