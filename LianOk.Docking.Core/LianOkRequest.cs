using Newtonsoft.Json;

namespace LianOk.Docking.Core
{
    public class LianOkRequest
    {
        [JsonProperty(PropertyName = "authCode")]
        public string AuthCode { get; set; }

        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        [JsonProperty(PropertyName = "versionNo")]
        public string VersionNO { get; set; }

        [JsonProperty(PropertyName = "sign")]
        public string Sign { get; set; }

        [JsonProperty(PropertyName = "requestTime")]
        public string RequestTime { get; set; }

        [JsonProperty(PropertyName = "params")]
        public string BizContent { get; set; }
    }
}