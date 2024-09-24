using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.B2b
{
    [Serializable]
    public class ApiHlAppletB2bQueryStoreInfoResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "storeInfos")]
        public string StoreInfos;
    }
}