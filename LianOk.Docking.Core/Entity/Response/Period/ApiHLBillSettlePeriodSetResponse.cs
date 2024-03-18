using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Period
{
    [Serializable]
    public class ApiHLBillSettlePeriodSetResponse : DockingResponseBase
    {
            /// <summary>
            /// 当前结算时刻信息
            /// </summary>
            [JsonProperty(PropertyName = "settlePeriodInfo")]
            public SettlePeriod SettlePeriodInfo { get; set; }

            /// <summary>
            /// 当前结算时刻信息
            /// </summary>
            [JsonProperty(PropertyName = "applyChangeInfo")]
            public ApplyChange ApplyChangeInfo { get; set; }
    }
}