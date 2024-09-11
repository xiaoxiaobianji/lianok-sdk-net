using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopEntryResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        [JsonProperty(PropertyName = "refundPassword")]
        public string RefundPassword;
    }
}