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
    /// 小程序普通商品创建
    ///
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/eso4p1151wuny9tr
    /// </summary>
    public class ApiHlAlipayAppItemCreateRequest : DockingRequestBase
    {

        public override string GetApiName()
        {
            return "api.hl.alipay.app.item.create";
        }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        [JsonProperty(PropertyName = "attrs")]
        public List<AppItemAttrVO> Attrs { get; set; }
        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }
        [JsonProperty(PropertyName = "categoryId")]
        public string CategoryId { get; set; }
        [JsonProperty(PropertyName = "desc")]
        public string Desc { get; set; }
        [JsonProperty(PropertyName = "descInfo")]
        public ItemDescInfoVO DescInfo { get; set; }
        [JsonProperty(PropertyName = "directPath")]
        public string DirectPath { get; set; }
        [JsonProperty(PropertyName = "headImg")]
        public string HeadImg { get; set; }
        [JsonProperty(PropertyName = "imageList")]
        public List<string> ImageList { get; set; }
        [JsonProperty(PropertyName = "itemDetailsPageModel")]
        public string ItemDetailsPageModel { get; set; }
        [JsonProperty(PropertyName = "itemType")]
        public string ItemType { get; set; }
        [JsonProperty(PropertyName = "originalPrice")]
        public int OriginalPrice { get; set; }
        [JsonProperty(PropertyName = "outItemId")]
        public string OutItemId { get; set; }
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }
        [JsonProperty(PropertyName = "priceUnit")]
        public string PriceUnit { get; set; }
        [JsonProperty(PropertyName = "salePrice")]
        public int SalePrice { get; set; }
        [JsonProperty(PropertyName = "saleStatus")]
        public string SaleStatus { get; set; }
        [JsonProperty(PropertyName = "skus")]
        public List<ItemSkuCreateVO> Skus { get; set; }
        [JsonProperty(PropertyName = "stockNum")]
        public int StockNum { get; set; }
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        public override bool GetNewRoute()
        {
            return true;
        }
    }
}

