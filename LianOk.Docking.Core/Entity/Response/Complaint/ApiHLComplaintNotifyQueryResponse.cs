using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Complaint
{
    [Serializable]
    public class ApiHlComplaintNotifyQueryResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        [JsonProperty(PropertyName = "notifyUrl")]
        public string NotifyUrl;
    }
}