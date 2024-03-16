using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopQueryBranchShopListResponse : DockingResponseBase
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount;
        /// <summary>
        /// 条数：10
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize;
        /// <summary>
        /// 页码：1
        /// </summary>
        [JsonProperty(PropertyName = "currentPage")]
        public int CurrentPage;
        /// <summary>
        /// 分店集合
        /// </summary>
        [JsonProperty(PropertyName = "branchShopList")]
        public List<ApiHlShopBranchShop> BranchShopList;
    }
}
