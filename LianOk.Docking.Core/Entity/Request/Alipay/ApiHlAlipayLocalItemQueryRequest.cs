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
    /// 本地商品查询
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sh27s2pc8nro2uof
    /// </summary>
    public class ApiHlAlipayLocalItemQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "itemId")]
        public string ItemId { get; set; }
        [JsonProperty(PropertyName = "needEditSpu")]
        public string NeedEditSpu { get; set; }
        [JsonProperty(PropertyName = "outItemId")]
        public string OutItemId { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}

