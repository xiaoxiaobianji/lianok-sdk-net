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
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/us5q3vcp2onfct8z
    /// </summary>
    public class ApiHlAlipayLocalItemListQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.list.query";
        }
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "itemIdList")]
        public List<string> ItemIdList;
        [JsonProperty(PropertyName = "outItemIdList")]
        public List<string> OutItemIdList;
        [JsonProperty(PropertyName = "pageNum")]
        public int PageNum { get; set; }
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }
        [JsonProperty(PropertyName = "spuStatus")]
        public string SpuStatus { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}

