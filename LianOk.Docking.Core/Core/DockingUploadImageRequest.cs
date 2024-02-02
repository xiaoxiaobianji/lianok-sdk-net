using Newtonsoft.Json;

namespace LianOk.Docking.Core
{
    public abstract class DockingUploadImageRequest : DockingRequestBase
    {

        [JsonIgnore]
        public string FileName { get; set; }

        [JsonIgnore]
        public byte[] FileData { get; set; }
    }
}
