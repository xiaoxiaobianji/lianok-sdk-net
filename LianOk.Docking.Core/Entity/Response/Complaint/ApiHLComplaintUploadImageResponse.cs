using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Complaint
{
    [Serializable]
    public class ApiHlComplaintUploadImageResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "imgUrl")]
        public string ImgUrl { get; set; }
    }
}
