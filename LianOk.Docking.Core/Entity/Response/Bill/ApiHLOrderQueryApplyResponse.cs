using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Bill
{
    [Serializable]
    public class ApiHlOrderQueryApplyResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "agentNo")]
        public string AgentNo { get; set; }

        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo { get; set; }

        [JsonProperty(PropertyName = "billDate")]
        public string BillDate { get; set; }

        [JsonProperty(PropertyName = "downIdentification")]
        public string DownIdentification { get; set; }

        [JsonProperty(PropertyName = "downType")]
        public int DownType { get; set; }

        [JsonProperty(PropertyName = "state")]
        public int State { get; set; }

        [JsonProperty(PropertyName = "downloadUrl")]
        public string DownloadUrl { get; set; }
    }
}