using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.B2b
{
    [Serializable]
    public class ApiHlAppletB2bPreAppletB2bResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "merchantNo")]
        public string MerchantNo;

        [JsonProperty(PropertyName = "signData")]
        public int SignData;

        [JsonProperty(PropertyName = "paySig")]
        public string PaySig;

        [JsonProperty(PropertyName = "signature")]
        public string Signature;

        [JsonProperty(PropertyName = "orderNo")]
        public string OrderNo;

        [JsonProperty(PropertyName = "businessOrderNo")]
        public string BusinessOrderNo;
    }
}