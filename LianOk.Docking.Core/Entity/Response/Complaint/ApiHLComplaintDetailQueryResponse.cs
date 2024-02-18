using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Complaint
{
    [Serializable]
    public class ApiHlComplaintDetailQueryResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "complaintNo")]
        public string ComplaintNo { get; set; }

        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo { get; set; }

        [JsonProperty(PropertyName = "huolianComplaintNo")]
        public string HuolianComplaintNo { get; set; }

        [JsonProperty(PropertyName = "agentNo")]
        public string AgentNo { get; set; }

        [JsonProperty(PropertyName = "topChannelOrderNo")]
        public string TopChannelOrderNo { get; set; }

        [JsonProperty(PropertyName = "channelMerchantNo")]
        public string ChannelMerchantNo { get; set; }

        [JsonProperty(PropertyName = "payWay")]
        public string PayWay { get; set; }

        [JsonProperty(PropertyName = "channelOrderNo")]
        public string ChannelOrderNo { get; set; }

        [JsonProperty(PropertyName = "payerPhone")]
        public string PayerPhone { get; set; }

        [JsonProperty(PropertyName = "complaintTime")]
        public string ComplaintTime { get; set; }

        [JsonProperty(PropertyName = "complaintCount")]
        public string ComplaintCount { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo { get; set; }

        [JsonProperty(PropertyName = "orderAmount")]
        public string OrderAmount { get; set; }

        [JsonProperty(PropertyName = "complaintStatus")]
        public string ComplaintStatus { get; set; }

        [JsonProperty(PropertyName = "complaintType")]
        public string ComplaintType { get; set; }

        [JsonProperty(PropertyName = "applyRefundAmount")]
        public string ApplyRefundAmount { get; set; }

        [JsonProperty(PropertyName = "channelCode")]
        public string ChannelCode { get; set; }

        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "needReply")]
        public string NeedReply { get; set; }
    }
}