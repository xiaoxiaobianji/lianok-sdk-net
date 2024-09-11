using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopSettlePeriodQueryResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "settlePeriodInfo")]
        public HlShopSettlePeriod SettlePeriodInfo { get; set; }

        [JsonProperty(PropertyName = "applyChangeInfo")]
        public HlShopSettlePeriodApply ApplyChangeInfo { get; set; }
    }
}