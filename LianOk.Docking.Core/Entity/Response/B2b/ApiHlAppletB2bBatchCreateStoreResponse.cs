using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.B2b
{
    [Serializable]
    public class ApiHlAppletB2bBatchCreateStoreResponse : DockingResponseBase
    {
        [JsonProperty(PropertyName = "failureRecords")]
        public string FailureRecords;

        [JsonProperty(PropertyName = "numSuccess")]
        public int NumSuccess;

        [JsonProperty(PropertyName = "numFailure")]
        public string NumFailure;
    }
}