using LianOk.Docking.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 小程序商品移除接口
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/mhq4c0mhyszchkw5
    /// </summary>
    public class ApiHlAlipayAppItemDeleteRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.delete";
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

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}