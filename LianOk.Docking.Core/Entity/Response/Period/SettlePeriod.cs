using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Period
{
    [Serializable]
    public class SettlePeriod
    {
            /// <summary>
            /// 开通分时计算的通道， 可选值(leShua, leShuaOnline,fuiouOffline)
            /// </summary>
            [JsonProperty(PropertyName = "channelCode")]
            public string ChannelCode { get; set; }

            /// <summary>
            /// 商户号
            /// </summary>
            [JsonProperty(PropertyName = "merchantNo")]
            public string MerchantNo { get; set; }

            /// <summary>
            /// 当前使用的结算时刻
            /// </summary>
            [JsonProperty(PropertyName = "settlePeriod")]
            public string SettlePeriod { get; set; }

    }
}