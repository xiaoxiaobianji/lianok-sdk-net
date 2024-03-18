using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillRelation
    {
            /// <summary>
            /// 分账方商户编号
            /// </summary>
            [JsonProperty(PropertyName = "merchantNo")]
            public string MerchantNo { get; set; }

            /// <summary>
            /// 分账方渠道编号
            /// </summary>
            [JsonProperty(PropertyName = "channelCode")]
            public string ChannelCode { get; set; }

            /// <summary>
            /// 分账接收方商户编号
            /// </summary>
            [JsonProperty(PropertyName = "receiveMerchantNo")]
            public string ReceiveMerchantNo { get; set; }

            /// <summary>
            /// 分账接收方渠道编号
            /// </summary>
            [JsonProperty(PropertyName = "receiveChannelCode")]
            public string ReceiveChannelCode { get; set; }
    }
}