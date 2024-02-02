using LianOk.Docking.Core;
using Newtonsoft.Json;
using System;

namespace LianOk.Docking.Entity.Response.Complaint
{
    [Serializable]
    public class ApiHlComplaintNotifySetResponse : DockingResponseBase
    {
        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty(PropertyName = "merchantNo")]
        public string merchantNo { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        [JsonProperty(PropertyName = "notifyUrl")]
        public string notifyUrl { get; set; }
    }
}