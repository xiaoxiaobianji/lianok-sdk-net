using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 回复确认退款结果
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sln287z542qcnogq
    /// </summary>
    public class ApiHlAlipayCertConfirmRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.confirm";
        }

        /**
         * 商户号
         */
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "certificateId")]
        public string CertificateId { get; set; }
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "orderId")]
        public string OrderId { get; set; }
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
        [JsonProperty(PropertyName = "userOpenId")]
        public string UserOpenId { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }

    }
}

