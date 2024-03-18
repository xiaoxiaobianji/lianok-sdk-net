using LianOk.Docking.Core;
using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Request.BranchShop
{
    /// <summary>
    /// 分店列表查询接口
    /// 
    /// 参考：https://www.yuque.com/youyun-8yqqt/vpbgq7/eqzu9y289zhcaunm
    /// </summary>
    public class ApiHlShopQueryBranchShopListRequest : DockingRequestBase
    {
        public override string GetApiName()
        {
            return "api.hl.shop.queryBranchShopList";
        }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty(PropertyName = "shopNo")]
        public string ShopNo { get; set; }
        /// <summary>
        /// 分店名称
        /// </summary>
        [JsonProperty(PropertyName = "shopName")]
        public string ShopName { get; set; }
        /// <summary>
        /// 条数：10
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }
        /// <summary>
        /// 页码：1
        /// </summary>
        [JsonProperty(PropertyName = "currentPage")]
        public int CurrentPage { get; set; }
    }
}
