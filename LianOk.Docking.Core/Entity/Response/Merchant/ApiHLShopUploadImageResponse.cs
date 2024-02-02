using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Merchant
{
    [Serializable]
    public class ApiHlShopUploadImageResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "imgUrl")]
        public string ImgUrl { get; set; }

        [JsonProperty(PropertyName = "uploadKey")]
        public string UploadKey { get; set; }
    }
}
