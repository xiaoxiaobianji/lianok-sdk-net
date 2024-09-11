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
    /// 小程序商品免审
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/eso4p1151wuny9tr
    /// </summary>
    public class ApiHlAlipayAppItemDirectModifyRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.direct.modify";
        }

        /**
         * 商户号
         */
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "itemId")]
        public string ItemId { get; set; }
        [JsonProperty(PropertyName = "mercoriginalPricehantNo")]
        public int OriginalPrice { get; set; }
        [JsonProperty(PropertyName = "outItemId")]
        public string OutItemId { get; set; }
        [JsonProperty(PropertyName = "salePrice")]
        public int SalePrice { get; set; }
        [JsonProperty(PropertyName = "saleStatus")]
        public string SaleStatus { get; set; }
        [JsonProperty(PropertyName = "skus")]
        public List<ItemDirectModifySku> Skus { get; set; }
        [JsonProperty(PropertyName = "stockNum")]
        public int StockNum { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}

