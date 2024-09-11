using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopQueryUpdateStatusResponse : DockingResponseBase
    {
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        /// <summary>
        /// 通道标识
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode;

        /// <summary>
        /// 修改状态
        /// 2 通道审核中
        /// 3 通道驳回
        /// 4 通过
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status;

        /// <summary>
        /// 驳回原因
        /// </summary>
        [JsonProperty(PropertyName = "rejectReason")]
        public string RejectReason;
    }
}