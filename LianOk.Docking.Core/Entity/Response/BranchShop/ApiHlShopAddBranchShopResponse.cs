using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.BranchShop
{
    [Serializable]
    public class ApiHlShopAddBranchShopResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        [JsonProperty(PropertyName = "shopNo")]
        public string ShopNo;

        [JsonProperty(PropertyName = "shopName")]
        public string ShopName;
    }
}