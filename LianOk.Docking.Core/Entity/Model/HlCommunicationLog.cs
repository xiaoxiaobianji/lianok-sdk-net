using Newtonsoft.Json;

namespace LianOk.Docking.Entity.Model
{
    public class HlCommunicationLog
    {
        [JsonProperty(PropertyName = "logNo")]
        public string LogNo { get; set; }

        [JsonProperty(PropertyName = "huolianComplaintNo")]
        public string HuolianComplaintNo { get; set; }

        [JsonProperty(PropertyName = "operateTime")]
        public string OperateTime { get; set; }

        [JsonProperty(PropertyName = "operateType")]
        public string OperateType { get; set; }

        [JsonProperty(PropertyName = "replyContent")]
        public string ReplyContent { get; set; }

        [JsonProperty(PropertyName = "replyImage")]
        public string ReplyImage { get; set; }

        [JsonProperty(PropertyName = "huolianLogNo")]
        public string HuolianLogNo { get; set; }
    }
}