using LianOk.Docking.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 查询凭证信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/wvcvdlefczgqcqux
    /// </summary>
    public class ApiHlAlipayCertBatchQueryRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.cert.batch.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "certificateIdList")]
        public List<string> CertificateIdList { get; set; }

        [JsonProperty(PropertyName = "openId")]
        public string OpenId { get; set; }

        [JsonProperty(PropertyName = "orderId")]
        public string OrderId { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}