using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Accredit
{
    [Serializable]
    public class ApiHLBillOrderCreateResponse : DockingResponseBase
    {
        /// <summary>
        /// 分账方商户ID
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 对接商分账单号
        /// </summary>
        [JsonProperty(PropertyName = "billNo")]
        public string BillNo { get; set; }

        /// <summary>
        /// 分账详情
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }
    }
}