using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.BranchShop
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
        public List<HlShopBranchShop> BranchShopList;
    }
}
