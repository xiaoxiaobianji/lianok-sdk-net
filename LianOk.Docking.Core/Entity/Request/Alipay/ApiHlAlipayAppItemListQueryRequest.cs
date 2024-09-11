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
    /// 小程序普通商品分页列表
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/sy52w1h3qkbi3kku
    /// </summary>
    public class ApiHlAlipayAppItemListQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.list.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "itemIdList")]
        public List<string> ItemIdList { get; set; }
        [JsonProperty(PropertyName = "outItemIdList")]
        public List<string> OutItemIdList { get; set; }
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

