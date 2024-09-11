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
    /// 小程序普通商品详情查询接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/eso4p1151wuny9tr
    /// </summary>
    public class ApiHlAlipayAppItemQueryRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.query";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "itemId")]
        public string ItemId { get; set; }
        [JsonProperty(PropertyName = "needEditSpu")]
        public int NeedEditSpu { get; set; }
        [JsonProperty(PropertyName = "outItemId")]
        public string OutItemId { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}

