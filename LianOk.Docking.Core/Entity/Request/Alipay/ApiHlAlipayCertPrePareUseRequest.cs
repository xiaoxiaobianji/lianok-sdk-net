using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 凭证核销准备接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sg4u4z2a18gyggkv
    /// </summary>
    public class ApiHlAlipayCertPrePareUseRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.cert.pre.pare.use";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string merchantNo { get; set; }
        [JsonProperty(PropertyName = "code")]

        public string Code { get; set; }
        [JsonProperty(PropertyName = "encryptedData")]
        public string EncryptedData { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }

    }
}

