using Newtonsoft.Json;

namespace LianOk.Docking.Core
{
    public class ResponseResultBase<T> where T : DockingResponseBase
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "status")]
        public int Status { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "data")]
        public T Data { get; set; }

        public bool Success { get { return Code == 0 && Status == 200; } }
    }
}