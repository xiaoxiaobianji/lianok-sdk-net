using LianOk.Docking.Core;
using LianOk.Docking.Entity.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LianOk.Docking.Entity.Response.Complaint
{
    [Serializable]
    internal class ApiHlComplaintLogListQueryResponse : DockingResponseBase
    {
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty(PropertyName = "pageNo")]
        public int PageNo { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// 沟通记录
        /// </summary>
        [JsonProperty(PropertyName = "communicationLogList")]
        public List<HlCommunicationLog> CommunicationLogList { get; set; }
    }
}