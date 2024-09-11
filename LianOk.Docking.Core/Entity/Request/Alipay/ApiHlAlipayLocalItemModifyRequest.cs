using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Request.Alipay
{
    /// <summary>
    /// 本地商品修改
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/nd1ogr4tn37lohvx
    /// </summary>
    public class ApiHlAlipayLocalItemModifyRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.alipay.local.item.modify";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "itemId")]
        public string ItemId { get; set; }

        [JsonProperty(PropertyName = "attrs")]
        public List<AppItemAttrVO> Attrs { get; set; }

        [JsonProperty(PropertyName = "categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty(PropertyName = "customerServiceMobile")]
        public PhoneStructVO CustomerServiceMobile { get; set; }

        [JsonProperty(PropertyName = "headImg")]
        public string headImg { get; set; }

        [JsonProperty(PropertyName = "imageList")]
        public List<string> ImageList { get; set; }

        [JsonProperty(PropertyName = "itemDetailsPageModel")]
        public string ItemDetailsPageModel { get; set; }

        [JsonProperty(PropertyName = "itemType")]
        public string ItemType { get; set; }

        [JsonProperty(PropertyName = "merchantName")]
        public string MerchantName { get; set; }

        [JsonProperty(PropertyName = "outItemId")]
        public string OutItemId { get; set; }

        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        [JsonProperty(PropertyName = "skus")]
        public List<LocalItemSkuCreateVO> Skus { get; set; }

        [JsonProperty(PropertyName = "soldTime")]
        public TimeRangeStructVO SoldTime { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        public override bool GetNewRoute()
        {
            return true;
        }
    }
}