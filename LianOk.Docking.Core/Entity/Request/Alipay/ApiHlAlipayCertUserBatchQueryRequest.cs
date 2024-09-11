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
    /// 查询凭证信息
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/ga2su5kryca73evy
    /// </summary>
    public class ApiHlAlipayCertUserBatchQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.user.batch.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "belongMerchantId")]
        public string BelongMerchantId { get; set; }
        [JsonProperty(PropertyName = "certificateStatus")]
        public string CertificateStatus { get; set; }
        [JsonProperty(PropertyName = "openId")]
        public string OpenId { get; set; }
        [JsonProperty(PropertyName = "pageNum")]
        public int PageNum { get; set; }
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }
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

